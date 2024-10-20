namespace APV_CZG_Practica3._3
{
    partial class VerMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMensajes));
            this.pnlBarraMenu = new System.Windows.Forms.Panel();
            this.btnMinize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listMensajes = new System.Windows.Forms.ListBox();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblindicacion = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pnlBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraMenu
            // 
            this.pnlBarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlBarraMenu.Controls.Add(this.btnMinize);
            this.pnlBarraMenu.Controls.Add(this.btnClose);
            this.pnlBarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraMenu.Name = "pnlBarraMenu";
            this.pnlBarraMenu.Size = new System.Drawing.Size(938, 35);
            this.pnlBarraMenu.TabIndex = 2;
            // 
            // btnMinize
            // 
            this.btnMinize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinize.Image")));
            this.btnMinize.Location = new System.Drawing.Point(829, 7);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(25, 25);
            this.btnMinize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinize.TabIndex = 1;
            this.btnMinize.TabStop = false;
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(874, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.listMensajes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 365);
            this.panel1.TabIndex = 3;
            // 
            // listMensajes
            // 
            this.listMensajes.FormattingEnabled = true;
            this.listMensajes.ItemHeight = 16;
            this.listMensajes.Items.AddRange(new object[] {
            "0"});
            this.listMensajes.Location = new System.Drawing.Point(12, 18);
            this.listMensajes.Name = "listMensajes";
            this.listMensajes.Size = new System.Drawing.Size(158, 292);
            this.listMensajes.TabIndex = 0;
            this.listMensajes.SelectedIndexChanged += new System.EventHandler(this.listMensajes_SelectedIndexChanged);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDesencriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesencriptar.FlatAppearance.BorderSize = 0;
            this.btnDesencriptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDesencriptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesencriptar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencriptar.Location = new System.Drawing.Point(207, 42);
            this.btnDesencriptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(207, 40);
            this.btnDesencriptar.TabIndex = 26;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(208, 143);
            this.txtMensaje.MaxLength = 50;
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(718, 100);
            this.txtMensaje.TabIndex = 27;
            this.txtMensaje.TextChanged += new System.EventHandler(this.txtMensaje_TextChanged);
            // 
            // lblindicacion
            // 
            this.lblindicacion.AutoSize = true;
            this.lblindicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindicacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblindicacion.Location = new System.Drawing.Point(206, 117);
            this.lblindicacion.Name = "lblindicacion";
            this.lblindicacion.Size = new System.Drawing.Size(246, 23);
            this.lblindicacion.TabIndex = 28;
            this.lblindicacion.Text = "Mensaje Desencriptado:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegresar.Location = new System.Drawing.Point(520, 345);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 32);
            this.btnRegresar.TabIndex = 29;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // VerMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(938, 400);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblindicacion);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarraMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerMensajes";
            this.pnlBarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraMenu;
        private System.Windows.Forms.PictureBox btnMinize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblindicacion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ListBox listMensajes;
    }
}