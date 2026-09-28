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
    public partial class FormConsultarUsuario : Form
    {
        public FormConsultarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataUsuario.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT * FROM usuarios WHERE nome like @nome";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nome", "%" + txtPesquisa.Text + "%");

                    conexao.Open();


                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        string nome = leitor.GetString("nome");
                        string email = leitor.GetString("email");
                        string telefone = leitor.GetString("telefone");
                        string tipo = leitor.GetString("tipo");

                        dataUsuario.Rows.Add(nome,email,telefone,tipo);

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuario: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataUsuario.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT * FROM usuarios WHERE email like @email";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@email", "%" + txtPesquisa.Text + "%");

                    conexao.Open();


                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        string nome = leitor.GetString("nome");
                        string email = leitor.GetString("email");
                        string telefone = leitor.GetString("telefone");
                        string tipo = leitor.GetString("tipo");

                        dataUsuario.Rows.Add(nome, email, telefone, tipo);

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuario: " + ex.Message);
            }
        }
        private void dataUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarTelefone_Click(object sender, EventArgs e)
        {
            dataUsuario.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT * FROM usuarios WHERE telefone like @telefone";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@telefone", "%" + txtPesquisa.Text + "%");

                    conexao.Open();


                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        string nome = leitor.GetString("nome");
                        string email = leitor.GetString("email");
                        string telefone = leitor.GetString("telefone");
                        string tipo = leitor.GetString("tipo");

                        dataUsuario.Rows.Add(nome, email, telefone, tipo);

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuario: " + ex.Message);
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dataUsuario.Rows.Clear();

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT * FROM usuarios";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();

                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        string nome = leitor.GetString("nome");
                        string email = leitor.GetString("email");
                        string telefone = leitor.GetString("telefone");
                        string tipo = leitor.GetString("tipo");

                        dataUsuario.Rows.Add(nome, email, telefone, tipo);

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuario: " + ex.Message);
            }
        }
    }
    }

