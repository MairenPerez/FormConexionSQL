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
    public partial class JobForm : Form
    {
        private SqlConnection conexion;

        public JobForm()
        {
            InitializeComponent();
            this.conexion = new SqlConnection("Server=85.208.21.117,54321;" +
                "Database=MairenEmployees;" +
                "User Id=sa;" +
                "Password=Sql#123456789;" +
                "TrustServerCertificate=True;");
        }

        /// <summary>
        /// Guarda un nuevo trabajo en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int job_id = Convert.ToInt32(txtjob_id.Text);
                string job_title = txtjob_title.Text;
                double min_salary = Convert.ToDouble(txtmin_salary.Text);
                double max_salary = Convert.ToDouble(txtmax_salary.Text);

                Job job = new Job(job_id, job_title, min_salary, max_salary);

                // Ejecutar la consulta SQL para insertar los datos
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    conexion.Open();

                    // Activar IDENTITY_INSERT
                    command.CommandText = "SET IDENTITY_INSERT jobs ON";
                    command.ExecuteNonQuery();

                    // Insertar los datos
                    command.CommandText = job.ToInsert();
                    command.ExecuteNonQuery();

                    // Desactivar IDENTITY_INSERT
                    command.CommandText = "SET IDENTITY_INSERT jobs OFF";
                    command.ExecuteNonQuery();

                    conexion.Close();
                }

                MessageBox.Show("Trabajo insertado con éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
