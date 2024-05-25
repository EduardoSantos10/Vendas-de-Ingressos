using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas_de_Ingressos
{
    public partial class Atualizar : Form
    {
        DAO bd;
        public Atualizar()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// Fim do CPF

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Campo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Dado

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox3.Text);
                string campo = textBox1.Text;
                string dado = textBox2.Text;
                //Atualizar Dados
                MessageBox.Show(bd.Atualizar(cpf, "pessoa", campo, dado));
                //Limpar os Campos
                textBox3.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
