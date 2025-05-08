using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5_Menu_while_CG
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repetir_texto repetir = new repetir_texto();
            repetir.Show();

            this.Hide();

        }

        private void btnOp2_Click(object sender, EventArgs e)
        {
            pares_e_impares pares = new pares_e_impares();
            pares.Show(); 

            this.Hide();


        }

        private void btnOp3_Click(object sender, EventArgs e)
        {
            sumatoria sumtoria = new sumatoria();
                sumtoria.Show();

            this.Hide();
        }
    }
}
