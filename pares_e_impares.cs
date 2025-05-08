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
    public partial class pares_e_impares : Form
    {
        public pares_e_impares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //Limpialos números anteriores 
            int i = 0;

            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1;
            }
        }

        private void btnimpares_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i <= 20)
            {
                if (i % 2 !=0)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1;
            }
        }
    }
}
