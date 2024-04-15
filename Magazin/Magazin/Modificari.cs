using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class Modificari : Form
    {
        public Magazin cMagazin;
        public Modificari(Magazin m)
        {

            InitializeComponent();
            if (m == null)
            {
                m = new Magazin();
                btnOK.Text = "Adauga";
            }
            else
            {
                btnOK.Text = "Modifica";
                tbNume.Text = m.Nume;
                tbQ.Text = m.Q.ToString();
                tbP.Text = m.P.ToString();
            }
           cMagazin = m;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cMagazin.Nume = tbNume.Text;
            cMagazin.Q = Convert.ToInt32(tbQ.Text);
            cMagazin.P = Convert.ToInt32(tbP.Text);
            
            
            //nu uita asta!!!
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
