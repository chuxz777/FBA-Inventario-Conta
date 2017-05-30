namespace Cls_PL
{
    partial class Frm_Modificar_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Inventario));
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_Editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.grpbx_Estados = new System.Windows.Forms.GroupBox();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_Objetivo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Color = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Departamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_Articulo = new System.Windows.Forms.ComboBox();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPicker_Mes_Año = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tbctrl_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
            this.grpbx_Estados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tbctrl_Principal
            // 
            this.tbctrl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrl_Principal.Controls.Add(this.tabPage1);
            this.tbctrl_Principal.Location = new System.Drawing.Point(7, 60);
            this.tbctrl_Principal.Margin = new System.Windows.Forms.Padding(4);
            this.tbctrl_Principal.Name = "tbctrl_Principal";
            this.tbctrl_Principal.SelectedIndex = 0;
            this.tbctrl_Principal.Size = new System.Drawing.Size(949, 123);
            this.tbctrl_Principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(941, 94);
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
            this.tlsbtn_Editar,
            this.toolStripSeparator2,
            this.tlsbtn_Nuevo,
            this.toolStripSeparator5,
            this.tlsbtn_Eliminar,
            this.toolStripSeparator6,
            this.tlsbtn_Salir});
            this.tlstrp_Funciones_Basicas.Location = new System.Drawing.Point(4, 4);
            this.tlstrp_Funciones_Basicas.Name = "tlstrp_Funciones_Basicas";
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(933, 86);
            this.tlstrp_Funciones_Basicas.TabIndex = 0;
            this.tlstrp_Funciones_Basicas.Text = "toolStrip1";
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
            // tlsbtn_Nuevo
            // 
            this.tlsbtn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Nuevo.Image")));
            this.tlsbtn_Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Nuevo.Name = "tlsbtn_Nuevo";
            this.tlsbtn_Nuevo.Size = new System.Drawing.Size(88, 83);
            this.tlsbtn_Nuevo.Text = "Nuevo";
            this.tlsbtn_Nuevo.Click += new System.EventHandler(this.tlsbtn_Nuevo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 86);
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
            // grpbx_Estados
            // 
            this.grpbx_Estados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_Estados.AutoSize = true;
            this.grpbx_Estados.Controls.Add(this.maskedTextBox1);
            this.grpbx_Estados.Controls.Add(this.dtPicker_Mes_Año);
            this.grpbx_Estados.Controls.Add(this.cbx_Estado);
            this.grpbx_Estados.Controls.Add(this.label8);
            this.grpbx_Estados.Controls.Add(this.cbx_Objetivo);
            this.grpbx_Estados.Controls.Add(this.label7);
            this.grpbx_Estados.Controls.Add(this.cbx_Color);
            this.grpbx_Estados.Controls.Add(this.label6);
            this.grpbx_Estados.Controls.Add(this.cbx_Departamento);
            this.grpbx_Estados.Controls.Add(this.label2);
            this.grpbx_Estados.Controls.Add(this.button3);
            this.grpbx_Estados.Controls.Add(this.button1);
            this.grpbx_Estados.Controls.Add(this.cbx_Articulo);
            this.grpbx_Estados.Controls.Add(this.nud_Cantidad);
            this.grpbx_Estados.Controls.Add(this.label5);
            this.grpbx_Estados.Controls.Add(this.label4);
            this.grpbx_Estados.Controls.Add(this.label3);
            this.grpbx_Estados.Controls.Add(this.lblTotal);
            this.grpbx_Estados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Estados.Location = new System.Drawing.Point(72, 225);
            this.grpbx_Estados.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_Estados.Name = "grpbx_Estados";
            this.grpbx_Estados.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_Estados.Size = new System.Drawing.Size(818, 348);
            this.grpbx_Estados.TabIndex = 2;
            this.grpbx_Estados.TabStop = false;
            this.grpbx_Estados.Text = "Lista de Artículos";
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Location = new System.Drawing.Point(575, 131);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(206, 24);
            this.cbx_Estado.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(472, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Estado";
            // 
            // cbx_Objetivo
            // 
            this.cbx_Objetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Objetivo.FormattingEnabled = true;
            this.cbx_Objetivo.Location = new System.Drawing.Point(575, 89);
            this.cbx_Objetivo.Name = "cbx_Objetivo";
            this.cbx_Objetivo.Size = new System.Drawing.Size(206, 24);
            this.cbx_Objetivo.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(472, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Objetivo";
            // 
            // cbx_Color
            // 
            this.cbx_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Color.FormattingEnabled = true;
            this.cbx_Color.Location = new System.Drawing.Point(575, 48);
            this.cbx_Color.Name = "cbx_Color";
            this.cbx_Color.Size = new System.Drawing.Size(206, 24);
            this.cbx_Color.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(472, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Color";
            // 
            // cbx_Departamento
            // 
            this.cbx_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Departamento.FormattingEnabled = true;
            this.cbx_Departamento.Location = new System.Drawing.Point(213, 92);
            this.cbx_Departamento.Name = "cbx_Departamento";
            this.cbx_Departamento.Size = new System.Drawing.Size(206, 24);
            this.cbx_Departamento.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(75, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Departamento";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 53);
            this.button3.TabIndex = 19;
            this.button3.Text = "Anadir al Inventario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbx_Articulo
            // 
            this.cbx_Articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Articulo.FormattingEnabled = true;
            this.cbx_Articulo.Location = new System.Drawing.Point(214, 51);
            this.cbx_Articulo.Name = "cbx_Articulo";
            this.cbx_Articulo.Size = new System.Drawing.Size(205, 24);
            this.cbx_Articulo.TabIndex = 13;
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(575, 173);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(206, 22);
            this.nud_Cantidad.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(68, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Etiqueta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(468, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Articulo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(75, 138);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Precio";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 60);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 538);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(955, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registrar Articulos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtPicker_Mes_Año
            // 
            this.dtPicker_Mes_Año.CustomFormat = "MM-yyyy";
            this.dtPicker_Mes_Año.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_Mes_Año.Location = new System.Drawing.Point(214, 173);
            this.dtPicker_Mes_Año.Name = "dtPicker_Mes_Año";
            this.dtPicker_Mes_Año.Size = new System.Drawing.Size(205, 22);
            this.dtPicker_Mes_Año.TabIndex = 28;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Culture = new System.Globalization.CultureInfo("es-CR");
            this.maskedTextBox1.Location = new System.Drawing.Point(214, 134);
            this.maskedTextBox1.Mask = "$9999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(205, 22);
            this.maskedTextBox1.TabIndex = 29;
            // 
            // Frm_Modificar_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(955, 598);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grpbx_Estados);
            this.Controls.Add(this.tbctrl_Principal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Inventario";
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrl_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip tlstrp_Funciones_Basicas;
        private System.Windows.Forms.ToolStripButton tlsbtn_Editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsbtn_Nuevo;
        private System.Windows.Forms.ToolStripButton tlsbtn_Salir;
        private System.Windows.Forms.GroupBox grpbx_Estados;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tlsbtn_Eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_Articulo;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Objetivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Color;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Departamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPicker_Mes_Año;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}