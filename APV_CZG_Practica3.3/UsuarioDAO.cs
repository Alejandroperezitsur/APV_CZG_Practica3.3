using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace APV_CZG_Practica3._3
{
    public class UsuarioDAO
    {
        private MySqlConnection connection;

        public UsuarioDAO()
        {
            string connectionString = "Server=calebitsurdb.mysql.database.azure.com;Database=SistemaMensajes;Uid=calebitsur;Pwd=Cvetdcmahmqv*;";
            connection = new MySqlConnection(connectionString);
        }

        public bool RegistrarUsuario(string nombre, string apellido, string correo, string usuario, string contrasena)
        {
            try
            {
                connection.Open();

                // Encriptar la contraseña
                string contrasenaEncriptada = EncriptarContrasena(contrasena);

                string query = "INSERT INTO usuarios (nombre, apellido, correo_electronico, usuario, contrasena) VALUES (@nombre, @apellido, @correo, @usuario, @contrasena)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasenaEncriptada);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool IniciarSesion(string usuario, string contrasena)
        {
            try
            {
                connection.Open();

                string contrasenaEncriptada = EncriptarContrasena(contrasena);

                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasenaEncriptada);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            finally
            {
                connection.Close();
            }
        }

        private string EncriptarContrasena(string contrasena)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
