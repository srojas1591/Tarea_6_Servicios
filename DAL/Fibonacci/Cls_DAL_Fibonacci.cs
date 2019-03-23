using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Fibonacci
{
  public class Cls_DAL_Fibonacci
    {
        private string _sMsj;
        private int _iNumero1, _iNumero2, _iSumatoria, _iLimite;
        private int[] _aDatos;

        public string sMsj
        {
            get
            {
                return _sMsj;
            }

            set
            {
                _sMsj = value;
            }
        }

        public int iNumero1
        {
            get
            {
                return _iNumero1;
            }

            set
            {
                _iNumero1 = value;
            }
        }

        public int iNumero2
        {
            get
            {
                return _iNumero2;
            }

            set
            {
                _iNumero2 = value;
            }
        }

        public int iSumatoria
        {
            get
            {
                return _iSumatoria;
            }

            set
            {
                _iSumatoria = value;
            }
        }

        public int iLimite
        {
            get
            {
                return _iLimite;
            }

            set
            {
                _iLimite = value;
            }
        }

        public int[] aDatos
        {
            get
            {
                return _aDatos;
            }

            set
            {
                _aDatos = value;
            }
        }
    }
}
