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
    public partial class Consultar : Form
    {
        DAO bd;
        public Consultar()
        {
            InitializeComponent();
            bd = new DAO();

            ConfigurarGrid();// Estruturar o grid
            NomesDados();// Dar os nomes as colunas
            bd.PreencherVetor();//Consulto Banco de Dados
            AdicionarDados();//Inserir linhas na Tela
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim do Data Grid

        public void NomesDados()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Endereço";
        }// Fim do Método

        public void AdicionarDados()
        {
            for (int i = 0; i < bd.QuantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.cpf[i], bd.nome[i], bd.telefone[i], bd.endereco[i]);
            }// Fim do four

        }// Fim do método
        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;// Usuário não adiciona linhas
            dataGridView1.AllowUserToAddRows = false;// Usuário não apaga linhas
            dataGridView1.AllowUserToResizeColumns = false;// Usuário não adiciona colunas
            dataGridView1.AllowUserToResizeRows = false; // Usuário modificar linhas
            dataGridView1.ColumnCount = 4;// Quantidade de Colunas
        }
    }
}
