﻿namespace APV_CZG_Practica3._3
{
    partial class Mensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensaje));
            this.pnlBarraMenu = new System.Windows.Forms.Panel();
            this.btnMinize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblindicacion = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnVerMensajes = new System.Windows.Forms.Button();
            this.pnlBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
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
            this.pnlBarraMenu.Size = new System.Drawing.Size(800, 35);
            this.pnlBarraMenu.TabIndex = 1;
            // 
            // btnMinize
            // 
            this.btnMinize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinize.Image")));
            this.btnMinize.Location = new System.Drawing.Point(715, 7);
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
            this.btnClose.Location = new System.Drawing.Point(763, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBienvenida.Location = new System.Drawing.Point(27, 48);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(172, 42);
            this.lblBienvenida.TabIndex = 21;
            this.lblBienvenida.Text = "Bienvenido:";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(34, 116);
            this.txtMensaje.MaxLength = 50;
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(718, 100);
            this.txtMensaje.TabIndex = 23;
            this.txtMensaje.TextChanged += new System.EventHandler(this.txtMensaje_TextChanged);
            // 
            // lblindicacion
            // 
            this.lblindicacion.AutoSize = true;
            this.lblindicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindicacion.ForeColor = System.Drawing.Color.DimGray;
            this.lblindicacion.Location = new System.Drawing.Point(39, 90);
            this.lblindicacion.Name = "lblindicacion";
            this.lblindicacion.Size = new System.Drawing.Size(173, 23);
            this.lblindicacion.TabIndex = 24;
            this.lblindicacion.Text = "Deja tu mensaje:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(255, 240);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(290, 46);
            this.btnInsertar.TabIndex = 25;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
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
            this.btnRegresar.Location = new System.Drawing.Point(698, 306);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 32);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnVerMensajes
            // 
            this.btnVerMensajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerMensajes.FlatAppearance.BorderSize = 0;
            this.btnVerMensajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVerMensajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMensajes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMensajes.ForeColor = System.Drawing.Color.LightGray;
            this.btnVerMensajes.Location = new System.Drawing.Point(324, 306);
            this.btnVerMensajes.Name = "btnVerMensajes";
            this.btnVerMensajes.Size = new System.Drawing.Size(152, 32);
            this.btnVerMensajes.TabIndex = 27;
            this.btnVerMensajes.Text = "Ver mensajes";
            this.btnVerMensajes.UseVisualStyleBackColor = false;
            this.btnVerMensajes.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.btnVerMensajes);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblindicacion);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pnlBarraMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.Load += new System.EventHandler(this.Mensaje_Load);
            this.pnlBarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraMenu;
        private System.Windows.Forms.PictureBox btnMinize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblindicacion;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnVerMensajes;
    }
}