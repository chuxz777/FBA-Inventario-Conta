using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Clientes;
using Cls_BLL.Catalogos.Factura;
using Cls_DAL.Catalogos.Detalle_Factura;
using Cls_BLL.Catalogos.Detalle_Factura;
using Cls_DAL.Catalogos.Factura;
using Cls_PL.Validaciones;

namespace Cls_PL.Pantallas.Catalogos.Listar
{
    public partial class frm_Factura_Nueva : Form
    {
        public frm_Factura_Nueva()
        {
            InitializeComponent();
        }
        #region variables Globales

        cls_Clientes_BLL obj_CargarClientes = new cls_Clientes_BLL();
        cls_Factura_BLL obj_Factura_BLL = new cls_Factura_BLL();
        cls_Detalle_Factura obj_DetalleFactura_DAL = new cls_Detalle_Factura();
        cls_Detalle_Factura_BLL obj_detalle_Factura_BLL = new cls_Detalle_Factura_BLL();
        cls_Factura_DAL obj_factura_DAL = new cls_Factura_DAL();
        cls_Validaciones_PL Validar_PL = new cls_Validaciones_PL();
        string sMensajeError;
        DataTable TDF = new DataTable();
        double dTotal = 0;
        public bool onLoad = false;
        //bool Btn;

        #endregion

        private void frm_Factura_Nueva_Load(object sender, EventArgs e)
        {
            Cargar();
            txt_Fecha.Text = string.Format("{0:yyyy/MM/dd H m s}", DateTime.Now.ToString());
            Cargar_ID_Factura();
            Cargar_Pagos();
            Cargar_Suministro();
            Cargar_Tratamientos();
            rdbtn_Tratamiento.Checked = true;
            onLoad = true;
            btn_Facturar.Enabled = true;          
            DataColumn Producto = new DataColumn("Producto", typeof(string));
            DataColumn Cantidad = new DataColumn("Cantidad", typeof(int));
            DataColumn Monto = new DataColumn("Monto", typeof(int));          
            TDF.Columns.Add(Producto);
            TDF.Columns.Add(Cantidad);
            TDF.Columns.Add(Monto);
            dgrw_TotalDetalles.DataSource = TDF;

        }

        #region Metodos

        private void Cargar()
        {
            sMensajeError = string.Empty;
            DataTable dt = new DataTable();

            if (obj_CargarClientes.Listar_Clientes_Factura_SP(ref dt, ref sMensajeError))
            {
                dgrv_InfoCliente.DataSource = dt;
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

        private void Cargar_ID_Factura()
        {
            string sMensajeError = string.Empty;
            DataTable dt = new DataTable();

            if (obj_Factura_BLL.Listar_ID_Factura_SP(ref dt, ref sMensajeError))
            {
                txt_ID_Factura.Text = dt.Rows[0][0].ToString();
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

        private void Cargar_Pagos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Código de Pago");
                dt.Columns.Add("Descripcion de Pago");


                // Trae los estados
                if (obj_Factura_BLL.Listar_Pagos_SP(ref dt, ref sMensajeError) == false)
                {
                    dt = null;
                }

                cmbx_TipoPago.DataSource = dt;

                cmbx_TipoPago.ValueMember = dt.Columns["Código de Pago"].ToString();
                cmbx_TipoPago.DisplayMember = dt.Columns["Descripcion de Pago"].ToString();

                // cmb_Id_Estado.DisplayMember = obj_Clientes_DAL.cEstado.ToString();




            }
            catch
            {
                // Si hay un error se limpia
                cmbx_TipoPago.DataSource = null;
            }


        }

        private void Cargar_Tratamientos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID Tratamiento");
                dt.Columns.Add("Descripcion");


                // Trae los estados
                if (obj_Factura_BLL.Listar_Factura_Tratamientos_SP(ref dt, ref sMensajeError) == false)
                {
                    dt = null;
                }

                cmb_Tratamiento.DataSource = dt;

                cmb_Tratamiento.ValueMember = dt.Columns["ID Tratamiento"].ToString();
                cmb_Tratamiento.DisplayMember = dt.Columns["Descripcion"].ToString();


            }
            catch
            {
                // Si hay un error se limpia
                cmb_Tratamiento.DataSource = null;
            }


        }

        private void Cargar_Suministro()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID Suministro");
                dt.Columns.Add("Descripcion");


                // Trae los estados
                if (obj_Factura_BLL.Listar_Factura_Suministro_SP(ref dt, ref sMensajeError) == false)
                {
                    dt = null;
                }

                cmb_Suministro.DataSource = dt;

                cmb_Suministro.ValueMember = dt.Columns["ID Suministro"].ToString();
                cmb_Suministro.DisplayMember = dt.Columns["Descripcion"].ToString();


            }
            catch
            {
                // Si hay un error se limpia
                cmb_Suministro.DataSource = null;
            }


        }

        private void Costos_Tratamiento()
        {
            try
            {

                int Parametro = Convert.ToInt32(cmb_Tratamiento.SelectedValue.ToString());
                DataTable dt = new DataTable();
                obj_detalle_Factura_BLL.Filtrar_Factura_Tratamientos_Costos(ref dt, ref Parametro, ref sMensajeError);
                obj_DetalleFactura_DAL.iMonto = Convert.ToInt32(dt.Rows[0][0]);
                txt_Costo.Text = Convert.ToString(obj_DetalleFactura_DAL.iMonto * txt_Cantidad.Value);


            }

            catch
            {
                MessageBox.Show("Error al cargar los costos de tratamiento" + sMensajeError, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void Costos_Suministro()
        {
            try
            {
                int Parametro = Convert.ToInt32(cmb_Suministro.SelectedValue.ToString());
                DataTable dt = new DataTable();
                obj_detalle_Factura_BLL.Filtrar_Factura_Suninistros_Costos(ref dt, ref Parametro, ref sMensajeError);
                obj_DetalleFactura_DAL.iMonto = Convert.ToInt32(dt.Rows[0][0]);
                txt_Costo.Text = Convert.ToString(obj_DetalleFactura_DAL.iMonto * txt_Cantidad.Value);

            }

            catch
            {
                MessageBox.Show("Error al cargar los costos de suministro" + sMensajeError, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgregarRows()
        {
                      
            if (rdbtn_Tratamiento.Checked == true)
            {
                TDF.Rows.Add(cmb_Tratamiento.Text.ToString(), txt_Cantidad.Value.ToString(), Convert.ToInt32(txt_Costo.Text));
            }
            else
            {
                TDF.Rows.Add(cmb_Suministro.Text.ToString(), txt_Cantidad.Value.ToString(), Convert.ToInt32(txt_Costo.Text));                
            }
        }

        private void Calculo_Total()
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_subtotal.Text) && TDF.Rows.Count > 0 && Convert.ToDouble(txt_Impuesto.Text) <= 100 && Convert.ToDouble(txt_Descuento.Text) <= 100)
                {
                //ambos son 0
                    if (Convert.ToDouble(txt_Impuesto.Text) == 0 && Convert.ToDouble(txt_Descuento.Text) == 0 )
                {
                    txt_Total_Pago.Text = txt_subtotal.Text.ToString();
                }

                //Descuento +0, impuesto = 0

                if (Convert.ToDouble(txt_Impuesto.Text) == 0 && Convert.ToDouble(txt_Descuento.Text) > 0)
                {
                    dTotal = Convert.ToDouble(txt_subtotal.Text) - (Convert.ToDouble(txt_subtotal.Text) * (Convert.ToDouble(txt_Descuento.Text) / 100));
                    txt_Total_Pago.Text = dTotal.ToString();
                }

                //Descueto = 0, impuesto +0

                if (Convert.ToDouble(txt_Impuesto.Text) > 0 && Convert.ToDouble(txt_Descuento.Text) == 0)
                {
                    dTotal = Convert.ToDouble(txt_subtotal.Text) + (Convert.ToDouble(txt_subtotal.Text) * (Convert.ToDouble(txt_Impuesto.Text) / 100));
                    txt_Total_Pago.Text = dTotal.ToString();
                }

                // ambos +0
                if (Convert.ToDouble(txt_Impuesto.Text) > 0 && Convert.ToDouble(txt_Descuento.Text) > 0)
                {
                    double desc =  (Convert.ToDouble(txt_subtotal.Text) * (Convert.ToDouble(txt_Descuento.Text) / 100));
                    double imp = (Convert.ToDouble(txt_subtotal.Text) * (Convert.ToDouble(txt_Impuesto.Text) / 100));

                    dTotal = Convert.ToDouble(txt_subtotal.Text) - desc + imp;

                    txt_Total_Pago.Text = dTotal.ToString();
                }

                }

                else
                {
                    MessageBox.Show("Por favor proveer todos los datos necesarios, el descuento y el impuesto no pueden ser mayores a 100, y deben de ser numero enteros positivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Descuento.Text = "0";
                    txt_Impuesto.Text = "0";

                }
            }

            catch
            {
                MessageBox.Show("Error a la hora de aplicar el descuento, solo se permiten numeros en los campos de impuesto y descuento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Descuento.Text = "0";
                txt_Impuesto.Text = "0";
            }

        }

        private void Insertar_Factura()
        {
            string sMensajeError = string.Empty;


            obj_Factura_BLL.Insertar_Factura_SP(ref obj_factura_DAL, ref sMensajeError);

            if (obj_factura_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("Factura creada! Numero de factura: " + txt_ID_Factura.Text,
                                "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                obj_factura_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("Hubo un error en la ejecución." +
                                "\nMensaje de error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                obj_factura_DAL.bAccion = true;
            }
        }

        private void Insertar_Detalle_Factura() //ver
        {
            string sMensajeError = string.Empty;


            obj_detalle_Factura_BLL.Insertar_DetalleFactura_SP(ref obj_DetalleFactura_DAL, ref sMensajeError);

            if (obj_DetalleFactura_DAL.bEstado_Ejec == true)
            {
                obj_DetalleFactura_DAL.bAccion = false;
            }
            else
            {
                MessageBox.Show("Hubo un error en la ejecución, insertando un detalle de la factura." +
                                "\nMensaje de error: " + sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                obj_DetalleFactura_DAL.bAccion = true;
            }
        }
               

        #endregion

        private void txt_IDCliente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_IDCliente.Text))
            {
                string Parametro = txt_IDCliente.Text.ToString().Trim();
                DataTable dt = new DataTable();

                if (obj_CargarClientes.Filtrar_Clientes_SP(ref dt, ref Parametro, ref sMensajeError))
                {
                    dgrv_InfoCliente.DataSource = dt;
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

            else
            {
                Cargar();
            }
        }

        private void rdbtn_Tratamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_Tratamiento.Checked == true)
            {
                txt_Cantidad.Value = 1;
                cmb_Tratamiento.Enabled = true;
                cmb_Suministro.Enabled = false;
                Costos_Tratamiento();
            }

            else
            {
                txt_Cantidad.Value = 1;
                cmb_Suministro.Enabled = true;
                cmb_Tratamiento.Enabled = false;
                Costos_Suministro();
            }
        }

        private void cmb_Tratamiento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (onLoad)
            {
                txt_Cantidad.Value = 1;
                Costos_Tratamiento();
            }
        }

        private void cmb_Suministro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (onLoad)
            {
                txt_Cantidad.Value = 1;
                Costos_Suministro();
            }
        }

        private void txt_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            string ValorMonto;
            ValorMonto = Convert.ToString(txt_Cantidad.Value * obj_DetalleFactura_DAL.iMonto);
            txt_Costo.Text = ValorMonto;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            
            AgregarRows();
            dTotal += Convert.ToDouble(txt_Costo.Text.ToString()); // es aca
            txt_subtotal.Text = Convert.ToString(dTotal);
        }

        private void txt_Facturar_Click(object sender, EventArgs e)
        {
            
            try
            {   //inserta emcabezado de factura
                if (dgrv_InfoCliente.SelectedRows.Count > 0 && TDF.Rows.Count > 0 && !string.IsNullOrEmpty(txt_Total_Pago.Text))
                {
                    obj_factura_DAL.dtFecha = Convert.ToDateTime(txt_Fecha.Text);
                    obj_factura_DAL.dImpuesto = Convert.ToDouble(txt_Impuesto.Text);
                    obj_factura_DAL.dDescuento = Convert.ToDouble(txt_Descuento.Text);
                    obj_factura_DAL.dSubtotal = Convert.ToDouble(txt_subtotal.Text);
                    obj_factura_DAL.dTotal = Convert.ToDouble(txt_Total_Pago.Text);
                    obj_factura_DAL.iTipoPago = Convert.ToInt16(cmbx_TipoPago.SelectedValue);
                    obj_factura_DAL.sId_Cliente = dgrv_InfoCliente.SelectedRows[0].Cells[0].Value.ToString();
                    string id = obj_factura_DAL.sId_Cliente.ToString();
                    obj_factura_DAL.iId_Estado = 1;

                    Insertar_Factura();
                    
                    //inserta detalles de factura
                    for (int i = 0; i <= TDF.Rows.Count-1; i++)
                    {
                        obj_DetalleFactura_DAL.sDescripcion = dgrw_TotalDetalles.Rows[i].Cells[0].Value.ToString();
                        obj_DetalleFactura_DAL.iCantidad = Convert.ToInt32(dgrw_TotalDetalles.Rows[i].Cells[1].Value);
                        obj_DetalleFactura_DAL.iMonto = Convert.ToInt32(dgrw_TotalDetalles.Rows[i].Cells[2].Value);
                        obj_DetalleFactura_DAL.iID_Factura = Convert.ToInt32(txt_ID_Factura.Text);
                        Insertar_Detalle_Factura();
                    }

                    btn_Facturar.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Debe de proveer todos lo datos antes de facturar, recuerde calcular el total");
                }
            }
            catch
            {
                MessageBox.Show("Error al crear la factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
           
           
        private void btn_Calcular_Total_Click(object sender, EventArgs e)
        {
            Calculo_Total();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_QuitarLinea_Click(object sender, EventArgs e)
        {
            if (dgrw_TotalDetalles.SelectedRows.Count > 0)
            {
                 

                dTotal -= Convert.ToDouble(dgrw_TotalDetalles.SelectedRows[0].Cells[2].Value);
                TDF.Rows.RemoveAt(dgrw_TotalDetalles.SelectedRows[0].Index);

                txt_subtotal.Text = dTotal.ToString();
            }

            else
            {
                MessageBox.Show("Para eliminar un detalle, primero debe de seleccionarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frm_Factura_Nueva_FormClosing(object sender, FormClosingEventArgs e)
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
