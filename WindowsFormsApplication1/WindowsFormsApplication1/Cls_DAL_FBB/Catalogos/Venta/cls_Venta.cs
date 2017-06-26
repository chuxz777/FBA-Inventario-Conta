using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.Venta
{
    public class cls_Venta_DAL : Acciones_Genericas.cls_Clase_Generica_DAL 
    {

        #region Variables Privadas
        private int _id_factura;
        private DateTime _fecha_venta;
        private int _total;
        private int _estado_factura;
        #endregion

        #region Constructores

        public int iId_Factura
        {
            get { return _id_factura; }
            set { _id_factura = value; }
        }

        public DateTime dFecha_Venta
        {
            get { return _fecha_venta; }
            set { _fecha_venta = value; }
        }

        public int iTotal
        {
            get { return _total; }
            set { _total = value; }

        }

        public int iEstado_Factura
        {
            get { return _estado_factura; }
            set { _estado_factura = value; }

        }
        #endregion
    }
}
