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
            // Da Main para a tela de Cadastro de Usuarios
            FormUsuarios telaUsuarios = new FormUsuarios();

            // Mostra ela na tela
            telaUsuarios.Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            // Da main para a tela de Cadastrar Livros
            FormLivros telaLivros = new FormLivros();

            telaLivros.Show();
        }

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
        }
    }
}
