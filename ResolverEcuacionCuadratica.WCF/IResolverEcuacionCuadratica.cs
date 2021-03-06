﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ResolverEcuacionCuadratica.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IResolverEcuacionCuadratica
    {
        [OperationContract]
        void ResolverLaEcuacionCuadratica(Double PrimerNumero, Double SegundoNumero, Double TercerNumero, ref double primeraRaiz, ref double SegundaRaiz);
    }
}
