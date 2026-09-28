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
<<<<<<< HEAD
            // Da Main para a tela de Cadastro de Usuarios
=======
            // Cria uma nova instancia da tela de usuarios
>>>>>>> 2f68b1f792237e0d834daf0953a96e3042729327
            FormUsuarios telaUsuarios = new FormUsuarios();

            // Mostra ela na tela
            telaUsuarios.Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // Da main para a tela de Cadastrar Livros
=======
            // Mesma ideia, mas abrindo a tela de livros
>>>>>>> 2f68b1f792237e0d834daf0953a96e3042729327
            FormLivros telaLivros = new FormLivros();

            telaLivros.Show();
        }

<<<<<<< HEAD
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarLivros_Click(object sender, EventArgs e)
        {
            // Da main para a tela de Consultar Livros
            FormConsultarLivros telaConsultarLivros = new FormConsultarLivros();

            telaConsultarLivros.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConsultarUsuario telaConsultarUsuario = new FormConsultarUsuario();

            telaConsultarUsuario.Show();
=======
        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            // Mesma ideia, mas abrindo a tela de emprestimos
            FormEmprestimos telaEmprestimos = new FormEmprestimos();

            telaEmprestimos.Show();
>>>>>>> 2f68b1f792237e0d834daf0953a96e3042729327
        }
    }
}
