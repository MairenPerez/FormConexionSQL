using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBBDD
{
    internal class Job
    {
        public int job_id { get; set; }
        public string job_title { get; set; }
        public double? min_salary { get; set; }
        public double? max_salary { get; set; }

        public Job(int job_id, string job_title, double? min_salary, double? max_salary)
        {
            this.job_id = job_id;
            this.job_title = job_title;
            this.min_salary = min_salary;
            this.max_salary = max_salary;
        }

        /// <summary>
        ///  Devuelve el nombre del trabajo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return job_title;
        }

        /// <summary>
        /// Inserta un nuevo trabajo en la base de datos
        /// </summary>
        /// <returns></returns>
        public string ToInsert()
        {
            return $"INSERT INTO jobs (job_id, job_title, min_salary, max_salary) VALUES ({job_id}, '{job_title}', {min_salary?.ToString().Replace(',', '.') ?? "NULL"}, {max_salary?.ToString().Replace(',', '.') ?? "NULL"})";
        }

        /// <summary>
        /// Actualiza un trabajo en la base de datos
        /// </summary>
        /// <returns></returns>
        public string ToUpdate()
        {
            return $"UPDATE jobs SET job_title = '{job_title}', min_salary = {min_salary?.ToString().Replace(',', '.') ?? "NULL"}, max_salary = {max_salary?.ToString().Replace(',', '.') ?? "NULL"} WHERE job_id = {job_id}";
        }
    }
}
