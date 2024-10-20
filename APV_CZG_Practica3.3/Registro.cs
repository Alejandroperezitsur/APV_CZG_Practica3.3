using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        private bool EsCorreoValido(string correo)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patronCorreo);
        }
        private void btnRegistrarseR_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreoElec.Text;
            string usuario = txtUsuarioR.Text;
            string contrasena = txtContraseniaR.Text;

            // Verificamos que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' no puede estar vacío.");
                return;
            }
            if (!EsCorreoValido(txtCorreoElec.Text))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoElec.Text))
            {
                MessageBox.Show("El campo 'Correo Electrónico' no puede estar vacío.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsuarioR.Text))
            {
                MessageBox.Show("El campo 'Usuario' no puede estar vacío.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContraseniaR.Text))
            {
                MessageBox.Show("El campo 'Contraseña' no puede estar vacío.");
                return;
            }

            // Si todos los campos están llenos, llamamos al método para registrar el usuario
            try
            {
                usuarioDAO.RegistrarUsuario(txtNombre.Text, txtApellido.Text, txtCorreoElec.Text, txtUsuarioR.Text, txtContraseniaR.Text);
                MessageBox.Show("Usuario registrado correctamente.");

                // Limpiamos los campos después del registro exitoso
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }

        // Método para limpiar los campos de texto después de registrar un usuario
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreoElec.Clear();
            txtUsuarioR.Clear();
            txtContraseniaR.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }
    }
}
