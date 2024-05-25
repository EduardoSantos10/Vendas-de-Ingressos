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
    public partial class Inicio : Form
    {
        Inicio inc;
        public Inicio()
        {
            InitializeComponent();
            inc = new Inicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inc.ShowDialog();
        }// Fim do Entrar
    }
}
