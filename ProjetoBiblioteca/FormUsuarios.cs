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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validacao simples
            // cadastrar usuario sem nome
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome e obrigatorio.");
                return; // para a execucao aqui, nao deixa continuar
            }

            try
            {
                // Pega uma conexao nova usando o metodo que criamos em Conexao.cs
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    // Comando SQL de insercao
                    // usei @nome, @email, @telefone, @tipo
                    // no lugar dos valores direto no texto
                    // evita que o usuario digite algo malicioso e quebre a query
                    string sql = "INSERT INTO usuarios (nome, email, telefone, tipo) " +
                                 "VALUES (@nome, @email, @telefone, @tipo)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    // Aqui preenchemos cada parametro com o valor digitado nas TextBox
                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    comando.Parameters.AddWithValue("@tipo", txtTipo.Text);

                    // Abre a conexao com o banco
                    conexao.Open();

                    // Executa o comando (ExecuteNonQuery e usado quando
                    // o comando nao devolve dados, so faz uma acao,
                    // tipo INSERT, UPDATE ou DELETE)
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario cadastrado com sucesso!");

                    // Limpa os campos depois de cadastrar
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtTelefone.Clear();
                    txtTipo.Clear();
                }
            }
            catch (Exception ex)
            {
                // Se der qualquer erro (conexao caiu, banco fora do ar, etc)
                // mostra a mensagem pro usuario em vez do programa travar
                MessageBox.Show("Erro ao cadastrar usuario: " + ex.Message);
            }
        }
    }
}
