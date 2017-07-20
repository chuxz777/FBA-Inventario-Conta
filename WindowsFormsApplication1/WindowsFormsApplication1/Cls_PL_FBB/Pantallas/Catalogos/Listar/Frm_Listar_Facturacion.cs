using System;
using System.Data;
using System.Windows.Forms;
//using Cls_DAL.Catalogos.Log_in;
using Cls_DAL_FBB.Catalogos.TipoArticulo;
using Cls_DAL_FBB.Catalogos.Inventario;
using Cls_DAL_FBB.Catalogos.Venta;
using Cls_DAL_FBB.Catalogos.DetalleFactura;
using Cls_BLL_FBB.Catalogos.Tipo_Articulo;
using Cls_PL.Pantallas.Catalogos.Modificar;
using Cls_BLL_FBB.Catalogos.Inventario;
using Cls_BLL_FBB.Catalogos.Venta;
using Cls_BLL_FBB.Catalogos.DetalleFactura;




namespace Cls_PL
{
    public partial class Frm_Listar_Facturacion : Form
    {
        #region Variables Globales
        private Frm_Modificar_Tipo_Articulo Obj_Pant_Mod_Tipo_Articulo = new Frm_Modificar_Tipo_Articulo();
        private string sMensajeError;
        cls_Tipo_Articulo_BLL Obj_Cls_Tipo_Articulo_BLL = new cls_Tipo_Articulo_BLL();
        cls_TipoArticulo_DAL Obj_Cls_Tipo_Articulo_DAL = new cls_TipoArticulo_DAL();
        cls_Tipo_Articulo_BLL Obj_Cls_Articulo = new cls_Tipo_Articulo_BLL();
        cls_Detalle_Factura_BLL Obj_Cls_DetalleFactura_BLL = new cls_Detalle_Factura_BLL();
        cls_Inventario_BLL Obj_Cls_Inventario_BLL = new cls_Inventario_BLL();
        cls_Inventario_DAL Obj_Cls_Inventario_DAL = new cls_Inventario_DAL();
        cls_DetalleFactura_DAL Obj_Cls_Detalle_Factura_DAL = new cls_DetalleFactura_DAL(); 
        cls_Venta_BLL Obj_Cls_Venta_BLL = new cls_Venta_BLL();
        cls_Venta_DAL Obj_Cls_Venta_DAL = new cls_Venta_DAL();
        //public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
        DataTable dt_Tipo_Articulo = new DataTable();
        DataTable dt_Factura_Temporal = new DataTable();
        DataTable dt_Producto = new DataTable();
        DataTable dt_Venta_Id = new DataTable();

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
            Formatear_Dgv_Productos();
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
            string Articulo;
            string MesAño;
            int VerificarCantidad;

            MesAño = cbx_Mes.Text + "-" + mTxt_Año.Text;
            Articulo = cbx_Articulo.Text;

            // Cargar objeto Inventario DAL con informacion de los controles del formulario
            Obj_Cls_Inventario_DAL.iCantidad = Convert.ToInt16(nud_Cantidad.Value);
            Obj_Cls_Inventario_DAL.iAño = Convert.ToInt16(mTxt_Año.Text.ToString());
            Obj_Cls_Inventario_DAL.iMes = Convert.ToInt16(cbx_Mes.SelectedItem.ToString());
            Obj_Cls_Inventario_DAL.iCod_tipo_articulo = Convert.ToInt16(cbx_Articulo.SelectedValue.ToString());

            // Revisar disponibilidad en BD
            Obj_Cls_Inventario_BLL.Productos_Id_Venta_SP(ref dt_Producto, ref Obj_Cls_Inventario_DAL, ref sMensajeError);

            VerificarCantidad = dt_Producto.Rows.Count;

            bool Procesar;
            Procesar = false;


            if (VerificarCantidad > 0 && VerificarCantidad == Obj_Cls_Inventario_DAL.iCantidad)
            { Procesar = true;
                MessageBox.Show("Si hay suficientes productos en el inventario", "Productos Disponibles",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            if (Procesar == true)
            {
                for (int i = 0; i < Obj_Cls_Inventario_DAL.iCantidad; i++)
                {
                    DataRow row;
                    row = dt_Factura_Temporal.NewRow();
                    Obj_Cls_Inventario_DAL.iIid_articulo = Convert.ToInt16(dt_Producto.Rows[i]["id_articulo"].ToString());
                    row["ID en Inventario"] = Obj_Cls_Inventario_DAL.iIid_articulo; // Carga de BD
                    row["Articulo"] = Articulo;
                    row["Precio"] = Convert.ToInt16(dt_Producto.Rows[i]["precio_sugerido"].ToString()); // Carga de BD
                    row["Fecha"] = MesAño;
                    dt_Factura_Temporal.Rows.Add(row);
                }
                dgv_Factura.DataSource = dt_Factura_Temporal;
                Calcular_Total();
            }
            // No hay la cantidad de productos especificada con los parametros dados
            else
            {
                MessageBox.Show("No existen ninguno o suficientes productos en el inventario con las etiquetas especificadas " + MesAño,
                 "Producto(s) No Disponibles, todo producto debe ser registrado antes de ser vendido",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void Formatear_Dgv_Productos()
        {
            // Si esta disponible anadir a la factura
            // Declare DataColumn and DataRow variables.
            DataColumn column;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID en Inventario";
            dt_Factura_Temporal.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Articulo";
            dt_Factura_Temporal.Columns.Add(column);

            //// Create second column.
            //column = new DataColumn();
            //column.DataType = Type.GetType("System.Int32");
            //column.ColumnName = "Cantidad";
            //dt_Factura_Temporal.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Precio";
            dt_Factura_Temporal.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Fecha";
            dt_Factura_Temporal.Columns.Add(column);

        }


        private void Calcular_Total()
        {
            int sum2 = Convert.ToInt32(dt_Factura_Temporal.Compute("SUM(Precio)", string.Empty));
            txt_Total.Text = sum2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calcular_Total();
        }

        private void dgv_Factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_factura;

            Obj_Cls_Venta_DAL.iTotal = Convert.ToInt16(txt_Total.Text.ToString());

            // Crea Factura en Blanco - Estado : Pendiente
            Obj_Cls_Venta_BLL.Insertar_Venta_En_Blanco_SP(ref  dt_Venta_Id, ref  Obj_Cls_Venta_DAL, ref  sMensajeError);
            Obj_Cls_Venta_DAL.iId_Factura = Convert.ToInt16(dt_Venta_Id.Rows[0][0]);

            // Actualiza la factura en blanco - Estado : Pagado

            for (int i = 0; i < dt_Factura_Temporal.Rows.Count; i++)
            {
                // Rows[i]["precio_sugerido"].ToString()                
                Obj_Cls_Detalle_Factura_DAL.iCodArticulo = Convert.ToInt16(dt_Producto.Rows[i]["id_articulo"].ToString());
                Obj_Cls_Detalle_Factura_DAL.iId_Factura = Obj_Cls_Venta_DAL.iId_Factura;
                // Insertar en tabla detalle de factura los datos id factura - id producto
                Obj_Cls_DetalleFactura_BLL.Actualizar_Factura_SP(ref Obj_Cls_Detalle_Factura_DAL, ref sMensajeError);
            }

            MessageBox.Show("Factura creada exitosamente, consecutivo #: " + Obj_Cls_Venta_DAL.iId_Factura,
                 "Producto(s) No Disponibles, todo producto debe ser registrado antes de ser vendido",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

            // Marcar la factura como pagada y los articulos cambiar de estado a "Vendido"

            for (int i = 0; i < dt_Factura_Temporal.Rows.Count; i++)
            {
                Obj_Cls_Inventario_DAL.iIid_articulo = Convert.ToInt16(dt_Producto.Rows[i]["id_articulo"].ToString());
                // Insertar en tabla detalle de factura los datos id factura - id producto
                Obj_Cls_Inventario_BLL.Marcar_Vendido_Inventario_SP(ref Obj_Cls_Inventario_DAL, ref sMensajeError);
            }

            MessageBox.Show("Articulos  exitosamente cambiados a estado \"Vendido\" " + Obj_Cls_Venta_DAL.iId_Factura,
             "Producto(s) No Disponibles, todo producto debe ser registrado antes de ser vendido",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);

            // Limpiar el Datagrid

            dgv_Factura.DataSource = null;
        }
    }
}