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
    public partial class telaLogin : Form
    {
        public int minPartida = 0;

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }
        public telaLogin()
        {
            InitializeComponent();
        }

        public telaLogin(int minPartida)
        {
            InitializeComponent();
            this.minPartida = minPartida;
        }


        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtNome.ForeColor = Color.Black;
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtNome.ForeColor = Color.Black;
        }

        private void txtSala_TextChanged(object sender, EventArgs e)
        {
            txtSala.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtSala.ForeColor = Color.Black;
        }

        private void txtSala_Click(object sender, EventArgs e)
        {
            txtSala.Text = "";
            txtSala.Font = new Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular);
            txtSala.ForeColor = Color.Black;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //botão apertado, verificando se os campos foram preenchidos corretamente
            if (Cadastro.salas.Contains(txtSala.Text) && (txtNome.Text != "" && txtNome.Text != "Nome:"))//txtSala.Text == "Teste01" && (txtNome.Text != "" && txtNome.Text != "Nome:")
            {
                /*cria um objeto da classe telaJogo e manda a string do nome para ser manipulada
                dentro do forms que está sendo chamado (telaJogo).*/


                TelaAluno tAluno = new TelaAluno(txtNome.Text);
                telaProfessor tProf = new telaProfessor();

                // Aqui estamos pegando os textos que estão nos campos do forms do professor e passando para a o forms dos alunos
                tAluno.lblcCarga.Text = tProf.comprimento.Text;
                tAluno.lblpCarga.Text = tProf.peso.Text;
                tAluno.lbllCarga.Text = tProf.largura.Text;
                tAluno.lblaCarga.Text = tProf.altura.Text;
                tAluno.lblqCarga.Text = tProf.quantidade.Text;
                tAluno.lblkmRota.Text = tProf.distancia.Text;
                tAluno.lbldRota.Text = tProf.dias.Text;
                tAluno.lblperN.Text = tProf.nPernoites.Text;

                tAluno.minutosIniciais = minPartida;

                this.Hide();//fecha a tela de login (ainda não está 100%)
                tAluno.ShowDialog(); //abre tela do jogo  
            }
            else MessageBox.Show("Dados incorretos");
        }


        private void linkProf_Click(object sender, EventArgs e)
        {
            loginProf lProf = new loginProf();
            this.Hide();
            lProf.ShowDialog();
        }
    }
}
