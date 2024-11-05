using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConexionBBDD
{
    public partial class ConexionSQL : Form
    {
        private SqlConnection conexion;

        public ConexionSQL()
        {
            InitializeComponent();
            ActualizarEstadoBBDD();
        }

        /// <summary>
        /// Actualiza el textbox con el estado de la conexión a la BBDD
        /// </summary>
        private void ActualizarEstadoBBDD()
        {
            txtEstadoBBDD.Text = btnConectar.Enabled ? "Closed" : "Open";
        }

        /// <summary>
        /// Llamamos al método ActualizarEstadoBBDD cada vez que se modifica el texto del textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEstadoBBDD_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBBDD();
        }

        /// <summary>
        ///  Hacemos la conexión a la BBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConectar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=85.208.21.117,54321;Database=MairenEmployees;" +
                                    "User Id=sa;" +
                                    "Password=Sql#123456789;" +
                                    "TrustServerCertificate=True;";

            try
            {
                conexion = new SqlConnection(connectionString);
                conexion.Open();
                MessageBox.Show("Conexión establecida con éxito");
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                ActualizarEstadoBBDD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la BBDD: " + ex.Message);
            }
        }

        /// <summary>
        ///  Cerramos la conexión a la BBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion?.State == ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("Conexión cerrada con éxito");
                    btnConectar.Enabled = true;
                    btnDesconectar.Enabled = false;
                    ActualizarEstadoBBDD();
                }
                else
                {
                    MessageBox.Show("La conexión ya está cerrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión con la BBDD: " + ex.Message);
            }
        }
    }
}
