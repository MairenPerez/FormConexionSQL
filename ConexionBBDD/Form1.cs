using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBBDD
{
    public partial class ConexionSQL : Form
    {
        private SqlConnection conexion;

        public ConexionSQL()
        {
            InitializeComponent();
        }

        private void txtEstadoBBDD_TextChanged(object sender, EventArgs e)
        {
            if (btnConectar.Enabled)
                txtEstadoBBDD.Text = "Closed";
            else
                txtEstadoBBDD.Text = "Open";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Server=85.208.21.117,54321;Database=MairenEmployees;User Id=sa;Password=Sql#123456789;TrustServerCertificate=True;";

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                MessageBox.Show("Conexión establecida con éxito");
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                txtEstadoBBDD.Text = "Open"; // Actualiza el estado del TextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la BBDD: " + ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Close();
                MessageBox.Show("Conexión cerrada con éxito");
                btnConectar.Enabled = true;
                btnDesconectar.Enabled = false;
                txtEstadoBBDD.Text = "Closed"; // Actualiza el estado del TextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión con la BBDD: " + ex.Message);
            }
        }
    }
}
