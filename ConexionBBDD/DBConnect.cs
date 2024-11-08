using System;
using System.Data;
using System.Data.SqlClient;

public class ConexionBD
{
    public SqlConnection Connection { get; private set; }

    public ConexionBD()
    {
        var CadenaConexion = new SqlConnectionStringBuilder
        {
            DataSource = "85.208.21.117,54321",
            InitialCatalog = "MairenEmployees",
            UserID = "sa",
            Password = "Sql#123456789",
            TrustServerCertificate = true
        };

        Connection = new SqlConnection(CadenaConexion.ToString());
    }

    public void OpenConnection()
    {
        try
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        catch (SqlException ex)
        {
            // Manejar la excepción de SQL
            throw new Exception("Error al abrir la conexión con la base de datos: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Manejar cualquier otra excepción
            throw new Exception("Error inesperado al abrir la conexión: " + ex.Message);
        }
    }

    public void CloseConnection()
    {
        try
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        catch (SqlException ex)
        {
            // Manejar la excepción de SQL
            throw new Exception("Error al cerrar la conexión con la base de datos: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Manejar cualquier otra excepción
            throw new Exception("Error inesperado al cerrar la conexión: " + ex.Message);
        }
    }
}
