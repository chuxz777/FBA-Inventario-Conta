using System;
using System.Data;
using System.Windows.Forms;
//using Cls_DAL.Catalogos.Log_in;
using Cls_DAL_FBB.Catalogos.TipoArticulo;
using Cls_BLL_FBB.Catalogos.Tipo_Articulo;
using Cls_PL.Pantallas.Catalogos.Modificar;



namespace Cls_PL
{
    public partial class Frm_Listar_Facturacion : Form
    {
        #region Variables Globales
        private Frm_Modificar_Tipo_Articulo Obj_Pant_Mod_Tipo_Articulo = new Frm_Modificar_Tipo_Articulo();
        cls_Tipo_Articulo_BLL Obj_Cls_Tipo_Articulo_BLL = new cls_Tipo_Articulo_BLL();
        cls_TipoArticulo_DAL Obj_Cls_Tipo_Articulo_DAL = new cls_TipoArticulo_DAL();
        //public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
        private string sMensajeError;

        DataTable dt_Tipo_Articulo = new DataTable();
        DataTable dt_Factura_Temporal = new DataTable();

        #endregion

        public Frm_Listar_Facturacion()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opciones();
            Cargar();
            Cargar_Combo_Tipo_Articulo();
        }

        private void tlsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            Obj_Cls_Tipo_Articulo_DAL.bAccion = true; // Es un insert
           // Obj_Cls_Tipo_Articulo_DAL.iIdEstado = ' ';
            Obj_Cls_Tipo_Articulo_DAL.sDescripcion = string.Empty;
            Obj_Cls_Tipo_Articulo_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
            Obj_Pant_Mod_Tipo_Articulo.Obj_Cls_Tipo_Articulo_DAL = Obj_Cls_Tipo_Articulo_DAL;
            Obj_Pant_Mod_Tipo_Articulo.ShowDialog();
        }

        private void tlsbtn_Editar_Click(object sender, EventArgs e)
        {
            //if (dgv_Estados.RowCount == 0)
            //{
            //    MessageBox.Show("No ha seleccionado un Estado para ser modificado.",
            //                    "Información",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Information);
            //}
            //else
            //{
            //    Cargar_Fila();
            //}
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
            //if (dgv_Estados.RowCount == 0)
            //{
            //    MessageBox.Show("No ha seleccionado un Estado para ser modificado.",
            //                    "Información",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Information);
            //}
            //else
            //{
            //    Cargar_Fila();
            //}
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

            //if (Obj_Cls_Tipo_Articulo_BLL.Listar_Tipo_Articulo_SP(ref dt, ref sMensajeError))
            //{
            //    dgv_Estados.DataSource = dt;
            //}
            //else
            //{
            //    MessageBox.Show("Problemas a la hora de la carga de la información.\n" +
            //                    "Mensaje del SQL: " + sMensajeError,
            //                    "Error",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //}
        }

        private void Cargar_Fila()
        {
            Obj_Cls_Tipo_Articulo_DAL.bAccion = false; //Update
            //Captura los valores del row para cargarlos en un objeto
            //Obj_Cls_Tipo_Articulo_DAL.iIdEstado = Convert.ToInt32(dgv_Estados.SelectedRows[0].Cells[0].Value.ToString());
           // Obj_Cls_Tipo_Articulo_DAL.sDescripcion = dgv_Estados.SelectedRows[0].Cells[01].Value.ToString().Trim();
            Obj_Cls_Tipo_Articulo_DAL.bEstado_Ejec = false;//no se ha hecho la ejecucion
            // Carga los valores del row en un objeto y los envia a la pantalla de edicion
            Obj_Pant_Mod_Tipo_Articulo.Obj_Cls_Tipo_Articulo_DAL = Obj_Cls_Tipo_Articulo_DAL;
            Obj_Pant_Mod_Tipo_Articulo.ShowDialog();
        }

        // Busqueda
        private void tlstrp_txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            DataTable dt_f = new DataTable();

            //if (Obj_Cls_Tipo_Articulo_BLL.Filtrar_Tipo_Articulo_SP(ref dt_f, tlstrp_txt_Busqueda.Text.Trim(), ref sMensajeError))
            //{
            //    dgv_Estados.DataSource = dt_f;
            //}
            //else
            //{
            //    MessageBox.Show("Problemas a la hora de la carga de la información.\n" +
            //                    "Mensaje error: " + sMensajeError,
            //                    "Error",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //}
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


        private void Cargar_Combo_Tipo_Articulo()
        {
            try
            {
                Obj_Cls_Tipo_Articulo_BLL.Listar_Tipo_Articulo_SP(ref dt_Tipo_Articulo, ref sMensajeError);
                if (dt_Tipo_Articulo != null)
                {
                    cbx_Articulo.DataSource = dt_Tipo_Articulo;
                    cbx_Articulo.ValueMember = dt_Tipo_Articulo.Columns["Codigo del tipo de articulo"].ToString().Trim();
                    cbx_Articulo.DisplayMember = dt_Tipo_Articulo.Columns["Descripcion del tipo de articulo"].ToString().Trim();
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



        private void dgv_Estados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            DataView view;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            dt_Factura_Temporal.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "item";
            dt_Factura_Temporal.Columns.Add(column);

            // Create new DataRow objects and add to DataTable.    
            for (int i = 0; i < 10; i++)
            {
                row = dt_Factura_Temporal.NewRow();
                row["id"] = i;
                row["item"] = "item " + i.ToString();
                dt_Factura_Temporal.Rows.Add(row);
            }

            //// Create a DataView using the DataTable.
            //view = new DataView(tdt_Factura_Temporal);

            dgv_Factura.DataSource = dt_Factura_Temporal;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum2 = Convert.ToInt32(dt_Factura_Temporal.Compute("SUM(id)", string.Empty));
            txt_Total.Text = sum2.ToString();
        }
    }
}