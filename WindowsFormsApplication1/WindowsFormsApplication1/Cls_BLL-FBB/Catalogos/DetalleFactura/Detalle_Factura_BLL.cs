using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cls_DAL_FBB.Catalogos.DetalleFactura;
using System.Data;
using System.Data.SqlClient;

namespace Cls_BLL_FBB.Catalogos.DetalleFactura
{
    public class cls_Detalle_Factura_BLL
    {

        #region Variables Globales
        SqlConnection Cnx_BD = new SqlConnection();
        BaseDatos.cls_Base_Datos_BLL Obj_BD_BLL = new BaseDatos.cls_Base_Datos_BLL();
        private SqlCommand cmd;
        #endregion

        public void Actualizar_Factura_SP(ref cls_DetalleFactura_DAL Obj_Cls_Detalle_Factura_DAL, ref string sMensajeError)
        {
            try
            {
                #region Prepara cmd

                Cnx_BD = Obj_BD_BLL.Traer_Cnx();

                cmd = new SqlCommand("SP_Detalle_Factura", Cnx_BD);
                //Define el tipo de ejec
                cmd.CommandType = CommandType.StoredProcedure;

                //Agrega Parametros
                //cmd.Parameters.Add("@Id_Estado", SqlDbType.Char).Value = Obj_Cls_Estados_DAL.iIdEstado;
                cmd.Parameters.Add("@factura", SqlDbType.Int).Value = Obj_Cls_Detalle_Factura_DAL.iId_Factura;
                cmd.Parameters.Add("@id_articulo", SqlDbType.Int).Value = Obj_Cls_Detalle_Factura_DAL.iCodArticulo;
                
                if (Cnx_BD.State.ToString() == "Closed")
                {
                    Cnx_BD.Open();
                }
                #endregion

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Obj_Cls_Detalle_Factura_DAL.bEstado_Ejec = true;
                }
                else
                {
                    Obj_Cls_Detalle_Factura_DAL.bEstado_Ejec = false;
                }
            }
            catch (SqlException ex)
            {
                sMensajeError = ex.Message;
                Obj_Cls_Detalle_Factura_DAL.bEstado_Ejec = false; // no se ejecuto 
            }
            catch (Exception ex)
            {
                sMensajeError = ex.Message;
            }
            finally
            {
                Cnx_BD = null;
            }
        }

    }
}
