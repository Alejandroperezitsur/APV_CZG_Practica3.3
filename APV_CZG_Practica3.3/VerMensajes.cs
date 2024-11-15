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
    public partial class VerMensajes : Form
    {
        private int usuarioId; // Almacenar el usuario logueado
        public VerMensajes(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            CargarMensajes();
        }

        private void CargarMensajes()
        {
            MensajeDAO mensajeDAO = new MensajeDAO();
            DataTable mensajes = mensajeDAO.ObtenerMensajesPorUsuario(usuarioId);

            listMensajes.Items.Clear();
            foreach (DataRow row in mensajes.Rows)
            {
                listMensajes.Items.Add(new { Id = row["id"], Mensaje = row["mensaje_encriptado"] });
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            if (listMensajes.SelectedItem != null)
            {
                // Obtener el mensaje seleccionado
                dynamic itemSeleccionado = listMensajes.SelectedItem;
                int mensajeId = itemSeleccionado.Id;

                MensajeDAO mensajeDAO = new MensajeDAO();
                string mensajeDesencriptado = mensajeDAO.DesencriptarMensaje(mensajeId);

                MessageBox.Show("Mensaje desencriptado: " + mensajeDesencriptado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un mensaje.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Mensaje mensajeForm = new Mensaje(usuarioId);
            mensajeForm.Show();
            this.Hide();
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void listMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerMensajes_Load(object sender, EventArgs e)
        {

        }
    }
}
