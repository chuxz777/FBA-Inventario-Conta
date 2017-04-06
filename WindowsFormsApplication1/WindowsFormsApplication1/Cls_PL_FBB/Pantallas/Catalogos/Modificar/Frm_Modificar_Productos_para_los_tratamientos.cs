using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Estados;
using Cls_BLL.Catalogos.Productos;
using Cls_DAL.Catalogos.Productos;
using Cls_PL.Validaciones;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Productos_para_los_tratamientos : Form
    {
        #region Variables

        public cls_Validaciones_PL Obj_Validaciones_PL = new cls_Validaciones_PL();
        public cls_Productos_DAL Obj_Productos_DAL = new cls_Productos_DAL();
        public cls_Productos_BLL Obj_Productos_BLL = new cls_Productos_BLL();
        public cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        DataTable dtEstados = new DataTable();
        DataTable dtPoveedores = new DataTable();
        public string sMensajeError;

        #endregion

        public Frm_Modificar_Productos_para_los_tratamientos()
        {
            InitializeComponent();
        }

        private void tlsbtn_Guardar_Modificar_Productos_para_los_tratamientos_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == string.Empty || txt_Costo.Text == string.Empty)
            {
                MessageBox.Show("El produco no fue guardado. Hay datos incompletos.",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Cargar_Datos_Pantalla();
                if (Obj_Productos_DAL.bAccion == true)
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

        private void Frm_Modificar_Productos_para_los_tratamientos_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Proveedores();
            Cargar_Combo_Estados();
            Cargar_Datos_Clasetipada();
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Carga lo que esta en pantalla en el objeto
        private void Cargar_Datos_Pantalla()
        {
            Obj_Productos_DAL.sNombre_Producto = txt_Nombre.Text.Trim();
            Obj_Productos_DAL.dCosto = Convert.ToDecimal(txt_Costo.Text, new NumberFormatInfo() { NumberDecimalSeparator = "." });
            // Cargar los Combo boxes
            Obj_Productos_DAL.chrId_Estado = Convert.ToChar(cmbx_Estado.SelectedValue);
            Obj_Productos_DAL.sId_Proveedor = cmbx_Proveedor.SelectedValue.ToString();
        }

        // Carga lo que recive el objeto a la pantalla
        private void Cargar_Datos_Clasetipada()
        {
            if (Obj_Productos_DAL.bAccion == true)
            {
                txt_Codigo.Enabled = false;
                txt_Codigo.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Costo.Text = string.Empty;
                // Cargar los Combo boxes
                cmbx_Estado.SelectedIndex = 0;
                cmbx_Proveedor.SelectedIndex = 0;
            }
            else
            {
                txt_Codigo.Enabled = false;
                txt_Codigo.Text = Obj_Productos_DAL.iId_Suministro.ToString();
                txt_Nombre.Text = Obj_Productos_DAL.sNombre_Producto.Trim();
                txt_Codigo.Text = Obj_Productos_DAL.iId_Suministro.ToString();
                txt_Costo.Text = Obj_Productos_DAL.dCosto.ToString("##.00");
                // Cargar los Combo boxes
                cmbx_Estado.SelectedValue = Obj_Productos_DAL.chrId_Estado.ToString();
                cmbx_Proveedor.SelectedValue = Obj_Productos_DAL.sId_Proveedor;
            }
        }

        // Metodos de los Botones
        private void Guardar()
        {
            Obj_Productos_BLL.Insertar_Productos_SP(ref Obj_Productos_DAL, ref sMensajeError);

            if (Obj_Productos_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El Producto fue insertado correctamente.",
                                "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                Obj_Productos_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El Producto no se pudo insertar, hubo un error en la ejecucíón.",
                                "Error: " + sMensajeError,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                Obj_Productos_DAL.bAccion = true;
            }
        }

        private void Modificar()
        {
            Obj_Productos_BLL.Modificar_Productos_SP(ref Obj_Productos_DAL, ref sMensajeError);

            if (Obj_Productos_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El producto fue modificado correctamente.",
                                "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                
                txt_Codigo.ReadOnly = true;
                Obj_Productos_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El producto no se pudo modificar, hubo un error en la ejecucíón.",
                                "Mensaje Error: " + sMensajeError,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                Obj_Productos_DAL.bAccion = false;
            }
        }

        // Combos
        private void Cargar_Combo_Proveedores()
        {
            if (Obj_Productos_BLL.Listar_Combo_Proveedores(ref dtPoveedores, ref sMensajeError))
            {

                cmbx_Proveedor.ValueMember = dtPoveedores.Columns["Id Proveedor"].ToString();
                cmbx_Proveedor.DisplayMember = dtPoveedores.Columns["Nombre"].ToString();
                cmbx_Proveedor.DataSource = dtPoveedores;
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

        public void Cargar_Combo_Estados()
        {
            if (Obj_Estados_BLL.Listar_Estados_SP(ref dtEstados, ref sMensajeError))
            {
                cmbx_Estado.ValueMember = dtEstados.Columns["Codigo del Estado"].ToString();
                cmbx_Estado.DisplayMember = dtEstados.Columns["Descripción del Estado"].ToString();
                cmbx_Estado.DataSource = dtEstados;
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

        private void txt_Costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_Validaciones_PL.evaluar_Key_NumerosDecimales(e, sMensajeError);
        }

        private void Frm_Modificar_Productos_para_los_tratamientos_FormClosing(object sender, FormClosingEventArgs e)
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