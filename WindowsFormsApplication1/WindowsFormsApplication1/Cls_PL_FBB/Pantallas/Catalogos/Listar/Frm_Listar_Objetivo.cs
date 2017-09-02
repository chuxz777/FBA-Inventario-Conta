using System;
using System.Data;
using System.Windows.Forms;
//using Cls_DAL.Catalogos.Log_in;
using Cls_DAL_FBB.Catalogos.Objetivo;
using Cls_BLL_FBB.Catalogos.Objetivo;
using Cls_PL.Pantallas.Catalogos.Modificar;


namespace Cls_PL
{
    public partial class Frm_Listar_Objetivo : Form
    {
        #region Variables Globales
        private Frm_Modificar_Objetivo Obj_Pant_Mod_Objetivo = new Frm_Modificar_Objetivo();
        cls_Objetivo_BLL Obj_Cls_Objetivo_BLL = new cls_Objetivo_BLL();
        cls_Objetivo_DAL Obj_Cls_Objetivo_DAL = new cls_Objetivo_DAL();
        //public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
        private string sMensajeError;
        #endregion

        public Frm_Listar_Objetivo()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opciones();
            Cargar();
        }

        private void tlsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            Obj_Cls_Objetivo_DAL.bAccion = true; // Es un insert
           // Obj_Cls_Objetivo_DAL.iIdEstado = ' ';
            Obj_Cls_Objetivo_DAL.sDescripcion = string.Empty;
            Obj_Cls_Objetivo_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
            Obj_Pant_Mod_Objetivo.Obj_Cls_Objetivo_DAL = Obj_Cls_Objetivo_DAL;
            Obj_Pant_Mod_Objetivo.ShowDialog();
        }

        private void tlsbtn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Estados.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Estado para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Cargar_Fila();
            }
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlsbtn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgv_Estados_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Estados.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Estado para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Cargar_Fila();
            }
        }

        private void tlsbtn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Estado();
        }

        // Metodos de cada boton
        private void Eliminar_Estado()
        {
            //if (dgv_Estados.SelectedRows.Count > 0)
            //{
            //    Obj_Cls_Estados_DAL.bEstado_Ejec = true;
            //    Obj_Cls_Estados_DAL.chrIdEstado = Convert.ToChar(dgv_Estados.SelectedRows[0].Cells[0].Value.ToString().Trim());
            //    Obj_Cls_Estados_DAL.sDescripcion = dgv_Estados.SelectedRows[0].Cells[1].Value.ToString().Trim();
            //    if (MessageBox.Show("Está seguro de que desea eliminar el registro", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //    {
            //        Obj_Cls_Estados_BLL.EliminarEstados_SP(ref Obj_Cls_Estados_DAL, ref sMensajeError);

            //        if (Obj_Cls_Estados_DAL.bEstado_Ejec == true)
            //        {
            //            MessageBox.Show("El registro a sido eliminado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            Cargar();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Problemas a la hora de la eliminar de la información.\n" +
            //                   "Mensaje error: " + sMensajeError,
            //                   "Error",
            //                   MessageBoxButtons.OK,
            //                   MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Debe de seleccionar un Row antes de modificar un dato ", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void Cargar()
        {
            DataTable dt = new DataTable();

            if (Obj_Cls_Objetivo_BLL.Listar_Objetivo_SP(ref dt, ref sMensajeError))
            {
                dgv_Estados.DataSource = dt;
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

        private void Cargar_Fila()
        {
            Obj_Cls_Objetivo_DAL.bAccion = false; //Update
            //Captura los valores del row para cargarlos en un objeto
            //Obj_Cls_Objetivo_DAL.iIdEstado = Convert.ToInt32(dgv_Estados.SelectedRows[0].Cells[0].Value.ToString());
            Obj_Cls_Objetivo_DAL.sDescripcion = dgv_Estados.SelectedRows[0].Cells[01].Value.ToString().Trim();
            Obj_Cls_Objetivo_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
            // Carga los valores del row en un objeto y los envia a la pantalla de edicion
            Obj_Pant_Mod_Objetivo.Obj_Cls_Objetivo_DAL = Obj_Cls_Objetivo_DAL;
            Obj_Pant_Mod_Objetivo.ShowDialog();
        }

        // Busqueda
        private void tlstrp_txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            DataTable dt_f = new DataTable();

            if (Obj_Cls_Objetivo_BLL.Filtrar_Objetivo_SP(ref dt_f, tlstrp_txt_Busqueda.Text.Trim(), ref sMensajeError))
            {
                dgv_Estados.DataSource = dt_f;
            }
            else
            {
                MessageBox.Show("Problemas a la hora de la carga de la información.\n" +
                                "Mensaje error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Opciones()
        {
            //switch (Obj_Login_DAL.iRol)
            //{
            //    case 1:// administrador

            //        tlsbtn_Editar.Enabled = true;
            //        tlsbtn_Nuevo.Enabled = true;
            //        tlsbtn_Eliminar.Enabled = true;
            //        break;

            //    case 2:// Medio

            //        tlsbtn_Editar.Enabled = true;
            //        tlsbtn_Nuevo.Enabled = true;
            //        tlsbtn_Eliminar.Enabled = false;
            //        break;

            //    case 3: // solo lectura


            //        tlsbtn_Editar.Enabled = false;
            //        tlsbtn_Nuevo.Enabled = false;
            //        tlsbtn_Eliminar.Enabled = false;
            //        break;

            //    default:

            //        tlsbtn_Editar.Enabled = false;
            //        tlsbtn_Nuevo.Enabled = false;
            //        tlsbtn_Eliminar.Enabled = false;
            //        break;

            //}
        }
    }
}