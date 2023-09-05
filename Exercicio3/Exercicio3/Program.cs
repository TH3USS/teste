using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string km_, combustivelGasto_;
            double km, combustivelGasto;

            Console.WriteLine("Digite os quilometros radados");
            km_ = Console.ReadLine();
            Console.WriteLine("Digite o combustivel gasto");
            combustivelGasto_ = Console.ReadLine();

            km = Double.Parse(km_);
            combustivelGasto = Double.Parse(combustivelGasto_);

            int abasteceu = 0;

            
            for(double i = km ; i==0;i--)
            {
                if(combustivelGasto > 0)
                {
                combustivelGasto = combustivelGasto - 50.0;
                abasteceu = abasteceu + 1;
                }
            }
            Console.WriteLine(abasteceu);





            Console.ReadKey();

        }
    }
}
