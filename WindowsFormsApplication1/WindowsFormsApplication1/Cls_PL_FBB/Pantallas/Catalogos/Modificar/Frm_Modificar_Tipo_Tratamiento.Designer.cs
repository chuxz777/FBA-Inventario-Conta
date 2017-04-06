namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    partial class Frm_Modificar_Tipo_Tratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Tipo_Tratamiento));
            this.label1 = new System.Windows.Forms.Label();
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_Guardar_Modificar_TipoTratamiento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.grpbx_Clientes = new System.Windows.Forms.GroupBox();
            this.Cmbx_Estado_Modificar_TipoTratamiento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Costo_Modificar_TipoTratamiento = new System.Windows.Forms.TextBox();
            this.txt_Descripcion_Modificar_TipoTratamiento = new System.Windows.Forms.TextBox();
            this.lbl_Apellido_2 = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Codigo_Cliente = new System.Windows.Forms.Label();
            this.txt_Codigo_Modificar_TipoTratamiento = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(695, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clinica Odontológica Perla Blanca - Tipos de tratamientos ";
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
            this.tbctrl_Principal.Size = new System.Drawing.Size(690, 100);
            this.tbctrl_Principal.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlstrp_Funciones_Basicas
            // 
            this.tlstrp_Funciones_Basicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlstrp_Funciones_Basicas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlstrp_Funciones_Basicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtn_Guardar_Modificar_TipoTratamiento,
            this.toolStripSeparator5,
            this.tlsbtn_Salir});
            this.tlstrp_Funciones_Basicas.Location = new System.Drawing.Point(3, 3);
            this.tlstrp_Funciones_Basicas.Name = "tlstrp_Funciones_Basicas";
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(676, 68);
            this.tlstrp_Funciones_Basicas.TabIndex = 0;
            this.tlstrp_Funciones_Basicas.Text = "toolStrip1";
            // 
            // tlsbtn_Guardar_Modificar_TipoTratamiento
            // 
            this.tlsbtn_Guardar_Modificar_TipoTratamiento.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtn_Guardar_Modificar_TipoTratamiento.Image")));
            this.tlsbtn_Guardar_Modificar_TipoTratamiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsbtn_Guardar_Modificar_TipoTratamiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtn_Guardar_Modificar_TipoTratamiento.Name = "tlsbtn_Guardar_Modificar_TipoTratamiento";
            this.tlsbtn_Guardar_Modificar_TipoTratamiento.Size = new System.Drawing.Size(85, 65);
            this.tlsbtn_Guardar_Modificar_TipoTratamiento.Text = "Guardar";
            this.tlsbtn_Guardar_Modificar_TipoTratamiento.Click += new System.EventHandler(this.tlsbtn_Guardar_Modificar_TipoTratamiento_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 68);
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
            this.grpbx_Clientes.Controls.Add(this.Cmbx_Estado_Modificar_TipoTratamiento);
            this.grpbx_Clientes.Controls.Add(this.label2);
            this.grpbx_Clientes.Controls.Add(this.txt_Costo_Modificar_TipoTratamiento);
            this.grpbx_Clientes.Controls.Add(this.txt_Descripcion_Modificar_TipoTratamiento);
            this.grpbx_Clientes.Controls.Add(this.lbl_Apellido_2);
            this.grpbx_Clientes.Controls.Add(this.lbl_Nombre);
            this.grpbx_Clientes.Controls.Add(this.lbl_Codigo_Cliente);
            this.grpbx_Clientes.Controls.Add(this.txt_Codigo_Modificar_TipoTratamiento);
            this.grpbx_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Clientes.Location = new System.Drawing.Point(9, 158);
            this.grpbx_Clientes.Name = "grpbx_Clientes";
            this.grpbx_Clientes.Size = new System.Drawing.Size(686, 137);
            this.grpbx_Clientes.TabIndex = 11;
            this.grpbx_Clientes.TabStop = false;
            this.grpbx_Clientes.Text = "Datos Tipos de tratamiento";
            // 
            // Cmbx_Estado_Modificar_TipoTratamiento
            // 
            this.Cmbx_Estado_Modificar_TipoTratamiento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cmbx_Estado_Modificar_TipoTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbx_Estado_Modificar_TipoTratamiento.FormattingEnabled = true;
            this.Cmbx_Estado_Modificar_TipoTratamiento.Location = new System.Drawing.Point(386, 75);
            this.Cmbx_Estado_Modificar_TipoTratamiento.Name = "Cmbx_Estado_Modificar_TipoTratamiento";
            this.Cmbx_Estado_Modificar_TipoTratamiento.Size = new System.Drawing.Size(200, 21);
            this.Cmbx_Estado_Modificar_TipoTratamiento.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado:";
            // 
            // txt_Costo_Modificar_TipoTratamiento
            // 
            this.txt_Costo_Modificar_TipoTratamiento.Enabled = false;
            this.txt_Costo_Modificar_TipoTratamiento.Location = new System.Drawing.Point(174, 75);
            this.txt_Costo_Modificar_TipoTratamiento.MaxLength = 10;
            this.txt_Costo_Modificar_TipoTratamiento.Name = "txt_Costo_Modificar_TipoTratamiento";
            this.txt_Costo_Modificar_TipoTratamiento.Size = new System.Drawing.Size(100, 20);
            this.txt_Costo_Modificar_TipoTratamiento.TabIndex = 14;
            this.txt_Costo_Modificar_TipoTratamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Costo_Modificar_TipoTratamiento_KeyPress);
            // 
            // txt_Descripcion_Modificar_TipoTratamiento
            // 
            this.txt_Descripcion_Modificar_TipoTratamiento.Enabled = false;
            this.txt_Descripcion_Modificar_TipoTratamiento.Location = new System.Drawing.Point(386, 49);
            this.txt_Descripcion_Modificar_TipoTratamiento.MaxLength = 150;
            this.txt_Descripcion_Modificar_TipoTratamiento.Name = "txt_Descripcion_Modificar_TipoTratamiento";
            this.txt_Descripcion_Modificar_TipoTratamiento.Size = new System.Drawing.Size(200, 20);
            this.txt_Descripcion_Modificar_TipoTratamiento.TabIndex = 12;
            this.txt_Descripcion_Modificar_TipoTratamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descripcion_Modificar_TipoTratamiento_KeyPress);
            // 
            // lbl_Apellido_2
            // 
            this.lbl_Apellido_2.AutoSize = true;
            this.lbl_Apellido_2.Location = new System.Drawing.Point(72, 78);
            this.lbl_Apellido_2.Name = "lbl_Apellido_2";
            this.lbl_Apellido_2.Size = new System.Drawing.Size(37, 13);
            this.lbl_Apellido_2.TabIndex = 4;
            this.lbl_Apellido_2.Text = "Costo:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(314, 52);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(66, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Descripcion:";
            // 
            // lbl_Codigo_Cliente
            // 
            this.lbl_Codigo_Cliente.AutoSize = true;
            this.lbl_Codigo_Cliente.Location = new System.Drawing.Point(72, 52);
            this.lbl_Codigo_Cliente.Name = "lbl_Codigo_Cliente";
            this.lbl_Codigo_Cliente.Size = new System.Drawing.Size(102, 13);
            this.lbl_Codigo_Cliente.TabIndex = 1;
            this.lbl_Codigo_Cliente.Text = "Codigo Tratamiento:";
            // 
            // txt_Codigo_Modificar_TipoTratamiento
            // 
            this.txt_Codigo_Modificar_TipoTratamiento.Enabled = false;
            this.txt_Codigo_Modificar_TipoTratamiento.Location = new System.Drawing.Point(174, 49);
            this.txt_Codigo_Modificar_TipoTratamiento.Name = "txt_Codigo_Modificar_TipoTratamiento";
            this.txt_Codigo_Modificar_TipoTratamiento.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo_Modificar_TipoTratamiento.TabIndex = 0;
            // 
            // Frm_Modificar_Tipo_Tratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(695, 307);
            this.Controls.Add(this.grpbx_Clientes);
            this.Controls.Add(this.tbctrl_Principal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Tipo_Tratamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Tratamiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Modificar_Tipo_Tratamiento_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Modificar_Tipo_Tratamiento_Load);
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
        private System.Windows.Forms.ToolStripButton tlsbtn_Guardar_Modificar_TipoTratamiento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tlsbtn_Salir;
        private System.Windows.Forms.GroupBox grpbx_Clientes;
        private System.Windows.Forms.ComboBox Cmbx_Estado_Modificar_TipoTratamiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Costo_Modificar_TipoTratamiento;
        private System.Windows.Forms.TextBox txt_Descripcion_Modificar_TipoTratamiento;
        private System.Windows.Forms.Label lbl_Apellido_2;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Codigo_Cliente;
        private System.Windows.Forms.TextBox txt_Codigo_Modificar_TipoTratamiento;
    }
}