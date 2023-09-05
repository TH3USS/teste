using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionamentoDeFrota
{
    public partial class loginProf : Form
    {
        public loginProf()
        {
            InitializeComponent();
        }

        private void txtNomeProf_TextChanged(object sender, EventArgs e)
        {
            txtNomeProf.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtNomeProf.ForeColor = Color.Black;
        }

        private void txtNomeProf_Click(object sender, EventArgs e)
        {
            txtNomeProf.Text = "";
            txtNomeProf.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtNomeProf.ForeColor = Color.Black;
        }

        private void txtSalaProf_TextChanged(object sender, EventArgs e)
        {
            txtSalaProf.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtSalaProf.ForeColor = Color.Black;
        }

        private void txtSalaProf_Click(object sender, EventArgs e)
        {
            txtSalaProf.Text = "";
            txtSalaProf.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtSalaProf.ForeColor = Color.Black;
        }

        private void linkAluno_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde a tela de login do professor
            telaLogin tlogin = new telaLogin(); // cria um objeto para a tela de login dos alunos
            tlogin.Show(); // abre o login dos alunos
        }

        private void btnEntrarProf_Click(object sender, EventArgs e)
        {
            if (Cadastro.salas.Contains(txtSalaProf.Text) && (Cadastro.users.Contains(txtNomeProf.Text) && Cadastro.senha.Contains(txtSenhaProf.Text)))
            {
                /*cria um objeto da classe telaJogo e manda a string do nome para ser manipulada
                dentro do forms que está sendo chamado (telaProfessor).*/
                telaProfessor tProf = new telaProfessor();

                this.Hide(); //fecha a tela de login (ainda não está 100%)
                tProf.ShowDialog(); //abre tela do professor
            }
            else MessageBox.Show("Cadastro ou(e) sala incorreta(os)");
        }

        private void loginProf_Load(object sender, EventArgs e)
        {
            Cadastro.users[0] = "Jeremias";
            Cadastro.senha[0] = "12345";
            Cadastro.salas[0] = "Teste01";
        }

        private void btnCriarSala_Click(object sender, EventArgs e)
        {
            if (Cadastro.senha.Contains(txtSenhaProf.Text) && Cadastro.users.Contains(txtNomeProf.Text))
            {
                CriarSala novaSala = new CriarSala();
                novaSala.Show();
            }
            else MessageBox.Show("Cadastro não encontrado");
        }

        private void txtSenhaProf_TextChanged(object sender, EventArgs e)
        {
            txtSenhaProf.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtSenhaProf.ForeColor = Color.Black;
            txtSenhaProf.PasswordChar = '*';
        }

        private void txtSenhaProf_Click(object sender, EventArgs e)
        {
            txtSenhaProf.Text = "";
            txtSenhaProf.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtSenhaProf.ForeColor = Color.Black;
            txtSenhaProf.PasswordChar = '*';
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NovoProf novo = new NovoProf();

            novo.Show();
        }
    }
}
