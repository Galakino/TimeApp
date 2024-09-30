using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TimeBd
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection
                    ("server=127.0.0.1;userid=root;password=root;database=time");
                conn.Open();
                string query = "SELECT nome, senha FROM cadastro WHERE nome = @nome AND senha = @senha";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@nome", txbNome.Text);
                comando.Parameters.AddWithValue("@senha", txbSenha.Text);

                object controle = comando.ExecuteReader();
                conn.Close();

                if (controle != null)
                {
                    Form1 tela = new Form1();
                    tela.ShowDialog();
                }
                else
                {
                    lblErro.Text = "Usuário ou senha incorretos.";
                    MessageBox.Show("Algo de errado não está certo \n",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
            finally
            {
                txbNome.Text = "";
                txbSenha.Text = "";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.ShowDialog();
        }
    }
}
