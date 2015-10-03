using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFResolverEcuacionCuadratica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ResolverEcuacionCuadratica : IResolverEcuacionCuadratica
    {
        public void ResolverLaEcuacionCuadratica(Double PrimerNumero, Double SegundoNumero, Double TercerNumero, ref double primeraRaiz, ref double SegundaRaiz)
        {
            // instancia la clase que resuelve la ecuacion
            ResolverEcuacionCuadratica resolverEcuacion = new ResolverEcuacionCuadratica();
            // invoque al metodo que resuelve la ecucion
            resolverEcuacion.ResolverLaEcuacionCuadratica(PrimerNumero, SegundoNumero, TercerNumero, ref primeraRaiz, ref SegundaRaiz);
        }
    }
}
