using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBBDD
{
    public partial class Employees
    {
        public int employee_id { get; set; } // Added missing property
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime hire_date { get; set; }
        public int job_id { get; set; }
        public double salary { get; set; }
        public int manager_id { get; set; }
        public int department_id { get; set; }

        public Employees(int employee_id, string first_name, string last_name, string email, string phone_number, DateTime hire_date, int job_id, double salary, int manager_id, int department_id)
        {
            this.employee_id = employee_id; // Initialize the new property
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.job_id = job_id;
            this.salary = salary;
            this.manager_id = manager_id;
            this.department_id = department_id;
        }

        public override string ToString()
        {
            return first_name + " " + last_name;
        }

        public string ToInsert()
        {
            return $"INSERT INTO employees (first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id) VALUES ('{first_name}', '{last_name}', '{email}', '{phone_number}', '{hire_date:yyyy-MM-dd}', {job_id}, {salary}, {manager_id}, {department_id});";
        }

        public string ToUpdate()
        {
            return $"UPDATE employees SET first_name = '{first_name}', last_name = '{last_name}', email = '{email}', phone_number = '{phone_number}', hire_date = '{hire_date:yyyy-MM-dd}', job_id = {job_id}, salary = {salary}, manager_id = {manager_id}, department_id = {department_id} WHERE employee_id = {employee_id};";
        }

        public string ToSelect()
        {
            return $"SELECT * FROM employees WHERE employee_id = {employee_id};";
        }
    }
}
