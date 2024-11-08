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
                string job_title = txtjob_title.Text;
                double min_salary = Convert.ToDouble(txtmin_salary.Text);
                double max_salary = Convert.ToDouble(txtmax_salary.Text);

                Job job = new Job(0, job_title, min_salary, max_salary); // El ID no es necesario aquí

                // Ejecutar la consulta SQL para insertar los datos
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    conexion.Open();

                    // Insertar los datos sin especificar job_id
                    command.CommandText = "INSERT INTO jobs (job_title, min_salary, max_salary) VALUES (@job_title, @min_salary, @max_salary)";
                    command.Parameters.AddWithValue("@job_title", job_title);
                    command.Parameters.AddWithValue("@min_salary", min_salary);
                    command.Parameters.AddWithValue("@max_salary", max_salary);
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
