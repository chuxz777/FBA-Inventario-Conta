using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Tipo_Empleado;
using Cls_DAL.Catalogos.TipoEmpleado;
using Cls_DAL.Catalogos.Log_in;

namespace Cls_PL.Pantallas.Catalogos.Listar
{
    public partial class frm_Listar_TipoEmpleado : Form
    {
        #region variables globales

        public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
        Catalogos.Modificar.frm_Modificar_TipoEmpleado obj_PantMod_TipoEmpleado = new Modificar.frm_Modificar_TipoEmpleado();
        cls_Tipo_Empleado_BLL obj_TipoEmpleado_BLL = new cls_Tipo_Empleado_BLL();
        cls_TipoEmpleado_DAL obj_TipoEmpleado_DAL = new cls_TipoEmpleado_DAL();
        string sMensajeError;

        #endregion

        public frm_Listar_TipoEmpleado()
        {
            InitializeComponent();
        }

        private void frm_Listar_TipoEmpleado_Load(object sender, EventArgs e)
        {
            Cargar();
            Opciones();
        }

        private void Cargar()
        {
            DataTable dt = new DataTable();

            if (obj_TipoEmpleado_BLL.listar_Tipo_Empleado_SP(ref dt, ref sMensajeError))
            {
                dgv_tipoEmpleado.DataSource = dt;
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

        private void tlsbtn_Nuevo_Click(object sender, EventArgs e)
        {
                obj_TipoEmpleado_DAL.bAccion = true; 
                obj_TipoEmpleado_DAL.iId_Tipo_Empleado = 0;
                obj_TipoEmpleado_DAL.sTipo = string.Empty;
                obj_TipoEmpleado_DAL.sId_Estado = "A";
                obj_TipoEmpleado_DAL.bEstado_Ejec = false;//No se ha hecho la ejecución

                obj_PantMod_TipoEmpleado.obj_TipoEmpleado_DAL = obj_TipoEmpleado_DAL;
                obj_PantMod_TipoEmpleado.ShowDialog();
        }

        private void tlsbtn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void tlsbtn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_tipoEmpleado.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Tipo de Empleado para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                obj_TipoEmpleado_DAL.bAccion = false; //Insert

                obj_TipoEmpleado_DAL.bAccion = false; //Update
                //Captura los valores del row para cargarlos en un objeto
                obj_TipoEmpleado_DAL.iId_Tipo_Empleado = Convert.ToInt32(dgv_tipoEmpleado.SelectedRows[0].Cells[0].Value.ToString());
                obj_TipoEmpleado_DAL.sTipo = dgv_tipoEmpleado.SelectedRows[0].Cells[1].Value.ToString();
                obj_TipoEmpleado_DAL.sId_Estado = dgv_tipoEmpleado.SelectedRows[0].Cells[2].Value.ToString();

                obj_TipoEmpleado_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
                // Carga los valores del row en un objeto y los envia a la pantalla de edicion

                obj_PantMod_TipoEmpleado.obj_TipoEmpleado_DAL = obj_TipoEmpleado_DAL;
                obj_PantMod_TipoEmpleado.ShowDialog();
            }
        }

        private void tlsbtn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Tipo_Empleado();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_TipoEmpleado.Text.Trim() == string.Empty)
            {
                Cargar();
            }
            else
            {
                DataTable dt = new DataTable();

                dt = obj_TipoEmpleado_BLL.Filtrar_TipoEmpleado_SP(txt_TipoEmpleado.Text.ToString().Trim());
                dgv_tipoEmpleado.DataSource = null;
                dgv_tipoEmpleado.DataSource = dt;
            }
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Opciones()
        {

            switch (Obj_Login_DAL.iRol)
            {
                case 1:// administrador
                    
                    tlsbtn_Editar.Enabled = true;
                    tlsbtn_Eliminar.Enabled = true;
                    tlsbtn_Nuevo.Enabled = true;
                    break;

                case 2:// Medio

                    tlsbtn_Editar.Enabled = true;
                    tlsbtn_Nuevo.Enabled = true;
                    tlsbtn_Eliminar.Enabled = false;
                    break;

                case 3:// solo lectura
                    
                    tlsbtn_Editar.Enabled = false;
                    tlsbtn_Eliminar.Enabled = false;
                    tlsbtn_Nuevo.Enabled = false;
                    break;

                default:

                    tlsbtn_Editar.Enabled = false;
                    tlsbtn_Eliminar.Enabled = false;
                    tlsbtn_Nuevo.Enabled = false;
                    break;
            }
        }

        private void tlsbtn_Eliminar_Click_1(object sender, EventArgs e)
        {
            Eliminar_Tipo_Empleado();
        }

        private void Eliminar_Tipo_Empleado()
        {
            if (dgv_tipoEmpleado.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Está seguro de que desea eliminar el registro", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    obj_TipoEmpleado_DAL.iId_Tipo_Empleado = Convert.ToInt32(dgv_tipoEmpleado.SelectedRows[0].Cells[0].Value.ToString());
                    obj_TipoEmpleado_BLL.Eliminar_TipoEmpleado_SP(ref obj_TipoEmpleado_DAL, ref sMensajeError);

                    if (obj_TipoEmpleado_DAL.bEstado_Ejec == true)
                    {
                        MessageBox.Show("El registro a sido eliminado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("Problemas a la hora de la eliminar de la información.\n" +
                                "Mensaje de Error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un Row antes de modificar un dato ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_tipoEmpleado_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_tipoEmpleado.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Tipo de empleado para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                obj_TipoEmpleado_DAL.bAccion = false; //Insert

                obj_TipoEmpleado_DAL.bAccion = false; //Update
                //Captura los valores del row para cargarlos en un objeto
                obj_TipoEmpleado_DAL.iId_Tipo_Empleado = Convert.ToInt32(dgv_tipoEmpleado.SelectedRows[0].Cells[0].Value.ToString());
                obj_TipoEmpleado_DAL.sTipo = dgv_tipoEmpleado.SelectedRows[0].Cells[1].Value.ToString();
                obj_TipoEmpleado_DAL.sId_Estado = dgv_tipoEmpleado.SelectedRows[0].Cells[2].Value.ToString();

                obj_TipoEmpleado_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
                // Carga los valores del row en un objeto y los envia a la pantalla de edicion

                obj_PantMod_TipoEmpleado.obj_TipoEmpleado_DAL = obj_TipoEmpleado_DAL;
                obj_PantMod_TipoEmpleado.ShowDialog();
            }
        }
    }
}
