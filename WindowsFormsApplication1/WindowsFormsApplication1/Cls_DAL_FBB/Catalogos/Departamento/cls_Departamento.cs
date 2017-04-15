using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.Departamento
{
    public class cls_Departamento
    {
        #region Variables Privadas
        private int _id_departamento;
        private string _descripcion;
        #endregion

        #region Constructores

        public int iDepartamento
        {
            get { return _id_departamento; }
            set { _id_departamento = value; }
        }

        public string sDescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        #endregion

    }
}
