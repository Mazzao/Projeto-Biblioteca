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
using ProjetoBiblioteca.Banco;

namespace ProjetoBiblioteca
{
    public partial class FormLivros : Form
    {
        public FormLivros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cadastrar livro sem titulo
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("O campo Titulo e obrigatorio.");
                return;
            }

            // Os campos numericos (ano, quantidade total, quantidade disponivel)
            // vem como texto da TextBox, entao precisamos converter pra numero
            // antes de mandar pro banco. Usei TryParse pra evitar que o programa
            // quebre se o usuario digitar uma letra em vez de numero
            int ano, quantidadeTotal, quantidadeDisponivel;

            if (!int.TryParse(txtAno.Text, out ano))
            {
                MessageBox.Show("O campo Ano deve ser um numero valido.");
                return;
            }

            if (!int.TryParse(txtQuantidadeTotal.Text, out quantidadeTotal))
            {
                MessageBox.Show("O campo Quantidade Total deve ser um numero valido.");
                return;
            }

            if (!int.TryParse(txtQuantidadeDisponivel.Text, out quantidadeDisponivel))
            {
                MessageBox.Show("O campo Quantidade Disponivel deve ser um numero valido.");
                return;
            }

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    // Comando de insercao com parametros, igual fiz no usuario
                    string sql = "INSERT INTO livros (titulo, autor, editora, ano_publicacao, quantidade_total, quantidade_disponivel, status) " +
                                 "VALUES (@titulo, @autor, @editora, @ano, @quantidadeTotal, @quantidadeDisponivel, @status)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                    comando.Parameters.AddWithValue("@autor", txtAutor.Text);
                    comando.Parameters.AddWithValue("@editora", txtEditora.Text);
                    comando.Parameters.AddWithValue("@ano", ano);
                    comando.Parameters.AddWithValue("@quantidadeTotal", quantidadeTotal);
                    comando.Parameters.AddWithValue("@quantidadeDisponivel", quantidadeDisponivel);
                    comando.Parameters.AddWithValue("@status", txtStatus.Text);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Livro cadastrado com sucesso!");

                    // Limpa os campos depois de cadastrar
                    txtTitulo.Clear();
                    txtAutor.Clear();
                    txtEditora.Clear();
                    txtAno.Clear();
                    txtQuantidadeTotal.Clear();
                    txtQuantidadeDisponivel.Clear();
                    txtStatus.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar livro: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // cadastrar livro sem titulo
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("O campo Titulo e obrigatorio.");
                return;
            }

            // usa a mesma logica do outro botao

            int ano, quantidadeTotal, quantidadeDisponivel;

            if (!int.TryParse(txtAno.Text, out ano))
            {
                MessageBox.Show("O campo Ano deve ser um numero valido.");
                return;
            }

            if (!int.TryParse(txtQuantidadeTotal.Text, out quantidadeTotal))
            {
                MessageBox.Show("O campo Quantidade Total deve ser um numero valido.");
                return;
            }

            if (!int.TryParse(txtQuantidadeDisponivel.Text, out quantidadeDisponivel))
            {
                MessageBox.Show("O campo Quantidade Disponivel deve ser um numero valido.");
                return;
            }

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    // Comando de insercao com parametros, igual fizemos no usuario
                    string sql = "INSERT INTO livros (titulo, autor, editora, ano_publicacao, quantidade_total, quantidade_disponivel, status) " +
                                 "VALUES (@titulo, @autor, @editora, @ano, @quantidadeTotal, @quantidadeDisponivel, @status)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                    comando.Parameters.AddWithValue("@autor", txtAutor.Text);
                    comando.Parameters.AddWithValue("@editora", txtEditora.Text);
                    comando.Parameters.AddWithValue("@ano", ano);
                    comando.Parameters.AddWithValue("@quantidadeTotal", quantidadeTotal);
                    comando.Parameters.AddWithValue("@quantidadeDisponivel", quantidadeDisponivel);
                    comando.Parameters.AddWithValue("@status", txtStatus.Text);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Livro cadastrado com sucesso!");

                    // Limpa os campos depois de cadastrar
                    txtTitulo.Clear();
                    txtAutor.Clear();
                    txtEditora.Clear();
                    txtAno.Clear();
                    txtQuantidadeTotal.Clear();
                    txtQuantidadeDisponivel.Clear();
                    txtStatus.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar livro: " + ex.Message);
            }
        }
    }
}
