using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace mylibreria2026
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string comando)
        {
            // Data Source=DESKTOP-JO26UBD\MSSQLSERVER2025;Initial Catalog=BD_SALDOS;Integrated Security=True;Trust Server Certificate=True
            // String de conexión Andrei
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JO26UBD\MSSQLSERVER2025;Initial Catalog=Sist_Votaciones_Electronicos;Integrated Security=True");

            // String de conexión César
            //SqlConnection conn = new SqlConnection(@"Data Source=;Initial Catalog=Sist_Votaciones_Electronicos;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando, conn);
            adaptador.Fill(ds);
            conn.Close();
            return ds;
        }

        public static string Codificar(string contrasenna)
        {
            byte[] datos = Encoding.UTF8.GetBytes(contrasenna);
            return System.Convert.ToBase64String(datos);
        }

        public static string Decodificar(string contrasenna)
        {
            byte[] datos = System.Convert.FromBase64String(contrasenna);
            return Encoding.UTF8.GetString(datos, 0, datos.Length);
        }
    }
}
