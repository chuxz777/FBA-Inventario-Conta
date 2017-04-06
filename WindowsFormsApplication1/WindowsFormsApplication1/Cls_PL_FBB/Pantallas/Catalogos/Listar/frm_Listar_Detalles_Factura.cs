using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_BLL.Catalogos.Detalle_Factura;
using Cls_DAL.Catalogos.Detalle_Factura;
namespace Cls_PL.Pantallas.Catalogos.Listar
{
    public partial class frm_Listar_Detalles_Factura : Form
    {
        public frm_Listar_Detalles_Factura()
        {
            InitializeComponent();
        }

        #region variables globales

        cls_Detalle_Factura_BLL Detalle_BLL = new cls_Detalle_Factura_BLL();
        string sMensajeError;

        #endregion

        #region metodos

        private void Cargar()
        {
            DataTable dt = new DataTable();
            int Parametro = Convert.ToInt32(txt_ID_Factura_Detalle.Text.Trim());
            if (Detalle_BLL.Listar_Detalles_Factura_SP(ref dt, ref sMensajeError, Parametro))
            {
                dtgrd_Detalles_Factura.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Problemas a la hora de la carga de la información.\n" +
                                sMensajeError,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #endregion 

        private void frm_Listar_Detalles_Factura_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ID_Factura_Detalle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ID_Factura_Detalle.Text))
            {
                sMensajeError = string.Empty;
                string Parametro = txt_ID_Factura_Detalle.Text.ToString().Trim();
                DataTable dt = new DataTable();
                Detalle_BLL.Filtrar_Detalles_Factura_SP(ref dt, ref sMensajeError, Parametro);
                dtgrd_Detalles_Factura.DataSource = dt;
            }

            else
            {
                Cargar();
            }
        }
    }
}