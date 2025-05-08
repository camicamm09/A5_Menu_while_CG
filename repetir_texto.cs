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
    public partial class repetir_texto : Form
    {
        public repetir_texto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            listBox1.Items.Clear(); 
            int i = 0;

            while (i <= 10)
            {
                listBox1.Items.Add(texto);
                i = i + 1;

        }
    }
    }


}
