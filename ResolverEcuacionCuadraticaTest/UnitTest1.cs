using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolverEcuacionCuadratica;

namespace ResolverEcuacionCuadraticaTest
{
    [TestClass]
    public class PrubasUnitariasEcuacionCuadratica
    {
        [TestMethod]
        public void ProbarResolverCorrectoMuyExacto()
        {

            /*
            1 - Declarar variables spar los parametros reles
            2 - Declarar variables con los valores que necesita para hacer pruebas
            3 - Declarar variables para los valores esperardos.
            4 - Contruya la logiaca que realiza la prueba
            5 - Asegurese de que los valores reales son iguales a los esperados.
            */

            // 
            double primerNumero = -1;
            double segundoNumero = 2;
            double TercerNumero = 3;
            //
            double primeraRaizReal= 0;
            double segundoRaizReal = 0;
            //
            double primeraRaizEsperada = 3;
            double segundoRaizEsperada = -1;

            ResolverEcuacionCuadratica.ResolverLaEcuacionCuadratica ecuacionCuadratica = new ResolverEcuacionCuadratica.ResolverLaEcuacionCuadratica();

            ecuacionCuadratica.REsolverLaEcuacionCuadratica(primerNumero,segundoNumero,TercerNumero,ref primeraRaizReal,ref segundoRaizReal);

            Assert.IsTrue((primeraRaizEsperada == primeraRaizReal) ||
                            (primeraRaizEsperada == segundoRaizReal));
            Assert.IsTrue((segundoRaizEsperada == primeraRaizReal) ||
                            (segundoRaizEsperada == segundoRaizReal));

            /* Tarea 
             
            * Cree Pruebas unitarias para los siguientes casos 
                 - Pruebas correctas para resultados reales de muchos decimales, 
                   de modo que la coincidencia NO sea exacta y se apruebe
                   cuando  

            */

        }
    }
}
