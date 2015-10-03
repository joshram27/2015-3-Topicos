using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ResolverEcuacionCuadratica;

namespace ResolverEcuacionCuadratica.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ResolverEcuacionCuadratica : IResolverEcuacionCuadratica
    {


        public void ResolverLaEcuacionCuadratica(Double PrimerNumero, Double SegundoNumero, Double TercerNumero, ref double primeraRaiz, ref double SegundaRaiz)
        {
            // instancia la clase que resuelve la ecuacion
            ResolverEcuacionCuadratica resolverEcuacion = new ResolverEcuacionCuadratica();
            // invoque al metodo que resuelve la ecucion
            resolverEcuacion.ResolverLaEcuacionCuadratica(PrimerNumero, SegundoNumero,  TercerNumero, ref  primeraRaiz, ref SegundaRaiz);
        }
    }
}
