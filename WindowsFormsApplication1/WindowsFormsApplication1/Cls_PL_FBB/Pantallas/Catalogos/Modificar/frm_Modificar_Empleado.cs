using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_DAL.Catalogos.Empleados;
using Cls_BLL.Catalogos.Empleados;
using Cls_BLL.Catalogos.Estados;
using Cls_BLL.Catalogos.Tipo_Empleado;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class frm_Modificar_Empleado : Form
    {

        #region Variables Globales

        public cls_Empleados_DAL obj_Empleados_DAL = new cls_Empleados_DAL();        
        cls_Empleados_BLL obj_Empleados_BLL = new cls_Empleados_BLL();
        cls_Tipo_Empleado_BLL obj_Tipo_Empleado_BLL = new cls_Tipo_Empleado_BLL();
        cls_Estados_BLL obj_Estados_BLL = new cls_Estados_BLL();
        DataTable dt_Tipo_Empleado = new DataTable();
        DataTable dt_Estados = new DataTable();
        string sMensajeError;
        
        #endregion

        public frm_Modificar_Empleado()
        {
            InitializeComponent();
        }
      
        private void frm_Modificar_Empleado_Load(object sender, EventArgs e)
        {
            cargarDatosClaseTipada();
        }

        private void tlsbtn_Guardar_Modificar_Proveedores_Click(object sender, EventArgs e)
    {
            if (txt_Nombre.Text != string.Empty && txt_Cedula.Text != string.Empty && txt_apellido1.Text != string.Empty
                && txt_Apellido2.Text != string.Empty && txt_Direccion.Text != string.Empty && txt_Edad.Text != null
                && txt_Telefono.Text != string.Empty && cmb_Id_Estado.SelectedValue != null && cmb_Id_Tip_Empleado.SelectedValue != null)
            {
                Cargar_Datos_Pantalla();

                if (obj_Empleados_DAL.bAccion == true)
                {
                    guardar();
                }
                else
                {
                    modificar();
                }
            }
            else
            {
                MessageBox.Show("Por favor asegurese que todos los campos no esten vacios,\n revise que los comboBox esten seleccionados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guardar()
        {
            obj_Empleados_BLL.Insertar_Empleados_SP(ref obj_Empleados_DAL, ref sMensajeError);

            if (obj_Empleados_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El empleado fue modificado correctamente.",
                                "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                obj_Empleados_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El empleado no se pudo modificar, hubo un error en la ejecucíón.",
                                "Mensaje Error: " + sMensajeError,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                obj_Empleados_DAL.bAccion = false;
            }
        }

        private void modificar()
        {
            obj_Empleados_BLL.Modificar_Empleados(ref obj_Empleados_DAL, ref sMensajeError);

            if (obj_Empleados_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El Empleado fue modificado correctamente.",
                            "Confirmación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                obj_Empleados_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El empleado no se pudo modificar, hubo un error en la ejecucíón.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                obj_Empleados_DAL.bAccion = false;
            }
        }

        public void Cargar_Combos()
        {
            #region Estados
            try
            {
                obj_Estados_BLL.Listar_Estados_SP(ref dt_Estados, ref sMensajeError);

                if (dt_Estados != null)
                {
                    cmb_Id_Estado.ValueMember = dt_Estados.Columns["Codigo del Estado"].ToString().Trim();
                    cmb_Id_Estado.DisplayMember = dt_Estados.Columns["Descripción del Estado"].ToString().Trim();

                    cmb_Id_Estado.DataSource = dt_Estados;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Cargar los datos de los datos, contacte con el Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            #region Tipo Empleado

            try
            {
                obj_Tipo_Empleado_BLL.listar_Tipo_Empleado_SP(ref dt_Tipo_Empleado, ref sMensajeError);
                if (dt_Tipo_Empleado != null)
                {
                    cmb_Id_Tip_Empleado.ValueMember = dt_Tipo_Empleado.Columns["Id Tipo Empleado"].ToString().Trim();
                    cmb_Id_Tip_Empleado.DisplayMember = dt_Tipo_Empleado.Columns["Tipo"].ToString().Trim();
                    cmb_Id_Tip_Empleado.DataSource = dt_Tipo_Empleado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Cargar los datos de los datos, contacte con el Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }

        public void cargarDatosClaseTipada()
        {
            Cargar_Combos();

            if (obj_Empleados_DAL.bAccion == true)
            {
                txt_ID_Empleado.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Cedula.Text = string.Empty;
                txt_apellido1.Text = string.Empty;
                txt_Apellido2.Text = string.Empty;
                txt_Direccion.Text = string.Empty;
                txt_Edad.Text = string.Empty;
                txt_Telefono.Text = string.Empty;

                cmb_Id_Estado.SelectedValue = "A";
                cmb_Id_Tip_Empleado.SelectedValue = 1;
            }
            else
            {
                txt_ID_Empleado.Text = obj_Empleados_DAL.iId_Empleado.ToString();
                txt_Nombre.Text = obj_Empleados_DAL.sNombre.ToString();
                txt_Cedula.Text = obj_Empleados_DAL.sCedula.ToString();
                txt_apellido1.Text = obj_Empleados_DAL.sApellido1.ToString();
                txt_Apellido2.Text = obj_Empleados_DAL.sApellido2.ToString();
                txt_Direccion.Text = obj_Empleados_DAL.sDireccion.ToString();
                txt_Edad.Text = obj_Empleados_DAL.iEdad.ToString();
                txt_Telefono.Text = obj_Empleados_DAL.sTelefono.ToString();

                cmb_Id_Estado.SelectedValue = obj_Empleados_DAL.sId_Estado.ToString();
                cmb_Id_Tip_Empleado.SelectedValue = obj_Empleados_DAL.iId_Tipo_Empleado.ToString();
            }
        }

        // Carga lo que esta en pantalla en el objeto
        private void Cargar_Datos_Pantalla()
        {
            try
            {
                obj_Empleados_DAL.sNombre = txt_Nombre.Text.Trim();
                obj_Empleados_DAL.sCedula = txt_Cedula.Text.Trim();
                obj_Empleados_DAL.sApellido1 = txt_apellido1.Text.Trim();
                obj_Empleados_DAL.sApellido2 = txt_Apellido2.Text.Trim();
                obj_Empleados_DAL.sDireccion = txt_Direccion.Text.Trim();
                obj_Empleados_DAL.iEdad = Convert.ToInt32(txt_Edad.Text.ToString().Trim());
                obj_Empleados_DAL.sTelefono = txt_Telefono.Text.Trim();

                // Cargar los Combo boxes
                obj_Empleados_DAL.sId_Estado = cmb_Id_Estado.SelectedValue.ToString(); // convertirlo a char
                obj_Empleados_DAL.iId_Tipo_Empleado = Convert.ToInt32(cmb_Id_Tip_Empleado.SelectedValue.ToString());
            }
            catch 
            {
                MessageBox.Show("Hubo un error, por favor pongase en contacto con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Por favor ingresar un numero valido de la edad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("En este campo solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_apellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("En este campo solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_Apellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("En este campo solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cmb_Id_Tip_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_Id_Estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Modificar_Empleado_FormClosing(object sender, FormClosingEventArgs e)
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
