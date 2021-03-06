﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.TipoArticulo
{
    public class cls_TipoArticulo_DAL : Acciones_Genericas.cls_Clase_Generica_DAL
    {
        #region Variables Privadas
        private int _id_tipo_articulo;
        private string _descripcion;
        #endregion

        #region Constructores

        public int iTipoArticulo
        {
            get { return _id_tipo_articulo; }
            set { _id_tipo_articulo = value; }
        }

        public string sDescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        #endregion

    }
}
