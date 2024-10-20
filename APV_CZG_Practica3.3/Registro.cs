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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuarioR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseniaR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarseR_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreoElec.Text;
            string usuario = txtUsuarioR.Text;
            string contrasena = txtContraseniaR.Text;

            if (usuarioDAO.RegistrarUsuario(nombre, apellido, correo, usuario, contrasena))
            {
                MessageBox.Show("Registro exitoso.");
                this.Hide();
                login loginForm = new login();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }
    }
}
