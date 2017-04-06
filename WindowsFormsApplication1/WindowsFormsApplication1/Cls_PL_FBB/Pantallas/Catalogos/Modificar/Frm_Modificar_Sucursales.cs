using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_DAL.Catalogos.Sucursal;
using Cls_BLL.Catalogos.Sucursal;
using Cls_BLL.Catalogos.Estados;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Sucursales : Form
    {
        #region Variables Globales
        
            public cls_Sucursal_DAL Obj_cls_Sucursal_DAL = new cls_Sucursal_DAL();
            cls_Sucursal_BLL Obj_cls_Sucursal_BLL = new cls_Sucursal_BLL();
            cls_Estados_BLL Obj_cls_Estados_BLL = new cls_Estados_BLL();
        
        #endregion

        public Frm_Modificar_Sucursales()
        {
            InitializeComponent();
        }

        private void CargarDatosClaseTipada()
        {
            txt_Codigo_Modificar_Sucursal.Text = Obj_cls_Sucursal_DAL.iIdSucursal.ToString();
            cmbx_Estado_Modificar_Sucursal.SelectedValue = Obj_cls_Sucursal_DAL.cIdEstado;
            txt_NombreSucursal_Modificar_Sucursal.Text = Obj_cls_Sucursal_DAL.sNombre;
            txt_Direccion_Modificar_Sucursal.Text = Obj_cls_Sucursal_DAL.sDireccion;
            txt_Telefono_Modificar_Sucursal.Text = Obj_cls_Sucursal_DAL.sTelefono;
        }

        private void CargarEstados()
        {
            try
            {
                DataTable dt = new DataTable();
                string sMensajeError = string.Empty;

                // Trae los estados
                if (Obj_cls_Estados_BLL.Listar_Estados_SP(ref dt, ref sMensajeError) == false)
                {
                    dt = null;

                    MessageBox.Show("Los estados no se pudieron cargar, hubo un error en la ejecución." +
                                "\nMensaje de error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }

                cmbx_Estado_Modificar_Sucursal.DataSource = dt;
                cmbx_Estado_Modificar_Sucursal.ValueMember = dt.Columns["Codigo del Estado"].ToString();
                cmbx_Estado_Modificar_Sucursal.DisplayMember = dt.Columns["Descripción del Estado"].ToString();
            }
            catch
            {
                // Si hay un error se limpia
                cmbx_Estado_Modificar_Sucursal.DataSource = null;
            }
        }

        private void Frm_Modificar_Sucursales_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarDatosClaseTipada();
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos no guardados se perderan al salir de la pantalla." +
                                "\n\nRealmente desea salir de esta Pantalla?",
                                "ALERTA",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tlsbtn_Guardar_Modificar_Sucursal_Click(object sender, EventArgs e)
        {
            if ((txt_NombreSucursal_Modificar_Sucursal.Text == string.Empty) || txt_Direccion_Modificar_Sucursal.Text == string.Empty)
            {
                MessageBox.Show("La sucursal no fue guardada. Hay datos incompletos.",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Obj_cls_Sucursal_DAL.iIdSucursal = Convert.ToInt32(txt_Codigo_Modificar_Sucursal.Text);
                Obj_cls_Sucursal_DAL.sNombre = txt_NombreSucursal_Modificar_Sucursal.Text;
                Obj_cls_Sucursal_DAL.sDireccion = txt_Direccion_Modificar_Sucursal.Text;
                Obj_cls_Sucursal_DAL.sTelefono = txt_Telefono_Modificar_Sucursal.Text;
                Obj_cls_Sucursal_DAL.cIdEstado = Char.Parse(cmbx_Estado_Modificar_Sucursal.SelectedValue.ToString());

                if (Obj_cls_Sucursal_DAL.bAccion == true)
                {
                    Insertar();
                }
                else
                {
                    Modificar();
                }
            }
        }

        private void Insertar()
        {
            string sMensajeError = string.Empty;

            Obj_cls_Sucursal_BLL.Insertar_Sucursal(ref Obj_cls_Sucursal_DAL, ref sMensajeError);

            if (Obj_cls_Sucursal_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("La sucursal fue insertada correctamente.",
                                "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Si se inserto la sucursal entonces se coloca el ID que se inserto
                txt_Codigo_Modificar_Sucursal.Text = Obj_cls_Sucursal_DAL.iIdSucursal.ToString();

                Obj_cls_Sucursal_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("La sucursal no se pudo insertar, hubo un error en la ejecución." +
                                "\nMensaje de error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                Obj_cls_Sucursal_DAL.bAccion = true;
            }
        }

        private void Modificar()
        {
            string sMensajeError = string.Empty;

            Obj_cls_Sucursal_BLL.Modificar_Sucursal(ref Obj_cls_Sucursal_DAL, ref sMensajeError);

            if (Obj_cls_Sucursal_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("La sucursal fue modificada correctamente.",
                                "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                Obj_cls_Sucursal_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("La sucursal no se pudo modificar, hubo un error en la ejecución." +
                                "\nMensaje de error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                Obj_cls_Sucursal_DAL.bAccion = false;
            }
        }

        private void Frm_Modificar_Sucursales_FormClosing(object sender, FormClosingEventArgs e)
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
