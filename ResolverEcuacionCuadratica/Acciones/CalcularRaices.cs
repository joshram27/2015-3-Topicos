using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    class CalcularRaices
    {
        public void CalcularlasRaices(double Discriminante, double PrimerNumero, double SegundoNumero, double TercerNumero,
                                        ref double primeraRaiz, ref double segundaRaiz)
        {
            primeraRaiz = (- SegundoNumero + Math.Sqrt(Discriminante))/ (2 * PrimerNumero);
            primeraRaiz = (- SegundoNumero + Math.Sqrt(Discriminante))/ (2 * PrimerNumero);
        }

    }
}
