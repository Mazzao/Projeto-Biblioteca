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
    public partial class FormEmprestimos : Form
    {
        public FormEmprestimos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validacao simples
            // nao deixa cadastrar um emprestimo sem as datas obrigatorias
            if (string.IsNullOrWhiteSpace(txtDataEmprestimo.Text))
            {
                MessageBox.Show("O campo Data do Emprestimo e obrigatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDataPrevistaDevolucao.Text))
            {
                MessageBox.Show("O campo Data Prevista de Devolucao e obrigatorio.");
                return;
            }

            // Os ids vem como texto da TextBox, entao precisamos converter pra numero
            // antes de mandar pro banco. Usei TryParse pra evitar que o programa
            // quebre se o usuario digitar uma letra em vez de numero
            int idUsuario, idLivro;

            if (!int.TryParse(txtIdUsuario.Text, out idUsuario))
            {
                MessageBox.Show("O campo Id do Usuario deve ser um numero valido.");
                return;
            }

            if (!int.TryParse(txtIdLivro.Text, out idLivro))
            {
                MessageBox.Show("O campo Id do Livro deve ser um numero valido.");
                return;
            }

            try
            {
                using (MySqlConnection conexao = Conexao.ObterConexao())
                {
                    // Comando de insercao com parametros, igual fiz nas outras telas
                    string sql = "INSERT INTO emprestimos (id_usuario, id_livro, data_emprestimo, data_prevista_devolucao, data_devolucao) " +
                                 "VALUES (@idUsuario, @idLivro, @dataEmprestimo, @dataPrevistaDevolucao, @dataDevolucao)";

                    // A data da devolucao e o unico campo que pode ficar vazio, porque
                    // enquanto o livro nao volta pra biblioteca essa data ainda nao existe.
                    // Quando ela vem vazia, cadastramos o emprestimo sem essa coluna
                    if (string.IsNullOrWhiteSpace(txtDataDevolucao.Text))
                    {
                        sql = "INSERT INTO emprestimos (id_usuario, id_livro, data_emprestimo, data_prevista_devolucao) " +
                              "VALUES (@idUsuario, @idLivro, @dataEmprestimo, @dataPrevistaDevolucao)";
                    }

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@idLivro", idLivro);
                    comando.Parameters.AddWithValue("@dataEmprestimo", txtDataEmprestimo.Text);
                    comando.Parameters.AddWithValue("@dataPrevistaDevolucao", txtDataPrevistaDevolucao.Text);

                    // so mandamos a data da devolucao quando ela foi preenchida
                    if (!string.IsNullOrWhiteSpace(txtDataDevolucao.Text))
                    {
                        comando.Parameters.AddWithValue("@dataDevolucao", txtDataDevolucao.Text);
                    }

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Emprestimo cadastrado com sucesso!");

                    // Limpa os campos depois de cadastrar
                    txtIdUsuario.Clear();
                    txtIdLivro.Clear();
                    txtDataEmprestimo.Clear();
                    txtDataPrevistaDevolucao.Clear();
                    txtDataDevolucao.Clear();
                }
            }
            catch (Exception ex)
            {
                // Se der qualquer erro (conexao caiu, data digitada errada, etc)
                // mostra a mensagem pro usuario em vez do programa travar
                MessageBox.Show("Erro ao cadastrar emprestimo: " + ex.Message);
            }
        }
    }
}
