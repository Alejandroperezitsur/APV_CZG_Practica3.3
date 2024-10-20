using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APV_CZG_Practica3._3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro();

            // Muestra el formulario de registro
            registroForm.Show();

            // Oculta el formulario actual (opcional, si deseas que el formulario actual desaparezca)
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            string usuario = txtUsuario.Text;
            string contrasena = txtPass.Text;

            if (usuarioDAO.IniciarSesion(usuario, contrasena))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                this.Hide();
                // Abre el menú principal después del login
                Mensaje mensajeForm = new Mensaje();
                mensajeForm.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
