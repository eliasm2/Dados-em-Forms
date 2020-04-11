using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados_em_Forms
{
    public partial class Form2 : Form
    {
        Form1 FormContagem;

        public Form2(Form1 F)
        {
            InitializeComponent();
            
            FormContagem = F;

            label2.Text = FormContagem.textBox1.Text;                // Inicializa o Label
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Valor;

            Valor = int.Parse(FormContagem.textBox1.Text);
            
            Valor++;

            FormContagem.textBox1.Text = Valor.ToString();                     // TextBox1 precisa ser public (Design)

            label2.Text = Valor.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Valor;

            Valor = int.Parse(FormContagem.textBox1.Text);

            Valor--;

            FormContagem.textBox1.Text = Valor.ToString();                     // TextBox1 precisa ser public (Design)

            label2.Text = Valor.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
