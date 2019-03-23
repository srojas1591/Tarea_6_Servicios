using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Fibonacci;
namespace BLL.Fibonacci
{
   public class Cls_BLL_Fibonacci
    {
        public void Operacion_Fibonacci(ref Cls_DAL_Fibonacci Obj_Datos)
        {
            //Obj_Datos.iNumero1 = 0;
            //Obj_Datos.iNumero2 = 1;

            //for (int i = 0; i < Obj_Datos.iLimite; i++)
            //{
            //    Obj_Datos.iSumatoria = Obj_Datos.iNumero1;
            //    Obj_Datos.iNumero1 = Obj_Datos.iNumero2;
            //    Obj_Datos.iNumero2 = Obj_Datos.iSumatoria + Obj_Datos.iNumero2;
            //}
            int[] aArreglo = new int[1];
            Obj_Datos.aDatos = new int[1];

            Array.Resize(ref aArreglo, Obj_Datos.iLimite);

            aArreglo[0] = 0;
            aArreglo[1] = 1;

            for (int i = 2; i < Obj_Datos.iLimite; i++)
            {
                aArreglo[i] = aArreglo[i - 1] + aArreglo[i - 2];

                Obj_Datos.aDatos = aArreglo;
            }

            
            
        }

    }
}
