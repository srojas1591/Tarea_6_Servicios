using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SVC.Interfaces
{
    [ServiceContract]
    public  interface IOperaciones
    {
        [OperationContract]

        string Calculo_Fibonacci(int iValor);
    }
}
