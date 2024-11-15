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
    public partial class Mensaje : Form
    {
        private int usuarioId; // Almacenar el usuario logueado
        public Mensaje(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {
            if (txtMensaje.Text.Length > 50)
            {
                MessageBox.Show("El mensaje no puede exceder los 50 caracteres.");
                txtMensaje.Text = txtMensaje.Text.Substring(0, 50);
            }
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text.Trim();
            if (string.IsNullOrEmpty(mensaje) || mensaje.Length > 50)
            {
                MessageBox.Show("El mensaje debe contener entre 1 y 50 caracteres.");
                return;
            }

            // Obtener el ID del usuario actual (por ejemplo, de la sesión)
            int usuarioId = ObtenerUsuarioId();  // Implementa esta función para obtener el ID del usuario logueado

            MensajeDAO mensajeDAO = new MensajeDAO();
            bool resultado = mensajeDAO.AlmacenarMensaje(usuarioId, mensaje);

            if (resultado)
            {
                MessageBox.Show("Mensaje guardado exitosamente.");
                txtMensaje.Clear();  // Limpiar el campo de texto
            }
            else
            {
                MessageBox.Show("Error al guardar el mensaje.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerMensajes verMensajesForm = new VerMensajes(usuarioId);
            verMensajesForm.Show();
            this.Hide();
        }
    }
}
