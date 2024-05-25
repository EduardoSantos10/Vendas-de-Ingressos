using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vendas_de_Ingressos
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public int contador;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=VendasIngressos;Uid=root;password=");
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo Deu Errado!\n\n" + ex);
            }
        }

        public string Inserir(long cpf, string nome, string telefone, string endereco)
        {
            string inserir = $"Insert into pessoa(cpf, nome, telefone, endereco) values" +
                             $"('{cpf}','{nome}','{telefone}','{endereco}')";

            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";
            return resultado;
        }// Fim do Método

        public void PreencherVetor()
        {
            string query = "select * from pessoa";

            //Instanciar

            this.cpf = new long[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];


            //Fazer comando do banco
            MySqlCommand sql = new MySqlCommand(query, conexao);

            //Leitor do Banco
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cpf[i] = Convert.ToInt64(leitura["cpf"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++;//Percorrer o Vetor
                contador++;//Contar quantos dados eu tenho

            }// Fim do while
            //Encerro a comunicação com o software
            leitura.Close();
        }// Fim do Preencher

        //Criar o método para retornar
        public int QuantidadeDados()
        {

            return contador;

        }// Fim do quantidade de dados
        public string Atualizar(long cpf, string nomeTabela, string campo, string dado)
        {

            string query = $"update {nomeTabela} set {campo} = '{dado}' where cpf = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }// fim do método

        public string Excluir(long cpf, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where CPF = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Excluido!";
            return resultado;
        }
    }
}
