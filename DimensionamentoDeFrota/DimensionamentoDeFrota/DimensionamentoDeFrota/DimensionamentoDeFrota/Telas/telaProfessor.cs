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
    public partial class telaProfessor : Form
    {
        string[] aux = new string[2];
        public telaProfessor()
        {
            InitializeComponent();

            ///////// Caminhão 1 /////////
            caminhao.Cfm[0] = "15600,00";
            caminhao.Cv[0] = "2,10";
            caminhao.Comp[0] = "12";
            caminhao.Larg[0] = "2,46";
            caminhao.Alt[0] = "2,89";
            caminhao.Cap[0] = "33000,00";

            ///////// Caminhão 2 /////////
            caminhao.Cfm[1] = "16600,00";
            caminhao.Cv[1] = "2,10";
            caminhao.Comp[1] = "12";
            caminhao.Larg[1] = "2,46";
            caminhao.Alt[1] = "2,89";
            caminhao.Cap[1] = "31000,00";

            ///////// Caminhão 3 /////////
            caminhao.Cfm[2] = "14600,00";
            caminhao.Cv[2] = "2,10";
            caminhao.Comp[2] = "12";
            caminhao.Larg[2] = "2,46";
            caminhao.Alt[2] = "2,89";
            caminhao.Cap[2] = "29000,00";

        }


        private void telaProfessor_Load(object sender, EventArgs e)
        {
            if (caminhao.Cfm[0] != null)
            {
                this.button1.Show();
            }
            else
            {
                this.button1.Hide();
            }
            if (caminhao.Cfm[1] != null)
            {
                this.button2.Show();
            }
            else
            {
                this.button2.Hide();
            }
            if (caminhao.Cfm[2] != null)
            {
                this.button3.Show();
            }
            else
            {
                this.button3.Hide();
            }
            if (caminhao.Cfm[3] != null)
            {
                this.button4.Show();
            }
            else
            {
                this.button4.Hide();
            }
            if (caminhao.Cfm[4] != null)
            {
                this.button5.Show();
            }
            else
            {
                this.button5.Hide();
            }
            if (caminhao.Cfm[5] != null)
            {
                this.button6.Show();
            }
            else
            {
                this.button6.Hide();
            }
            if (caminhao.Cfm[6] != null)
            {
                this.button7.Show();
            }
            else
            {
                this.button7.Hide();
            }
            if (caminhao.Cfm[7] != null)
            {
                this.button8.Show();
            }
            else
            {
                this.button8.Hide();
            }
        } 
        
        private void Iniciar_Click(object sender, EventArgs e)
        {
            int minPartida = Convert.ToInt32(cbMinutos.Text);
            TelaAluno tAluno = new TelaAluno("");
            telaLogin loginAluno = new telaLogin(minPartida);


            this.Hide();//fecha a tela de login (ainda não está 100%)
            loginAluno.ShowDialog(); //abre tela do jogo
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            caminhoes cami = new caminhoes(); // cria um objeto para o forms Caminhoes

            if (caminhao.Cfm[7] != null)
            {
                MessageBox.Show("Você excedeu o número de caminhões!");
                Adicionar.Enabled = false;
            } else
            {
                caminhao.i = caminhao.i + 1; // aumenta no indice das matrizes cada vez que o botão adicionar é acionado
                                
                cami.nomeCaminhao.Text = "Caminhão " + caminhao.i; // dá o nome do caminhão que será criado
                cami.adicionarCami.Enabled = true;

                this.Hide(); // esconde esse forms
                cami.Show(); // mostra o forms Caminhoes  
            }  
        }

        private void cbMinutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMinutos_SelectedValueChanged(object sender, EventArgs e)
        {
        }
    }
        
}
