namespace ProjetoBiblioteca.Classes
{
    // Essa classe representa um livro dentro do nosso sistema
    // cada propriedade aqui corresponde a uma coluna da tabela "livros" no banco
    public class Livro
    {
        // Id do livro, vem do banco depois que ele e cadastrado
        public int IdLivro { get; set; }

        // Titulo do livro, campo obrigatorio
        public string Titulo { get; set; }

        // Nome do autor
        public string Autor { get; set; }

        // Nome da editora
        public string Editora { get; set; }

        // Ano em que o livro foi publicado
        public int AnoPublicacao { get; set; }

        // Quantidade total de copias que a biblioteca tem desse livro
        public int QuantidadeTotal { get; set; }

        // Quantidade de copias disponiveis pra emprestimo agora
        public int QuantidadeDisponivel { get; set; }

        // Status do livro (exemplo: disponivel, indisponivel)
        public string Status { get; set; }
    }
}