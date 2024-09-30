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
    public partial class InfoContato : Form
    {
        public InfoContato()
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
               ("INSERT INTO `infocontato` (endereco, telefone, email, siteOficial, redesSociais) VALUES (@endereco, @telefone, @email, @siteofic, @redesoci);", conn);
                comando.Parameters.AddWithValue("@endereco", txbEndereco.Text);
                comando.Parameters.AddWithValue("@telefone", txbTelefone.Text);
                comando.Parameters.AddWithValue("@email", txbEmail.Text);
                comando.Parameters.AddWithValue("@redesoci", txbRedesSoci.Text);     
                comando.Parameters.AddWithValue("@siteofic", txbSiteOfic.Text);

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
                txbEndereco.Text = "";
                txbTelefone.Text = "";
                txbEmail.Text = "";
                txbRedesSoci.Text = "";
                txbSiteOfic.Text = "";
                lblErro.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoContato_Load(object sender, EventArgs e)
        {

        }
    }
}

