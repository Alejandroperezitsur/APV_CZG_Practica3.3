using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APV_CZG_Practica3._3
{
    internal class Encriptador
    {
        // Encriptación simple invirtiendo la cadena
        public static string EncriptarMensaje(string mensaje)
        {
            char[] charArray = mensaje.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Desencriptación simple invirtiendo la cadena
        public static string DesencriptarMensaje(string mensajeEncriptado)
        {
            char[] charArray = mensajeEncriptado.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
