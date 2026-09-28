using MySql.Data.MySqlClient;
using ProjetoBiblioteca.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class FormConsultarLivros : Form
    {
        public FormConsultarLivros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultarLivros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dvgLivros.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT * FROM livros";

                    if (chkSomenteDisponiveis.Checked == true)
                    {
                        sql += "  WHERE quantidade_disponivel > 0";
                    }

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();


                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        string editora = leitor.GetString("editora");
                        int quantidadeDisponivel = leitor.GetInt32("quantidade_disponivel");
                        int anoPublicacao = leitor.GetInt32("ano_publicacao");
                        string titulo = leitor.GetString("titulo");
                        string autor = leitor.GetString("autor");
                        string status = leitor.GetString("status");

                        dvgLivros.Rows.Add(titulo, autor, anoPublicacao, editora, quantidadeDisponivel, status);

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Livros: " + ex.Message);
            }
        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
              dvgLivros.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT * FROM livros WHERE titulo LIKE @titulo";

                    if (chkSomenteDisponiveis.Checked == true)
                    {
                        sql += " AND quantidade_disponivel > 0";
                    }

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@titulo", "%" + txtPesquisa.Text + "%");

                    conexao.Open();


                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        string editora = leitor.GetString("editora");
                        int quantidadeDisponivel = leitor.GetInt32("quantidade_disponivel");
                        int anoPublicacao = leitor.GetInt32("ano_publicacao");
                        string titulo = leitor.GetString("titulo");
                        string autor = leitor.GetString("autor");
                        string status = leitor.GetString("status");

                        dvgLivros.Rows.Add(titulo, autor, anoPublicacao, editora, quantidadeDisponivel, status);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Livros: " + ex.Message);
            }
                
            
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            dvgLivros.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT * FROM livros WHERE autor LIKE @autor";


                    if (chkSomenteDisponiveis.Checked == true)
                    {
                        sql += " AND quantidade_disponivel > 0";
                    }

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@autor", "%" + txtPesquisa.Text + "%");

                    conexao.Open();


                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        string editora = leitor.GetString("editora");
                        int quantidadeDisponivel = leitor.GetInt32("quantidade_disponivel");
                        int anoPublicacao = leitor.GetInt32("ano_publicacao");
                        string titulo = leitor.GetString("titulo");
                        string autor = leitor.GetString("autor");
                        string status = leitor.GetString("status");

                        dvgLivros.Rows.Add(titulo, autor, anoPublicacao, editora, quantidadeDisponivel, status);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Livros: " + ex.Message);
            }
        }

        private void chkSomenteDisponiveis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstLivros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    

            
        }
    }
}
