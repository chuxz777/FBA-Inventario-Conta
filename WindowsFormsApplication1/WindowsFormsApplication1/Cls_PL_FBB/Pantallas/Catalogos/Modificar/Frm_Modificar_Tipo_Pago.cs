using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Tipo_Pago;
using Cls_DAL.Catalogos.Tipo_Pago;
using Cls_BLL.Catalogos.Estados;
using Cls_DAL.Catalogos.Estados;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Tipo_Pago : Form
    {

        #region Variables Globales

            cls_Tipo_Pago_BLL Obj_Tipo_Pago_BLL = new cls_Tipo_Pago_BLL();
            public cls_Tipo_Pago_DAL Obj_Tipo_Pago_DAL = new cls_Tipo_Pago_DAL();
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable dt_Estados = new DataTable();
            string sMensajeError;

        #endregion

        public Frm_Modificar_Tipo_Pago()
        {
            InitializeComponent();
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlsbtn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_Descripcion.Text == string.Empty)
            {
                MessageBox.Show("Espacios en blanco, por favor digite toda la informacion solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Obj_Tipo_Pago_DAL.sDescripcion = txt_Descripcion.Text.Trim();
                Obj_Tipo_Pago_DAL.cId_Estado = Convert.ToChar(cmbx_Estado.SelectedValue.ToString());

                if (Obj_Tipo_Pago_DAL.bAccion == true)
                {
                    Guardar();
                    Cargar_Datos_Tipada();
                }
                else
                {
                    Modificar();
                }
            }
        }

        private void Guardar()
        {
            Obj_Tipo_Pago_BLL.Insertar_Tipo_Pago_SP(ref Obj_Tipo_Pago_DAL, ref sMensajeError);

            if (Obj_Tipo_Pago_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El Tipo de pago fue guardado exitosamente.",
                                "Confirmacion", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                txt_Codigo_Tipo_Pago.Enabled = false;
                txt_Codigo_Tipo_Pago.ReadOnly = true;

                Obj_Tipo_Pago_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El Tipo de pago no fue guardado. Error en la ejecución." + sMensajeError,
                "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txt_Codigo_Tipo_Pago.Enabled = true;
                txt_Codigo_Tipo_Pago.ReadOnly = false;

                Obj_Tipo_Pago_DAL.bAccion = true;
            }
        }

        private void Modificar()
        {
            Obj_Tipo_Pago_BLL.Modificar_Tipo_Pago_SP(ref Obj_Tipo_Pago_DAL, ref sMensajeError);
            if (Obj_Tipo_Pago_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El tipo de pago fue actualizado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                txt_Codigo_Tipo_Pago.Enabled = false;// mantiene la llave primaria
                txt_Descripcion.ReadOnly = true;
                Obj_Tipo_Pago_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El tipo de pago no se pudo actualizar, hubo un error en la ejecucíón." + sMensajeError,
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                txt_Codigo_Tipo_Pago.Enabled = true;// mantiene la llave primaria
                txt_Descripcion.ReadOnly = false;
                Obj_Tipo_Pago_DAL.bAccion = true;
            }
        }

        private void Cargar_Datos_Tipada()
        {
            if (Obj_Tipo_Pago_DAL.bAccion == true)
            {
                txt_Codigo_Tipo_Pago.Text = string.Empty;
                txt_Descripcion.Text = string.Empty;
                cmbx_Estado.SelectedValue = 'A';
            }
            else
            {
                txt_Codigo_Tipo_Pago.Text = Obj_Tipo_Pago_DAL.iId_Tipo_Pago.ToString();
                txt_Descripcion.Text = Obj_Tipo_Pago_DAL.sDescripcion;
                cmbx_Estado.SelectedValue = Obj_Tipo_Pago_DAL.cId_Estado.ToString();
            }
        }

        public void Cargar_Combo_Estados()
        {
            #region Estados
            try
            {
                Obj_Estados_BLL.Listar_Estados_SP(ref dt_Estados, ref sMensajeError);

                if (dt_Estados != null)
                {
                    DataRow newRow = dt_Estados.NewRow();

                    cmbx_Estado.DataSource = dt_Estados;
                    cmbx_Estado.ValueMember = dt_Estados.Columns["Codigo del Estado"].ToString().Trim();
                    cmbx_Estado.DisplayMember = dt_Estados.Columns["Descripción del Estado"].ToString().Trim();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Cargar los datos de los datos, contacte con el Administrador del Sistema" + sMensajeError,
                                 "Error",
                                  MessageBoxButtons.OK, 
                                  MessageBoxIcon.Error);
            }
            #endregion
        }

        private void Frm_Modificar_Tipo_Pago_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Estados();
            Cargar_Datos_Tipada();
        }

        private void Frm_Modificar_Tipo_Pago_FormClosing(object sender, FormClosingEventArgs e)
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
