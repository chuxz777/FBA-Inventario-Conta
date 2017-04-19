using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Cls_BLL_FBB.BaseDatos
{
    class cls_Base_Datos_BLL
    {
        #region Variable Global

        // esta es la variable globlal de la conexion        
        SqlConnection Cnx_BD = new SqlConnection();

        #endregion

        public SqlConnection Traer_Cnx()
        {
            #region Variable

            ConnectionStringSettings cadena;

            #endregion

            try
            {
                // esta linea lee el XML del App.config para que lea cada 
                // dato, tengo que especificar el nombre en "[]"
                cadena = ConfigurationManager.ConnectionStrings["CNX_BD2"];

                // esto hace la conexion de BD, es mas una preparar el obj que 
                //otra cosa
                Cnx_BD = new SqlConnection(cadena.ToString());

                return Cnx_BD;
            }
            catch
            {
                return null;// por si no lo hace que no tire nada raro

            }
            finally
            {
                Cnx_BD = null;// GarbageCollector 
            }
        }
    }
}
