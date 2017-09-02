using System;
using System.Windows.Forms;
using Cls_BLL_FBB.Catalogos.Tipo_Articulo;
using Cls_DAL_FBB.Catalogos.TipoArticulo;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Tipo_Articulo : Form
    {
        #region Variables Globales
            public cls_Tipo_Articulo_BLL Obj_Cls_Tipo_Articulo_BLL = new cls_Tipo_Articulo_BLL();
            public cls_TipoArticulo_DAL Obj_Cls_Tipo_Articulo_DAL = new cls_TipoArticulo_DAL();
            private string sMensajeError;
        #endregion

        public Frm_Modificar_Tipo_Articulo()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Estados_Load(object sender, EventArgs e)
        {
            CargarDatosClasetipada();
        }  

        private void tlsbtn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Estado.Text != string.Empty && txt_Descripcion.Text == string.Empty )
            {
                MessageBox.Show("El artículo no fue guardado. Hay datos incompletos.",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                //Obj_Cls_Estado_DAL.iIdEstado = Convert.ToInt16(txt_Codigo_Estado.Text.Trim());
                Obj_Cls_Tipo_Articulo_DAL.sDescripcion = txt_Descripcion.Text.Trim();

                if (Obj_Cls_Tipo_Articulo_DAL.bAccion == true)
                {
                    Guardar();
                    CargarDatosClasetipada();
                }
                else
                {
                    Modificar();
                    CargarDatosClasetipada();
                }
            }
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Metodos de los botones
        private void CargarDatosClasetipada()
        {
            if (Obj_Cls_Tipo_Articulo_DAL.bAccion) //  == true
            {
                // No hay accion a realizar
                txt_Codigo_Estado.Enabled = false;
                txt_Codigo_Estado.Text = string.Empty;
                txt_Descripcion.Text = string.Empty;
            }
            else
            {
                // Cargar los datos del objeto en pantalla
                txt_Codigo_Estado.Enabled = false;
                //txt_Codigo_Estado.Text = Obj_Cls_Estado_DAL.iIdEstado.ToString().Trim();
                txt_Descripcion.Text = Obj_Cls_Tipo_Articulo_DAL.sDescripcion.Trim();
            }
        }

        private void Guardar()
        {
            Obj_Cls_Tipo_Articulo_BLL.Insertar_Tipo_Articulo_SP(ref Obj_Cls_Tipo_Articulo_DAL, ref sMensajeError);

            if (Obj_Cls_Tipo_Articulo_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El Artículo fue guardado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                Obj_Cls_Tipo_Articulo_DAL.bAccion = false;// update
            }
            else
            {
                MessageBox.Show("El Artículo nuevo no fue guardado, hubo un error en la ejecucíón.\n" +
                               "Mensaje del SQL: " + sMensajeError,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                Obj_Cls_Tipo_Articulo_DAL.bAccion = true; // insert
            }
        }

        private void Modificar()
        {
            Obj_Cls_Tipo_Articulo_BLL.Modificar_Tipo_Articulo_SP(ref Obj_Cls_Tipo_Articulo_DAL, ref sMensajeError);

            if (Obj_Cls_Tipo_Articulo_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El Artículo fue actualizado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                Obj_Cls_Tipo_Articulo_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El Artículo no se pudo actualizar, hubo un error en la ejecucíón.\n" +
                               "Mensaje error: " + sMensajeError,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                Obj_Cls_Tipo_Articulo_DAL.bAccion = true;
            }
        }

        private void Frm_Modificar_Estados_FormClosing(object sender, FormClosingEventArgs e)
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
