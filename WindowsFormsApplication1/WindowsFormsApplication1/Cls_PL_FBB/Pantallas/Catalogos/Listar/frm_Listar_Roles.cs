using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_DAL.Catalogos.Roles;
using Cls_BLL.BaseDatos;
using Cls_PL.Pantallas.Catalogos.Modificar;
using Cls_BLL.Catalogos.Roles;
using Cls_DAL.Catalogos.Log_in;

namespace Cls_PL.Pantallas.Catalogos.Listar
{
    public partial class frm_Listar_Roles : Form
    {
        #region Variables Globales

            public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
            cls_Roles_BLL Obj_cls_Roles_BLL = new cls_Roles_BLL();
            cls_Roles_DAL Obj_cls_Roles_DAL = new cls_Roles_DAL();
            Frm_Modificar_Roles Obj_Pantalla_Mod_Roles = new Frm_Modificar_Roles();
            string sMensajeError;

        #endregion

        public frm_Listar_Roles()
        {
            InitializeComponent();
        }

        private void frm_Listar_Roles_Load(object sender, EventArgs e)
        {
            Cargar();
            Opciones();
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlsbtn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Roles.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Rol para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Cargar_Filas();
            }
        }

        private void tlsbtn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void tlsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            Obj_cls_Roles_DAL.bAccion = true;

            Obj_cls_Roles_DAL.iId_Rol = 0;
            Obj_cls_Roles_DAL.sNombre = string.Empty;
            Obj_cls_Roles_DAL.sDescripcion = string.Empty;
            Obj_cls_Roles_DAL.cId_Estado = 'A';

            Obj_cls_Roles_DAL.bEstado_Ejec = false;

            Obj_Pantalla_Mod_Roles.Obj_cls_Roles_DAL = Obj_cls_Roles_DAL;
            Obj_Pantalla_Mod_Roles.ShowDialog();
        }

        private void tlsbtn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Fila();
            Cargar();
        }

        private void dgv_Roles_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Roles.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Rol para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Cargar_Filas();
            }
        }

        private void tlstxt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            DataTable dt_Busqueda = new DataTable();

            if (Obj_cls_Roles_BLL.Filtrar_Roles_SP(ref dt_Busqueda, tlstxt_Busqueda.Text.Trim(), ref sMensajeError))
            {
                dgv_Roles.DataSource = dt_Busqueda;
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

        private void Cargar_Filas()
        {
            Obj_cls_Roles_DAL.bAccion = false;

            Obj_cls_Roles_DAL.iId_Rol = Convert.ToInt32(dgv_Roles.SelectedRows[0].Cells[0].Value.ToString());
            Obj_cls_Roles_DAL.sNombre = dgv_Roles.SelectedRows[0].Cells[1].Value.ToString();
            Obj_cls_Roles_DAL.sDescripcion = dgv_Roles.SelectedRows[0].Cells[2].Value.ToString();
            Obj_cls_Roles_DAL.cId_Estado = Convert.ToChar(dgv_Roles.SelectedRows[0].Cells[3].Value.ToString());

            Obj_cls_Roles_DAL.bEstado_Ejec = false;

            Obj_Pantalla_Mod_Roles.Obj_cls_Roles_DAL = Obj_cls_Roles_DAL;
            Obj_Pantalla_Mod_Roles.ShowDialog();
        }

        private void Cargar()
        {
            string sMensajeError = string.Empty;
            DataTable dt = new DataTable();

            if (Obj_cls_Roles_BLL.Listar_Roles_SP(ref dt, ref sMensajeError))
            {
                dgv_Roles.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Problemas a la hora de la carga de la información.\n" +
                                "Mensaje del SQL: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Fila()
        {
            if (dgv_Roles.SelectedRows.Count > 0)
            {
                Obj_cls_Roles_DAL.bEstado_Ejec = true;
                Obj_cls_Roles_DAL.iId_Rol = Convert.ToInt32(dgv_Roles.SelectedRows[0].Cells[0].Value.ToString());
                Obj_cls_Roles_DAL.sNombre = dgv_Roles.SelectedRows[0].Cells[1].Value.ToString();
                Obj_cls_Roles_DAL.sDescripcion = dgv_Roles.SelectedRows[0].Cells[2].ToString();
                Obj_cls_Roles_DAL.cId_Estado = Convert.ToChar(dgv_Roles.SelectedRows[0].Cells[3].Value.ToString());

                if (MessageBox.Show("Está seguro de que desea eliminar el registro", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Obj_cls_Roles_BLL.Eliminar_Roles_SP(ref Obj_cls_Roles_DAL, ref sMensajeError);

                    if (Obj_cls_Roles_DAL.bEstado_Ejec == true)
                    {
                        MessageBox.Show("El registro a sido eliminado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("A ocurrido un error:  " + sMensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un Row antes de modificar un dato ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}