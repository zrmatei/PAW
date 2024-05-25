using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing.Printing;



namespace proiectPAW_dictionar
{
    public partial class Form1 : Form
    {
        private List<CuvRo> listaRo;
        private List<CuvEng> listaEng;

        //pt print
        private PrintPreviewDialog printPreviewDialog1;
        public PrintDocument pd;
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            InitDictionar();
            PopLVCuvinteRo();
            PopLVCuvinteEng();
            this.printPreviewDialog1 = new PrintPreviewDialog(); 
        }

        private void InitDictionar()
        {
          listaRo = new List<CuvRo>
          {
             new CuvRo("apa", "Neutru", "lichid esential de baut", new DateTime(2000, 05, 15)),
             new CuvRo("carte", "Feminin", "obiect pentru citit", new DateTime(2021, 01, 20))
          };

          listaEng = new List<CuvEng>
          {
            new CuvEng("water", "apa", new DateTime(2000, 05, 15)),
            new CuvEng("book", "carte", new DateTime(2021, 01, 20))
          };

          listaRo[0].AdaugTrans(listaEng[0]);
          listaRo[1].AdaugTrans(listaEng[1]);
        }

        private void PopLVCuvinteRo()
        {
            lvCuvRo.Items.Clear();
            foreach (CuvRo c in listaRo)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    c.Cuvant, c.Gen, c.DataInreg.ToString("yyyy-MM-dd"), c.Expl
                })
                {
                    Tag = c
                };
                lvCuvRo.Items.Add(lvi);
            }
        }

        private void PopLVCuvinteEng()
        {
            lvCuvEng.Items.Clear();
            foreach (CuvEng word in listaEng)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    word.Word, word.RomanianWord, word.RegistrationDate.ToString("yyyy-MM-dd")
                })
                {
                    Tag = word
                };
                lvCuvEng.Items.Add(lvi);
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvCuvRo.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvCuvRo.SelectedItems[0];
                CuvRo cuvRo = (CuvRo)lvi.Tag;

                //sterg cuv din lista de cuvinte eng
                foreach (CuvEng cuvEng in cuvRo.Translations)
                {
                    listaEng.Remove(cuvEng);
                    ListViewItem lvi2 = FindByTag(lvCuvEng, cuvEng);
                    lvi2.Remove();
                }

                //sterg cuv in romana din lista ro
                listaRo.Remove(cuvRo);
                lvi.Remove();
            }
        }

        private ListViewItem FindByTag(ListView lv, object tag)
        {
            foreach (ListViewItem lvi in lv.Items)
            {
                if (lvi.Tag == tag)
                {
                    return lvi;
                }
            }
            return null;
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuvRo c = null;
            CuvEng en = null;
            Cuvinte form = new Cuvinte(c, en);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //pt romana
                c = form.mCuv;
                en = form.mCuvEng;
                ListViewItem lviRO = new ListViewItem(new string[]
                {c.Cuvant,c.Gen,c.DataInreg.ToString("yyyy-MM-dd"),c.Expl});
                lviRO.Tag = c;
                lvCuvRo.Items.Add(lviRO);

                //pt lista de cuv in engleza + adaugare cuvant romana in lv engleza
                ListViewItem lviEng = new ListViewItem(new string[]
                { en.Word, en.RomanianWord, en.RegistrationDate.ToString("yyyy-MM-dd") });
                lviEng.Tag = en;
                lvCuvEng.Items.Add(lviEng);
                c.AdaugTrans(en);
            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvCuvRo.SelectedItems.Count > 0)
            {
                CuvRo c = lvCuvRo.SelectedItems[0].Tag as CuvRo;
                CuvEng en = c.Translations[0];
                Cuvinte form = new Cuvinte(c, en);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lviRo = lvCuvRo.SelectedItems[0] as ListViewItem;
                    lviRo.SubItems[0].Text = c.Cuvant;
                    lviRo.SubItems[1].Text = c.Gen;
                    lviRo.SubItems[2].Text = c.DataInreg.ToString("yyyy-MM-dd");
                    lviRo.SubItems[3].Text = c.Expl;

                    //practic fac un foreach pentru a cauta in toata toata lista de cuvinte in engleza cuvantul in romana asociat + update-ul
                    foreach(ListViewItem lvi in lvCuvEng.Items)
                    {
                        CuvEng gasit = lvi.Tag as CuvEng;
                        if(gasit.RomanianWord == c.Cuvant)
                        {
                            lvi.SubItems[0].Text = en.Word;
                            lvi.SubItems[1].Text = en.RomanianWord;
                            lvi.SubItems[2].Text = en.RegistrationDate.ToString("yyyy-MM-dd");
                        }
                    }
                }
            }
        }

        private void salvareBinaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "dictionar(*.dic) | *.dic";
            fd.CheckFileExists = true;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<CuvRo> lista = new List<CuvRo>();
                List<CuvEng> lista2 = new List<CuvEng>();
                foreach(ListViewItem lvi in lvCuvRo.Items)
                {
                    lista.Add((CuvRo)lvi.Tag);
                    CuvRo cRo = (CuvRo)lvi.Tag;

                    foreach(CuvEng cEn in cRo.Translations)
                    {
                        lista2.Add(cEn);
                    }
                }

                BinaryFormatter serial = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serial.Serialize(fisier, lista);
                serial.Serialize(fisier, lista2);
                fisier.Close();
            }
        }

        private void restaurareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "dictionar(*.dic) | *.dic";
            fd.CheckFileExists = true;
            
            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<CuvRo> lista = new List<CuvRo>();
                BinaryFormatter serializare = new BinaryFormatter();
                Stream fisier = File.OpenRead(fd.FileName);
                lista = (List<CuvRo>)serializare.Deserialize(fisier);

                lvCuvRo.Items.Clear();

                foreach (CuvRo cuvRo in lista)
                {
                    ListViewItem lviRo = new ListViewItem(new string[]
                    {
                cuvRo.Cuvant, cuvRo.Gen, cuvRo.DataInreg.ToString("yyyy-MM-dd"), cuvRo.Expl
                    });
                    lviRo.Tag = cuvRo;
                    lvCuvRo.Items.Add(lviRo);

                    foreach (CuvEng cuvEng in cuvRo.Translations)
                    {
                        ListViewItem lviEng = new ListViewItem(new string[]
                        {
                    cuvEng.Word, cuvEng.RomanianWord, cuvEng.RegistrationDate.ToString("yyyy-MM-dd")
                        });
                        lviEng.Tag = cuvEng;
                        lvCuvEng.Items.Add(lviEng);
                    }
                }
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            ev.Graphics.DrawImage(bitmap, 0, 0);
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
                pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
                Panel panel = new Panel();
                this.Controls.Add(panel);
                Graphics grp = panel.CreateGraphics();
                Size formSize = this.ClientSize;
                bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
                grp = Graphics.FromImage(bitmap);
                Point panelLocation = PointToScreen(panel.Location);
                grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
                printPreviewDialog1.Document = pd;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
        }
    }
}
