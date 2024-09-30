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
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection
                    ("server=127.0.0.1;userid=root;password=root;database=time");
                conn.Open();
                MySqlCommand comando = new MySqlCommand
               ("INSERT INTO `historico` (TitulosConquist, ParticipacaoCompeticao, Artilheiros, MaioresVencedores) " +
               "VALUES (@titulo, @paticip, @artilheiro, @maioresvencedores);", conn);
                comando.Parameters.AddWithValue("@titulo", txbTituloConquistado.Text);
                comando.Parameters.AddWithValue("@paticip", txbPartiCompet.Text);
                comando.Parameters.AddWithValue("@artilheiro", txbPartidasVencidas.Text);
                comando.Parameters.AddWithValue("@maioresvencedores", txbArtilheiro.Text);

                comando.ExecuteNonQuery();
                conn.Close();

                if (comando != null)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                lblErro.Text = ex.Message;
            }
            finally
            {
                txbTituloConquistado.Text = "";
                txbPartiCompet.Text = "";
                txbPartidasVencidas.Text = "";
                txbArtilheiro.Text = "";
                lblErro.Text = "";

            }
        }

        private void txbTituloConquistado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Historico_Load(object sender, EventArgs e)
        {

        }
    }
}
