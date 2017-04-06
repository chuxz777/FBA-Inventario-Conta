using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.Estados
{
    class cls_Estados_DAL
    {
        #region Variables Privadas
        private int _id_estado;
        private string _descripcion;
        #endregion

        #region Constructores

        public int iIdEstado
        {
            get { return _id_estado; }
            set { _id_estado = value; }
        }

        public string sDescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        #endregion
    }
}
