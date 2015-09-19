using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    class ResolverLaEcuacionCuadratica
    {
        CalcularDiscriminanante accionCalcularDiscriminante;
        ValidadDiscriminante ValidarDiscriminante;
        CalcularRaices CalcularRaices;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="PrimerNumero"></param>
        /// <param name="SegundoNumero"></param>
        /// <param name="TercerNumero"></param>
        /// <param name="primeraRaiz"></param>
        /// <param name="SegundaRaiz"></param>
        public void REsolverLaEcuacionCuadratica(Double PrimerNumero, Double SegundoNumero, Double TercerNumero, ref double primeraRaiz, ref double SegundaRaiz)
        {
            accionCalcularDiscriminante = new CalcularDiscriminanante();
            ValidarDiscriminante = new ValidadDiscriminante();
            CalcularRaices = new CalcularRaices();

            // Calcular Disctriminante
            double discriminante = accionCalcularDiscriminante.CalcularElDiscriminanante(PrimerNumero,SegundoNumero,TercerNumero);

            // Validar Discriminante
            if (ValidarDiscriminante.ValidadElDiscriminanteMayorqueCero(discriminante)){ 
            // Calcular las Raices
            CalcularRaices.CalcularlasRaices(discriminante, PrimerNumero, SegundoNumero, TercerNumero, ref primeraRaiz, ref SegundoNumero);
            }else{
                // Levante una excepcion 
                Exception ex = new Exception(string.Format("Ocurrio un Error al calcular las raices, ya que el discriminante [{0}], es menor que cero.",discriminante.ToString()));
                throw ex;
            }
        }
    }
}
