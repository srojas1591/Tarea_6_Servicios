using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL.Fibonacci;
using BLL.Fibonacci;

namespace SVC.Contracts
{
  public class Operaciones : Interfaces.IOperaciones
    {
        string iResultado = string.Empty;

        public string Calculo_Fibonacci(int iValor)
        {
            Cls_DAL_Fibonacci Obj_Dato_DAL = new Cls_DAL_Fibonacci();
            Cls_BLL_Fibonacci Obj_Dato_BLL = new Cls_BLL_Fibonacci();

            if (iValor <= 0)
            {
                Obj_Dato_DAL.sMsj = "Error, debe ingresar un valor";
                iResultado = Obj_Dato_DAL.sMsj;

            }
            else
            {
                Obj_Dato_DAL.iLimite = iValor;
                Obj_Dato_BLL.Operacion_Fibonacci(ref Obj_Dato_DAL);
                iResultado = String.Join(",", Obj_Dato_DAL.aDatos.Select(p=>p.ToString()).ToArray());

            }

            return iResultado;

        }
    }
}
