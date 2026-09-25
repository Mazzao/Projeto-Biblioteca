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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Cria uma nova instancia da tela de usuarios
            FormUsuarios telaUsuarios = new FormUsuarios();

            // Mostra ela na tela
            telaUsuarios.Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            // Mesma ideia, mas abrindo a tela de livros
            FormLivros telaLivros = new FormLivros();

            telaLivros.Show();
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            // Mesma ideia, mas abrindo a tela de emprestimos
            FormEmprestimos telaEmprestimos = new FormEmprestimos();

            telaEmprestimos.Show();
        }
    }
}
