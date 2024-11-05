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

        /// <summary>
        /// Si el botón Conectar está habilitado, cambiamos el texto a "Conectado"
        /// Si está deshabilitado, cambiamos el texto a "Desconectado"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEstadoBBDD_TextChanged(object sender, EventArgs e)
        {
            if (btnConectar.Enabled == true)
                txtEstadoBBDD.Text = "Open";
            else
                txtEstadoBBDD.Text = "Closed";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Si el usuario le da al botón, iniciamos la conexión con la BBDD MairenEmployees
            string cadenaConexion = "Server= 85.208.21.117,54321;Database=MairenEmployees;User Id=sa;Password=Sql#123456789;";

            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                MessageBox.Show("Conexión establecida con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la BBDD: " + ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            // Si el usuario le da al botón, cerramos la conexión con la BBDD MairenEmployees
            try
            {
                conexion.Close();
                MessageBox.Show("Conexión cerrada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión con la BBDD: " + ex.Message);
            }
        }
    }
}
