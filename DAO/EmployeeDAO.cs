using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BuiTienThinh_22102363.DTO;

namespace BuiTienThinh_22102363.DAO
{
    public class EmployeeDAO
    {
        private string connectionString = "Data Source=(local);Initial Catalog=LoveStore2;Integrated Security=True;TrustServerCertificate=True"; // Thay thế bằng chuỗi kết nối của bạn

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, FullName, Position, DiaChi, DateofBirth, Picture FROM Employee";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        Id = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        Position = reader.GetString(2),
                        DiaChi = reader.GetString(3),
                        DateofBirth = reader.GetDateTime(4),
                        Picture = reader["Picture"] as byte[]
                    };

                    employees.Add(employee);
                }
            }

            return employees;
        }
        public Employee GetById(int id)
        {
            Employee employee = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, FullName, Position, DiaChi, DateofBirth, Picture FROM Employee WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    employee = new Employee
                    {
                        Id = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        Position = reader.GetString(2),
                        DiaChi = reader.GetString(3),
                        DateofBirth = reader.GetDateTime(4),
                        Picture = reader["Picture"] as byte[]
                    };
                }
            }

            return employee;
        }
        public List<Employee> SearchEmployees(string keyword)
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, FullName, Position, DiaChi, DateofBirth, Picture FROM Employee WHERE FullName LIKE @Keyword";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        Id = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        Position = reader.GetString(2),
                        DiaChi = reader.GetString(3),
                        DateofBirth = reader.GetDateTime(4),
                        Picture = reader["Picture"] as byte[]
                    };

                    employees.Add(employee);
                }
            }

            return employees;
        }

        public void Insert(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employee (FullName, Position, DiaChi, DateofBirth, Picture) VALUES (@FullName, @Position, @DiaChi, @DateofBirth, @Picture)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", employee.FullName);
                command.Parameters.AddWithValue("@Position", employee.Position);
                command.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
                command.Parameters.AddWithValue("@DateofBirth", employee.DateofBirth);
                command.Parameters.AddWithValue("@Picture", employee.Picture ?? (object)DBNull.Value);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee SET FullName = @FullName, Position = @Position, DiaChi = @DiaChi, DateofBirth = @DateofBirth, Picture = @Picture WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", employee.Id);
                command.Parameters.AddWithValue("@FullName", employee.FullName);
                command.Parameters.AddWithValue("@Position", employee.Position);
                command.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
                command.Parameters.AddWithValue("@DateofBirth", employee.DateofBirth);
                command.Parameters.AddWithValue("@Picture", employee.Picture ?? (object)DBNull.Value);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int employeeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Employee WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", employeeId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
