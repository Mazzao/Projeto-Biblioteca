namespace ProjetoBiblioteca.Classes
{
    // Essa classe representa um usuario dentro do nosso sistema
    // cada propriedade aqui corresponde a uma coluna da tabela "usuarios" no banco
    public class Usuario
    {
        // Id do usuario, vem do banco depois que ele e cadastrado
        public int IdUsuario { get; set; }

        // Nome do usuario, campo obrigatorio 
        public string Nome { get; set; }

        // Email do usuario
        public string Email { get; set; }

        // Telefone do usuario
        public string Telefone { get; set; }

        // Tipo do usuario (exemplo: aluno, professor)
        public string Tipo { get; set; }
    }
}