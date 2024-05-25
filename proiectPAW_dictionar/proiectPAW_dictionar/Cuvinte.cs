using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW_dictionar
{
    public partial class Cuvinte : Form
    {
        public CuvRo mCuv;
        public CuvEng mCuvEng;
        public Cuvinte(CuvRo c, CuvEng en)
        {
            InitializeComponent();

            if (c == null )
            {
                c = new CuvRo();
                en = new CuvEng();
                button1.Text = "Adauga";
            }
            else
            {
                button1.Text = "Editeaza";
                tbRO.Text = c.Cuvant;
                tbGen.Text = c.Gen;
                boxDatInreg.Value = c.DataInreg;
                tbExpl.Text = c.Expl;

                tbEng.Text = en.Word;


            }
            mCuv = c;
            mCuvEng = en;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //preia datele din form2 in form1 
            mCuv.Cuvant = tbRO.Text;
            mCuv.Gen = tbGen.Text;
            mCuv.DataInreg = boxDatInreg.Value;
            mCuv.Expl = tbExpl.Text;

            //preia datele din form2 in form1 pe lv cu engleza
            mCuvEng.Word = tbEng.Text;
            mCuvEng.RomanianWord = tbRO.Text;
            mCuvEng.RegistrationDate = boxDatInreg.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cuvinte_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
