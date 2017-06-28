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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.cbx_Articulo = new System.Windows.Forms.ComboBox();
            this.cbx_Mes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Generar_Factura = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.mTxt_Año = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Factura = new System.Windows.Forms.DataGridView();
            this.grpbx_Estados = new System.Windows.Forms.GroupBox();
            this.tbctrl_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).BeginInit();
            this.grpbx_Estados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrl_Principal
            // 
            this.tbctrl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrl_Principal.Controls.Add(this.tabPage1);
            this.tbctrl_Principal.Location = new System.Drawing.Point(7, 60);
            this.tbctrl_Principal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbctrl_Principal.Name = "tbctrl_Principal";
            this.tbctrl_Principal.SelectedIndex = 0;
            this.tbctrl_Principal.Size = new System.Drawing.Size(1195, 123);
            this.tbctrl_Principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1187, 94);
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
            this.tlsbtn_Refrescar,
            this.toolStripSeparator1,
            this.tlsbtn_Editar,
            this.toolStripSeparator2,
            this.tlsbtn_Eliminar,
            this.toolStripSeparator6,
            this.tlsbtn_Salir});
            this.tlstrp_Funciones_Basicas.Location = new System.Drawing.Point(4, 4);
            this.tlstrp_Funciones_Basicas.Name = "tlstrp_Funciones_Basicas";
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(1179, 86);
            this.tlstrp_Funciones_Basicas.TabIndex = 0;
            this.tlstrp_Funciones_Basicas.Text = "toolStrip1";
            // 
            // tlsbtn_Refrescar
            // 
            this.tlsbtn_Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Refrescar.Image")));
            this.tlsbtn_Refrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Refrescar.Name = "tlsbtn_Refrescar";
            this.tlsbtn_Refrescar.Size = new System.Drawing.Size(106, 83);
            this.tlsbtn_Refrescar.Text = "Refrescar";
            this.tlsbtn_Refrescar.Click += new System.EventHandler(this.tlsbtn_Refrescar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // tlsbtn_Editar
            // 
            this.tlsbtn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Editar.Image")));
            this.tlsbtn_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Editar.Name = "tlsbtn_Editar";
            this.tlsbtn_Editar.Size = new System.Drawing.Size(84, 83);
            this.tlsbtn_Editar.Text = "Editar";
            this.tlsbtn_Editar.Click += new System.EventHandler(this.tlsbtn_Editar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 86);
            // 
            // tlsbtn_Eliminar
            // 
            this.tlsbtn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Eliminar.Image")));
            this.tlsbtn_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Eliminar.Name = "tlsbtn_Eliminar";
            this.tlsbtn_Eliminar.Size = new System.Drawing.Size(99, 83);
            this.tlsbtn_Eliminar.Text = "Eliminar";
            this.tlsbtn_Eliminar.Click += new System.EventHandler(this.tlsbtn_Eliminar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 86);
            // 
            // tlsbtn_Salir
            // 
            this.tlsbtn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Salir.Image")));
            this.tlsbtn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Salir.Name = "tlsbtn_Salir";
            this.tlsbtn_Salir.Size = new System.Drawing.Size(74, 83);
            this.tlsbtn_Salir.Text = "Salir";
            this.tlsbtn_Salir.Click += new System.EventHandler(this.tlsbtn_Salir_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 60);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 538);
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
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1201, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(864, 346);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(936, 346);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(100, 22);
            this.txt_Total.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Articulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Etiqueta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(179, 78);
            this.nud_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(120, 22);
            this.nud_Cantidad.TabIndex = 12;
            // 
            // cbx_Articulo
            // 
            this.cbx_Articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Articulo.FormattingEnabled = true;
            this.cbx_Articulo.Location = new System.Drawing.Point(179, 36);
            this.cbx_Articulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Articulo.Name = "cbx_Articulo";
            this.cbx_Articulo.Size = new System.Drawing.Size(121, 24);
            this.cbx_Articulo.TabIndex = 13;
            // 
            // cbx_Mes
            // 
            this.cbx_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Mes.FormattingEnabled = true;
            this.cbx_Mes.Items.AddRange(new object[] {
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
            this.cbx_Mes.Location = new System.Drawing.Point(179, 116);
            this.cbx_Mes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Mes.Name = "cbx_Mes";
            this.cbx_Mes.Size = new System.Drawing.Size(121, 24);
            this.cbx_Mes.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 68);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Generar_Factura
            // 
            this.btn_Generar_Factura.Location = new System.Drawing.Point(723, 320);
            this.btn_Generar_Factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Generar_Factura.Name = "btn_Generar_Factura";
            this.btn_Generar_Factura.Size = new System.Drawing.Size(100, 68);
            this.btn_Generar_Factura.TabIndex = 18;
            this.btn_Generar_Factura.Text = "Generar Factura";
            this.btn_Generar_Factura.UseVisualStyleBackColor = true;
            this.btn_Generar_Factura.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 182);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 70);
            this.button3.TabIndex = 19;
            this.button3.Text = "Anadir a la Factura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Total
            // 
            this.btn_Total.Location = new System.Drawing.Point(268, 182);
            this.btn_Total.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(107, 70);
            this.btn_Total.TabIndex = 20;
            this.btn_Total.Text = "Calcular Total";
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.button4_Click);
            // 
            // mTxt_Año
            // 
            this.mTxt_Año.Location = new System.Drawing.Point(328, 116);
            this.mTxt_Año.Margin = new System.Windows.Forms.Padding(4);
            this.mTxt_Año.Mask = "9999";
            this.mTxt_Año.Name = "mTxt_Año";
            this.mTxt_Año.Size = new System.Drawing.Size(80, 22);
            this.mTxt_Año.TabIndex = 21;
            this.mTxt_Año.Text = "2017";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Factura);
            this.groupBox1.Location = new System.Drawing.Point(483, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(671, 273);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos a Facturar";
            // 
            // dgv_Factura
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Factura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Factura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Factura.Location = new System.Drawing.Point(4, 19);
            this.dgv_Factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Factura.Name = "dgv_Factura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Factura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Factura.RowTemplate.Height = 24;
            this.dgv_Factura.ShowEditingIcon = false;
            this.dgv_Factura.Size = new System.Drawing.Size(663, 250);
            this.dgv_Factura.TabIndex = 16;
            this.dgv_Factura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Factura_CellContentClick);
            // 
            // grpbx_Estados
            // 
            this.grpbx_Estados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_Estados.AutoSize = true;
            this.grpbx_Estados.Controls.Add(this.groupBox1);
            this.grpbx_Estados.Controls.Add(this.mTxt_Año);
            this.grpbx_Estados.Controls.Add(this.btn_Total);
            this.grpbx_Estados.Controls.Add(this.button3);
            this.grpbx_Estados.Controls.Add(this.btn_Generar_Factura);
            this.grpbx_Estados.Controls.Add(this.button1);
            this.grpbx_Estados.Controls.Add(this.cbx_Mes);
            this.grpbx_Estados.Controls.Add(this.cbx_Articulo);
            this.grpbx_Estados.Controls.Add(this.nud_Cantidad);
            this.grpbx_Estados.Controls.Add(this.label5);
            this.grpbx_Estados.Controls.Add(this.label4);
            this.grpbx_Estados.Controls.Add(this.label3);
            this.grpbx_Estados.Controls.Add(this.txt_Total);
            this.grpbx_Estados.Controls.Add(this.lblTotal);
            this.grpbx_Estados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Estados.Location = new System.Drawing.Point(15, 191);
            this.grpbx_Estados.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_Estados.Name = "grpbx_Estados";
            this.grpbx_Estados.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_Estados.Size = new System.Drawing.Size(1183, 415);
            this.grpbx_Estados.TabIndex = 2;
            this.grpbx_Estados.TabStop = false;
            this.grpbx_Estados.Text = "Lista de Artículos";
            // 
            // Frm_Listar_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1201, 598);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grpbx_Estados);
            this.Controls.Add(this.tbctrl_Principal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).EndInit();
            this.grpbx_Estados.ResumeLayout(false);
            this.grpbx_Estados.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton tlsbtn_Salir;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tlsbtn_Eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.ComboBox cbx_Articulo;
        private System.Windows.Forms.ComboBox cbx_Mes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Generar_Factura;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.MaskedTextBox mTxt_Año;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Factura;
        private System.Windows.Forms.GroupBox grpbx_Estados;
    }
}