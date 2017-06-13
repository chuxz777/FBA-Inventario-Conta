namespace Cls_PL
{
    partial class Frm_Listar_Facturacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Listar_Facturacion));
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_Buscar = new System.Windows.Forms.ToolStripButton();
            this.tlstrp_txt_Busqueda = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.grpbx_Estados = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_Factura = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbx_Articulo = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Total = new System.Windows.Forms.Button();
            this.mTxt_Año = new System.Windows.Forms.MaskedTextBox();
            this.tbctrl_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
            this.grpbx_Estados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbctrl_Principal
            // 
            this.tbctrl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrl_Principal.Controls.Add(this.tabPage1);
            this.tbctrl_Principal.Location = new System.Drawing.Point(5, 49);
            this.tbctrl_Principal.Name = "tbctrl_Principal";
            this.tbctrl_Principal.SelectedIndex = 0;
            this.tbctrl_Principal.Size = new System.Drawing.Size(896, 100);
            this.tbctrl_Principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(888, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlstrp_Funciones_Basicas
            // 
            this.tlstrp_Funciones_Basicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlstrp_Funciones_Basicas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlstrp_Funciones_Basicas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlstrp_Funciones_Basicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtn_Buscar,
            this.tlstrp_txt_Busqueda,
            this.toolStripSeparator4,
            this.tlsbtn_Refrescar,
            this.toolStripSeparator1,
            this.tlsbtn_Editar,
            this.toolStripSeparator2,
            this.tlsbtn_Nuevo,
            this.toolStripSeparator5,
            this.tlsbtn_Eliminar,
            this.toolStripSeparator6,
            this.tlsbtn_Salir});
            this.tlstrp_Funciones_Basicas.Location = new System.Drawing.Point(3, 3);
            this.tlstrp_Funciones_Basicas.Name = "tlstrp_Funciones_Basicas";
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(882, 68);
            this.tlstrp_Funciones_Basicas.TabIndex = 0;
            this.tlstrp_Funciones_Basicas.Text = "toolStrip1";
            // 
            // tlsbtn_Buscar
            // 
            this.tlsbtn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Buscar.Image")));
            this.tlsbtn_Buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Buscar.Name = "tlsbtn_Buscar";
            this.tlsbtn_Buscar.Size = new System.Drawing.Size(78, 65);
            this.tlsbtn_Buscar.Text = "Buscar";
            // 
            // tlstrp_txt_Busqueda
            // 
            this.tlstrp_txt_Busqueda.Name = "tlstrp_txt_Busqueda";
            this.tlstrp_txt_Busqueda.Size = new System.Drawing.Size(200, 68);
            this.tlstrp_txt_Busqueda.TextChanged += new System.EventHandler(this.tlstrp_txt_Busqueda_TextChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 68);
            // 
            // tlsbtn_Refrescar
            // 
            this.tlsbtn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Refrescar.Image")));
            this.tlsbtn_Refrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Refrescar.Name = "tlsbtn_Refrescar";
            this.tlsbtn_Refrescar.Size = new System.Drawing.Size(91, 65);
            this.tlsbtn_Refrescar.Text = "Refrescar";
            this.tlsbtn_Refrescar.Click += new System.EventHandler(this.tlsbtn_Refrescar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // tlsbtn_Editar
            // 
            this.tlsbtn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Editar.Image")));
            this.tlsbtn_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Editar.Name = "tlsbtn_Editar";
            this.tlsbtn_Editar.Size = new System.Drawing.Size(73, 65);
            this.tlsbtn_Editar.Text = "Editar";
            this.tlsbtn_Editar.Click += new System.EventHandler(this.tlsbtn_Editar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // tlsbtn_Nuevo
            // 
            this.tlsbtn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Nuevo.Image")));
            this.tlsbtn_Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Nuevo.Name = "tlsbtn_Nuevo";
            this.tlsbtn_Nuevo.Size = new System.Drawing.Size(78, 65);
            this.tlsbtn_Nuevo.Text = "Nuevo";
            this.tlsbtn_Nuevo.Click += new System.EventHandler(this.tlsbtn_Nuevo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 68);
            // 
            // tlsbtn_Eliminar
            // 
            this.tlsbtn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Eliminar.Image")));
            this.tlsbtn_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Eliminar.Name = "tlsbtn_Eliminar";
            this.tlsbtn_Eliminar.Size = new System.Drawing.Size(86, 65);
            this.tlsbtn_Eliminar.Text = "Eliminar";
            this.tlsbtn_Eliminar.Click += new System.EventHandler(this.tlsbtn_Eliminar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 68);
            // 
            // tlsbtn_Salir
            // 
            this.tlsbtn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Salir.Image")));
            this.tlsbtn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Salir.Name = "tlsbtn_Salir";
            this.tlsbtn_Salir.Size = new System.Drawing.Size(65, 65);
            this.tlsbtn_Salir.Text = "Salir";
            this.tlsbtn_Salir.Click += new System.EventHandler(this.tlsbtn_Salir_Click);
            // 
            // grpbx_Estados
            // 
            this.grpbx_Estados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_Estados.AutoSize = true;
            this.grpbx_Estados.Controls.Add(this.mTxt_Año);
            this.grpbx_Estados.Controls.Add(this.btn_Total);
            this.grpbx_Estados.Controls.Add(this.button3);
            this.grpbx_Estados.Controls.Add(this.button2);
            this.grpbx_Estados.Controls.Add(this.button1);
            this.grpbx_Estados.Controls.Add(this.dgv_Factura);
            this.grpbx_Estados.Controls.Add(this.comboBox2);
            this.grpbx_Estados.Controls.Add(this.cbx_Articulo);
            this.grpbx_Estados.Controls.Add(this.numericUpDown1);
            this.grpbx_Estados.Controls.Add(this.label5);
            this.grpbx_Estados.Controls.Add(this.label4);
            this.grpbx_Estados.Controls.Add(this.label3);
            this.grpbx_Estados.Controls.Add(this.textBox2);
            this.grpbx_Estados.Controls.Add(this.label2);
            this.grpbx_Estados.Controls.Add(this.txt_Total);
            this.grpbx_Estados.Controls.Add(this.lblTotal);
            this.grpbx_Estados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Estados.Location = new System.Drawing.Point(11, 170);
            this.grpbx_Estados.Name = "grpbx_Estados";
            this.grpbx_Estados.Size = new System.Drawing.Size(887, 316);
            this.grpbx_Estados.TabIndex = 2;
            this.grpbx_Estados.TabStop = false;
            this.grpbx_Estados.Text = "Lista de Artículos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 150);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "Anadir a la Factura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Generar Factura";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv_Factura
            // 
            this.dgv_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo});
            this.dgv_Factura.Location = new System.Drawing.Point(354, 29);
            this.dgv_Factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Factura.Name = "dgv_Factura";
            this.dgv_Factura.RowTemplate.Height = 24;
            this.dgv_Factura.Size = new System.Drawing.Size(364, 221);
            this.dgv_Factura.TabIndex = 16;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Column1";
            this.Articulo.Name = "Articulo";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(134, 94);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // cbx_Articulo
            // 
            this.cbx_Articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Articulo.FormattingEnabled = true;
            this.cbx_Articulo.Location = new System.Drawing.Point(134, 29);
            this.cbx_Articulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Articulo.Name = "cbx_Articulo";
            this.cbx_Articulo.Size = new System.Drawing.Size(92, 21);
            this.cbx_Articulo.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 63);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Etiqueta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Articulo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(806, 173);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descuento";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(806, 205);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(76, 20);
            this.txt_Total.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(731, 207);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 49);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 437);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Total
            // 
            this.btn_Total.Location = new System.Drawing.Point(122, 150);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(89, 43);
            this.btn_Total.TabIndex = 20;
            this.btn_Total.Text = "Calcular Total";
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.button4_Click);
            // 
            // mTxt_Año
            // 
            this.mTxt_Año.Location = new System.Drawing.Point(246, 94);
            this.mTxt_Año.Mask = "9999";
            this.mTxt_Año.Name = "mTxt_Año";
            this.mTxt_Año.Size = new System.Drawing.Size(61, 20);
            this.mTxt_Año.TabIndex = 21;
            // 
            // Frm_Listar_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(901, 486);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grpbx_Estados);
            this.Controls.Add(this.tbctrl_Principal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Listar_Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbctrl_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tlstrp_Funciones_Basicas.ResumeLayout(false);
            this.tlstrp_Funciones_Basicas.PerformLayout();
            this.grpbx_Estados.ResumeLayout(false);
            this.grpbx_Estados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrl_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip tlstrp_Funciones_Basicas;
        private System.Windows.Forms.ToolStripButton tlsbtn_Editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsbtn_Refrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsbtn_Nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tlsbtn_Salir;
        private System.Windows.Forms.GroupBox grpbx_Estados;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tlsbtn_Buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tlsbtn_Eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox tlstrp_txt_Busqueda;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_Factura;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbx_Articulo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.MaskedTextBox mTxt_Año;
    }
}