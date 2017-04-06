using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Factura;
using Cls_DAL.Catalogos.Detalle_Factura;
using Cls_DAL.Catalogos.Factura;
using Cls_DAL.Catalogos.Log_in;

namespace Cls_PL.Pantallas.Catalogos.Listar
{
    public partial class frm_Listar_Factura : Form
    {
        #region variables globales

            public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();
            cls_Factura_BLL Obj_cls_Clientes_BLL = new cls_Factura_BLL();
            cls_Detalle_Factura obj_detalle_DAL = new cls_Detalle_Factura();
            cls_Factura_BLL obj_Factura_BLL = new cls_Factura_BLL();
            cls_Factura_DAL obj_Factura_DAL = new cls_Factura_DAL();
            string sMensajeError;
         
        #endregion

        public frm_Listar_Factura()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            string sMensajeError = string.Empty;
            DataTable dt = new DataTable();

            if (Obj_cls_Clientes_BLL.Listar_Clientes_SP(ref dt, ref sMensajeError))
            {
                dgv_Factura.DataSource = dt;
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

        private void fmr_listar_Factura_Load(object sender, EventArgs e)
        {
           Cargar();
           Opciones();
        }

        private void tlsbtn_Refrescar_Click(object sender, EventArgs e)
        {
             Cargar();
        }

        private void tlsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            frm_Factura_Nueva Nueva = new frm_Factura_Nueva();
            Nueva.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_filtrar_Factura.Text))
            {
                string Parametro = txt_filtrar_Factura.Text.ToString().Trim();
                DataTable dt = new DataTable();

                if (Obj_cls_Clientes_BLL.Filtrar_Factura_SP(ref dt, ref Parametro, ref sMensajeError))
                {
                    dgv_Factura.DataSource = dt;
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

        private void dgv_Factura_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Factura.SelectedRows.Count > 0)
            {
                frm_Listar_Detalles_Factura Detalles = new frm_Listar_Detalles_Factura();
                Detalles.txt_ID_Factura_Detalle.Text = dgv_Factura.SelectedRows[0].Cells[0].Value.ToString();
                Detalles.ShowDialog();
            }
            else
            {
                MessageBox.Show("No ha seleccionado una Factura para ser modificado.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void tlsbtn_Anular_Click(object sender, EventArgs e)
        {
            if (dgv_Factura.Rows.Count > 0)
            {
                if (MessageBox.Show("Desea Anular la factura", "Anular", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    obj_Factura_DAL.iId_Factura = Convert.ToInt32(dgv_Factura.SelectedRows[0].Cells[0].Value);
                    obj_Factura_DAL.iId_Estado = 2;
                    obj_Factura_BLL.Anular_Factura(ref obj_Factura_DAL, ref sMensajeError);
                    Cargar();
                }
            }
            else
            {
                MessageBox.Show("Antes de anular debe de seleccionar una factura", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
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

                    tlsbtn_Nuevo.Enabled = true;
                    tlsbtn_Anular.Enabled = true;
                    break;

                case 2:// Medio

                    tlsbtn_Nuevo.Enabled = true;
                    tlsbtn_Anular.Enabled = false;
                    break;

                case 3: // solo lectura

                    tlsbtn_Nuevo.Enabled = false;
                    tlsbtn_Anular.Enabled = false;
                    break;

                default:

                    tlsbtn_Nuevo.Enabled = false;
                    tlsbtn_Anular.Enabled = false;
                    break;
            }
        }
    }
          
}


