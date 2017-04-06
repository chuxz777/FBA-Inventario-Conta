using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Estados;
using Cls_DAL.Catalogos.Estados;
using Cls_BLL.Catalogos.TIpo_Tratamiento;
using Cls_DAL.Catalogos.Tipo_Tratamiento;
using Cls_DAL.Acciones_Genericas;
using Cls_PL.Validaciones;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Tipo_Tratamiento : Form
    {
        #region variables globales

        public cls_Validaciones_PL Obj_Validaciones = new cls_Validaciones_PL();
        public cls_Clase_Generica_DAL Obj_Generica_DAL = new cls_Clase_Generica_DAL();
        public Cls_Tipo_Tratamiento_DAL Obj_Cls_Mod_Tipo_Tratamiento_DAL = new Cls_Tipo_Tratamiento_DAL();
        public Cls_Tipo_Tratamiento_BLL Obj_Cls_Mod_Tipo_Tratamiento_BLL = new Cls_Tipo_Tratamiento_BLL();
        public cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        DataTable dt_Estados = new DataTable();
        public string sMensajeError;
        
        #endregion

        public Frm_Modificar_Tipo_Tratamiento()
        {
            InitializeComponent();
        }

        private void tlsbtn_Guardar_Modificar_TipoTratamiento_Click(object sender, EventArgs e)
        {
            if (txt_Descripcion_Modificar_TipoTratamiento.Text == "" || txt_Costo_Modificar_TipoTratamiento.Text == "" || Cmbx_Estado_Modificar_TipoTratamiento.Text == "")
            {
                MessageBox.Show("Debe Completar los espacios en blanco","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Obj_Cls_Mod_Tipo_Tratamiento_DAL.Descripcion = txt_Descripcion_Modificar_TipoTratamiento.Text.Trim();
                Obj_Cls_Mod_Tipo_Tratamiento_DAL.Costo = Convert.ToDecimal(txt_Costo_Modificar_TipoTratamiento.Text.Trim());
                Obj_Cls_Mod_Tipo_Tratamiento_DAL.Id_Estado = Convert.ToChar(Cmbx_Estado_Modificar_TipoTratamiento.SelectedValue.ToString().Trim());

                if (Obj_Cls_Mod_Tipo_Tratamiento_DAL.bAccion == true)
                {
                    Guardar();
                }
                else
                {
                    Modificar();
                }
            }
        }

        private void Frm_Modificar_Tipo_Tratamiento_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Estados();
            CargarDatosClasetipada();
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosClasetipada()
        {
            if (Obj_Cls_Mod_Tipo_Tratamiento_DAL.bAccion == true)
            {
                // No hay accion a realizar
                txt_Codigo_Modificar_TipoTratamiento.Enabled = false;
                txt_Codigo_Modificar_TipoTratamiento.Text = string.Empty;
                txt_Descripcion_Modificar_TipoTratamiento.Enabled = true;
                txt_Descripcion_Modificar_TipoTratamiento.Text = string.Empty;
                txt_Costo_Modificar_TipoTratamiento.Enabled = true;
                txt_Costo_Modificar_TipoTratamiento.Text = string.Empty;
                Cmbx_Estado_Modificar_TipoTratamiento.SelectedValue = "A";
            }
            else
            {
                // Cargar los datos del objeto en pantalla
                txt_Codigo_Modificar_TipoTratamiento.Enabled = false;
                txt_Codigo_Modificar_TipoTratamiento.Text = Obj_Cls_Mod_Tipo_Tratamiento_DAL.iId_Tipo_Tratamiento.ToString().Trim();
                txt_Descripcion_Modificar_TipoTratamiento.Text = Obj_Cls_Mod_Tipo_Tratamiento_DAL.Descripcion.Trim();
                txt_Costo_Modificar_TipoTratamiento.Text = Obj_Cls_Mod_Tipo_Tratamiento_DAL.Costo.ToString().Trim();
                Cmbx_Estado_Modificar_TipoTratamiento.SelectedValue = Obj_Cls_Mod_Tipo_Tratamiento_DAL.Id_Estado.ToString();
            }
        }

        private void Guardar()
        {
            Obj_Cls_Mod_Tipo_Tratamiento_BLL.Insertar_Tipo_Tratamiento(ref Obj_Cls_Mod_Tipo_Tratamiento_DAL, ref sMensajeError);

            if (Obj_Cls_Mod_Tipo_Tratamiento_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El estado fue guardado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                Obj_Cls_Mod_Tipo_Tratamiento_DAL.bAccion = false;// update
            }
            else
            {
                MessageBox.Show("El estado nuevo no fue guardado, hubo un error en la ejecucíón.\n" +
                               "Mensaje del SQL: " + sMensajeError,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                txt_Codigo_Modificar_TipoTratamiento.Enabled = true;
                txt_Codigo_Modificar_TipoTratamiento.ReadOnly = false;
                Obj_Cls_Mod_Tipo_Tratamiento_DAL.bAccion = true; // insert
            }
        }

        private void Modificar()
        {
            Obj_Cls_Mod_Tipo_Tratamiento_BLL.Modificar_Tipo_Tratamiento(ref Obj_Cls_Mod_Tipo_Tratamiento_DAL, ref sMensajeError);

            if (Obj_Cls_Mod_Tipo_Tratamiento_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El estado fue actualizado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                Obj_Cls_Mod_Tipo_Tratamiento_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El estado no se pudo actualizar, hubo un error en la ejecucíón.\n" +
                               "Mensaje del SQL: " + sMensajeError,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                Obj_Cls_Mod_Tipo_Tratamiento_DAL.bAccion = true;
            }
        }

        public void Cargar_Combo_Estados()
        {
            if (Obj_Estados_BLL.Listar_Estados_SP(ref dt_Estados, ref sMensajeError))
            {

                Cmbx_Estado_Modificar_TipoTratamiento.ValueMember = dt_Estados.Columns["Codigo del Estado"].ToString();
                Cmbx_Estado_Modificar_TipoTratamiento.DisplayMember = dt_Estados.Columns["Descripción del Estado"].ToString();
                Cmbx_Estado_Modificar_TipoTratamiento.DataSource = dt_Estados;
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

        private void txt_Costo_Modificar_TipoTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_Validaciones.evaluar_Key_NumerosEnteros(e, ref sMensajeError);
        }

        private void txt_Descripcion_Modificar_TipoTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_Validaciones.No_Simbolos(e, ref sMensajeError);
        }

        private void Frm_Modificar_Tipo_Tratamiento_FormClosing(object sender, FormClosingEventArgs e)
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
    
