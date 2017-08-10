using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_DAL_FBB.Catalogos.Donacion
{
    public class Donacion_DAL : Acciones_Genericas.cls_Clase_Generica_DAL
    {
        #region Variables Privadas
        private int _id_donacion;
        private int _monto;
        private DateTime _fecha;
        private string _donador;
        private string _telefono;
        private string _email;
        private string _comentario;
        #endregion

        #region Constructores

        public int iIdDonacion
        {
            get { return _id_donacion; }
            set { _id_donacion = value; }
        }

        public int iMonto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        public DateTime dtmFecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string sDonador
        {
            get { return _donador; }
            set { _donador = value; }
        }

        public string sTelefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string sEmail
        {
            get { return _email; }
            set { _email = value; }
        }
        public string sComentario
        {
            get { return _comentario; }
            set { _comentario = value; }
        }


        #endregion


    }
}
