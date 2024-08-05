using BuiTienThinh_22102363.DTO;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BuiTienThinh_22102363.DAO
{
    internal class AccountDAO
    {
        private string connectionString;

        public AccountDAO()
        {
            // Lấy chuỗi kết nối từ app.config
            /*  connectionString = ConfigurationManager.ConnectionStrings["LoveStore2"].ConnectionString;*/
            new SqlDataAccessHelper();
        }

        // Lấy tất cả tài khoản
        public DataTable GetAll()
        {
            string query = "SELECT * FROM Account";
            return ExecuteSelectQuery(query);
        }

        // Thêm tài khoản mới
        public void Insert(Account account)
        {
            string query = "INSERT INTO [Account] (Email, FullName, RoleId, Password) VALUES (@Email, @FullName, @RoleId, @Password)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = account.Email },
                new SqlParameter("@FullName", SqlDbType.NVarChar) { Value = account.FullName },
                new SqlParameter("@RoleId", SqlDbType.NVarChar) { Value = account.RoleId },
                new SqlParameter("@Password", SqlDbType.NVarChar) { Value = account.Password }
            };

            ExecuteNonQuery(query, sqlParameters);
        }

        // Tìm kiếm tài khoản theo tên
        public DataTable SearchAccounts(string keyword)
        {
            string query = "SELECT * FROM Account WHERE FullName LIKE @Keyword";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Keyword", SqlDbType.NVarChar) { Value = "%" + keyword + "%" }
            };

            return ExecuteSelectQuery(query, parameters);
        }

        // Xác thực thông tin đăng nhập
        public bool ValidateCredentials(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE Email = @Email AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
                new SqlParameter("@Password", SqlDbType.NVarChar) { Value = password }
            };

            object result = ExecuteScalar(query, parameters);
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        // Thực thi truy vấn và trả về kết quả
        private DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Thực thi truy vấn không trả về kết quả
        private void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Thực thi truy vấn và trả về một giá trị đơn
        private object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }
    }
}
