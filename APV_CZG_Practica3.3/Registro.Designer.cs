namespace APV_CZG_Practica3._3
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.pnlBarraMenu = new System.Windows.Forms.Panel();
            this.btnMinize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreoElec = new System.Windows.Forms.TextBox();
            this.txtUsuarioR = new System.Windows.Forms.TextBox();
            this.txtContraseniaR = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarseR = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pnlBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlBarraMenu.Size = new System.Drawing.Size(778, 35);
            this.pnlBarraMenu.TabIndex = 0;
            this.pnlBarraMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMinize
            // 
            this.btnMinize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinize.Image")));
            this.btnMinize.Location = new System.Drawing.Point(690, 7);
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
            this.btnClose.Location = new System.Drawing.Point(741, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.DimGray;
            this.lblRegistro.Location = new System.Drawing.Point(301, 38);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(168, 40);
            this.lblRegistro.TabIndex = 11;
            this.lblRegistro.Text = "REGISTRO";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegistro.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.DimGray;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(154, 287);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(450, 32);
            this.txtApellido.TabIndex = 14;
            // 
            // txtCorreoElec
            // 
            this.txtCorreoElec.BackColor = System.Drawing.Color.DimGray;
            this.txtCorreoElec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElec.ForeColor = System.Drawing.Color.Black;
            this.txtCorreoElec.Location = new System.Drawing.Point(154, 357);
            this.txtCorreoElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoElec.Name = "txtCorreoElec";
            this.txtCorreoElec.Size = new System.Drawing.Size(450, 32);
            this.txtCorreoElec.TabIndex = 15;
            this.txtCorreoElec.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUsuarioR
            // 
            this.txtUsuarioR.BackColor = System.Drawing.Color.DimGray;
            this.txtUsuarioR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioR.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioR.Location = new System.Drawing.Point(154, 427);
            this.txtUsuarioR.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioR.Name = "txtUsuarioR";
            this.txtUsuarioR.Size = new System.Drawing.Size(450, 32);
            this.txtUsuarioR.TabIndex = 16;
            this.txtUsuarioR.TextChanged += new System.EventHandler(this.txtUsuarioR_TextChanged);
            // 
            // txtContraseniaR
            // 
            this.txtContraseniaR.BackColor = System.Drawing.Color.DimGray;
            this.txtContraseniaR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseniaR.ForeColor = System.Drawing.Color.Black;
            this.txtContraseniaR.Location = new System.Drawing.Point(154, 497);
            this.txtContraseniaR.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseniaR.Name = "txtContraseniaR";
            this.txtContraseniaR.Size = new System.Drawing.Size(450, 32);
            this.txtContraseniaR.TabIndex = 17;
            this.txtContraseniaR.TextChanged += new System.EventHandler(this.txtContraseniaR_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DimGray;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(154, 217);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(450, 32);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(330, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(330, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(290, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Correo electrónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(340, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(314, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Contraseña:";
            // 
            // btnRegistrarseR
            // 
            this.btnRegistrarseR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRegistrarseR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarseR.FlatAppearance.BorderSize = 0;
            this.btnRegistrarseR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrarseR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarseR.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarseR.Location = new System.Drawing.Point(242, 555);
            this.btnRegistrarseR.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarseR.Name = "btnRegistrarseR";
            this.btnRegistrarseR.Size = new System.Drawing.Size(290, 46);
            this.btnRegistrarseR.TabIndex = 23;
            this.btnRegistrarseR.Text = "REGISTRARSE";
            this.btnRegistrarseR.UseVisualStyleBackColor = false;
            this.btnRegistrarseR.Click += new System.EventHandler(this.btnRegistrarseR_Click);
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
            this.btnRegresar.Location = new System.Drawing.Point(344, 625);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 32);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(778, 669);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRegistrarseR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseniaR);
            this.Controls.Add(this.txtUsuarioR);
            this.Controls.Add(this.txtCorreoElec);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.pnlBarraMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.pnlBarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraMenu;
        private System.Windows.Forms.PictureBox btnMinize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreoElec;
        private System.Windows.Forms.TextBox txtUsuarioR;
        private System.Windows.Forms.TextBox txtContraseniaR;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarseR;
        private System.Windows.Forms.Button btnRegresar;
    }
}