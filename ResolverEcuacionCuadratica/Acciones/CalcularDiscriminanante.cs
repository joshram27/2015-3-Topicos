using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class CalcularDiscriminanante
    {
        public  double CalcularElDiscriminanante(Double PrimerNumero, Double SegundoNumero, Double TercerNumero)
        {
            double Resultado = 0;

            Resultado = (Math.Pow(SegundoNumero, 2) - 4 * PrimerNumero * TercerNumero);
            return Resultado;
        }
    }
}
