using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cls_DAL_FBB.Catalogos.Estados;

namespace Cls_BLL_FBB.Catalogos.Estados
{
    class cls_Estados_BLL
    {
        #region Variables Globales

        SqlConnection Cnx_BD = new SqlConnection();
        BaseDatos.cls_Base_Datos_BLL Obj_BD_BLL = new BaseDatos.cls_Base_Datos_BLL();
        private SqlCommand cmd;

        #endregion

        public bool Filtrar_Estados_SP(ref DataTable dt_Estados_Filtrados, string sBusqueda, ref string sMensajeError)
        {
            try
            {
                // Prepara cmd

                DataSet DataSet = new DataSet();
                SqlDataAdapter DataAdapter;
                Cnx_BD = Obj_BD_BLL.Traer_Cnx();

                cmd = new SqlCommand("SP_Estados_Filtrar", Cnx_BD);
                //Agrega Parametros
                cmd.Parameters.Add("@Busqueda", SqlDbType.NVarChar).Value = sBusqueda.Trim();

                cmd.CommandType = CommandType.StoredProcedure;


                if (Cnx_BD.State.ToString() == "Closed")
                {
                    Cnx_BD.Open();
                }

                DataAdapter = new SqlDataAdapter(cmd);
                DataAdapter.Fill(DataSet, "dt_Estados_filtr");

                dt_Estados_Filtrados = DataSet.Tables["dt_Estados_filtr"];

                return true;

            }
            catch (SqlException ex)
            {
                sMensajeError = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                sMensajeError = ex.Message;
                return false;
            }
            finally
            {
                Cnx_BD = null;
            }
        }

        public bool Listar_Estados_SP(ref DataTable dt_Estados, ref string sMensajeError)
        {
            try
            {
                #region Coneccion
                DataSet DataSet = new DataSet();
                SqlDataAdapter DataAdapter;
                Cnx_BD = Obj_BD_BLL.Traer_Cnx();

                cmd = new SqlCommand("SP_Estados_Seleccionar", Cnx_BD);

                if (Cnx_BD.State.ToString() == "Closed")
                {
                    Cnx_BD.Open();
                }

                cmd.CommandType = CommandType.StoredProcedure;

                DataAdapter = new SqlDataAdapter(cmd);

                DataAdapter.Fill(DataSet, "dt_Estados");

                dt_Estados = DataSet.Tables["dt_Estados"];

                return true;
                #endregion
            }
            catch (SqlException ex)
            {
                sMensajeError = ex.Message;
                return false;
            }
            finally
            {
                Cnx_BD = null;
            }
        }

        public void Insertar_Estados_SP(ref cls_Estados_DAL Obj_Cls_Estados_DAL, ref string sMensajeError)
        {
            try
            {
                #region Prepara cmd

                Cnx_BD = Obj_BD_BLL.Traer_Cnx();

                cmd = new SqlCommand("SP_Estados_Insertar", Cnx_BD);
                //Define el tipo de ejec
                cmd.CommandType = CommandType.StoredProcedure;

                //Agrega Parametros
                cmd.Parameters.Add("@Id_Estado", SqlDbType.Char).Value = Obj_Cls_Estados_DAL.iIdEstado;
                cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = Obj_Cls_Estados_DAL.sDescripcion;

                if (Cnx_BD.State.ToString() == "Closed")
                {
                    Cnx_BD.Open();
                }
                #endregion

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Obj_Cls_Estados_DAL.bEstado_Ejec = true;
                }
                else
                {
                    Obj_Cls_Estados_DAL.bEstado_Ejec = false;
                }
            }
            catch (SqlException ex)
            {
                sMensajeError = ex.Message;
                Obj_Cls_Estados_DAL.bEstado_Ejec = false; // no se ejecuto 
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

        public void ModificarEstados_SP(ref cls_Estados_DAL Obj_Cls_Estados_DAL, ref string sMensajeError)
        {
            try
            {
                #region Prepara cmd

                Cnx_BD = Obj_BD_BLL.Traer_Cnx();

                cmd = new SqlCommand("SP_Estados_Modificar", Cnx_BD);
                //Define el tipo de ejec
                cmd.CommandType = CommandType.StoredProcedure;

                //Agrega Parametros
                cmd.Parameters.Add("@Id_Estado", SqlDbType.Char).Value = Obj_Cls_Estados_DAL.iIdEstado;
                cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = Obj_Cls_Estados_DAL.sDescripcion;

                if (Cnx_BD.State.ToString() == "Closed")
                {
                    Cnx_BD.Open();
                }

                #endregion
                // exec non query

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Obj_Cls_Estados_DAL.bEstado_Ejec = true;
                }
                else
                {
                    Obj_Cls_Estados_DAL.bEstado_Ejec = false;
                }
            }
            catch (SqlException ex)
            {
                sMensajeError = ex.Message;
                Obj_Cls_Estados_DAL.bEstado_Ejec = false;
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

        public void EliminarEstados_SP(ref cls_Estados_DAL Obj_Cls_Estados_DAL, ref string sMensajeError)
        {
            try
            {
                #region Prepara cmd

                Cnx_BD = Obj_BD_BLL.Traer_Cnx();

                cmd = new SqlCommand("SP_Estados_Eliminar", Cnx_BD);

                if (Cnx_BD.State.ToString() == "Closed")
                {
                    Cnx_BD.Open();
                }

                //Define el tipo de ejec
                cmd.CommandType = CommandType.StoredProcedure;

                //Agrega Parametros
                cmd.Parameters.Add("@Id_Estado", SqlDbType.Char).Value = Obj_Cls_Estados_DAL.iIdEstado;
                #endregion

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Obj_Cls_Estados_DAL.bEstado_Ejec = true;
                }
                else
                {
                    Obj_Cls_Estados_DAL.bEstado_Ejec = false;
                }
            }
            catch (SqlException ex)
            {
                sMensajeError = ex.Message;
                Obj_Cls_Estados_DAL.bEstado_Ejec = false;
            }
            finally
            {
                Cnx_BD = null;
            }
        }


    }
}
