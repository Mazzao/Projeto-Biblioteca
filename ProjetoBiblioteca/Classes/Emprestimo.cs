namespace ProjetoBiblioteca.Classes
{
    public class Emprestimo
    {
        public int IdEmprestimo { get; set; }

        public int IdUsuario { get; set; }

        public int IdLivro { get; set; }

        public string DataEmprestimo { get; set; }

        public string DataPrevistaDevolucao { get; set; }

        public string DataDevolucao { get; set; }
    }
}
