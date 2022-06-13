using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpApostilaCap04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Imnsuficiente");
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;
            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realziado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if(saldo < 0.0)
            {
                MessageBox.Show("Vcoe está no negativo!");
            }
            else if(saldo < 1000000.0)
            {
                MessageBox.Show("Voce é um bom cliente");
            }
            else
            {
                MessageBox.Show("Voce é milionario!");
            }
        }
    }
}
