using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.Inventario
{
    public class cls_Inventario_DAL : Acciones_Genericas.cls_Clase_Generica_DAL
    {

        #region Variables Privadas
        private int _id_articulo;
        private int _cod_tipo_articulo;
        private int _cod_departamento;
        private int _precio_sugerido;
        private DateTime _fecha_entrada_inv;
        private int _cod_color;
        private int _cod_objetivo;
        private int _cod_estado;

        #endregion

        #region Constructores

        public int iIid_articulo
        {
            get { return _id_articulo; }
            set { _id_articulo = value; }
        }

        public int iCod_tipo_articulo
        {
            get { return _cod_tipo_articulo; }
            set { _cod_tipo_articulo = value; }
        }

        public int iCod_departamento
        {
            get { return _cod_departamento; }
            set { _cod_departamento = value; }
        }

        public int iPrecio_sugerido
        {
            get { return _precio_sugerido; }
            set { _precio_sugerido = value; }
        }

        public DateTime dFecha_entrada_inv
        {
            get { return _fecha_entrada_inv; }
            set { _fecha_entrada_inv = value; }

        }

        public int iCod_color
        {
            get { return _cod_color; }
            set { _cod_color = value; }
        }

        public int iCod_Objetivo
        {
            get { return _cod_objetivo; }
            set { _cod_objetivo = value; }
        }

        public int iCod_Estado
        {
            get { return _cod_estado; }
            set { _cod_estado = value; }
        }
        #endregion
    }
}
