using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SistemasUsuarios
{
    public class Conexion_base_datos
    {
        private readonly string conexion =
            @"Server=FREDY\SQLEXPRESS04;Database=SistemaUsuariosDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private const string tabla = "dbo.Usuarios_Usss039026";

        public DataSet crearDs()
        {
            DataSet ds = new DataSet();

            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlDataAdapter da = new SqlDataAdapter(
                $"SELECT * FROM {tabla} ORDER BY idUsuario", cn))
            {
                da.Fill(ds, "usuarios");
            }

            return ds;
        }

        public int procesar(string consulta, SqlParameter[] parametros)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cmd = new SqlCommand(consulta, cn))
            {
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int mantenimiento_usuarios_Usss039026(
            string consulta, SqlParameter[] parametros)
        {
            return procesar(consulta, parametros);
        }
    }
}