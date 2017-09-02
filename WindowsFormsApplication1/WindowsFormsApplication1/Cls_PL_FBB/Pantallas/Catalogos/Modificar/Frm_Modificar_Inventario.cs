using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
//using Cls_DAL.Catalogos.Log_in;
using Cls_DAL_FBB.Catalogos.TipoArticulo;
using Cls_DAL_FBB.Catalogos.Inventario;
using Cls_BLL_FBB.Catalogos.Departamento;
using Cls_BLL_FBB.Catalogos.Objetivo;
using Cls_BLL_FBB.Catalogos.Estados;
using Cls_BLL_FBB.Catalogos.Tipo_Articulo;
using Cls_BLL_FBB.Catalogos.Color;
using Cls_BLL_FBB.Catalogos.Inventario;
using Cls_PL.Pantallas.Catalogos.Modificar;



namespace Cls_PL
{
    public partial class Frm_Modificar_Inventario : Form
    {
        #region Variables Globales
        private Frm_Modificar_Tipo_Articulo Obj_Pant_Mod_Tipo_Articulo = new Frm_Modificar_Tipo_Articulo();
        cls_Tipo_Articulo_BLL Obj_Cls_Tipo_Articulo_BLL = new cls_Tipo_Articulo_BLL();
        cls_Departamento_BLL Obj_Cls_Departamento_BLL = new cls_Departamento_BLL();
        cls_Objetivo_BLL  Obj_Cls_Objetivo_BLL = new cls_Objetivo_BLL();
        cls_Estados_BLL Obj_Cls_Estado_BLL = new cls_Estados_BLL();
        cls_Color_BLL Obj_Cls_Color_BLL = new cls_Color_BLL();
        cls_Inventario_BLL Obj_Cls_Inventario_BLL = new cls_Inventario_BLL();
        cls_TipoArticulo_DAL Obj_Cls_Tipo_Articulo_DAL = new cls_TipoArticulo_DAL();
        cls_Inventario_DAL Obj_Cls_Inventario_DAL = new cls_Inventario_DAL();
        //public Cls_Tabla_LogIn_DAL Obj_Login_DAL = new Cls_Tabla_LogIn_DAL();

        DataTable dt_Tipo_Articulo = new DataTable();
        DataTable dt_color = new DataTable();
        DataTable dt_Estado = new DataTable();
        DataTable dt_Objetivo = new DataTable();


        private string sMensajeError;
        #endregion

        public Frm_Modificar_Inventario()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opciones();
            Cargar();
            Cargar_Combo_Tipo_Articulo();
            Cargar_Combo_Departamento();
            Cargar_Combo_Objetivo();
            Cargar_Combo_Estado();
            Cargar_Combo_Color();

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


        private void Cargar_Combo_Departamento()
        {
            try
            {
                Obj_Cls_Departamento_BLL.Listar_Departamento_SP(ref dt_Tipo_Articulo, ref sMensajeError);
                if (dt_Tipo_Articulo != null)
                {
                    cbx_Departamento.DataSource = dt_Tipo_Articulo;
                    cbx_Departamento.ValueMember = dt_Tipo_Articulo.Columns["Codigo del tipo de Departamento"].ToString().Trim();
                    cbx_Departamento.DisplayMember = dt_Tipo_Articulo.Columns["Descripcion del Departamento"].ToString().Trim();
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


        private void Cargar_Combo_Objetivo()
        {
            try
            {
                Obj_Cls_Objetivo_BLL.Listar_Objetivo_SP(ref dt_Objetivo, ref sMensajeError);
                if (dt_Tipo_Articulo != null)
                {
                    cbx_Objetivo.DataSource = dt_Objetivo;
                    cbx_Objetivo.ValueMember = dt_Objetivo.Columns["Codigo del tipo de Objetivo"].ToString().Trim();
                    cbx_Objetivo.DisplayMember = dt_Objetivo.Columns["Descripcion del objetivo para el artículo"].ToString().Trim();
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


        private void Cargar_Combo_Estado()
        {
            try
            {
                Obj_Cls_Estado_BLL.Listar_Estados_SP(ref dt_Estado, ref sMensajeError);
                if (dt_Tipo_Articulo != null)
                {
                    cbx_Estado.DataSource = dt_Estado;
                    cbx_Estado.ValueMember = dt_Estado.Columns["Codigo del Estado"].ToString().Trim();
                    cbx_Estado.DisplayMember = dt_Estado.Columns["Descripcion del Estado"].ToString().Trim();
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


        private void Cargar_Combo_Color()
        {
            try
            {
                Obj_Cls_Color_BLL.Listar_Color_SP(ref dt_color, ref sMensajeError);
                if (dt_Tipo_Articulo != null)
                {
                    cbx_Color.DataSource = dt_color;
                    cbx_Color.ValueMember = dt_color.Columns["Codigo del Color"].ToString().Trim();
                    cbx_Color.DisplayMember = dt_color.Columns["Descripcion del Color"].ToString().Trim();
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


        private void Ingresar_Productos()
        {
            int cantidad = int.Parse(nud_Cantidad.Value.ToString());

            Obj_Cls_Inventario_DAL.iCod_tipo_articulo = Convert.ToInt32(cbx_Articulo.SelectedValue.ToString());
            Obj_Cls_Inventario_DAL.iCod_departamento = Convert.ToInt32(cbx_Departamento.SelectedValue.ToString());
            Obj_Cls_Inventario_DAL.iPrecio_sugerido = Convert.ToInt32(txt_Precio.Text.ToString());
            Obj_Cls_Inventario_DAL.dFecha_entrada_inv = dtPicker_Mes_Año.Value;
            Obj_Cls_Inventario_DAL.iCod_color = Convert.ToInt32(cbx_Color.SelectedValue.ToString());
            Obj_Cls_Inventario_DAL.iCod_Objetivo = Convert.ToInt32(cbx_Objetivo.SelectedValue.ToString());
            Obj_Cls_Inventario_DAL.iCod_Estado = Convert.ToInt32(cbx_Estado.SelectedValue.ToString());

            if (cantidad > 1 )
           {
                for (int i = 0; i < cantidad; i++)
                {
                    // Registrar productos las veces que indica el contador 
                    Obj_Cls_Inventario_BLL.Insertar_Inventario_SP(ref  Obj_Cls_Inventario_DAL, ref sMensajeError);

                }
            }
            else if (cantidad == 1)
            {
                Obj_Cls_Inventario_BLL.Insertar_Inventario_SP(ref Obj_Cls_Inventario_DAL, ref sMensajeError);
            }
            else
            {
                MessageBox.Show("No ha indicado la cantidad de productos para ser registrados.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            

            if (Obj_Cls_Inventario_DAL.bEstado_Ejec == true)
            {
                MessageBox.Show("Los productos han sido registrados.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }

            LimpiarFormulario();
        }



        private void dgv_Estados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Ingresar_Productos();
        }

        private void LimpiarFormulario()
        {
            txt_Precio.Text = "";
           
        }
    }
}