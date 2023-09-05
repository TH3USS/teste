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
    public partial class Inicializar : Form
    {
        int tempo = 0;
        public Inicializar()
        {
            InitializeComponent();
        }

        private void Inicializar_Load(object sender, EventArgs e)
        {
            
        }

        private void Começar_Tick(object sender, EventArgs e)
        {
            loginProf lProf = new loginProf();

            if (tempo < 5)
            {

                tempo++;
            }
            else
            {
                Começar.Stop();
                
                this.Hide();
                lProf.ShowDialog();
            }

        }
    }
}
