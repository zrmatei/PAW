using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Magazin
{
    [Serializable]
    public partial class Form1 : Form
    {
        Magazin m1, m2;

        private void lvMagazin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMagazin.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvMagazin.SelectedItems[0];
                tbMagazin.Text = "";
                tbMagazin.Text += lvi.Text + " " + lvi.SubItems[1].Text + " " + lvi.SubItems[2].Text;
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvMagazin.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvMagazin.SelectedItems[0];
                lvi.Remove();
            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvMagazin.SelectedItems.Count > 0)
            {
                Magazin m = lvMagazin.SelectedItems[0].Tag as Magazin;
                Modificari mod = new Modificari(m);
                if(mod.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvi = lvMagazin.SelectedItems[0] as ListViewItem;
                    lvi.SubItems[0].Text = m.Nume;
                    lvi.SubItems[1].Text = m.Q.ToString();
                    lvi.SubItems[2].Text = m.P.ToString();

                }
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magazin m = null;
            Modificari mod = new Modificari(m);
            if (mod.ShowDialog() == DialogResult.OK)
            {
                m = mod.cMagazin;
                ListViewItem lvi = new ListViewItem(new string[]
                {
                m.Nume, m.Q.ToString(), m.P.ToString()
                });
                lvi.Tag = m;
                lvMagazin.Items.Add(lvi);
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "mancare | *.food";
            fd.CheckFileExists = true;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Magazin> lista = new List<Magazin>();
                foreach(ListViewItem lvi in lvMagazin.Items)
                {
                    lista.Add((Magazin)lvi.Tag);
                }
                BinaryFormatter serial = new BinaryFormatter();
                Stream fis = File.Create(fd.FileName);
                serial.Serialize(fis, lista);
                fis.Close();
            }
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "mancare | *.food";
            fd.CheckFileExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Magazin> lista = new List<Magazin>();
                BinaryFormatter serial = new BinaryFormatter();
                Stream fis = File.OpenRead(fd.FileName);
                lista = (List<Magazin>)serial.Deserialize(fis);

                lvMagazin.Items.Clear();

                foreach(Magazin m in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        m.Nume, m.Q.ToString(), m.P.ToString()
                    });
                    lvi.Tag = m;
                    lvMagazin.Items.Add(lvi);
                }
            }
        }

        private void xMLSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "mancare | *.xml";
            fd.CheckFileExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Magazin> lista = new List<Magazin>();
                foreach (ListViewItem lvi in lvMagazin.Items)
                {
                    lista.Add((Magazin)lvi.Tag);
                }
                XmlSerializer serial = new XmlSerializer(typeof(List<Magazin>));
                Stream fis = File.Create(fd.FileName);
                serial.Serialize(fis, lista);
                fis.Close();
            }
        }

        private void xMLRestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "mancare | *.food";
            fd.CheckFileExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Magazin> lista = new List<Magazin>();
                XmlSerializer serial = new XmlSerializer(typeof(List<Magazin>));
                Stream fis = File.OpenRead(fd.FileName);
                lista = (List<Magazin>)serial.Deserialize(fis);

                lvMagazin.Items.Clear();

                foreach (Magazin m in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        m.Nume, m.Q.ToString(), m.P.ToString()
                    });
                    lvi.Tag = m;
                    lvMagazin.Items.Add(lvi);
                }
            }
        }




        private void lvMagazin_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvMagazin.SelectedItems.Count > 0)
            {
                lvMagazin.DoDragDrop(lvMagazin.SelectedItems[0].Tag, DragDropEffects.Copy);
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Effect == DragDropEffects.Copy && e.Data.GetDataPresent(new Magazin().GetType().ToString()))
            {
                Magazin m = (Magazin)e.Data.GetData(new Magazin().GetType().ToString());
                TreeNode tn = new TreeNode(m.Nume);
                tn.Tag = m;
                treeView1.Nodes.Add(tn);
            }

        }

        private void treeView1_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(new Magazin().GetType().ToString()))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public Form1()
        {
            InitializeComponent();
            m1 = new Magazin("Oua", 13, 10);
            m2 = new Magazin("Carne", 25, 3);

            ListViewItem lv1 = new ListViewItem(new string[]
            {
                m1.Nume, m1.Q.ToString(), m1.P.ToString()
            });
            lv1.Tag = m1;
            lvMagazin.Items.Add(lv1);

            ListViewItem lv2 = new ListViewItem(new string[]
            {
                m2.Nume, m2.Q.ToString(), m2.P.ToString()
            });
            lv2.Tag = m2;
            lvMagazin.Items.Add(lv2);
        }
    }
}
