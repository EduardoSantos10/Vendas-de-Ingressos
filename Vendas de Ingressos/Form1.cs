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
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            atu = new Atualizar();
            exc = new Excluir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new Consultar();//Consultar ATUALIZADAS!!!
            con.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }
    }
}
