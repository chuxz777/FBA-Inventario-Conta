using System;
using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Estados;
using Cls_BLL.Catalogos.Tipo_Usuario;
using Cls_BLL.Catalogos.Usuario;
using Cls_DAL.Catalogos.Estados;
using Cls_DAL.Catalogos.Tipo_Usuario;
using Cls_DAL.Catalogos.Usuario;
using Cls_BLL.Catalogos.Empleados;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Usuario : Form
    {
        #region Variables

            public cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            public cls_Usuario_BLL Obj_Cls_Empleado_BLL = new cls_Usuario_BLL();
            public cls_Usuario_DAL Obj_Cls_Empleado_DAL = new cls_Usuario_DAL();
            public cls_Tipo_Usuario_BLL Obj_Cls_Tipo_Usuario_BLL = new cls_Tipo_Usuario_BLL();
            public cls_Empleados_BLL Obj_Cls_Empleados_BLL = new cls_Empleados_BLL();
            DataTable dtEstados = new DataTable();
            DataTable dtRoles = new DataTable();
            DataTable dtTipoUsuario = new DataTable();
            DataTable dtEmpleados = new DataTable();
            private string sMensajeError;
       
        #endregion

        public Frm_Modificar_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Estados_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Tipo_Usuario();
            Cargar_Combo_Rol();
            Cargar_Combo_Estados();
            Cargar_Combo_Empleado();
            Cargar_Datos_Clasetipada();
        }

        private void tlsbtn_Guardar_Click(object sender, EventArgs e)
        {
            if (msktxt_contraseña.Text.Trim() == string.Empty || txt_Codigo_Usuario.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El empleado no fue guardado. Hay datos incompletos.",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Cargar_Datos_Pantalla();

                if (Obj_Cls_Empleado_DAL.bAccion == true)
                {
                    Guardar();
                    Cargar_Datos_Clasetipada();
                }
                else
                {
                    Modificar();
                    Cargar_Datos_Clasetipada();
                }
            }
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkbx_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            msktxt_contraseña.PasswordChar = chkbx_contraseña.Checked ? '\0' : '*';
        }
        
        // Carga lo que recive el objeto a la pantalla
        private void Cargar_Datos_Clasetipada()
        {
            if (Obj_Cls_Empleado_DAL.bAccion) //  == true
            {
                txt_Codigo_Usuario.Enabled = true;
                txt_Codigo_Usuario.Text = string.Empty;
                msktxt_contraseña.Text = string.Empty;
                cmbx_Codigo_Empleado.SelectedIndex = 0;
                cmbx_Estado.SelectedIndex = 0;
                cmbx_Rol.SelectedIndex = 0;
                cmbx_TipoUsuario.SelectedIndex = 0;
            }
            else
            {
                txt_Codigo_Usuario.Enabled = false;
                // Cargar los datos del objeto en pantnalla
                txt_Codigo_Usuario.Text = Obj_Cls_Empleado_DAL.sUsuario;
                msktxt_contraseña.Text = Obj_Cls_Empleado_DAL.sContrasena.Trim();
                cmbx_Codigo_Empleado.SelectedValue = Obj_Cls_Empleado_DAL.iCodempleado.ToString();
                cmbx_Rol.SelectedValue = Obj_Cls_Empleado_DAL.iIdrol.ToString() ;
                cmbx_Estado.SelectedValue = Obj_Cls_Empleado_DAL.chrIdEstado.ToString();
                cmbx_TipoUsuario.SelectedValue = Obj_Cls_Empleado_DAL.iTipoUsuario.ToString();
            }
        }

        // Carga lo que esta en pantalla en el objeto
        private void Cargar_Datos_Pantalla()
        {
            Obj_Cls_Empleado_DAL.sUsuario = txt_Codigo_Usuario.Text.Trim();
            Obj_Cls_Empleado_DAL.sContrasena = msktxt_contraseña.Text.Trim();
            Obj_Cls_Empleado_DAL.iTipoUsuario = Convert.ToInt32(cmbx_TipoUsuario.SelectedValue.ToString());
            Obj_Cls_Empleado_DAL.iCodempleado = Convert.ToInt32(cmbx_Codigo_Empleado.SelectedValue.ToString());
            Obj_Cls_Empleado_DAL.iIdrol = Convert.ToInt32(cmbx_Rol.SelectedValue.ToString());
            Obj_Cls_Empleado_DAL.chrIdEstado = Convert.ToChar(cmbx_Estado.SelectedValue.ToString());
        }

        public void Cargar_Combo_Estados()
        {
            if (Obj_Estados_BLL.Listar_Estados_SP(ref dtEstados, ref sMensajeError))
            {
                cmbx_Estado.ValueMember = dtEstados.Columns["Codigo del Estado"].ToString();
                cmbx_Estado.DisplayMember = dtEstados.Columns["Descripción del Estado"].ToString();
                cmbx_Estado.DataSource = dtEstados;
                cmbx_Estado.SelectedValue = "0";
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

        public void Cargar_Combo_Rol()
        {
            if (Obj_Cls_Empleado_BLL.Listar_Roles_SP(ref dtRoles, ref sMensajeError))
            {
                cmbx_Rol.ValueMember = dtRoles.Columns["Código del Rol"].ToString();
                cmbx_Rol.DisplayMember = dtRoles.Columns["Nombre del Rol"].ToString();
                cmbx_Rol.DataSource = dtRoles;
                cmbx_Rol.SelectedValue = "0";
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

        public void Cargar_Combo_Tipo_Usuario()
        {
            if (Obj_Cls_Tipo_Usuario_BLL.Listar_Tipo_Usuario_SP(ref dtTipoUsuario, ref sMensajeError))
            {
                cmbx_TipoUsuario.ValueMember = dtTipoUsuario.Columns["Código del Usuario"].ToString();
                cmbx_TipoUsuario.DisplayMember = dtTipoUsuario.Columns["Descripción"].ToString();
                cmbx_TipoUsuario.DataSource = dtTipoUsuario;
                cmbx_TipoUsuario.SelectedValue = "0";
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

        public void Cargar_Combo_Empleado()
        {
            if (Obj_Cls_Empleados_BLL.listar_Empleados_SP(ref dtEmpleados, ref sMensajeError))
            {
                cmbx_Codigo_Empleado.ValueMember = dtEmpleados.Columns["ID Empleado"].ToString();
                cmbx_Codigo_Empleado.DisplayMember = dtEmpleados.Columns["Nombre"].ToString();
                cmbx_Codigo_Empleado.DataSource = dtEmpleados;
                cmbx_Codigo_Empleado.SelectedValue = "0";
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
        
        private void Guardar()
        {
            Cargar_Datos_Pantalla();
            Obj_Cls_Empleado_BLL.Insertar_Usuarios_SP(ref Obj_Cls_Empleado_DAL, ref sMensajeError);

            if (Obj_Cls_Empleado_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El usuario fue insertado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                Obj_Cls_Empleado_DAL.bAccion = false;// update
            }
            else
            {
                MessageBox.Show("El usuario nuevo no fue guardado, hubo un error en la ejecucíón.\n" +
                               "Mensaje Error: " + sMensajeError,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                Obj_Cls_Empleado_DAL.bAccion = true; // insert
            }
        }

        private void Modificar()
        {
            Cargar_Datos_Pantalla();
            Obj_Cls_Empleado_BLL.Modificar_Usuarios_SP(ref Obj_Cls_Empleado_DAL, ref sMensajeError);

            if (Obj_Cls_Empleado_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El usuario fue actualizado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                Obj_Cls_Empleado_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El usuario no se pudo actualizar, hubo un error en la ejecucíón.\n" +
                               "Mensaje del SQL: " + sMensajeError,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                Obj_Cls_Empleado_DAL.bAccion = true;
            }
        }

        private void Frm_Modificar_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Se perderán los datos no salvados. ¿Desea salir?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
