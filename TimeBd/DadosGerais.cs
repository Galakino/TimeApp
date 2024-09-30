using MySql.Data.MySqlClient;
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
    public partial class DadosGerais : Form
    {
        public DadosGerais()
        {
            InitializeComponent();
        }

        private void DadosGerais_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection
                    ("server=127.0.0.1;userid=root;password=root;database=time");
                conn.Open();
                MySqlCommand comando = new MySqlCommand
               ("INSERT INTO `dadosgerais` (NomeComp, NomeAbrev, DataFundacao, Estadio, CorOficial, Patrocinadores, CapacEstadio) VALUES (@nome, @abrev, @data, @estadio, @cor, @patrocin, @capaestad);", conn);
                comando.Parameters.AddWithValue("@nome", txbNome.Text);
                comando.Parameters.AddWithValue("@abrev", txbAbreviado.Text);
                comando.Parameters.AddWithValue("@data", DataTimePicker.Text);
                comando.Parameters.AddWithValue("@estadio", txbEstadio.Text);
                comando.Parameters.AddWithValue("@cor", txbCor.Text);
                comando.Parameters.AddWithValue("@patrocin", txbPatroOficial.Text);
                comando.Parameters.AddWithValue("@capaestad", txbCapactEstadio.Text);

                comando.ExecuteNonQuery();
                conn.Close();

                if (comando != null)
                {
                    Historico tela = new Historico();
                    tela.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                lblErro.Text = ex.Message;
            }
            finally
            {
                txbNome.Text = "";
                txbAbreviado.Text = "";
                txbCapactEstadio.Text = "";
                txbCor.Text = "";
                txbEstadio.Text = "";
                txbPatroOficial.Text = "";
                DataTimePicker.Text = "";
                lblErro.Text = "";

            }
        }
    }
}
