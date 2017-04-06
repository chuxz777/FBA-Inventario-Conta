using System;
using System.Data;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Productos;
using Cls_DAL.Catalogos.Log_in;
using Cls_DAL.Catalogos.Productos;
using Cls_PL.Pantallas.Catalogos.Modificar;

namespace Cls_PL
{
    public partial class Frm_Listar_Productos : Form
    {
        #region Variables Globales
            
            public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
            Frm_Modificar_Productos_para_los_tratamientos Obj_Pant_Mod_Productos = new Frm_Modificar_Productos_para_los_tratamientos();
            cls_Productos_BLL Obj_cls_Productos_BLL = new cls_Productos_BLL();
            cls_Productos_DAL Obj_cls_Productos_DAL = new cls_Productos_DAL();
            private string sMensajeError;
        
        #endregion

        public Frm_Listar_Productos()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
            Opciones();
        }

        private void tlsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            Obj_cls_Productos_DAL.bAccion = true; //Insert
            //Captura los valores del row para cargarlos en un objeto
            Obj_cls_Productos_DAL.iId_Suministro = 0;
            Obj_cls_Productos_DAL.sNombre_Producto = string.Empty;
            Obj_cls_Productos_DAL.dCosto = 0;
            Obj_cls_Productos_DAL.sId_Proveedor = string.Empty;
            Obj_cls_Productos_DAL.chrId_Estado = ' ';

            Obj_cls_Productos_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
            // Carga los valores del row en un objeto y los envia a la pantalla de edicion
            Obj_Pant_Mod_Productos.Obj_Productos_DAL = Obj_cls_Productos_DAL;
            Obj_Pant_Mod_Productos.ShowDialog();
        }

        private void tlsbtn_Eliminar_Click_1(object sender, EventArgs e)
        {
            Eliminar_Producto();
        }

        private void tlsbtn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Productos.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Producto para ser modificado.",
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

        private void dgv_Productos_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Productos.RowCount == 0)
            {
                MessageBox.Show("No ha seleccionado un Producto para ser modificado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                Cargar_Fila();
            }
        }

        // Metodos de cada boton
        private void Cargar()
        {
            string sMensajeError = string.Empty;
            DataTable dt = new DataTable();

            if (Obj_cls_Productos_BLL.Listar_Productos_SP(ref dt, ref sMensajeError))
            {
                dgv_Productos.DataSource = dt;
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

        private void Eliminar_Producto()
        {
            if (dgv_Productos.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Está seguro de que desea eliminar el registro", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Obj_cls_Productos_DAL.iId_Suministro = Convert.ToInt32(dgv_Productos.SelectedRows[0].Cells[0].Value.ToString());
                    Obj_cls_Productos_BLL.Eliminar_Productos_SP(ref Obj_cls_Productos_DAL, ref sMensajeError);

                    if (Obj_cls_Productos_DAL.bEstado_Ejec == true)
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

        private void Cargar_Fila()
        {
            Obj_cls_Productos_DAL.bAccion = false; //Update
            //Captura los valores del row para cargarlos en un objeto
            Obj_cls_Productos_DAL.iId_Suministro = Convert.ToInt32(dgv_Productos.SelectedRows[0].Cells[0].Value.ToString());
            Obj_cls_Productos_DAL.sNombre_Producto = dgv_Productos.SelectedRows[0].Cells[1].Value.ToString();
            Obj_cls_Productos_DAL.dCosto = Convert.ToDecimal(dgv_Productos.SelectedRows[0].Cells[2].Value.ToString());
            Obj_cls_Productos_DAL.sId_Proveedor = dgv_Productos.SelectedRows[0].Cells[3].Value.ToString();
            Obj_cls_Productos_DAL.chrId_Estado = Convert.ToChar(dgv_Productos.SelectedRows[0].Cells[5].Value.ToString());
            
            Obj_cls_Productos_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
            // Carga los valores del row en un objeto y los envia a la pantalla de edicion
            Obj_Pant_Mod_Productos.Obj_Productos_DAL = Obj_cls_Productos_DAL;
            Obj_Pant_Mod_Productos.ShowDialog();
        }

        // Filtrado
        private void tlstrp_txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            DataTable dt_f = new DataTable();

            if (Obj_cls_Productos_BLL.Filtrar_Productos_SP(ref dt_f, tlstrp_txt_Busqueda.Text.Trim(), ref sMensajeError))
            {
                dgv_Productos.DataSource = dt_f;
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
            switch (Obj_Login_DAL.iRol)
            {
                case 1:// administrador

                    tlsbtn_Editar.Enabled = true;
                    tlsbtn_Nuevo.Enabled = true;
                    tlsbtn_Eliminar.Enabled = true;
                    break;

                case 2:// Medio

                    tlsbtn_Editar.Enabled = true;
                    tlsbtn_Nuevo.Enabled = true;
                    tlsbtn_Eliminar.Enabled = false;
                    break;

                case 3: // solo lectura

                    tlsbtn_Editar.Enabled = false;
                    tlsbtn_Nuevo.Enabled = false;
                    tlsbtn_Eliminar.Enabled = false;
                    break;

                default:

                    tlsbtn_Editar.Enabled = false;
                    tlsbtn_Nuevo.Enabled = false;
                    tlsbtn_Eliminar.Enabled = false;
                    break;
            }
        }
    }
}