using System;
using System.Data;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Estados;
using Cls_BLL.Catalogos.Tipo_Usuario;
using Cls_DAL.Catalogos.Estados;
using Cls_DAL.Catalogos.Tipo_Usuario;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Tipo_Usuario : Form
    {
        #region Variables Globales
        
            public cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            public cls_Tipo_Usuario_BLL Obj_Cls_Tipo_Empleado_BLL = new cls_Tipo_Usuario_BLL();
            public cls_Tipo_Usuario_DAL Obj_Cls_Tipo_Empleado_DAL = new cls_Tipo_Usuario_DAL();
            DataTable dtEstados = new DataTable();
            private string sMensajeError;
       
        #endregion
        
        public Frm_Modificar_Tipo_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Estados_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Estados();
            Cargar_Datos_Clase_Tipada();
        }

        private void tlsbtn_Guardar_Click(object sender, EventArgs e)
        {
            Cargar_Datos_Pantalla();

            if (Obj_Cls_Tipo_Empleado_DAL.bAccion == true)
            {
                Guardar();
                Cargar_Datos_Clase_Tipada();
            }
            else
            {
                Modificar();
            }
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Carga lo que recive el objeto a la pantalla
        private void Cargar_Datos_Clase_Tipada()
        {
            if (Obj_Cls_Tipo_Empleado_DAL.bAccion) //  == true
            {
                // No hay accion a realizar
                txt_Codigo_Usuario.Enabled = false;
                txt_Codigo_Usuario.Text = string.Empty;
                txt_Descripcion.Text = string.Empty;
                cmbx_Estado.SelectedIndex = 0;
            }
            else
            {
                // Cargar los datos del objeto en pantnalla
                txt_Codigo_Usuario.Enabled = false;
                txt_Codigo_Usuario.Text = Obj_Cls_Tipo_Empleado_DAL.iId_Tipo_Usuario.ToString();
                txt_Descripcion.Text = Obj_Cls_Tipo_Empleado_DAL.sDescripcion.Trim();
                cmbx_Estado.SelectedValue = Obj_Cls_Tipo_Empleado_DAL.chrId_Estado;
            }
        }

        // Carga lo que esta en pantalla en el objeto
        private void Cargar_Datos_Pantalla()
        {
            Obj_Cls_Tipo_Empleado_DAL.sDescripcion = txt_Descripcion.Text.Trim();
            Obj_Cls_Tipo_Empleado_DAL.chrId_Estado = Convert.ToChar(cmbx_Estado.SelectedValue.ToString());
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
                                "Mensaje de error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Metodos de los botones
        private void Guardar()
        {
            if (txt_Descripcion.Text == string.Empty)
            {
                MessageBox.Show("El tipo de usuario no fue guardado. Hay datos incompletos.",
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                Obj_Cls_Tipo_Empleado_BLL.Insertar_Tipo_Usuario_SP(ref Obj_Cls_Tipo_Empleado_DAL, ref sMensajeError);

                if (Obj_Cls_Tipo_Empleado_DAL.bEstado_Ejec == true)
                {
                    MessageBox.Show("El tipo de usuario fue guardado correctamente.",
                                  "Confirmación",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    Obj_Cls_Tipo_Empleado_DAL.bAccion = false;// update
                }
                else
                {
                    MessageBox.Show("El nuevo tipo de usuario no fue guardado, hubo un error en la ejecucíón.\n" +
                                   "Mensaje de error: " + sMensajeError,
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);

                    Obj_Cls_Tipo_Empleado_DAL.bAccion = true; // insert
                }
            }
        }

        private void Modificar()
        {
            Obj_Cls_Tipo_Empleado_BLL.Modificar_Tipo_Usuario_SP(ref Obj_Cls_Tipo_Empleado_DAL, ref sMensajeError);

            if (Obj_Cls_Tipo_Empleado_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El tipo de usuario fue actualizado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                txt_Codigo_Usuario.Enabled = false;// mantiene la llave primaria
                txt_Codigo_Usuario.ReadOnly = true;

                Obj_Cls_Tipo_Empleado_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El tipo de usuario no se pudo actualizar, hubo un error en la ejecucíón.\n" +
                               "Mensaje de error: " + sMensajeError,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                Obj_Cls_Tipo_Empleado_DAL.bAccion = true;
            }
        }

        private void Frm_Modificar_Tipo_Usuario_FormClosing(object sender, FormClosingEventArgs e)
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
