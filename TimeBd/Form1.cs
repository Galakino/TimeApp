using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeBd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGeralDados_Click(object sender, EventArgs e)
        {
            DadosGerais dadosGerais = new DadosGerais();
            dadosGerais.ShowDialog();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Historico dadosGerais = new Historico();
            dadosGerais.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            InformaçõesFinanceiras dadosGerais = new InformaçõesFinanceiras();
            dadosGerais.ShowDialog();
        }

        private void btnInfoContato_Click(object sender, EventArgs e)
        {
            InfoContato dadosGerais = new InfoContato();
            dadosGerais.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            jogadores jogadores = new jogadores();
            jogadores.ShowDialog();
        }
    }
}
