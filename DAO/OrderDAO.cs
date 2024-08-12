using BuiTienThinh_22102363.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiTienThinh_22102363.DAO
{
    internal class OrderDAO
    {
        public DataTable GetAllOrders()
        {
            string query = "SELECT TOP (1000) [Id], [Date], [Status],[EmployeeId] FROM [LoveStore2].[dbo].[Order]";
            DataTable result = SqlDataAccessHelper.ExecuteSelectAllQuery(query);

            // Kiểm tra xem có dữ liệu không
            if (result == null || result.Rows.Count == 0)
            {
                MessageBox.Show("No orders found or unable to retrieve data.");
            }
            else
            {
                MessageBox.Show($"Number of orders retrieved: {result.Rows.Count}");
            }

            return result;
        }
        public DataTable GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            string connectionString = "Data Source=(local);Initial Catalog=LoveStore2;Integrated Security=True;TrustServerCertificate=True"; // Cập nhật chuỗi kết nối của bạn

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cập nhật tên bảng và schema nếu cần
                string query = @"
            SELECT 
                CAST([Date] AS DATE) AS OrderDate, 
                COUNT(*) AS OrderCount
            FROM 
                [dbo].[Order]
            WHERE 
                [Date] BETWEEN @StartDate AND @EndDate
            GROUP BY 
                CAST([Date] AS DATE)
            ORDER BY 
                OrderDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public void InsertOrder(OrderDTO order)
        {
            string query = @"
            INSERT INTO [Order] (Date, Status, CustomerId, EmployeeId)
            VALUES (@Date, @Status, @EmployeeId)";

            SqlParameter[] parameters = {
                new SqlParameter("@Date", SqlDbType.DateTime) { Value = order.Date },
                new SqlParameter("@Status", SqlDbType.NVarChar) { Value = order.Status ?? (object)DBNull.Value },
               
                new SqlParameter("@EmployeeId", SqlDbType.Int) { Value = order.EmployeeId }
            };

            try
            {
                SqlDataAccessHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                // Display or log the error message
                MessageBox.Show("Error in InsertOrder: " + ex.Message);
                throw;
            }
        }

        public void UpdateOrder(OrderDTO order)
        {
            string query = @"
            UPDATE [Order]
            SET [Date] = @Date,
                [Status] = @Status,
               
                [EmployeeId] = @EmployeeId
            WHERE [Id] = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", SqlDbType.Int) { Value = order.Id },
                new SqlParameter("@Date", SqlDbType.DateTime) { Value = order.Date },
                new SqlParameter("@Status", SqlDbType.NVarChar) { Value = order.Status ?? (object)DBNull.Value },
                
                new SqlParameter("@EmployeeId", SqlDbType.Int) { Value = order.EmployeeId }
            };

            try
            {
                SqlDataAccessHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                // Display or log the error message
                MessageBox.Show("Error in UpdateOrder: " + ex.Message);
                throw;
            }
        }

        public void DeleteOrder(int orderId)
        {
            string query = "DELETE FROM [Order] WHERE [Id] = @Id";

            SqlParameter sqlParameter = new SqlParameter("@Id", SqlDbType.Int) { Value = orderId };

            try
            {
                SqlDataAccessHelper.ExecuteDeleteQuery(query, sqlParameter);
            }
            catch (Exception ex)
            {
                // Display or log the error message
                MessageBox.Show("Error in DeleteOrder: " + ex.Message);
                throw;
            }
        }
    }
}
