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
    public partial class UserControl1 : UserControl
    {
        public event EventHandler<Color> Schimb;

        public UserControl1()
        {
            InitializeComponent();
        }


        private void btnSchimb_Click(object sender, EventArgs e)
        {
            string hex = tbSchimb.Text.Trim();
            try
            {
                Color cNoua = ColorTranslator.FromHtml(hex);
                Schimb?.Invoke(this, cNoua);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
