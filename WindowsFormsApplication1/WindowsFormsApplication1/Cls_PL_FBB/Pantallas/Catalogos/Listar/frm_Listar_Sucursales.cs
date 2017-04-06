using System;
using System.Data;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Sucursal;
using Cls_DAL.Catalogos.Sucursal;
using Cls_BLL.BaseDatos;
using Cls_DAL.Catalogos.Log_in;

namespace Cls_PL
{
    public partial class Frm_Listar_Sucursales : Form
    {
        #region Variables Globales

        cls_Base_Datos_BLL Obj_cls_Base_Datos_BLL = new cls_Base_Datos_BLL();
        cls_Sucursal_BLL Obj_cls_Sucursales_BLL = new cls_Sucursal_BLL();
        cls_Sucursal_DAL Obj_cls_Sucursal_DAL = new cls_Sucursal_DAL();
        public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
        string sMensajeError;

        Cls_PL.Pantallas.Catalogos.Modificar.Frm_Modificar_Sucursales Obj_Frm_Modificar_Sucursales_PL = new Cls_PL.Pantallas.Catalogos.Modificar.Frm_Modificar_Sucursales();
        
        #endregion

        public Frm_Listar_Sucursales()
        {
            InitializeComponent(); 
        }

        private void Frm_Listar_Sucursales_Load(object sender, EventArgs e)
        {
            Opciones();
            Cargar();
        }

        private void Cargar()
        {
            string sMensajeError = string.Empty;
            DataTable dt = new DataTable();

            if (Obj_cls_Sucursales_BLL.Listar_Sucursal(ref dt, ref sMensajeError))
            {
                dgv_Sucursales.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Problemas a la hora de la carga de la información.\n" +
                                "Mensaje de error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            if (dgv_Sucursales.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado una sucursal para ser modificada.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Obj_cls_Sucursal_DAL.bAccion = false; // No es insert
                Obj_cls_Sucursal_DAL.bEstado_Ejec = false; // No se ha hecho la ejecucion

                Obj_cls_Sucursal_DAL.iIdSucursal = Convert.ToInt32(dgv_Sucursales.SelectedRows[0].Cells[0].Value);
                Obj_cls_Sucursal_DAL.sNombre = dgv_Sucursales.SelectedRows[0].Cells[1].Value.ToString();
                Obj_cls_Sucursal_DAL.sDireccion = dgv_Sucursales.SelectedRows[0].Cells[2].Value.ToString();
                Obj_cls_Sucursal_DAL.sTelefono = dgv_Sucursales.SelectedRows[0].Cells[3].Value.ToString();
                Obj_cls_Sucursal_DAL.cIdEstado = Convert.ToChar(dgv_Sucursales.SelectedRows[0].Cells[4].Value);

                Obj_Frm_Modificar_Sucursales_PL.Obj_cls_Sucursal_DAL = Obj_cls_Sucursal_DAL;
                Obj_Frm_Modificar_Sucursales_PL.ShowDialog();
            }
        }

        private void tlsbtn_Refrescar_Click(object sender, EventArgs e)
        {
            this.Cargar();
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            Obj_cls_Sucursal_DAL.bAccion = true; // Es insert
            Obj_cls_Sucursal_DAL.bEstado_Ejec = false; // No se ha hecho la accion

            Obj_cls_Sucursal_DAL.iIdSucursal = 0;
            Obj_cls_Sucursal_DAL.sNombre = string.Empty;
            Obj_cls_Sucursal_DAL.sDireccion = string.Empty;
            Obj_cls_Sucursal_DAL.sTelefono = string.Empty;
            Obj_cls_Sucursal_DAL.cIdEstado = 'A';

            Obj_Frm_Modificar_Sucursales_PL.Obj_cls_Sucursal_DAL = Obj_cls_Sucursal_DAL;
            Obj_Frm_Modificar_Sucursales_PL.ShowDialog();
        }

        private void tlsbtn_Editar_Click(object sender, EventArgs e)
        {
            this.Editar();
        }

        private void tlsbtn_Eliminar_Click(object sender, EventArgs e)
        {
            string sMensajeError = string.Empty;

            if (dgv_Sucursales.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado una sucursal para ser eliminada.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Obj_cls_Sucursal_DAL.bAccion = false; // No es insert
                Obj_cls_Sucursal_DAL.bEstado_Ejec = false; // No se ha hecho la ejecucion
                
                Obj_cls_Sucursal_DAL.iIdSucursal = Convert.ToInt32(dgv_Sucursales.SelectedRows[0].Cells[0].Value);

                Obj_cls_Sucursales_BLL.Eliminar_Sucursal(ref Obj_cls_Sucursal_DAL, ref sMensajeError);

                if (Obj_cls_Sucursal_DAL.bEstado_Ejec == true)
                {
                    MessageBox.Show("La sucursal fue eliminada correctamente.",
                                    "Confirmación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La sucursal no se pudo eliminar correctamente, hubo un error en la ejecución." +
                                    "\nMensaje de error: " + sMensajeError,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void tlstrp_txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            DataTable dt_f = new DataTable();

            if (Obj_cls_Sucursales_BLL.Filtrar_Sucursal(ref dt_f, tlstrp_txt_Busqueda.Text.Trim(), ref sMensajeError))
            {
                dgv_Sucursales.DataSource = dt_f;
            }
            else
            {
                MessageBox.Show("Problemas a la hora de la carga de la información.\n" +
                                "Mensaje error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Opciones()
        {
            switch (Obj_Login_DAL.iRol)
            {
                case 1:// administrador

                    tlsbtn_Editar.Enabled = true;
                    tlsbtn_Nuevo.Enabled = true;
                    tlsbtn_Eliminar.Enabled = true;
                    break;

                case 2:// Medio

                    tlsbtn_Editar.Enabled = true;
                    tlsbtn_Nuevo.Enabled = true;
                    tlsbtn_Eliminar.Enabled = false;
                    break;

                case 3: // solo lectura


                    tlsbtn_Editar.Enabled = false;
                    tlsbtn_Nuevo.Enabled = false;
                    tlsbtn_Eliminar.Enabled = false;
                    break;

                default:

                    tlsbtn_Editar.Enabled = false;
                    tlsbtn_Nuevo.Enabled = false;
                    tlsbtn_Eliminar.Enabled = false;
                    break;
            }
        }

        private void dgv_Sucursales_DoubleClick(object sender, EventArgs e)
        {
            this.Editar();
        }
    }
}