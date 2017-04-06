namespace Cls_PL.Pantallas.Catalogos.Modificar
{
    partial class Frm_Modificar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Usuario));
            this.label1 = new System.Windows.Forms.Label();
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.grpbx_Tipos_Usuario = new System.Windows.Forms.GroupBox();
            this.cmbx_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.chkbx_contraseña = new System.Windows.Forms.CheckBox();
            this.msktxt_contraseña = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbx_Rol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_Estado = new System.Windows.Forms.ComboBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Codigo_Cliente = new System.Windows.Forms.Label();
            this.txt_Codigo_Usuario = new System.Windows.Forms.TextBox();
            this.cmbx_Codigo_Empleado = new System.Windows.Forms.ComboBox();
            this.tbctrl_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
            this.grpbx_Tipos_Usuario.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(703, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clinica Odontológica Perla Blanca - Usuario";
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
            this.tbctrl_Principal.Size = new System.Drawing.Size(698, 100);
            this.tbctrl_Principal.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 74);
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
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(684, 68);
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
            // grpbx_Tipos_Usuario
            // 
            this.grpbx_Tipos_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_Tipos_Usuario.AutoSize = true;
            this.grpbx_Tipos_Usuario.Controls.Add(this.cmbx_Codigo_Empleado);
            this.grpbx_Tipos_Usuario.Controls.Add(this.cmbx_TipoUsuario);
            this.grpbx_Tipos_Usuario.Controls.Add(this.chkbx_contraseña);
            this.grpbx_Tipos_Usuario.Controls.Add(this.msktxt_contraseña);
            this.grpbx_Tipos_Usuario.Controls.Add(this.label3);
            this.grpbx_Tipos_Usuario.Controls.Add(this.label5);
            this.grpbx_Tipos_Usuario.Controls.Add(this.label4);
            this.grpbx_Tipos_Usuario.Controls.Add(this.cmbx_Rol);
            this.grpbx_Tipos_Usuario.Controls.Add(this.label2);
            this.grpbx_Tipos_Usuario.Controls.Add(this.cmbx_Estado);
            this.grpbx_Tipos_Usuario.Controls.Add(this.lbl_Nombre);
            this.grpbx_Tipos_Usuario.Controls.Add(this.lbl_Codigo_Cliente);
            this.grpbx_Tipos_Usuario.Controls.Add(this.txt_Codigo_Usuario);
            this.grpbx_Tipos_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_Tipos_Usuario.Location = new System.Drawing.Point(12, 158);
            this.grpbx_Tipos_Usuario.Name = "grpbx_Tipos_Usuario";
            this.grpbx_Tipos_Usuario.Size = new System.Drawing.Size(684, 147);
            this.grpbx_Tipos_Usuario.TabIndex = 8;
            this.grpbx_Tipos_Usuario.TabStop = false;
            this.grpbx_Tipos_Usuario.Text = "Datos de Usuarios";
            // 
            // cmbx_TipoUsuario
            // 
            this.cmbx_TipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_TipoUsuario.FormattingEnabled = true;
            this.cmbx_TipoUsuario.Location = new System.Drawing.Point(174, 89);
            this.cmbx_TipoUsuario.Name = "cmbx_TipoUsuario";
            this.cmbx_TipoUsuario.Size = new System.Drawing.Size(141, 21);
            this.cmbx_TipoUsuario.TabIndex = 2;
            // 
            // chkbx_contraseña
            // 
            this.chkbx_contraseña.AutoSize = true;
            this.chkbx_contraseña.Location = new System.Drawing.Point(126, 65);
            this.chkbx_contraseña.Name = "chkbx_contraseña";
            this.chkbx_contraseña.Size = new System.Drawing.Size(42, 17);
            this.chkbx_contraseña.TabIndex = 24;
            this.chkbx_contraseña.Text = "Ver";
            this.chkbx_contraseña.UseVisualStyleBackColor = true;
            this.chkbx_contraseña.CheckedChanged += new System.EventHandler(this.chkbx_contraseña_CheckedChanged);
            // 
            // msktxt_contraseña
            // 
            this.msktxt_contraseña.Location = new System.Drawing.Point(174, 63);
            this.msktxt_contraseña.Mask = "aaaaaaaa";
            this.msktxt_contraseña.Name = "msktxt_contraseña";
            this.msktxt_contraseña.PasswordChar = '*';
            this.msktxt_contraseña.PromptChar = ' ';
            this.msktxt_contraseña.Size = new System.Drawing.Size(141, 20);
            this.msktxt_contraseña.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tipo de Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre de Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rol:";
            // 
            // cmbx_Rol
            // 
            this.cmbx_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Rol.FormattingEnabled = true;
            this.cmbx_Rol.Location = new System.Drawing.Point(489, 63);
            this.cmbx_Rol.Name = "cmbx_Rol";
            this.cmbx_Rol.Size = new System.Drawing.Size(141, 21);
            this.cmbx_Rol.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estado:";
            // 
            // cmbx_Estado
            // 
            this.cmbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Estado.FormattingEnabled = true;
            this.cmbx_Estado.Location = new System.Drawing.Point(489, 90);
            this.cmbx_Estado.Name = "cmbx_Estado";
            this.cmbx_Estado.Size = new System.Drawing.Size(141, 21);
            this.cmbx_Estado.TabIndex = 5;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(45, 66);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(64, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Contraseña:";
            // 
            // lbl_Codigo_Cliente
            // 
            this.lbl_Codigo_Cliente.AutoSize = true;
            this.lbl_Codigo_Cliente.Location = new System.Drawing.Point(45, 37);
            this.lbl_Codigo_Cliente.Name = "lbl_Codigo_Cliente";
            this.lbl_Codigo_Cliente.Size = new System.Drawing.Size(101, 13);
            this.lbl_Codigo_Cliente.TabIndex = 1;
            this.lbl_Codigo_Cliente.Text = "Nombre de Usuario:";
            // 
            // txt_Codigo_Usuario
            // 
            this.txt_Codigo_Usuario.Location = new System.Drawing.Point(174, 37);
            this.txt_Codigo_Usuario.MaxLength = 15;
            this.txt_Codigo_Usuario.Name = "txt_Codigo_Usuario";
            this.txt_Codigo_Usuario.Size = new System.Drawing.Size(141, 20);
            this.txt_Codigo_Usuario.TabIndex = 0;
            // 
            // cmbx_Codigo_Empleado
            // 
            this.cmbx_Codigo_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Codigo_Empleado.FormattingEnabled = true;
            this.cmbx_Codigo_Empleado.Location = new System.Drawing.Point(489, 36);
            this.cmbx_Codigo_Empleado.Name = "cmbx_Codigo_Empleado";
            this.cmbx_Codigo_Empleado.Size = new System.Drawing.Size(141, 21);
            this.cmbx_Codigo_Empleado.TabIndex = 25;
            // 
            // Frm_Modificar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(703, 317);
            this.Controls.Add(this.grpbx_Tipos_Usuario);
            this.Controls.Add(this.tbctrl_Principal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Modificar_Usuario_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Modificar_Estados_Load);
            this.tbctrl_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tlstrp_Funciones_Basicas.ResumeLayout(false);
            this.tlstrp_Funciones_Basicas.PerformLayout();
            this.grpbx_Tipos_Usuario.ResumeLayout(false);
            this.grpbx_Tipos_Usuario.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpbx_Tipos_Usuario;
        private System.Windows.Forms.Label lbl_Codigo_Cliente;
        private System.Windows.Forms.TextBox txt_Codigo_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_Estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbx_Rol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.MaskedTextBox msktxt_contraseña;
        private System.Windows.Forms.CheckBox chkbx_contraseña;
        private System.Windows.Forms.ComboBox cmbx_TipoUsuario;
        private System.Windows.Forms.ComboBox cmbx_Codigo_Empleado;
    }
}