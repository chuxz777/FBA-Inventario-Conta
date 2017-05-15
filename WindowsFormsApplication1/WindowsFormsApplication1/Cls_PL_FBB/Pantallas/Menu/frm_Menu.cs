using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
using Cls_PL.Pantallas;
using Cls_PL.Pantallas.Catalogos.Listar;
using Cls_DAL.Catalogos.Log_in;
*/

namespace Cls_PL
{
    public partial class Frm_Menu : Form
    {
        #region variable global
        ////public Cls_Tabla_LogIn_DAL obj_Log_In_DAL = new Cls_Tabla_LogIn_DAL();
        #endregion

        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//Clientes
        {
            Frm_Listar_Color Obj_Pantalla_Listar_Color = new Frm_Listar_Color();
            Obj_Pantalla_Listar_Color.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)//Activos
        {

            Frm_Listar_Tipo_Articulo Obj_Pantalla_Listar_Tipo_Articulo = new Frm_Listar_Tipo_Articulo();
            //Obj_Pantalla_Listar_Estados.Obj_Login_DAL = obj_Log_In_DAL;
            Obj_Pantalla_Listar_Tipo_Articulo.ShowDialog();


        }

        private void toolStripButton6_Click(object sender, EventArgs e)//Productos
        {
            
        }

        private void toolStripButton8_Click(object sender, EventArgs e)//Estados
        {
            Frm_Listar_Estados Obj_Pantalla_Listar_Estados = new Frm_Listar_Estados();
            //Obj_Pantalla_Listar_Estados.Obj_Login_DAL = obj_Log_In_DAL;
            Obj_Pantalla_Listar_Estados.ShowDialog();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)//Roles
        {
            //frm_Listar_Roles Obj_Pantalla_Listar_Roles = new frm_Listar_Roles();
            //Obj_Pantalla_Listar_Roles.Obj_Login_DAL = obj_Log_In_DAL;
            //Obj_Pantalla_Listar_Roles.ShowDialog();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)//Tipo Pago
        {
            //frm_Listar_Tipo_Pago Obj_Pantalla_Listar_Tipo_Pago = new frm_Listar_Tipo_Pago();
            //Obj_Pantalla_Listar_Tipo_Pago.Obj_Login_DAL = obj_Log_In_DAL;
            //Obj_Pantalla_Listar_Tipo_Pago.ShowDialog();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)//Sucursales
        {
            Frm_Listar_Tipo_Articulo Obj_Pantalla_Listar_Tipo_Articulo = new Frm_Listar_Tipo_Articulo();
            Obj_Pantalla_Listar_Tipo_Articulo.ShowDialog();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)//Usuario
        {
            //Frm_Listar_Usuario Obj_Pantalla_Listar_Tipo_Usuario = new Frm_Listar_Usuario();
            //Obj_Pantalla_Listar_Tipo_Usuario.Obj_Login_DAL = obj_Log_In_DAL;
            //Obj_Pantalla_Listar_Tipo_Usuario.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)//Empleado
        {
            //frm_Listar_Empleado Obj_Pantalla_Listar_Empleado = new frm_Listar_Empleado();
            //Obj_Pantalla_Listar_Empleado.Obj_Login_DAL = obj_Log_In_DAL;
            //Obj_Pantalla_Listar_Empleado.ShowDialog();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)//TipoEmpleado
        {
            //frm_Listar_TipoEmpleado Obj_Pantalla_Listar_Tipo_Empleado = new frm_Listar_TipoEmpleado();
            //Obj_Pantalla_Listar_Tipo_Empleado.Obj_Login_DAL = obj_Log_In_DAL;
            //Obj_Pantalla_Listar_Tipo_Empleado.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)//Proveedores
        {
            //frm_Listar_Proveedores obj_Pantalla_Listar_Proveedores = new frm_Listar_Proveedores();
            //obj_Pantalla_Listar_Proveedores.obj_Log_In_DAL = obj_Log_In_DAL;
            //obj_Pantalla_Listar_Proveedores.ShowDialog();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)//Tipo Usuario
        {
            //Frm_Listar_Tipo_Usuario obj_Pantalla_Listar_Tipo_Usuario = new Frm_Listar_Tipo_Usuario();
            //obj_Pantalla_Listar_Tipo_Usuario.Obj_Login_DAL = obj_Log_In_DAL;
            //obj_Pantalla_Listar_Tipo_Usuario.Show();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)//Tipo Tratamiento
        {
            //frm_Listar_Tipo_Tratamiento Obj_Pantalla_listar_Tipo_Tratamiento = new frm_Listar_Tipo_Tratamiento();
            //Obj_Pantalla_listar_Tipo_Tratamiento.Obj_Login_DAL = obj_Log_In_DAL;
            //Obj_Pantalla_listar_Tipo_Tratamiento.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//Citas
        {
            //frm_Listar_Citas Obj_Pantalla_Listar_Citas = new frm_Listar_Citas();
            //Obj_Pantalla_Listar_Citas.Obj_Login_DAL = obj_Log_In_DAL;
            //Obj_Pantalla_Listar_Citas.ShowDialog();
        }

        private void tlsbtn_Expediente_Click(object sender, EventArgs e)//Expediente
        {
            Frm_Listar_Departamento Obj_Pantalla_Listar_Departamento = new Frm_Listar_Departamento();
            Obj_Pantalla_Listar_Departamento.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)//Factura
        {
            //frm_Listar_Factura Obj_Pantalla_Listar_Facturas = new frm_Listar_Factura();
            //Obj_Pantalla_Listar_Facturas.Obj_Login_DAL = obj_Log_In_DAL;
            //Obj_Pantalla_Listar_Facturas.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //frm_Listar_Detalles_Factura Obj_Pantalla_Detalles_Facturas = new frm_Listar_Detalles_Factura();
            //Obj_Pantalla_Detalles_Facturas.ShowDialog();
        }

        private void toolStripButton16_Click_1(object sender, EventArgs e)
        {
            Frm_Listar_Estados Obj_Pantalla_Listar_Estados = new Frm_Listar_Estados();
            //Obj_Pantalla_Listar_Estados.Obj_Login_DAL = obj_Log_In_DAL;
            Obj_Pantalla_Listar_Estados.ShowDialog();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            Frm_Listar_Objetivo Obj_Pantalla_Listar_Objetivo = new Frm_Listar_Objetivo();
            Obj_Pantalla_Listar_Objetivo.ShowDialog();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            Frm_Listar_Facturacion Obj_Pantalla_Listar_Facturacion = new Frm_Listar_Facturacion();
            Obj_Pantalla_Listar_Facturacion.Show();
        }
    }
}
