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
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }// Fim do Construtor

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Botão CPF

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Botão Nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Botão Telefone

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Botão Endereço

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);
                string nome = textBox4.Text;
                string telefone = textBox3.Text;
                string endereco = textBox2.Text;
                MessageBox.Show(bd.Inserir(cpf, nome, telefone, endereco));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }// Fim do Botão Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Fim do Botão Cancelar
    }
}
