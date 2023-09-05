using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DimensionamentoDeFrota
{
    public class caminhao
    {        
        TelaAluno tAluno = new TelaAluno("");

        public static int i = 3; // criação do indice das matrizes

        // Criação de matrizes Globais, elas podem ser utilizadas em todos os forms        
        public static string[] Cfm = new string[8];
        public static string[] Cv = new string[8];
        public static string[] Comp = new string[8];
        public static string[] Larg = new string[8];
        public static string[] Alt = new string[8];
        public static string[] Cap = new string[8];        
                
    }
}
