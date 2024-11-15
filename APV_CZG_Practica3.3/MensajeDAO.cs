using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
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
                string mensajeEncriptado = Convert.ToBase64String(Encoding.UTF8.GetBytes(mensaje));

                string query = "INSERT INTO mensajes (usuario_id, mensaje_encriptado) VALUES (@usuarioId, @mensajeEncriptado)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@mensajeEncriptado", mensajeEncriptado);

                int result = cmd.ExecuteNonQuery();
                return result > 0;  // Devuelve verdadero si se insertó al menos un registro
            }
            catch (MySqlException ex)  // Captura cualquier error relacionado con MySQL
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}");
                return false;  // Retorna falso en caso de error
            }
            catch (Exception ex)  // Captura cualquier otro tipo de error
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;  // Retorna falso en caso de error
            }
            finally
            {
                connection.Close();
            }
        }


        // Obtener mensajes por usuario
        public DataTable ObtenerMensajesPorUsuario(int usuarioId)
        {
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                string query = "SELECT id, mensaje_encriptado FROM mensajes WHERE usuario_id = @usuarioId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuarioId", usuarioId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            finally
            {
                connection.Close();
            }
            return table;
        }

        // Desencriptar mensaje
        public string DesencriptarMensaje(int mensajeId)
        {
            try
            {
                connection.Open();

                string query = "SELECT mensaje_encriptado FROM mensajes WHERE id = @mensajeId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@mensajeId", mensajeId);

                string mensajeEncriptado = cmd.ExecuteScalar().ToString();
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

