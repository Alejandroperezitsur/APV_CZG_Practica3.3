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
        public VerMensajes()
        {
            InitializeComponent();
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

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Mensaje mensajeForm = new Mensaje();
            mensajeForm.Show();
            this.Hide();
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
