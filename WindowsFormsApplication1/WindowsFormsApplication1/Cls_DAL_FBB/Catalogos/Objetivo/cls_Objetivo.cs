using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.Objetivo
{
    class cls_Objetivo
    {
        #region Variables Privadas
        private int _id_objetivo;
        private string _descripcion;
        #endregion

        #region Constructores

        public int iObjetivo
        {
            get { return _id_objetivo; }
            set { _id_objetivo = value; }
        }

        public string sDescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        #endregion

    }
}
