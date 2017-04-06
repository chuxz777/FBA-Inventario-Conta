namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    partial class Frm_Modificar_Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Roles));
            this.label1 = new System.Windows.Forms.Label();
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.grpbx_Clientes = new System.Windows.Forms.GroupBox();
            this.txt_Descripcion_Rol = new System.Windows.Forms.TextBox();
            this.cbx_Estado_Rol = new System.Windows.Forms.ComboBox();
            this.txt_Nombre_Rol = new System.Windows.Forms.TextBox();
            this.lbl_Id_Sucursal = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Nombre_Rol = new System.Windows.Forms.Label();
            this.lbl_Codigo_Rol = new System.Windows.Forms.Label();
            this.txt_Codigo_Rol = new System.Windows.Forms.TextBox();
            this.tbctrl_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
            this.grpbx_Clientes.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(674, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clinica Odontológica Perla Blanca - Roles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbctrl_Principal
            // 
            this.tbctrl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrl_Principal.Controls.Add(this.tabPage1);
            this.tbctrl_Principal.Location = new System.Drawing.Point(5, 52);
            this.tbctrl_Principal.Name = "tbctrl_Principal";
            this.tbctrl_Principal.SelectedIndex = 0;
            this.tbctrl_Principal.Size = new System.Drawing.Size(669, 100);
            this.tbctrl_Principal.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlstrp_Funciones_Basicas
            // 
            this.tlstrp_Funciones_Basicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlstrp_Funciones_Basicas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlstrp_Funciones_Basicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtn_Guardar,
            this.toolStripSeparator2,
            this.tlsbtn_Salir});
            this.tlstrp_Funciones_Basicas.Location = new System.Drawing.Point(3, 3);
            this.tlstrp_Funciones_Basicas.Name = "tlstrp_Funciones_Basicas";
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(655, 68);
            this.tlstrp_Funciones_Basicas.TabIndex = 0;
            this.tlstrp_Funciones_Basicas.Text = "toolStrip1";
            // 
            // tlsbtn_Guardar
            // 
            this.tlsbtn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Guardar.Image")));
            this.tlsbtn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Guardar.Name = "tlsbtn_Guardar";
            this.tlsbtn_Guardar.Size = new System.Drawing.Size(85, 65);
            this.tlsbtn_Guardar.Text = "Guardar";
            this.tlsbtn_Guardar.Click += new System.EventHandler(this.tlsbtn_Guardar_Click);
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
            // grpbx_Clientes
            // 
            this.grpbx_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_Clientes.AutoSize = true;
            this.grpbx_Clientes.Controls.Add(this.txt_Descripcion_Rol);
            this.grpbx_Clientes.Controls.Add(this.cbx_Estado_Rol);
            this.grpbx_Clientes.Controls.Add(this.txt_Nombre_Rol);
            this.grpbx_Clientes.Controls.Add(this.lbl_Id_Sucursal);
            this.grpbx_Clientes.Controls.Add(this.lbl_Estado);
            this.grpbx_Clientes.Controls.Add(this.lbl_Nombre_Rol);
            this.grpbx_Clientes.Controls.Add(this.lbl_Codigo_Rol);
            this.grpbx_Clientes.Controls.Add(this.txt_Codigo_Rol);
            this.grpbx_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Clientes.Location = new System.Drawing.Point(12, 158);
            this.grpbx_Clientes.Name = "grpbx_Clientes";
            this.grpbx_Clientes.Size = new System.Drawing.Size(655, 146);
            this.grpbx_Clientes.TabIndex = 9;
            this.grpbx_Clientes.TabStop = false;
            this.grpbx_Clientes.Text = "Datos de Roles";
            // 
            // txt_Descripcion_Rol
            // 
            this.txt_Descripcion_Rol.Location = new System.Drawing.Point(190, 75);
            this.txt_Descripcion_Rol.MaxLength = 250;
            this.txt_Descripcion_Rol.Name = "txt_Descripcion_Rol";
            this.txt_Descripcion_Rol.Size = new System.Drawing.Size(377, 20);
            this.txt_Descripcion_Rol.TabIndex = 21;
            // 
            // cbx_Estado_Rol
            // 
            this.cbx_Estado_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Estado_Rol.FormattingEnabled = true;
            this.cbx_Estado_Rol.Location = new System.Drawing.Point(190, 101);
            this.cbx_Estado_Rol.Name = "cbx_Estado_Rol";
            this.cbx_Estado_Rol.Size = new System.Drawing.Size(143, 21);
            this.cbx_Estado_Rol.TabIndex = 20;
            // 
            // txt_Nombre_Rol
            // 
            this.txt_Nombre_Rol.Location = new System.Drawing.Point(444, 49);
            this.txt_Nombre_Rol.MaxLength = 25;
            this.txt_Nombre_Rol.Name = "txt_Nombre_Rol";
            this.txt_Nombre_Rol.Size = new System.Drawing.Size(123, 20);
            this.txt_Nombre_Rol.TabIndex = 12;
            // 
            // lbl_Id_Sucursal
            // 
            this.lbl_Id_Sucursal.AutoSize = true;
            this.lbl_Id_Sucursal.Location = new System.Drawing.Point(72, 78);
            this.lbl_Id_Sucursal.Name = "lbl_Id_Sucursal";
            this.lbl_Id_Sucursal.Size = new System.Drawing.Size(102, 13);
            this.lbl_Id_Sucursal.TabIndex = 10;
            this.lbl_Id_Sucursal.Text = "Descripcion del Rol:";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(72, 104);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_Estado.TabIndex = 9;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_Nombre_Rol
            // 
            this.lbl_Nombre_Rol.AutoSize = true;
            this.lbl_Nombre_Rol.Location = new System.Drawing.Point(355, 52);
            this.lbl_Nombre_Rol.Name = "lbl_Nombre_Rol";
            this.lbl_Nombre_Rol.Size = new System.Drawing.Size(83, 13);
            this.lbl_Nombre_Rol.TabIndex = 2;
            this.lbl_Nombre_Rol.Text = "Nombre del Rol:";
            // 
            // lbl_Codigo_Rol
            // 
            this.lbl_Codigo_Rol.AutoSize = true;
            this.lbl_Codigo_Rol.Location = new System.Drawing.Point(72, 52);
            this.lbl_Codigo_Rol.Name = "lbl_Codigo_Rol";
            this.lbl_Codigo_Rol.Size = new System.Drawing.Size(62, 13);
            this.lbl_Codigo_Rol.TabIndex = 1;
            this.lbl_Codigo_Rol.Text = "Codigo Rol:";
            // 
            // txt_Codigo_Rol
            // 
            this.txt_Codigo_Rol.Enabled = false;
            this.txt_Codigo_Rol.Location = new System.Drawing.Point(190, 49);
            this.txt_Codigo_Rol.Name = "txt_Codigo_Rol";
            this.txt_Codigo_Rol.Size = new System.Drawing.Size(143, 20);
            this.txt_Codigo_Rol.TabIndex = 0;
            // 
            // Frm_Modificar_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(674, 316);
            this.Controls.Add(this.grpbx_Clientes);
            this.Controls.Add(this.tbctrl_Principal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Modificar_Roles_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Modificar_Roles_Load);
            this.tbctrl_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tlstrp_Funciones_Basicas.ResumeLayout(false);
            this.tlstrp_Funciones_Basicas.PerformLayout();
            this.grpbx_Clientes.ResumeLayout(false);
            this.grpbx_Clientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbctrl_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip tlstrp_Funciones_Basicas;
        private System.Windows.Forms.ToolStripButton tlsbtn_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsbtn_Salir;
        private System.Windows.Forms.GroupBox grpbx_Clientes;
        private System.Windows.Forms.TextBox txt_Descripcion_Rol;
        private System.Windows.Forms.ComboBox cbx_Estado_Rol;
        private System.Windows.Forms.TextBox txt_Nombre_Rol;
        private System.Windows.Forms.Label lbl_Id_Sucursal;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Nombre_Rol;
        private System.Windows.Forms.Label lbl_Codigo_Rol;
        private System.Windows.Forms.TextBox txt_Codigo_Rol;
    }
}