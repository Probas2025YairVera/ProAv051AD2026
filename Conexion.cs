using Microsoft.Data.SqlClient;

public class Conexion
{
    private string cadenaConexion =
        @"Server=localhost\SQLEXPRESS;
          Database=PIAPA;
          Trusted_Connection=True;
          TrustServerCertificate=True;";

    public SqlConnection ObtenerConexion()
    {
        return new SqlConnection(cadenaConexion);
    }
}


