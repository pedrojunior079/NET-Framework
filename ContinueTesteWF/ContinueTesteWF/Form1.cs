using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinueTesteWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            for(int contador = 1; contador <= 10; contador++)
            {
                if (contador == 5)
                    continue;  //pula o codigo restante no laço
                               //apenas se contador == 5
                output += contador + "";                
            }

            output += "\nUsado continue para pular a impressão 5";

            MessageBox.Show(output, "Usando a instrução continue",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
