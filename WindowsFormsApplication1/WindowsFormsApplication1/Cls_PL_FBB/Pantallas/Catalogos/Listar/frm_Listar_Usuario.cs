using System;
using System.Data;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Estados;
using Cls_BLL.Catalogos.Usuario;
using Cls_DAL.Catalogos.Log_in;
using Cls_DAL.Catalogos.Usuario;
using Cls_PL.Pantallas.Catalogos.Modificar;

namespace Cls_PL
{
    public partial class Frm_Listar_Usuario : Form
    {
        #region Variables Globales

            private Frm_Modificar_Usuario Obj_Pant_Mod_Usuario = new Frm_Modificar_Usuario();
            cls_Usuario_DAL Obj_Cls_Usuario_DAL = new cls_Usuario_DAL();
            cls_Usuario_BLL Obj_Cls_Usuario_BLL = new cls_Usuario_BLL();
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
            DataTable dtEstados = new DataTable();
            private string sMensajeError;
       
        #endregion

        public Frm_Listar_Usuario()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opciones();
            Cargar();
        }

        private void tlsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            Obj_Cls_Usuario_DAL.bAccion = true; // Es un insert
            Obj_Cls_Usuario_DAL.sUsuario = string.Empty;
            Obj_Cls_Usuario_DAL.sContrasena = string.Empty;
            Obj_Cls_Usuario_DAL.iCodempleado = 0;
            Obj_Cls_Usuario_DAL.iIdrol = 0;
            Obj_Cls_Usuario_DAL.chrIdEstado = ' ';
            Obj_Cls_Usuario_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
            Obj_Pant_Mod_Usuario.Obj_Cls_Empleado_DAL = Obj_Cls_Usuario_DAL;
            Obj_Pant_Mod_Usuario.ShowDialog();
        }

        private void tlsbtn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Estado();
        }

        private void tlsbtn_Editar_Click(object sender, EventArgs e)
        {
            Obj_Cls_Usuario_DAL.bAccion = false; // Es un update
            if (dgv_Usuarios.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Usuario para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else 
            {
                Cargar_Fila();
            }
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlsbtn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgv_Estados_DoubleClick(object sender, EventArgs e)
        {
            Obj_Cls_Usuario_DAL.bAccion = false; // Es un update
            if (dgv_Usuarios.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Usuario para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else 
            {
                Cargar_Fila();
            }
        }

        // Metodos de cada boton
        private void Eliminar_Estado()
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                Obj_Cls_Usuario_DAL.bEstado_Ejec = true;
                Obj_Cls_Usuario_DAL.sUsuario = dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString().Trim();

            if (MessageBox.Show("Está seguro de que desea eliminar el registro", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Obj_Cls_Usuario_BLL.Eliminar_Usuarios_SP(ref Obj_Cls_Usuario_DAL, ref sMensajeError);

                    if (Obj_Cls_Usuario_DAL.bEstado_Ejec == true)
                    {
                        MessageBox.Show("El registro a sido eliminado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("Problemas a la hora de la eliminar de la información.\n" +
                               "Mensaje del SQL: " + sMensajeError,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un Row antes de modificar un dato ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cargar()
        {
            DataTable dt = new DataTable();

            if (Obj_Cls_Usuario_BLL.Listar_Usuarios_SP(ref dt, ref sMensajeError))
            {
                dgv_Usuarios.DataSource = dt;
                // esconde columna de contraseñas
                dgv_Usuarios.Columns[1].Visible = false;
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

        private void Cargar_Fila()
        {
            Obj_Cls_Usuario_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
            Obj_Cls_Usuario_DAL.sUsuario = dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString().Trim();
            Obj_Cls_Usuario_DAL.sContrasena = dgv_Usuarios.SelectedRows[0].Cells[1].Value.ToString().Trim();
            Obj_Cls_Usuario_DAL.iTipoUsuario = Convert.ToInt32(dgv_Usuarios.SelectedRows[0].Cells[2].Value.ToString().Trim());
            Obj_Cls_Usuario_DAL.iCodempleado = Convert.ToInt32(dgv_Usuarios.SelectedRows[0].Cells[4].Value.ToString().Trim());
            Obj_Cls_Usuario_DAL.iIdrol = Convert.ToInt32(dgv_Usuarios.SelectedRows[0].Cells[5].Value.ToString().Trim());
            Obj_Cls_Usuario_DAL.chrIdEstado = Convert.ToChar(dgv_Usuarios.SelectedRows[0].Cells[7].Value.ToString().Trim());
            
            // Carga los valores del row en un objeto y los envia a la pantalla de edicion
            Obj_Pant_Mod_Usuario.Obj_Cls_Empleado_DAL = Obj_Cls_Usuario_DAL;
            Obj_Pant_Mod_Usuario.ShowDialog();
        }

        // Filtrado
        private void tlstrp_txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            DataTable dt_f = new DataTable();

            if (Obj_Cls_Usuario_BLL.Filtrar_Usuarios_SP(ref dt_f, tlstrp_txt_Busqueda.Text.Trim(), ref sMensajeError))
            {
                dgv_Usuarios.DataSource = dt_f;
                // esconde columna de contraseñas
                dgv_Usuarios.Columns[1].Visible = false;
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
    }
}