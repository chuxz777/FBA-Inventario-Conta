using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_DAL.Acciones_Genericas;
using Cls_DAL.Catalogos.Proveedores;
using Cls_BLL.Catalogos.Proveedores;
using Cls_BLL.Catalogos.Estados;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Proveedores : Form
    {

        #region Variables Globales

        public cls_Proveedores_DAL obj_Proveedores_DAL = new cls_Proveedores_DAL();
        //public cls_Clase_Generica_DAL obj_Genericos_DAL = new cls_Clase_Generica_DAL();
        cls_Proveedores_BLL obj_Proveedores_BLL = new cls_Proveedores_BLL();
        public cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        DataTable dtEstados = new DataTable();
        string sMensajeError;
        
        #endregion

        public Frm_Modificar_Proveedores()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Proveedores_Load(object sender, EventArgs e)
        {
            cargarDatosClaseTipada();    
        }

        private void tlsbtn_Guardar_Modificar_Proveedores_Click(object sender, EventArgs e)
        {
            if (txt__Modificar_Nombre_Proveedor.Text != string.Empty && txt_Direccion_Modificar_Proveedor.Text != string.Empty
                && txt_Telefono_Modificar_Proveedor.Text != string.Empty && cmb_Id_Estado.SelectedValue != null)
            {
                Cargar_Datos_Pantalla();

                if (obj_Proveedores_DAL.bAccion == true)
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

        public void Cargar_Combo_Estados()
        {
            #region Estados
            try
            {
                Obj_Estados_BLL.Listar_Estados_SP(ref dtEstados, ref sMensajeError);

                if (dtEstados != null)
                {
                    DataRow newRow = dtEstados.NewRow();

                    cmb_Id_Estado.ValueMember = dtEstados.Columns["Codigo del Estado"].ToString().Trim();
                    cmb_Id_Estado.DisplayMember = dtEstados.Columns["Descripción del Estado"].ToString().Trim();

                    cmb_Id_Estado.DataSource = dtEstados;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas a la hora de la carga de la información.\n" +
                                "Mensaje de error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            #endregion
        }

        private void guardar()
        {
                obj_Proveedores_BLL.Insertar_Provedores_SP(ref obj_Proveedores_DAL, ref sMensajeError);

                if (obj_Proveedores_DAL.bAccion == true)
                {
                    MessageBox.Show("El Proveedor fue insertado correctamente.",
                               "Confirmación",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                    obj_Proveedores_DAL.bAccion = false;
                }
                else
                {
                    MessageBox.Show("La region no se pudo insertar, hubo un error en la ejecucíón.",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                    obj_Proveedores_DAL.bAccion = true;
                }
        }

        private void modificar()
        {
                 obj_Proveedores_BLL.Modificar_Proveedores(ref obj_Proveedores_DAL, ref sMensajeError);

                if (obj_Proveedores_DAL.bEstado_Ejec == true)
                {
                    MessageBox.Show("El Producto fue insertado correctamente.",
                                    "Confirmación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    obj_Proveedores_DAL.bAccion = false;
                }
                else
                {
                    MessageBox.Show("El Producto no se pudo insertar, hubo un error en la ejecucíón.",
                                    "Error: " + sMensajeError,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    obj_Proveedores_DAL.bAccion = true;
                }
        }
       
        public void cargarDatosClaseTipada()
        {
            Cargar_Combo_Estados();
           
            if (obj_Proveedores_DAL.bAccion == true)
            {
                txt_ID_Proveedor.Text = string.Empty;
                txt__Modificar_Nombre_Proveedor.Text = string.Empty;
                txt_Direccion_Modificar_Proveedor.Text = string.Empty;
                txt_Telefono_Modificar_Proveedor.Text = string.Empty;
              
                cmb_Id_Estado.SelectedValue = "A";
            }
            else
            {
                txt_ID_Proveedor.Text = obj_Proveedores_DAL.iIdProveedor.ToString();
                txt__Modificar_Nombre_Proveedor.Text = obj_Proveedores_DAL.sNombre;
                txt_Direccion_Modificar_Proveedor.Text = obj_Proveedores_DAL.sDireccion;
                txt_Telefono_Modificar_Proveedor.Text = obj_Proveedores_DAL.sTelefono;

                cmb_Id_Estado.SelectedValue = obj_Proveedores_DAL.sID_Estado;
            }
        }

        // Carga lo que esta en pantalla en el objeto
        private void Cargar_Datos_Pantalla()
        {
            obj_Proveedores_DAL.sNombre = txt__Modificar_Nombre_Proveedor.Text.Trim();
            obj_Proveedores_DAL.sDireccion = txt_Direccion_Modificar_Proveedor.Text.Trim();
            obj_Proveedores_DAL.sTelefono = txt_Telefono_Modificar_Proveedor.Text.Trim();
            // Cargar los Combo boxes
            obj_Proveedores_DAL.sID_Estado = cmb_Id_Estado.SelectedValue.ToString(); 
        }

        private void cmb_Id_Estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Modificar_Proveedores_FormClosing(object sender, FormClosingEventArgs e)
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
