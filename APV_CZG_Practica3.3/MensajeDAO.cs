using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace APV_CZG_Practica3._3
{
    public class MensajeDAO
    {
        private MySqlConnection connection;

        public MensajeDAO()
        {
            string connectionString = "Server=calebitsurdb.mysql.database.azure.com;Database=SistemaMensajes;Uid=calebitsur;Pwd=Cvetdcmahmqv*;";
            connection = new MySqlConnection(connectionString);
        }

        public bool AlmacenarMensaje(int usuarioId, string mensaje)
        {
            try
            {
                connection.Open();

                // Encriptar mensaje de manera reversible
                string mensajeEncriptado = Convert.ToBase64String(Encoding.UTF8.GetBytes(mensaje));

                string query = "INSERT INTO mensajes (usuario_id, mensaje_encriptado) VALUES (@usuarioId, @mensajeEncriptado)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@mensajeEncriptado", mensajeEncriptado);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public string DesencriptarMensaje(int usuarioId)
        {
            try
            {
                connection.Open();

                string query = "SELECT mensaje_encriptado FROM mensajes WHERE usuario_id = @usuarioId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuarioId", usuarioId);

                string mensajeEncriptado = cmd.ExecuteScalar().ToString();

                // Desencriptar mensaje
                byte[] data = Convert.FromBase64String(mensajeEncriptado);
                return Encoding.UTF8.GetString(data);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

