﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.Color
{
    public class cls_Color_DAL : Acciones_Genericas.cls_Clase_Generica_DAL
    {
        #region Variables Privadas
        private int _id_color;
        private string _descripcion;
        #endregion

        #region Constructores

        public int iColor
        {
            get { return _id_color; }
            set { _id_color = value; }
        }

        public string sDescripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        #endregion

    }
}
