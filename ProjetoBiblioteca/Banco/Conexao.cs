using MySql.Data.MySqlClient;

namespace ProjetoBiblioteca.Banco
{
    // Essa classe tem uma unica responsabilidade: abrir e devolver
    // uma conexao com o banco de dados "biblioteca"
    public class Conexao
    {
        //
        // server = localhost -> o banco esta rodando na sua propria maquina
        // (e o que o XAMPP faz)
        //
        // port = 3306 -> porta padrao do MySQL
        //
        // database = biblioteca -> nome do banco que criamos no phpMyAdmin
        //
        // uid = root -> usuario padrao do MySQL quando ele vem no XAMPP
        //
        // pwd = (vazio) -> o XAMPP por padrao nao coloca senha no usuario root
        
        private static string connectionString =
            "server=localhost;port=3306;database=biblioteca;uid=root;pwd=;";

        // metodo que cria e devolve uma conexao nova toda vez que for chamado
        // cada tela (usuarios, livros, emprestimos) vai chamar esse metodo
        // quando precisar falar com o banco
        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(connectionString);
        }
    }
}