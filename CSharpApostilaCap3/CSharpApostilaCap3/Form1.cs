using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpApostilaCap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Olá ";
            string nome = "PedroJr";
            int idade = 42;
            MessageBox.Show(mensagem + "meu nome é " + nome + " minha idade é " + idade);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorDoSaque = 10.0;
            saldo = saldo - valorDoSaque;

            MessageBox.Show("O saldo da conta após o saque é: " +saldo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " +piQuebrado);
        }
    }
}
