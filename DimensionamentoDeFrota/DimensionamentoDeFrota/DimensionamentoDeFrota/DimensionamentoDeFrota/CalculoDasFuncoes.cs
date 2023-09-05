using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionamentoDeFrota
{
    public class CalculoDasFuncoes
    {
        public CalculoDasFuncoes()
        {
        }

        public int CapacPeso(float caTruck, float pCarga)
        {
            int retorno = Convert.ToInt16(Math.Floor(caTruck/pCarga));
            return retorno;
        }
        public int CapacDimensao(float cTruck, float cCarga, float lTruck, float lCarga, float aTruck, float aCarga)
        {
            int retorno = Convert.ToInt16(Math.Floor(cTruck / cCarga) * Math.Floor(lTruck / lCarga) * Math.Floor(aTruck / aCarga));
            return retorno;
        }
        public int NumeroDias(int numViagem, int dRota)
        {
            int retorno = numViagem * dRota;
            return retorno;
        }
        public int NumViagem(int qCarga, int menorQ)
        {
            int retorno = qCarga / menorQ;
            return retorno;
        }
        public int NumPern(int numViagem, int dRota)
        {
            int retorno = numViagem * (dRota - 1);
            return retorno;
        }
        public decimal CustoVariavel(int numViagem, float kmRota, decimal cv)
        {
            decimal retorno = numViagem * Convert.ToDecimal(kmRota) * cv;
            return retorno;
        }
        public decimal CustoFixo(decimal cfm, int numDias)
        {
            decimal retorno = (cfm / 30) * numDias;
            return retorno;
        }
        public decimal CustoPernoite(int numPer, decimal perN)
        {
            decimal retorno = numPer * perN;
            return retorno;
        }
    }
}
