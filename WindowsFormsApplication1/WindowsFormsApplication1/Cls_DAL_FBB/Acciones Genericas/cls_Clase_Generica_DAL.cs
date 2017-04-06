using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Acciones_Genericas
{
    class cls_Clase_Generica_DAL
    {
        #region Variables privadas
        // Clase para q todos los objetos DAL hereden estas propiedades
        private bool _baccion;
        private bool _bestadoEjec;
        #endregion

        #region Constructores
        public bool bAccion  // false > Update   ----  true > Insert
        {
            get { return _baccion; }
            set { _baccion = value; }
        }

        public bool bEstado_Ejec
        {
            get { return _bestadoEjec; }
            set { _bestadoEjec = value; }
        }
        #endregion
    }
}
