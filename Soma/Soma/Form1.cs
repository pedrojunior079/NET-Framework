using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int numero = 2; numero <= 100; numero += 2)
                soma += numero;

            MessageBox.Show("A soma foi " + soma,
                "Soma de inteiros pares de 2 a 100",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
