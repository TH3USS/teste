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
    public partial class caminhoes : Form
    {
        public caminhoes()
        {
            InitializeComponent();
        }

        private void caminhoes_Load(object sender, EventArgs e)
        {

        }
        private void voltarCami_Click(object sender, EventArgs e)
        {
            telaProfessor tProf = new telaProfessor();            
            this.Hide();
            tProf.Show();
        }

        private void adicionarCami_Click(object sender, EventArgs e)
        {

            telaProfessor tProf = new telaProfessor(); // objeto para o forms do professor
                                   
            caminhao cami = new caminhao(); // criação do objeto para a classe caminhao            

            caminhao.Cfm[caminhao.i - 1] = this.textBox1.Text; // pega o valor digitado pelo usuário na textBox1 e coloca na respectiva posição da matriz
            caminhao.Cv[caminhao.i - 1] = this.textBox2.Text;
            caminhao.Comp[caminhao.i - 1] = this.textBox3.Text;
            caminhao.Larg[caminhao.i - 1] = this.textBox4.Text;
            caminhao.Alt[caminhao.i - 1] = this.textBox5.Text;
            caminhao.Cap[caminhao.i - 1] = this.textBox6.Text;
                        
            this.Hide(); // fecha essa tela (do cadastro de caminhões)
            tProf.Show();// abre a tela do professor
        }
    }
}
