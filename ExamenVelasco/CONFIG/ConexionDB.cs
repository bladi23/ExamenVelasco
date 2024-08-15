using System;
using System.Data.SqlClient;
using System.Configuration;

public class ConexionDB : IDisposable
{
    private SqlConnection conexion;

    public ConexionDB()
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
    }

    public SqlConnection Conexion => conexion;

    public void Dispose()
    {
        if (conexion != null)
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            conexion.Dispose();
        }
    }
}
