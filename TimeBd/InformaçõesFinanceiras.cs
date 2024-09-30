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
    public partial class InformaçõesFinanceiras : Form
    {
        public InformaçõesFinanceiras()
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
               ("INSERT INTO `infofinancas` (Receita, Despesa, patriLiquid) VALUES (@receita, @despesa, @patrimonio);", conn);
                comando.Parameters.AddWithValue("@receita", txbReceita.Text);
                comando.Parameters.AddWithValue("@despesa", txbDespesas.Text);
                comando.Parameters.AddWithValue("@patrimonio", txbPatriLiquido.Text);

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
                txbReceita.Text = "";
                txbDespesas.Text = "";
                txbPatriLiquido.Text = "";
                lblErro.Text = "";

            }
        }

        private void InformaçõesFinanceiras_Load(object sender, EventArgs e)
        {

        }
    }
}
