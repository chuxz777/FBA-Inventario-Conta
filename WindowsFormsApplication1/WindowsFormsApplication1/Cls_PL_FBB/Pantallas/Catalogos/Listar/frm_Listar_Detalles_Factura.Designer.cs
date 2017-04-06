namespace Cls_PL.Pantallas.Catalogos.Listar
{
    partial class frm_Listar_Detalles_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Listar_Detalles_Factura));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrd_Detalles_Factura = new System.Windows.Forms.DataGridView();
            this.tbctrl_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlstrp_Funciones_Basicas = new System.Windows.Forms.ToolStrip();
            this.tlsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.txt_ID_Factura_Detalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Detalles_Factura)).BeginInit();
            this.tbctrl_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlstrp_Funciones_Basicas.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1076, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clinica Odontológica Perla Blanca - Detalles de Factura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgrd_Detalles_Factura
            // 
            this.dtgrd_Detalles_Factura.AllowUserToAddRows = false;
            this.dtgrd_Detalles_Factura.AllowUserToDeleteRows = false;
            this.dtgrd_Detalles_Factura.AllowUserToResizeColumns = false;
            this.dtgrd_Detalles_Factura.AllowUserToResizeRows = false;
            this.dtgrd_Detalles_Factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrd_Detalles_Factura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgrd_Detalles_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_Detalles_Factura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgrd_Detalles_Factura.Location = new System.Drawing.Point(5, 184);
            this.dtgrd_Detalles_Factura.Name = "dtgrd_Detalles_Factura";
            this.dtgrd_Detalles_Factura.ReadOnly = true;
            this.dtgrd_Detalles_Factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_Detalles_Factura.Size = new System.Drawing.Size(1071, 373);
            this.dtgrd_Detalles_Factura.TabIndex = 7;
            // 
            // tbctrl_Principal
            // 
            this.tbctrl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrl_Principal.Controls.Add(this.tabPage1);
            this.tbctrl_Principal.Location = new System.Drawing.Point(5, 52);
            this.tbctrl_Principal.Name = "tbctrl_Principal";
            this.tbctrl_Principal.SelectedIndex = 0;
            this.tbctrl_Principal.Size = new System.Drawing.Size(1071, 100);
            this.tbctrl_Principal.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlstrp_Funciones_Basicas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlstrp_Funciones_Basicas
            // 
            this.tlstrp_Funciones_Basicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlstrp_Funciones_Basicas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlstrp_Funciones_Basicas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtn_Salir});
            this.tlstrp_Funciones_Basicas.Location = new System.Drawing.Point(3, 3);
            this.tlstrp_Funciones_Basicas.Name = "tlstrp_Funciones_Basicas";
            this.tlstrp_Funciones_Basicas.Size = new System.Drawing.Size(1057, 68);
            this.tlstrp_Funciones_Basicas.TabIndex = 0;
            this.tlstrp_Funciones_Basicas.Text = "toolStrip1";
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
            // txt_ID_Factura_Detalle
            // 
            this.txt_ID_Factura_Detalle.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ID_Factura_Detalle.Location = new System.Drawing.Point(72, 158);
            this.txt_ID_Factura_Detalle.Name = "txt_ID_Factura_Detalle";
            this.txt_ID_Factura_Detalle.ReadOnly = true;
            this.txt_ID_Factura_Detalle.Size = new System.Drawing.Size(100, 20);
            this.txt_ID_Factura_Detalle.TabIndex = 2;
            this.txt_ID_Factura_Detalle.TextChanged += new System.EventHandler(this.txt_ID_Factura_Detalle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Factura:";
            // 
            // frm_Listar_Detalles_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1076, 569);
            this.Controls.Add(this.tbctrl_Principal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID_Factura_Detalle);
            this.Controls.Add(this.dtgrd_Detalles_Factura);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Listar_Detalles_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Detalles Factura";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Listar_Detalles_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Detalles_Factura)).EndInit();
            this.tbctrl_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tlstrp_Funciones_Basicas.ResumeLayout(false);
            this.tlstrp_Funciones_Basicas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrd_Detalles_Factura;
        private System.Windows.Forms.TabControl tbctrl_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip tlstrp_Funciones_Basicas;
        private System.Windows.Forms.ToolStripButton tlsbtn_Salir;
        public System.Windows.Forms.TextBox txt_ID_Factura_Detalle;
        private System.Windows.Forms.Label label2;
    }
}