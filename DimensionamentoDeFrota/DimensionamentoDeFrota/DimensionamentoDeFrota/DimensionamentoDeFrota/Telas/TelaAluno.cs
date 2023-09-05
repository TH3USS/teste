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
    public partial class TelaAluno : Form
    {

        public int minutosIniciais;
        int segundos = 0, minutos;

        int segundosTruck = 10;        // 10 segundos para escolher um novo caminhão
        public static int aux;                       // guarda qual caminhão foi seleionado (3 opções neste caso)
        int auxSegTruck = 0;           // indicada se a contagem do segundos para escolha ainda está rolando (0 - não, 1 - sim)
        int auxPause = 0;              // guarda se o jogo vai ser pausado ou continuado (0 - deve ser pausado, 1 - deve ser continuado)
        bool fizminhaescolha = false;

        public int mousePassou = 0;

        float cCarga, lCarga, aCarga, pCarga, kmRota;

        private void TelaAluno_Load(object sender, EventArgs e)
        {
            //Dados da carga
            //lblcCarga.Text = "1";                           //1.comprimento da carga
            cCarga = float.Parse(lblcCarga.Text);
            //lbllCarga.Text = "1,2";                         //2.largura da carga
            lCarga = float.Parse(lbllCarga.Text);
            //lblaCarga.Text = "1,3";                         //3.altura da carga
            aCarga = float.Parse(lblaCarga.Text);
            //lblpCarga.Text = "720";                         //4.peso da carga
            pCarga = float.Parse(lblpCarga.Text);
            //lblqCarga.Text = "90";                          //5.quantidade da carga
            qCarga = Convert.ToInt16(lblqCarga.Text);

            //dados da rota
            //lblkmRota.Text = "1020";                        //1.distância da rota
            kmRota = float.Parse(lblkmRota.Text);
            //lbldRota.Text = "2";                            //2.dias da rota
            dRota = Convert.ToInt16(lbldRota.Text);

            //Custo da Pernoite
            //lblperN.Text = "140,00";
            perN = Convert.ToDecimal(lblperN.Text);

            minutos = minutosIniciais;

            temporizador.Enabled = true;
        }
        public TelaAluno(string nome)
        {
            InitializeComponent();
            lblNomeAluno.Text = nome;

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
        private void temporizadorTruck_Tick(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            
            foreach (Control b in Controls)
            {
                if (b is Button)
                {
                    if(((Button)b).Name != "btnEscolher") ((Button)b).Enabled = false;
                }
            }
            //verifica se a contagem já não se encerrou
            if (segundosTruck >= 0)
            {
                auxSegTruck = 1; //contagem rolando...
                //mostra os segundos de espera
                displayTruck.Text = $"00:{segundosTruck:D2}";
                //diminui um segundo
                segundosTruck--;
                //enquanto a contagem não acaba, os boões de escolha são desativados
                button1.BackColor = Color.DarkCyan;
            }
            else
            {
                button1.BackColor = Color.LightSeaGreen;
                button1.ForeColor = Color.White;
                //reinicia o contador e libera os botões de escolha

                auxSegTruck = 0; //contagem terminada
                segundosTruck = 10;
                displayTruck.Text = $"00:{segundosTruck:D2}";
                panel1.Enabled = true;
                foreach (Control b in Controls)
                {
                    if(b is Button)
                    {
                        ((Button)b).Enabled = true;
                    }
                }
                
                temporizadorTruck.Enabled = false;


                picCaminhao.Visible = false;

                foreach (Control b in Controls)
                {
                    if (b is Button)
                    {
                        ((Button)b).Enabled = true;
                    }
                    lblcTruckHIST.Text = lblcTruck.Text;
                    lbllTruckHIST.Text = lbllTruck.Text;
                    lblaTruckHIST.Text = lblaTruck.Text;
                    lblcaTruckHIST.Text = lblcaTruck.Text;
                    lblcfmHIST.Text = lblcfm.Text;
                    lblcvHIST.Text = lblcv.Text;
                    lblMenorQHIST.Text = lblMenorQ.Text;
                    lblCustTotalHIST.Text = lblCustTotal.Text;
                    picCaminhaoHIST.Image = picCaminhao.Image;
                    picCaminhaoHIST.Visible = true;
                }

                lblcTruck.Text = "";
                lbllTruck.Text = "";
                lblaTruck.Text = "";
                lblcaTruck.Text = "";
                lblcfm.Text = "";
                lblcv.Text = "";
                lblMenorQ.Text = "";
                lblCustTotal.Text = "";
                picCaminhao.Visible = false;

                aux = 0;
            }
        }
        private void temporizador_Tick(object sender, EventArgs e)
        {            
            //mostra o tempo que falta para a partida se encerrar
            display.Text = $"{minutos:D2}:{segundos:D2}";

            //verifica se já se passou 1 minuto e se ainda há mais minutos (para transformar os segundos em 59 e diminuir 1 minuto)
            if (segundos == 0 && minutos > 0)
            {
                minutos--;
                segundos = 59;
            }
            else if (segundos > 0) segundos--; //verifica se ainda há segundos para diminuir
            else if (minutos == 0) //se não houver segundos para diminuir, nem minutos, o tempo acabou
            {
                //reiniciação do temporizador para nova partida
                segundos = 0;
                minutos = minutosIniciais;
                temporizador.Enabled = false;
                display.Text = $"{minutos:D2}:{segundos:D2}";

                //a partida acabou, o jogador não pode mais escolher
                foreach (Control b in Controls)
                {
                    if (b is Button)
                    {
                        ((Button)b).Enabled = false;
                    }
                    if(b is PictureBox)
                    {
                        ((PictureBox)b).Visible = false;
                    }
                }
                Ranking ranking = new Ranking(lblNomeAluno.Text, lblCustTotalESC.Text);

                lblnomeCaminhao.Text = "---";
                lblcTruck.Text = "";
                lbllTruck.Text = "";
                lblaTruck.Text = "";
                lblcaTruck.Text = "";
                lblcfm.Text = "";
                lblcv.Text = "";
                lblMenorQ.Text = "";
                lblCustTotal.Text = "";

                lblcTruckESC.Text = "";
                lbllTruckESC.Text = "";
                lblaTruckESC.Text = "";
                lblcaTruckESC.Text = "";
                lblcfmESC.Text = "";
                lblcvESC.Text = "";
                lblMenorQESC.Text = "";
                lblCustTotalESC.Text = "";

                lblcTruckHIST.Text = "";
                lbllTruckHIST.Text = "";
                lblaTruckHIST.Text = "";
                lblcaTruckHIST.Text = "";
                lblcfmHIST.Text = "";
                lblcvHIST.Text = "";
                lblMenorQHIST.Text = "";
                lblCustTotalHIST.Text = "";

                
                ranking.Show();
                this.Hide();
            }
        }


        int qCarga, dRota;
        decimal perN;

        public void EscolhaCaminhao(int aux)
        {
            //Custos do caminhão
            //lblcfm.Text = "15600,00";                       //1.custo fixo mensal
            decimal cfm = Convert.ToDecimal(lblcfm.Text);
            //lblcv.Text = "2,10";                            //2.custo variável
            decimal cv = Convert.ToDecimal(lblcv.Text);

            //Dados do caminhão
            //lblcTruck.Text = "12";                          //1.comprimento do caminhão
            float cTruck = float.Parse(lblcTruck.Text);
            //lbllTruck.Text = "2,46";                        //2.largura do caminhão
            float lTruck = float.Parse(lbllTruck.Text);
            //lblaTruck.Text = "2,89";                        //3.altura do camihão
            float aTruck = float.Parse(lblaTruck.Text);
            //lblcaTruck.Text = "33000,00";                   //4.capacidade do caminhão
            float caTruck = float.Parse(lblcaTruck.Text);

            //Resultados

            CalculoDasFuncoes objCalculos = new CalculoDasFuncoes(); //criação de um objeto para chamar os métodos com os cálculos

            int capacidadePeso = objCalculos.CapacPeso(caTruck, pCarga);
            //capacPeso.Text = Convert.ToString(capacidadePeso);

            int capacidadeDimen = objCalculos.CapacDimensao(cTruck, cCarga, lTruck, lCarga, aTruck, aCarga);
            //capacDimen.Text = Convert.ToString(capacidadeDimen);

            int menorQ = capacidadePeso > capacidadeDimen ? capacidadeDimen : capacidadePeso;
            lblMenorQ.Text = Convert.ToString(menorQ);

            int numViagem = objCalculos.NumViagem(qCarga, menorQ);
            //numViagemVal.Text = Convert.ToString(numViagem);

            int numDias = objCalculos.NumeroDias(numViagem, dRota);
            //numDiasVal.Text = Convert.ToString(numDias);

            int numPern = objCalculos.NumPern(numViagem, dRota);
            //numPernVal.Text = Convert.ToString(numPern);

            decimal custVar = objCalculos.CustoVariavel(numViagem, kmRota, cv);
            //custVarVal.Text = Convert.ToString(custVar);

            decimal custFix = objCalculos.CustoFixo(cfm, numDias);
            //custFixVal.Text = Convert.ToString(custFix);

            decimal custPer = objCalculos.CustoPernoite(numPern, perN);
            //custPerVal.Text = Convert.ToString(custPer);

            decimal custTotal = custVar + custFix + custPer;
            lblCustTotal.Text = $"{custTotal:N2}";//Convert.ToString(custTotal);

            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblnomeCaminhao.Text = button1.Text;
            //representa que o primeiro caminhão foi escolhido
            aux = 1;
            picCaminhao.Visible = true; //Mostra imagem do caminhão
            
            //liga a contagem de 10 segundos
            temporizadorTruck.Enabled = true;
            //o jogador não pode selecionar os outros nem o mesmo duas vezes
            //foreach (Control i in Controls)
            //{
            //    if (i is Button)
            //    {
            //        ((Button)i).Enabled = false;
            //    }
            //}

            lblcTruck.Text = caminhao.Comp[0];
            lbllTruck.Text = caminhao.Larg[0];
            lblaTruck.Text = caminhao.Alt[0];
            lblcaTruck.Text = caminhao.Cap[0];

            lblcfm.Text = caminhao.Cfm[0];
            lblcv.Text = caminhao.Cv[0];

            EscolhaCaminhao(aux);

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            picCaminhao.Visible = true;
            picCaminhao.Image = Properties.Resources.army_g218a61867_1280;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                picCaminhao.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblnomeCaminhao.Text = button2.Text;
            //representa que o primeiro caminhão foi escolhido
            aux = 2;
            picCaminhao.Visible = true; //Mostra imagem do caminhão
            //liga a contagem de 10 segundos
            temporizadorTruck.Enabled = true;
            //o jogador não pode selecionar os outros nem o mesmo duas vezes
            //foreach (Control i in Controls)
            //{
            //    if (i is Button)
            //    {
            //        ((Button)i).Enabled = false;
            //    }
            //}

            lblcTruck.Text = caminhao.Comp[1];
            lbllTruck.Text = caminhao.Larg[1];
            lblaTruck.Text = caminhao.Alt[1];
            lblcaTruck.Text = caminhao.Cap[1];

            lblcfm.Text = caminhao.Cfm[1];
            lblcv.Text = caminhao.Cv[1];

            EscolhaCaminhao(aux);
            //lblcTruck.Text = caminhao.Comp[1];
            //lbllTruck.Text = caminhao.Larg[1];
            //lblaTruck.Text = caminhao.Alt[1];
            //lblcaTruck.Text = caminhao.Cap[1];

            //lblcfm.Text = caminhao.Cfm[1];
            //lblcv.Text = caminhao.Cv[1];

            //EscolhaCaminhao(aux);

            ////liga a contagem de 10 segundos
            //temporizadorTruck.Enabled = true;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            picCaminhao.Visible = true;
            picCaminhao.Image = Properties.Resources.truck_g94cad97f6_1280;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                picCaminhao.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblnomeCaminhao.Text = button3.Text;
            //representa que o primeiro caminhão foi escolhido
            aux = 3;
            picCaminhao.Visible = true; //Mostra imagem do caminhão
            

            //liga a contagem de 10 segundos
            temporizadorTruck.Enabled = true;
            //o jogador não pode selecionar os outros nem o mesmo duas vezes
            //foreach (Control i in Controls)
            //{
            //    if (i is Button)
            //    {
            //        ((Button)i).Enabled = false;
            //    }
            //}

            lblcTruck.Text = caminhao.Comp[2];
            lbllTruck.Text = caminhao.Larg[2];
            lblaTruck.Text = caminhao.Alt[2];
            lblcaTruck.Text = caminhao.Cap[2];

            lblcfm.Text = caminhao.Cfm[2];
            lblcv.Text = caminhao.Cv[2];

            EscolhaCaminhao(aux);
            //lblcTruck.Text = caminhao.Comp[2];
            //lbllTruck.Text = caminhao.Larg[2];
            //lblaTruck.Text = caminhao.Alt[2];
            //lblcaTruck.Text = caminhao.Cap[2];

            //lblcfm.Text = caminhao.Cfm[2];
            //lblcv.Text = caminhao.Cv[2];

            //EscolhaCaminhao(aux);

            ////liga a contagem de 10 segundos
            //temporizadorTruck.Enabled = true;
        }

        

        private void button3_MouseHover(object sender, EventArgs e)
        {
            picCaminhao.Visible = true;
            picCaminhao.Image = Properties.Resources.army_g218a61867_1280;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                picCaminhao.Visible = false;
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            lblnomeCaminhao.Text = button4.Text;
            //representa que o primeiro caminhão foi escolhido
            aux = 4;
            picCaminhao.Visible = true; //Mostra imagem do caminhão
            

            //liga a contagem de 10 segundos
            temporizadorTruck.Enabled = true;
            //o jogador não pode selecionar os outros nem o mesmo duas vezes
            //foreach (Control i in Controls)
            //{
            //    if (i is Button)
            //    {
            //        ((Button)i).Enabled = false;
            //    }
            //}

            lblcTruck.Text = caminhao.Comp[3];
            lbllTruck.Text = caminhao.Larg[3];
            lblaTruck.Text = caminhao.Alt[3];
            lblcaTruck.Text = caminhao.Cap[3];

            lblcfm.Text = caminhao.Cfm[3];
            lblcv.Text = caminhao.Cv[3];

            EscolhaCaminhao(aux);

            //lblcTruck.Text = caminhao.Comp[3];
            //lbllTruck.Text = caminhao.Larg[3];
            //lblaTruck.Text = caminhao.Alt[3];
            //lblcaTruck.Text = caminhao.Cap[3];

            //lblcfm.Text = caminhao.Cfm[3];
            //lblcv.Text = caminhao.Cv[3];
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            if (segundosTruck <= 10)
            {
                btnEscolher.Enabled = false;
                lblcTruckESC.Text = lblcTruck.Text;
                lbllTruckESC.Text = lbllTruck.Text;
                lblaTruckESC.Text = lblaTruck.Text;
                lblcaTruckESC.Text = lblcaTruck.Text;
                lblcfmESC.Text = lblcfm.Text;
                lblcvESC.Text = lblcv.Text;
                lblMenorQESC.Text = lblMenorQ.Text;
                lblCustTotalESC.Text = lblCustTotal.Text;

                picCaminhaoESC.Visible = true;
                picCaminhao.Visible = false;
                picCaminhaoESC.Image = picCaminhao.Image;

                lblnomeCaminhao.Text = "---";
                lblcTruck.Text = "";
                lbllTruck.Text = "";
                lblaTruck.Text = "";
                lblcaTruck.Text = "";
                lblcfm.Text = "";
                lblcv.Text = "";
                lblMenorQ.Text = "";
                lblCustTotal.Text = "";

                foreach(Control b in Controls)
                {
                    if(b is Button)
                    {
                        ((Button)b).Enabled = false;
                    }
                }

                temporizadorTruck.Stop();

                displayTruck.Text = "00:00";

                fizminhaescolha = true;
            }
        }


        private void button4_MouseHover(object sender, EventArgs e)
        {
            picCaminhao.Visible = true;
            picCaminhao.Image = Properties.Resources.truck_g94cad97f6_1280;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                picCaminhao.Visible = false;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            lblcTruck.Text = caminhao.Comp[4];
            lbllTruck.Text = caminhao.Larg[4];
            lblaTruck.Text = caminhao.Alt[4];
            lblcaTruck.Text = caminhao.Cap[4];

            lblcfm.Text = caminhao.Cfm[4];
            lblcv.Text = caminhao.Cv[4];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblcTruck.Text = caminhao.Comp[5];
            lbllTruck.Text = caminhao.Larg[5];
            lblaTruck.Text = caminhao.Alt[5];
            lblcaTruck.Text = caminhao.Cap[5];

            lblcfm.Text = caminhao.Cfm[5];
            lblcv.Text = caminhao.Cv[5];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblcTruck.Text = caminhao.Comp[6];
            lbllTruck.Text = caminhao.Larg[6];
            lblaTruck.Text = caminhao.Alt[6];
            lblcaTruck.Text = caminhao.Cap[6];

            lblcfm.Text = caminhao.Cfm[6];
            lblcv.Text = caminhao.Cv[6];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblcTruck.Text = caminhao.Comp[7];
            lbllTruck.Text = caminhao.Larg[7];
            lblaTruck.Text = caminhao.Alt[7];
            lblcaTruck.Text = caminhao.Cap[7];

            lblcfm.Text = caminhao.Cfm[7];
            lblcv.Text = caminhao.Cv[7];
        }

    }
}
