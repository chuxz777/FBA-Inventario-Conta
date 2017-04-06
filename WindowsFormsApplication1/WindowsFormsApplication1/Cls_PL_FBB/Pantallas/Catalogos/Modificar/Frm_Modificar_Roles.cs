using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_DAL.Catalogos.Estados;
using Cls_BLL.Catalogos.Estados;
using Cls_DAL.Catalogos.Roles;
using Cls_BLL.Catalogos.Roles;

namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    public partial class Frm_Modificar_Roles : Form
    {

        #region Variablesglobales

        public cls_Roles_DAL Obj_cls_Roles_DAL = new cls_Roles_DAL();
        cls_Roles_BLL Obj_Roles_BLL = new cls_Roles_BLL();
        cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
        DataTable dt_Estados = new DataTable();
        string sMensajeError;

        #endregion

        public Frm_Modificar_Roles()
        {
            InitializeComponent();
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Modificar_Roles_Load(object sender, EventArgs e)
        {
            Cargar_Combo_Estados();
            Cargar_Datos_Tipada();
        }

        private void Cargar_Combo_Estados()
        {
            try
            {
                Obj_Estados_BLL.Listar_Estados_SP(ref dt_Estados, ref sMensajeError);
                if (dt_Estados != null)
                {
                    DataRow newRow = dt_Estados.NewRow();

                    cbx_Estado_Rol.DataSource = dt_Estados;
                    cbx_Estado_Rol.ValueMember = dt_Estados.Columns["Codigo del Estado"].ToString().Trim();
                    cbx_Estado_Rol.DisplayMember = dt_Estados.Columns["Descripción del Estado"].ToString().Trim();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos, contacte con el Administrador del Sistema" + sMensajeError,
                                "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void Cargar_Datos_Tipada()
        {
            if (Obj_cls_Roles_DAL.bAccion == true)
            {
                txt_Codigo_Rol.Text = string.Empty;
                txt_Nombre_Rol.Text = string.Empty;
                txt_Descripcion_Rol.Text = string.Empty;
                cbx_Estado_Rol.SelectedValue = 'A';
            }
            else
            {
                txt_Codigo_Rol.Text = Obj_cls_Roles_DAL.iId_Rol.ToString();
                txt_Nombre_Rol.Text = Obj_cls_Roles_DAL.sNombre.ToString();
                txt_Descripcion_Rol.Text = Obj_cls_Roles_DAL.sDescripcion.ToString();
                cbx_Estado_Rol.Text = Obj_cls_Roles_DAL.cId_Estado.ToString();
            }
        }

        private void Guardar()
        {
            Obj_Roles_BLL.Insertar_Roles_SP(ref Obj_cls_Roles_DAL, ref sMensajeError);

            if (Obj_cls_Roles_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El Rol fue guardado exitosamente.",
                "Confirmacion", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                txt_Codigo_Rol.Enabled = false;
                txt_Codigo_Rol.ReadOnly = true;

                Obj_cls_Roles_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El Rol no fue guardado. Error en la ejecución." + sMensajeError,
                "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txt_Codigo_Rol.Enabled = true;
                txt_Codigo_Rol.ReadOnly = false;

                Obj_cls_Roles_DAL.bAccion = true;
            }
        }

        private void Modificar()
        {
            Obj_Roles_BLL.Modificar_Roles_SP(ref Obj_cls_Roles_DAL, ref sMensajeError);
            if (Obj_cls_Roles_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("El Rol fue actualizado correctamente.",
                              "Confirmación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                txt_Codigo_Rol.Enabled = false;// mantiene la llave primaria
                txt_Nombre_Rol.ReadOnly = true;
                txt_Descripcion_Rol.ReadOnly = true;
                Obj_cls_Roles_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("El Rol no se pudo actualizar, hubo un error en la ejecucíón." + sMensajeError,
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                txt_Codigo_Rol.Enabled = true;// mantiene la llave primaria
                txt_Nombre_Rol.ReadOnly = false;
                txt_Descripcion_Rol.ReadOnly = false;
                Obj_cls_Roles_DAL.bAccion = true;
            }
        }

        private void tlsbtn_Guardar_Click(object sender, EventArgs e)
        {
            if ((txt_Nombre_Rol.Text == string.Empty) || (txt_Descripcion_Rol.Text == string.Empty))
            {
                MessageBox.Show("El Rol no fue guardado. Hay datos incompletos.",
                "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
	        {
                Obj_cls_Roles_DAL.sNombre = txt_Nombre_Rol.Text.Trim();
                Obj_cls_Roles_DAL.sDescripcion = txt_Descripcion_Rol.Text.Trim();
                Obj_cls_Roles_DAL.cId_Estado = Convert.ToChar(cbx_Estado_Rol.SelectedValue.ToString());

                if (Obj_cls_Roles_DAL.bAccion == true)
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

        private void Frm_Modificar_Roles_FormClosing(object sender, FormClosingEventArgs e)
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
