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
    public partial class jogadores : Form
    {
        public jogadores()
        {
            InitializeComponent();
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

                string dataCadastro = DateTime.Now.ToString("yyyy-MM-dd");

                string query = "INSERT INTO `jogadores` (nome, idade, sexo, gols, data) VALUES (@nome, @idade, @sexo, @gols, @data);";

                using (MySqlCommand comando = new MySqlCommand(query, conn))
                {           
                    comando.Parameters.AddWithValue("@nome", txbNome.Text);
                    comando.Parameters.AddWithValue("@idade", txbIdade.Text);
                    comando.Parameters.AddWithValue("@gols", txbGols.Text);
                    comando.Parameters.AddWithValue("@sexo", sexo);
                    comando.Parameters.AddWithValue("@data", dataCadastro);  // Adicionando o parâmetro de data corretamente

                    comando.ExecuteNonQuery();

                    if (comando != null)
                    {
                        this.Close();
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
                lblErro.Text = "";
            }

        }
    }
}
