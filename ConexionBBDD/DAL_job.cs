﻿using System;
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
                    command.ExecuteNonQuery();
                }
                finally
                {
                    conexionBD.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Obtenemos el trabajo por su ID.
        /// </summary>
        public Job GetJobById(int jobId)
        {
            string query = "SELECT job_id, job_title, min_salary, max_salary FROM jobs WHERE job_id = @JobId";
            using (SqlCommand command = new SqlCommand(query, conexionBD.Connection))
            {
                command.Parameters.Add(new SqlParameter("@JobId", SqlDbType.Int) { Value = jobId });

                try
                {
                    conexionBD.OpenConnection();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Job(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.IsDBNull(2) ? (double?)null : reader.GetDouble(2),
                                reader.IsDBNull(3) ? (double?)null : reader.GetDouble(3)
                            );
                        }
                    }
                }
                finally
                {
                    conexionBD.CloseConnection();
                }
            }
            return null;
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