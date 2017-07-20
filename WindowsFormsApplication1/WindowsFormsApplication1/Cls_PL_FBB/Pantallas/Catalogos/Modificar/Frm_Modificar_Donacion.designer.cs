namespace Cls_PL
{
    partial class Frm_Modificar_Donacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Donacion));
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
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.dtPicker_Mes_Año = new System.Windows.Forms.DateTimePicker();
            this.btn_Añadir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbctrl_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
            this.grpbx_Estados.SuspendLayout();
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
            this.grpbx_Estados.Controls.Add(this.label2);
            this.grpbx_Estados.Controls.Add(this.txtComentario);
            this.grpbx_Estados.Controls.Add(this.txt_Precio);
            this.grpbx_Estados.Controls.Add(this.dtPicker_Mes_Año);
            this.grpbx_Estados.Controls.Add(this.btn_Añadir);
            this.grpbx_Estados.Controls.Add(this.button1);
            this.grpbx_Estados.Controls.Add(this.label5);
            this.grpbx_Estados.Controls.Add(this.lblTotal);
            this.grpbx_Estados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Estados.Location = new System.Drawing.Point(72, 225);
            this.grpbx_Estados.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_Estados.Name = "grpbx_Estados";
            this.grpbx_Estados.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_Estados.Size = new System.Drawing.Size(819, 348);
            this.grpbx_Estados.TabIndex = 2;
            this.grpbx_Estados.TabStop = false;
            this.grpbx_Estados.Text = "Registrar Donacion";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(225, 83);
            this.txt_Precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(205, 22);
            this.txt_Precio.TabIndex = 1;
            // 
            // dtPicker_Mes_Año
            // 
            this.dtPicker_Mes_Año.CustomFormat = "dd-MM-yyyy";
            this.dtPicker_Mes_Año.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_Mes_Año.Location = new System.Drawing.Point(225, 124);
            this.dtPicker_Mes_Año.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPicker_Mes_Año.Name = "dtPicker_Mes_Año";
            this.dtPicker_Mes_Año.Size = new System.Drawing.Size(205, 22);
            this.dtPicker_Mes_Año.TabIndex = 2;
            this.dtPicker_Mes_Año.ValueChanged += new System.EventHandler(this.dtPicker_Mes_Año_ValueChanged);
            // 
            // btn_Añadir
            // 
            this.btn_Añadir.Location = new System.Drawing.Point(268, 252);
            this.btn_Añadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Añadir.Name = "btn_Añadir";
            this.btn_Añadir.Size = new System.Drawing.Size(104, 53);
            this.btn_Añadir.TabIndex = 19;
            this.btn_Añadir.Text = "Anadir al Inventario";
            this.btn_Añadir.UseVisualStyleBackColor = true;
            this.btn_Añadir.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(70, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Donacion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(70, 83);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Monto";
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
            this.label1.Text = "Registrar Donaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(225, 162);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(395, 64);
            this.txtComentario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Comentario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_Modificar_Donacion
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
            this.Name = "Frm_Modificar_Donacion";
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
        private System.Windows.Forms.Button btn_Añadir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPicker_Mes_Año;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComentario;
    }
}