namespace Cls_PL.Pantallas.Catalogos.Listar
{
    partial class frm_Factura_Nueva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Factura_Nueva));
            this.label1 = new System.Windows.Forms.Label();
            this.Grbx_Cliente = new System.Windows.Forms.GroupBox();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ID_Factura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgrv_InfoCliente = new System.Windows.Forms.DataGridView();
            this.txt_IDCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Grbx_Detalles = new System.Windows.Forms.GroupBox();
            this.btn_QuitarLinea = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.cmb_Suministro = new System.Windows.Forms.ComboBox();
            this.cmb_Tratamiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpbx_Opciones = new System.Windows.Forms.GroupBox();
            this.rdbtn_Tratamiento = new System.Windows.Forms.RadioButton();
            this.rdbtn_Suministro = new System.Windows.Forms.RadioButton();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Costo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Grbx_TotalDetalles = new System.Windows.Forms.GroupBox();
            this.dgrw_TotalDetalles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular_Total = new System.Windows.Forms.Button();
            this.txt_Total_Pago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Impuesto = new System.Windows.Forms.TextBox();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.cmbx_TipoPago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Grbx_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_InfoCliente)).BeginInit();
            this.Grbx_Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).BeginInit();
            this.grpbx_Opciones.SuspendLayout();
            this.Grbx_TotalDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrw_TotalDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clinica Odontológica Perla Blanca - Facturación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grbx_Cliente
            // 
            this.Grbx_Cliente.Controls.Add(this.txt_Fecha);
            this.Grbx_Cliente.Controls.Add(this.label11);
            this.Grbx_Cliente.Controls.Add(this.txt_ID_Factura);
            this.Grbx_Cliente.Controls.Add(this.label3);
            this.Grbx_Cliente.Controls.Add(this.dgrv_InfoCliente);
            this.Grbx_Cliente.Controls.Add(this.txt_IDCliente);
            this.Grbx_Cliente.Controls.Add(this.label2);
            this.Grbx_Cliente.Location = new System.Drawing.Point(12, 63);
            this.Grbx_Cliente.Name = "Grbx_Cliente";
            this.Grbx_Cliente.Size = new System.Drawing.Size(824, 221);
            this.Grbx_Cliente.TabIndex = 6;
            this.Grbx_Cliente.TabStop = false;
            this.Grbx_Cliente.Text = "Cliente";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(595, 18);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.ReadOnly = true;
            this.txt_Fecha.Size = new System.Drawing.Size(161, 20);
            this.txt_Fecha.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Fecha:";
            // 
            // txt_ID_Factura
            // 
            this.txt_ID_Factura.Location = new System.Drawing.Point(363, 17);
            this.txt_ID_Factura.Name = "txt_ID_Factura";
            this.txt_ID_Factura.ReadOnly = true;
            this.txt_ID_Factura.Size = new System.Drawing.Size(161, 20);
            this.txt_ID_Factura.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Factura";
            // 
            // dgrv_InfoCliente
            // 
            this.dgrv_InfoCliente.AllowUserToAddRows = false;
            this.dgrv_InfoCliente.AllowUserToDeleteRows = false;
            this.dgrv_InfoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrv_InfoCliente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrv_InfoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_InfoCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrv_InfoCliente.Location = new System.Drawing.Point(16, 51);
            this.dgrv_InfoCliente.MultiSelect = false;
            this.dgrv_InfoCliente.Name = "dgrv_InfoCliente";
            this.dgrv_InfoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrv_InfoCliente.Size = new System.Drawing.Size(790, 150);
            this.dgrv_InfoCliente.TabIndex = 3;
            // 
            // txt_IDCliente
            // 
            this.txt_IDCliente.Location = new System.Drawing.Point(94, 16);
            this.txt_IDCliente.Name = "txt_IDCliente";
            this.txt_IDCliente.Size = new System.Drawing.Size(161, 20);
            this.txt_IDCliente.TabIndex = 2;
            this.txt_IDCliente.TextChanged += new System.EventHandler(this.txt_IDCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar cliente";
            // 
            // Grbx_Detalles
            // 
            this.Grbx_Detalles.Controls.Add(this.btn_QuitarLinea);
            this.Grbx_Detalles.Controls.Add(this.txt_Cantidad);
            this.Grbx_Detalles.Controls.Add(this.cmb_Suministro);
            this.Grbx_Detalles.Controls.Add(this.cmb_Tratamiento);
            this.Grbx_Detalles.Controls.Add(this.label4);
            this.Grbx_Detalles.Controls.Add(this.grpbx_Opciones);
            this.Grbx_Detalles.Controls.Add(this.btn_Agregar);
            this.Grbx_Detalles.Controls.Add(this.txt_Costo);
            this.Grbx_Detalles.Controls.Add(this.label7);
            this.Grbx_Detalles.Location = new System.Drawing.Point(22, 297);
            this.Grbx_Detalles.Name = "Grbx_Detalles";
            this.Grbx_Detalles.Size = new System.Drawing.Size(498, 145);
            this.Grbx_Detalles.TabIndex = 7;
            this.Grbx_Detalles.TabStop = false;
            this.Grbx_Detalles.Text = "Detalles";
            // 
            // btn_QuitarLinea
            // 
            this.btn_QuitarLinea.Location = new System.Drawing.Point(400, 115);
            this.btn_QuitarLinea.Name = "btn_QuitarLinea";
            this.btn_QuitarLinea.Size = new System.Drawing.Size(75, 23);
            this.btn_QuitarLinea.TabIndex = 16;
            this.btn_QuitarLinea.Text = "Quitar liena";
            this.btn_QuitarLinea.UseVisualStyleBackColor = true;
            this.btn_QuitarLinea.Click += new System.EventHandler(this.btn_QuitarLinea_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(355, 34);
            this.txt_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.ReadOnly = true;
            this.txt_Cantidad.Size = new System.Drawing.Size(120, 20);
            this.txt_Cantidad.TabIndex = 8;
            this.txt_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Cantidad.ValueChanged += new System.EventHandler(this.txt_Cantidad_ValueChanged);
            // 
            // cmb_Suministro
            // 
            this.cmb_Suministro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Suministro.FormattingEnabled = true;
            this.cmb_Suministro.Location = new System.Drawing.Point(108, 69);
            this.cmb_Suministro.Name = "cmb_Suministro";
            this.cmb_Suministro.Size = new System.Drawing.Size(165, 21);
            this.cmb_Suministro.TabIndex = 15;
            this.cmb_Suministro.SelectedValueChanged += new System.EventHandler(this.cmb_Suministro_SelectedValueChanged);
            // 
            // cmb_Tratamiento
            // 
            this.cmb_Tratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tratamiento.FormattingEnabled = true;
            this.cmb_Tratamiento.Location = new System.Drawing.Point(108, 39);
            this.cmb_Tratamiento.Name = "cmb_Tratamiento";
            this.cmb_Tratamiento.Size = new System.Drawing.Size(165, 21);
            this.cmb_Tratamiento.TabIndex = 14;
            this.cmb_Tratamiento.SelectedValueChanged += new System.EventHandler(this.cmb_Tratamiento_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad:";
            // 
            // grpbx_Opciones
            // 
            this.grpbx_Opciones.Controls.Add(this.rdbtn_Tratamiento);
            this.grpbx_Opciones.Controls.Add(this.rdbtn_Suministro);
            this.grpbx_Opciones.Location = new System.Drawing.Point(6, 19);
            this.grpbx_Opciones.Name = "grpbx_Opciones";
            this.grpbx_Opciones.Size = new System.Drawing.Size(96, 77);
            this.grpbx_Opciones.TabIndex = 10;
            this.grpbx_Opciones.TabStop = false;
            this.grpbx_Opciones.Text = "Opciones";
            // 
            // rdbtn_Tratamiento
            // 
            this.rdbtn_Tratamiento.AutoSize = true;
            this.rdbtn_Tratamiento.Location = new System.Drawing.Point(6, 21);
            this.rdbtn_Tratamiento.Name = "rdbtn_Tratamiento";
            this.rdbtn_Tratamiento.Size = new System.Drawing.Size(81, 17);
            this.rdbtn_Tratamiento.TabIndex = 16;
            this.rdbtn_Tratamiento.TabStop = true;
            this.rdbtn_Tratamiento.Text = "Tratamiento";
            this.rdbtn_Tratamiento.UseVisualStyleBackColor = true;
            this.rdbtn_Tratamiento.CheckedChanged += new System.EventHandler(this.rdbtn_Tratamiento_CheckedChanged);
            // 
            // rdbtn_Suministro
            // 
            this.rdbtn_Suministro.AutoSize = true;
            this.rdbtn_Suministro.Location = new System.Drawing.Point(6, 44);
            this.rdbtn_Suministro.Name = "rdbtn_Suministro";
            this.rdbtn_Suministro.Size = new System.Drawing.Size(73, 17);
            this.rdbtn_Suministro.TabIndex = 15;
            this.rdbtn_Suministro.TabStop = true;
            this.rdbtn_Suministro.Text = "Suministro";
            this.rdbtn_Suministro.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(400, 86);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 8;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Costo
            // 
            this.txt_Costo.Location = new System.Drawing.Point(355, 60);
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.ReadOnly = true;
            this.txt_Costo.Size = new System.Drawing.Size(120, 20);
            this.txt_Costo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Costo:";
            // 
            // Grbx_TotalDetalles
            // 
            this.Grbx_TotalDetalles.Controls.Add(this.dgrw_TotalDetalles);
            this.Grbx_TotalDetalles.Location = new System.Drawing.Point(22, 448);
            this.Grbx_TotalDetalles.Name = "Grbx_TotalDetalles";
            this.Grbx_TotalDetalles.Size = new System.Drawing.Size(498, 206);
            this.Grbx_TotalDetalles.TabIndex = 8;
            this.Grbx_TotalDetalles.TabStop = false;
            this.Grbx_TotalDetalles.Text = "Total de detalles";
            // 
            // dgrw_TotalDetalles
            // 
            this.dgrw_TotalDetalles.AllowUserToAddRows = false;
            this.dgrw_TotalDetalles.AllowUserToDeleteRows = false;
            this.dgrw_TotalDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrw_TotalDetalles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrw_TotalDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrw_TotalDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrw_TotalDetalles.Location = new System.Drawing.Point(10, 19);
            this.dgrw_TotalDetalles.Name = "dgrw_TotalDetalles";
            this.dgrw_TotalDetalles.ReadOnly = true;
            this.dgrw_TotalDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrw_TotalDetalles.Size = new System.Drawing.Size(440, 168);
            this.dgrw_TotalDetalles.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Calcular_Total);
            this.groupBox1.Controls.Add(this.txt_Total_Pago);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_subtotal);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Impuesto);
            this.groupBox1.Controls.Add(this.txt_Descuento);
            this.groupBox1.Controls.Add(this.cmbx_TipoPago);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(539, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 181);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago";
            // 
            // btn_Calcular_Total
            // 
            this.btn_Calcular_Total.Location = new System.Drawing.Point(189, 138);
            this.btn_Calcular_Total.Name = "btn_Calcular_Total";
            this.btn_Calcular_Total.Size = new System.Drawing.Size(90, 22);
            this.btn_Calcular_Total.TabIndex = 25;
            this.btn_Calcular_Total.Text = "Calcular";
            this.btn_Calcular_Total.UseVisualStyleBackColor = true;
            this.btn_Calcular_Total.Click += new System.EventHandler(this.btn_Calcular_Total_Click);
            // 
            // txt_Total_Pago
            // 
            this.txt_Total_Pago.Location = new System.Drawing.Point(97, 138);
            this.txt_Total_Pago.Name = "txt_Total_Pago";
            this.txt_Total_Pago.ReadOnly = true;
            this.txt_Total_Pago.Size = new System.Drawing.Size(82, 20);
            this.txt_Total_Pago.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(98, 44);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(121, 20);
            this.txt_subtotal.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Subtotal:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "%";
            // 
            // txt_Impuesto
            // 
            this.txt_Impuesto.Location = new System.Drawing.Point(98, 108);
            this.txt_Impuesto.MaxLength = 3;
            this.txt_Impuesto.Name = "txt_Impuesto";
            this.txt_Impuesto.Size = new System.Drawing.Size(60, 20);
            this.txt_Impuesto.TabIndex = 18;
            this.txt_Impuesto.Text = "0";
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Location = new System.Drawing.Point(98, 76);
            this.txt_Descuento.MaxLength = 3;
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(60, 20);
            this.txt_Descuento.TabIndex = 15;
            this.txt_Descuento.Text = "0";
            // 
            // cmbx_TipoPago
            // 
            this.cmbx_TipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_TipoPago.FormattingEnabled = true;
            this.cmbx_TipoPago.Location = new System.Drawing.Point(98, 16);
            this.cmbx_TipoPago.Name = "cmbx_TipoPago";
            this.cmbx_TipoPago.Size = new System.Drawing.Size(121, 21);
            this.cmbx_TipoPago.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Impuesto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Descuento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo de pago:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(761, 676);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cerrar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Location = new System.Drawing.Point(676, 676);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(69, 23);
            this.btn_Facturar.TabIndex = 10;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.UseVisualStyleBackColor = true;
            this.btn_Facturar.Click += new System.EventHandler(this.txt_Facturar_Click);
            // 
            // frm_Factura_Nueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(848, 705);
            this.Controls.Add(this.btn_Facturar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.Grbx_TotalDetalles);
            this.Controls.Add(this.Grbx_Detalles);
            this.Controls.Add(this.Grbx_Cliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Factura_Nueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Factura_Nueva_FormClosing);
            this.Load += new System.EventHandler(this.frm_Factura_Nueva_Load);
            this.Grbx_Cliente.ResumeLayout(false);
            this.Grbx_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_InfoCliente)).EndInit();
            this.Grbx_Detalles.ResumeLayout(false);
            this.Grbx_Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).EndInit();
            this.grpbx_Opciones.ResumeLayout(false);
            this.grpbx_Opciones.PerformLayout();
            this.Grbx_TotalDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrw_TotalDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Grbx_Cliente;
        private System.Windows.Forms.GroupBox Grbx_Detalles;
        private System.Windows.Forms.GroupBox Grbx_TotalDetalles;
        private System.Windows.Forms.TextBox txt_IDCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_Costo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dgrw_TotalDetalles;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.DataGridView dgrv_InfoCliente;
        private System.Windows.Forms.TextBox txt_ID_Factura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpbx_Opciones;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox cmb_Tratamiento;
        private System.Windows.Forms.RadioButton rdbtn_Tratamiento;
        private System.Windows.Forms.RadioButton rdbtn_Suministro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Total_Pago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Impuesto;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.ComboBox cmbx_TipoPago;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.ComboBox cmb_Suministro;
        private System.Windows.Forms.NumericUpDown txt_Cantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_QuitarLinea;
        private System.Windows.Forms.Button btn_Calcular_Total;
    }
}