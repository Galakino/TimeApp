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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection
                ("server=127.0.0.1;userid=root;password=root;database=time");
                
                    conn.Open();

                    string sexo = "";
                    if (chxM.Checked)
                    {
                        sexo = "M";
                    }
                    else if (chxF.Checked)
                    {
                        sexo = "F";
                    }

                    string query = "INSERT INTO `cadastro` (nome, senha, sexo) VALUES (@nome, @senha, @sexo);";

                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@nome", txbNome.Text);
                        comando.Parameters.AddWithValue("@senha", txbSenha.Text);
                        comando.Parameters.AddWithValue("@sexo", sexo);

                        comando.ExecuteNonQuery();

                        if (comando != null)
                        {
                            login tela = new login();
                            tela.ShowDialog();
                        }
                    }
                    conn.Close();

            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
            finally
            {
                txbNome.Text = "";
                txbSenha.Text = "";
                chxM.Checked = false;
                lblErro.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login tela = new login();
            tela.ShowDialog();
        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            lblErro.Text = "";
        }
    }
}
