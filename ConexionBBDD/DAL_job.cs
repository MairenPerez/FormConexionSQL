using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBBDD
{
    internal class DAL_job
    {
        private readonly ConexionBD conexionBD;

        public DAL_job(ConexionBD conexionBD)
        {
            this.conexionBD = conexionBD;
        }

        /// <summary>
        /// Insertamos un nuevo trabajo dentro de la BBDD.
        /// </summary>
        public void InsertJob(Job job)
        {
            string query = "INSERT INTO jobs (job_id, job_title, min_salary, max_salary) VALUES (@job_id, @job_title, @min_salary, @max_salary)";
            using (SqlCommand command = new SqlCommand(query, conexionBD.Connection))
            {
                command.Parameters.Add(new SqlParameter("@job_id", SqlDbType.Int) { Value = job.job_id });
                command.Parameters.Add(new SqlParameter("@job_title", SqlDbType.NVarChar, 100) { Value = job.job_title });
                command.Parameters.Add(new SqlParameter("@min_salary", SqlDbType.Float) { Value = job.min_salary ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@max_salary", SqlDbType.Float) { Value = job.max_salary ?? (object)DBNull.Value });

                try
                {
                    conexionBD.OpenConnection();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conexionBD.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Actualizamos los datos de cada trabajo.
        /// </summary>
        public void UpdateJob(Job job)
        {
            string query = "UPDATE jobs SET job_title = @job_title, min_salary = @min_salary, max_salary = @max_salary WHERE job_id = @job_id";
            using (SqlCommand command = new SqlCommand(query, conexionBD.Connection))
            {
                command.Parameters.Add(new SqlParameter("@job_id", SqlDbType.Int) { Value = job.job_id });
                command.Parameters.Add(new SqlParameter("@job_title", SqlDbType.NVarChar, 100) { Value = job.job_title });
                command.Parameters.Add(new SqlParameter("@min_salary", SqlDbType.Float) { Value = job.min_salary ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@max_salary", SqlDbType.Float) { Value = job.max_salary ?? (object)DBNull.Value });

                try
                {
                    conexionBD.OpenConnection();

                    int rowsAffected = command.ExecuteNonQuery(); // Verificar filas afectadas
                    if (rowsAffected == 0)
                    {
                        Console.WriteLine("No se actualizó ningún registro. Verifique que el job_id existe.");
                    }
                    else
                    {
                        Console.WriteLine("Registro actualizado correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar el registro: " + ex.Message);
                }
                finally
                {
                    conexionBD.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Insertamos un nuevo trabajo dentro de la BBDD y obtenemos el ID generado.
        /// </summary>
        public void GetById(Job job)
        {
            string query = @"
            INSERT INTO jobs (job_title, min_salary, max_salary) 
            OUTPUT INSERTED.job_id 
            VALUES (@job_title, @min_salary, @max_salary)";

            using (SqlCommand command = new SqlCommand(query, conexionBD.Connection))
            {
                command.Parameters.Add(new SqlParameter("@job_title", SqlDbType.NVarChar, 100) { Value = job.job_title });
                command.Parameters.Add(new SqlParameter("@min_salary", SqlDbType.Float) { Value = job.min_salary ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@max_salary", SqlDbType.Float) { Value = job.max_salary ?? (object)DBNull.Value });

                try
                {
                    conexionBD.OpenConnection();
                    job.job_id = (int)command.ExecuteScalar(); // Captura el ID generado
                    Console.WriteLine("Trabajo insertado con ID: " + job.job_id);
                }
                finally
                {
                    conexionBD.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Obtenemos todos los trabajos.
        /// </summary>
        public List<Job> GetAllJobs()
        {
            List<Job> jobs = new List<Job>();
            string query = "SELECT job_id, job_title, min_salary, max_salary FROM jobs";
            using (SqlCommand command = new SqlCommand(query, conexionBD.Connection))
            {
                try
                {
                    conexionBD.OpenConnection();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            jobs.Add(new Job(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.IsDBNull(2) ? (double?)null : reader.GetDouble(2),
                                reader.IsDBNull(3) ? (double?)null : reader.GetDouble(3)
                            ));
                        }
                    }
                }
                finally
                {
                    conexionBD.CloseConnection();
                }
            }
            return jobs;
        }
    }
}
