namespace Cls_PL.Pantallas.Catalogos.Listar
{
    partial class frm_Listar_TipoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Listar_TipoEmpleado));
            this.grpbx_Productos = new System.Windows.Forms.GroupBox();
            this.dgv_tipoEmpleado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.txt_TipoEmpleado = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.grpbx_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoEmpleado)).BeginInit();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbctrl_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_Productos
            // 
            this.grpbx_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_Productos.AutoSize = true;
            this.grpbx_Productos.Controls.Add(this.dgv_tipoEmpleado);
            this.grpbx_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Productos.Location = new System.Drawing.Point(5, 155);
            this.grpbx_Productos.Name = "grpbx_Productos";
            this.grpbx_Productos.Size = new System.Drawing.Size(896, 338);
            this.grpbx_Productos.TabIndex = 6;
            this.grpbx_Productos.TabStop = false;
            this.grpbx_Productos.Text = "Lista de Tipo Empleado";
            // 
            // dgv_tipoEmpleado
            // 
            this.dgv_tipoEmpleado.AllowUserToAddRows = false;
            this.dgv_tipoEmpleado.AllowUserToDeleteRows = false;
            this.dgv_tipoEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tipoEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_tipoEmpleado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tipoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_tipoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tipoEmpleado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tipoEmpleado.Location = new System.Drawing.Point(3, 16);
            this.dgv_tipoEmpleado.MultiSelect = false;
            this.dgv_tipoEmpleado.Name = "dgv_tipoEmpleado";
            this.dgv_tipoEmpleado.ReadOnly = true;
            this.dgv_tipoEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tipoEmpleado.Size = new System.Drawing.Size(890, 319);
            this.dgv_tipoEmpleado.TabIndex = 1;
            this.dgv_tipoEmpleado.DoubleClick += new System.EventHandler(this.dgv_tipoEmpleado_DoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clinica Odontológica Perla Blanca - Tipo Empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tlsbtn_Buscar.Size = new System.Drawing.Size(78, 65);
            this.tlsbtn_Buscar.Text = "Buscar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 68);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
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
            // tlstrp_Funciones_Basicas
            // 
            this.tlstrp_Funciones_Basicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlstrp_Funciones_Basicas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlstrp_Funciones_Basicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtn_Buscar,
            this.txt_TipoEmpleado,
            this.toolStripSeparator4,
            this.tlsbtn_Refrescar,
            this.toolStripSeparator1,
            this.tlsbtn_Editar,
            this.toolStripSeparator2,
            this.tlsbtn_Nuevo,
            this.toolStripSeparator3,
            this.tlsbtn_Eliminar,
            this.toolStripSeparator5,
            this.tlsbtn_Salir});
            this.tlstrp_Funciones_Basicas.Location = new System.Drawing.Point(3, 3);
            this.tlstrp_Funciones_Basicas.Name = "tlstrp_Funciones_Basicas";
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(882, 68);
            this.tlstrp_Funciones_Basicas.TabIndex = 0;
            this.tlstrp_Funciones_Basicas.Text = "toolStrip1";
            // 
            // txt_TipoEmpleado
            // 
            this.txt_TipoEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_TipoEmpleado.Name = "txt_TipoEmpleado";
            this.txt_TipoEmpleado.Size = new System.Drawing.Size(200, 68);
            this.txt_TipoEmpleado.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 68);
            // 
            // tlsbtn_Eliminar
            // 
            this.tlsbtn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Eliminar.Image")));
            this.tlsbtn_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Eliminar.Name = "tlsbtn_Eliminar";
            this.tlsbtn_Eliminar.Size = new System.Drawing.Size(86, 65);
            this.tlsbtn_Eliminar.Text = "Eliminar";
            this.tlsbtn_Eliminar.Click += new System.EventHandler(this.tlsbtn_Eliminar_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 505);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
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
            this.tbctrl_Principal.TabIndex = 5;
            // 
            // frm_Listar_TipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(901, 505);
            this.Controls.Add(this.grpbx_Productos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbctrl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Listar_TipoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Tipo Empleado";
            this.Load += new System.EventHandler(this.frm_Listar_TipoEmpleado_Load);
            this.grpbx_Productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoEmpleado)).EndInit();
            this.tlstrp_Funciones_Basicas.ResumeLayout(false);
            this.tlstrp_Funciones_Basicas.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbctrl_Principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_Productos;
        private System.Windows.Forms.DataGridView dgv_tipoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tlsbtn_Salir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tlsbtn_Buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tlsbtn_Nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsbtn_Editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsbtn_Refrescar;
        private System.Windows.Forms.ToolStrip tlstrp_Funciones_Basicas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tbctrl_Principal;
        private System.Windows.Forms.ToolStripTextBox txt_TipoEmpleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlsbtn_Eliminar;

    }
}