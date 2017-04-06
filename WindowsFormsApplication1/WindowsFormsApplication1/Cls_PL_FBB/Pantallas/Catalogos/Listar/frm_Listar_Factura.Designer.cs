namespace Cls_PL.Pantallas.Catalogos.Listar
{
    partial class frm_Listar_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Listar_Factura));
            this.grpbx_Activos = new System.Windows.Forms.GroupBox();
            this.dgv_Factura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_filtrar_Factura = new System.Windows.Forms.TextBox();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Anular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Buscar = new System.Windows.Forms.ToolStripLabel();
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.grpbx_Activos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
            this.tbctrl_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_Activos
            // 
            this.grpbx_Activos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_Activos.AutoSize = true;
            this.grpbx_Activos.Controls.Add(this.dgv_Factura);
            this.grpbx_Activos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Activos.Location = new System.Drawing.Point(5, 158);
            this.grpbx_Activos.Name = "grpbx_Activos";
            this.grpbx_Activos.Size = new System.Drawing.Size(1041, 289);
            this.grpbx_Activos.TabIndex = 10;
            this.grpbx_Activos.TabStop = false;
            this.grpbx_Activos.Text = "Listar Activos";
            // 
            // dgv_Factura
            // 
            this.dgv_Factura.AllowUserToAddRows = false;
            this.dgv_Factura.AllowUserToDeleteRows = false;
            this.dgv_Factura.AllowUserToResizeColumns = false;
            this.dgv_Factura.AllowUserToResizeRows = false;
            this.dgv_Factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Factura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Factura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Factura.Location = new System.Drawing.Point(3, 16);
            this.dgv_Factura.MultiSelect = false;
            this.dgv_Factura.Name = "dgv_Factura";
            this.dgv_Factura.ReadOnly = true;
            this.dgv_Factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Factura.Size = new System.Drawing.Size(1035, 270);
            this.dgv_Factura.TabIndex = 1;
            this.dgv_Factura.DoubleClick += new System.EventHandler(this.dgv_Factura_DoubleClick);
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
            this.label1.Size = new System.Drawing.Size(1046, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clinica Odontológica Perla Blanca - Facturas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_filtrar_Factura);
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_filtrar_Factura
            // 
            this.txt_filtrar_Factura.Location = new System.Drawing.Point(474, 27);
            this.txt_filtrar_Factura.Name = "txt_filtrar_Factura";
            this.txt_filtrar_Factura.Size = new System.Drawing.Size(452, 20);
            this.txt_filtrar_Factura.TabIndex = 1;
            this.txt_filtrar_Factura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tlstrp_Funciones_Basicas
            // 
            this.tlstrp_Funciones_Basicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlstrp_Funciones_Basicas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlstrp_Funciones_Basicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtn_Refrescar,
            this.toolStripSeparator1,
            this.tlsbtn_Nuevo,
            this.toolStripSeparator4,
            this.tlsbtn_Anular,
            this.toolStripSeparator2,
            this.tlsbtn_Salir,
            this.toolStripSeparator5,
            this.tlsbtn_Buscar});
            this.tlstrp_Funciones_Basicas.Location = new System.Drawing.Point(3, 3);
            this.tlstrp_Funciones_Basicas.Name = "tlstrp_Funciones_Basicas";
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(1031, 68);
            this.tlstrp_Funciones_Basicas.TabIndex = 0;
            this.tlstrp_Funciones_Basicas.Text = "toolStrip1";
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 68);
            // 
            // tlsbtn_Anular
            // 
            this.tlsbtn_Anular.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Anular.Image")));
            this.tlsbtn_Anular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Anular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Anular.Name = "tlsbtn_Anular";
            this.tlsbtn_Anular.Size = new System.Drawing.Size(118, 65);
            this.tlsbtn_Anular.Text = "Anular factura";
            this.tlsbtn_Anular.Click += new System.EventHandler(this.tlsbtn_Anular_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 68);
            // 
            // tlsbtn_Buscar
            // 
            this.tlsbtn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Buscar.Image")));
            this.tlsbtn_Buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Buscar.Name = "tlsbtn_Buscar";
            this.tlsbtn_Buscar.Size = new System.Drawing.Size(74, 65);
            this.tlsbtn_Buscar.Text = "Buscar";
            // 
            // tbctrl_Principal
            // 
            this.tbctrl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrl_Principal.Controls.Add(this.tabPage1);
            this.tbctrl_Principal.Location = new System.Drawing.Point(1, 52);
            this.tbctrl_Principal.Name = "tbctrl_Principal";
            this.tbctrl_Principal.SelectedIndex = 0;
            this.tbctrl_Principal.Size = new System.Drawing.Size(1045, 100);
            this.tbctrl_Principal.TabIndex = 9;
            // 
            // frm_Listar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1046, 459);
            this.Controls.Add(this.grpbx_Activos);
            this.Controls.Add(this.tbctrl_Principal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Listar_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Facturas";
            this.Load += new System.EventHandler(this.fmr_listar_Factura_Load);
            this.grpbx_Activos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factura)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tlstrp_Funciones_Basicas.ResumeLayout(false);
            this.tlstrp_Funciones_Basicas.PerformLayout();
            this.tbctrl_Principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_Activos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip tlstrp_Funciones_Basicas;
        private System.Windows.Forms.ToolStripButton tlsbtn_Refrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsbtn_Nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TabControl tbctrl_Principal;
        private System.Windows.Forms.ToolStripButton tlsbtn_Anular;
        private System.Windows.Forms.ToolStripLabel tlsbtn_Buscar;
        private System.Windows.Forms.DataGridView dgv_Factura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsbtn_Salir;
        private System.Windows.Forms.TextBox txt_filtrar_Factura;
    }
}