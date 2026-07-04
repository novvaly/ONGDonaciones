using Microsoft.Data.SqlClient;
using System.Data;               

namespace AccesoDatos
{
    public class ConexionDB
    {   // Cadena de comunicacion
        private static readonly string cadenaConexion =
            @"Server=DESKTOP-3NGQBG8;                    
              Database=ONGDonaciones;                 
              Integrated Security=True;                   
              TrustServerCertificate=True;";  

        // Abrir coxecion con Sql
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public static int EjecutarComando(string sql, SqlParameter[]? parametros = null)
        {
            using SqlConnection con = ObtenerConexion();
            using SqlCommand cmd = new SqlCommand(sql, con);

            if (parametros != null)
                cmd.Parameters.AddRange(parametros);

            return cmd.ExecuteNonQuery();
        }

        public static DataTable EjecutarConsulta(string sql, SqlParameter[]? parametros = null)
        {
            using SqlConnection con = ObtenerConexion();
            using SqlCommand cmd = new SqlCommand(sql, con);

            if (parametros != null)
                cmd.Parameters.AddRange(parametros);

            DataTable tabla = new DataTable();

            using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);

            return tabla;
        }

        public static bool ProbarConexion()
        {
            try
            {
                using SqlConnection con = ObtenerConexion();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}