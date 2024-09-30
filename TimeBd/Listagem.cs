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
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        int idPuxar = 0;

        private void Listagem_Load(object sender, EventArgs e)
        {
            lblErro.Text = "";
            lblJogador.Text = "";
            cbxJogador.Visible = false;
            lbllink.Text = "";
            linkLabel1.Visible = false;
            btnListar1.Visible = false;

            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=time");
                conn.Open();

                MySqlCommand inserir = new MySqlCommand("SELECT `id`, `nome` FROM `jogadores`;", conn);
                MySqlDataReader reader = inserir.ExecuteReader();

                cbxJogador.Items.Clear();

                while (reader.Read())
                {
                    cbxJogador.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                }

                cbxJogador.DisplayMember = "Value";
                cbxJogador.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage02_Click(object sender, EventArgs e)
        {

        }
        private void cbxGeral_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbxGeral.SelectedIndex)
                {
                    case 0:
                        lblJogador.Text = "";
                        btnListar.Visible = true;
                        cbxJogador.Visible = false;
                        btnListar1.Visible = false;
                        lstLista.Items.Clear();
                        break;

                    case 1:
                        lblJogador.Text = "";
                        btnListar.Visible = true;
                        cbxJogador.Visible = false;
                        btnListar1.Visible = false;
                        lstLista.Items.Clear();
                        break;

                    case 2:
                        lblJogador.Text = "";
                        btnListar.Visible = true;
                        cbxJogador.Visible = false;
                        btnListar1.Visible = false;
                        lstLista.Items.Clear();
                        break;

                    case 3:
                        lblJogador.Text = "";
                        btnListar.Visible = true;
                        cbxJogador.Visible = false;
                        btnListar1.Visible = false;
                        lstLista.Items.Clear();
                        break;

                    case 4:
                        cbxJogador.Visible = true;
                        btnListar.Visible = false;
                        btnListar1.Visible = true;
                        lblJogador.Text = "Escolha o jogador que quer ver:";
                        lstLista.Items.Clear();
                        break;

                    default:
                        // Se nenhum dos casos acima, esconde todos os campos
                        lblJogador.Text = "";
                        cbxJogador.Visible = false;
                        lstLista.Items.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
            finally
            {

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=time");
                conn.Open();
      
                int desc = cbxGeral.SelectedIndex;
                MySqlCommand cmd;
                MySqlDataReader reader;

                switch (desc)
                {
                    //Dados Gerais
                    case 0:
                            try
                            {
                                // Cria o comando SQL para selecionar todos os registros
                                cmd = new MySqlCommand("SELECT * FROM `dadosgerais`", conn);
                                reader = cmd.ExecuteReader();

                                // Limpa a lista antes de adicionar novos itens
                                lstLista.Items.Clear();

                                // Verifica se há registros retornados
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        lstLista.Items.Add("Nome completo: " + reader.GetString(0));
                                        lstLista.Items.Add("Nome abreviado: " + reader.GetString(1));
                                        lstLista.Items.Add("Data de fundação: " + reader.GetString(2));
                                        lstLista.Items.Add("Estadio: " + reader.GetString(3));
                                        lstLista.Items.Add("Cor Oficial: " + reader.GetString(4));
                                        lstLista.Items.Add("Patrocinadores: " + reader.GetString(5));
                                        lstLista.Items.Add("Capacidade do estádio: " + reader.GetString(6));

                                        lstLista.Items.Add("-----------------------------------");
                                    }
                                }
                                else
                                {
                                    lstLista.Items.Add("Nenhuma moeda encontrada.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message);
                            }
                            finally
                            {
                                cmd = null;
                            }
                        break;
                    //Histórico
                    case 1:
                        try
                        {
                            // Cria o comando SQL para selecionar todos os registros
                            cmd = new MySqlCommand("SELECT * FROM `historico`", conn);
                            reader = cmd.ExecuteReader();

                            // Limpa a lista antes de adicionar novos itens
                            lstLista.Items.Clear();

                            // Verifica se há registros retornados
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    lstLista.Items.Add("Títulos conquistados: " + reader.GetString(0));
                                    lstLista.Items.Add("Participação em competição: " + reader.GetString(1));
                                    lstLista.Items.Add("Artilheiros: " + reader.GetString(2));
                                    lstLista.Items.Add("Maiores vencedores: " + reader.GetString(3));

                                    lstLista.Items.Add("-----------------------------------");
                                }
                            }
                            else
                            {
                                lstLista.Items.Add("Nenhuma moeda encontrada.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                        finally
                        {
                            cmd = null;
                        }
                        break;
                    //Informação de contato
                    case 2:
                        try
                        {
                            linkLabel1.Visible = true;
                            linkLabel1.Text = "Clique aqui para mais informações";

                            // Cria o comando SQL para selecionar todos os registros
                            cmd = new MySqlCommand("SELECT * FROM `infocontato`", conn);
                            reader = cmd.ExecuteReader();

                            // Limpa a lista antes de adicionar novos itens
                            lstLista.Items.Clear();

                            // Verifica se há registros retornados
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    lbllink.Text = "Site oficial: ";
                                    linkLabel1.Links.Add(0, linkLabel1.Text.Length, reader.GetString(3));
                                    lstLista.Items.Add("Endereço: " + reader.GetString(0));
                                    lstLista.Items.Add("Telefone: " + reader.GetString(1));
                                    lstLista.Items.Add("Email: " + reader.GetString(2));
                                    lstLista.Items.Add("Redes sociais: " + reader.GetString(4));

                                    lstLista.Items.Add("-----------------------------------");

                                }
                            }
                            else
                            {
                                lstLista.Items.Add("Nenhuma moeda encontrada.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                        finally
                        {
                            cmd = null;
                        }
                        break;
                    //Informações finanças
                    case 3:
                        try
                        {
                            // Cria o comando SQL para selecionar todos os registros
                            cmd = new MySqlCommand("SELECT * FROM `infofinancas`", conn);
                            reader = cmd.ExecuteReader();

                            // Limpa a lista antes de adicionar novos itens
                            lstLista.Items.Clear();

                            // Verifica se há registros retornados
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    lstLista.Items.Add("Receita: " + reader.GetString(0));
                                    lstLista.Items.Add("Despesa: " + reader.GetString(1));
                                    lstLista.Items.Add("Patriônio líquido: " + reader.GetString(2));
                                 
                                    lstLista.Items.Add("-----------------------------------");
                                }
                            }
                            else
                            {
                                lstLista.Items.Add("Nenhuma moeda encontrada.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                        finally
                        {
                            cmd = null;
                        }
                        break;
                    //dtp
                    case 4:
                        
                        break;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        private void btnListar1_Click(object sender, EventArgs e)
        {
            // Recupera o jogador selecionado (KeyValuePair)
            if (cbxJogador.SelectedItem != null)
            {
                var selectedPlayer = (KeyValuePair<int, string>)cbxJogador.SelectedItem;

                // Atualiza a variável global idPuxar com o ID do jogador selecionado
                idPuxar = selectedPlayer.Key;

                // Chama o método para buscar os dados do jogador
                BuscarDadosDoJogador();
            }
        }

        // Método que busca os dados do jogador com base no ID selecionado
        private void BuscarDadosDoJogador()
        {
            try
            {
                // Conexão com o banco de dados
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=time");
                conn.Open();

                // Comando SQL com o parâmetro @id
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `jogadores` WHERE `id` = @id", conn);
                cmd.Parameters.AddWithValue("@id", idPuxar);  // Adiciona o parâmetro @id com o valor de idPuxar

                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpa a lista antes de adicionar novos itens
                lstLista.Items.Clear();

                // Verifica se há registros retornados
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Adiciona as informações do jogador na lista
                        lstLista.Items.Add("Id: " + reader.GetInt32(0));
                        lstLista.Items.Add("Nome: " + reader.GetString(1));
                        lstLista.Items.Add("Idade: " + reader.GetInt32(2));  // Idade é um int
                        lstLista.Items.Add("Sexo: " + reader.GetString(3));
                        lstLista.Items.Add("Gols feitos: " + reader.GetInt32(4));  // Gols feitos é um int
                        lstLista.Items.Add("Data de cadastro: " + reader.GetDateTime(5).ToString("dd/MM/yyyy"));  // Formata a data
                        lstLista.Items.Add("-----------------------------------");
                    }
                }
                else
                {
                    lstLista.Items.Add("Nenhum jogador encontrado.");
                }

                // Fecha o leitor e a conexão
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbxJogador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
