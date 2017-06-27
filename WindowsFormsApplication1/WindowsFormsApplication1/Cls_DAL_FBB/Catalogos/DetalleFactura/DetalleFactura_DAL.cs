using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.DetalleFactura
{
    public class cls_DetalleFactura_DAL : Acciones_Genericas.cls_Clase_Generica_DAL
    {
        #region Variables Privadas
        private int _id_factura;
        private int _id_articulo;
        #endregion

        #region Constructores

        public int iId_Factura
        {
            get { return _id_factura; }
            set { _id_factura = value; }
        }

        public int iCodArticulo
        {
            get { return _id_articulo; }
            set { _id_articulo = value; }

        }
        #endregion


    }
}
