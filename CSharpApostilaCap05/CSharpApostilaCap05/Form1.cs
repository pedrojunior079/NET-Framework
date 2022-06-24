using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpApostilaCap05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            for(int i = 1; i <= 12; i += 1)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            int i = 1;
            while(i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 2;
            for(int i = 0; i < 5; i+= 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }
    }
}
