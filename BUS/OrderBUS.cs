using BuiTienThinh_22102363.DAO;
using BuiTienThinh_22102363.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiTienThinh_22102363.BUS
{
    public class OrderBUS
    {
        private OrderDAO orderDAO;

        public OrderBUS()
        {
            orderDAO = new OrderDAO();
        }

        public DataTable GetAllOrders()
        {
            return orderDAO.GetAllOrders();
        }
        /* public DataTable GetOrdersByDateRange(DateTime startDate, DateTime endDate)
         {
             // Tạo chuỗi truy vấn SQL với các giá trị tham số được thay thế bằng các giá trị cụ thể
             string query = $@"SELECT [Id], [Date], [Status], [EmployeeId]
                       FROM [Order]
                       WHERE [Date] BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'";

             // Gọi phương thức ExecuteSelectAllQuery với chuỗi truy vấn SQL đã chuẩn bị
             return SqlDataAccessHelper.ExecuteSelectAllQuery(query);
         }*/
        public DataTable GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return orderDAO.GetOrdersByDateRange(startDate, endDate);
        }

        public void InsertOrder(OrderDTO order)
        {
            // Here you can add additional business logic if needed before inserting
            orderDAO.InsertOrder(order);
        }

        public void UpdateOrder(OrderDTO order)
        {
            // Here you can add additional business logic if needed before updating
            orderDAO.UpdateOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            // Here you can add additional business logic if needed before deleting
            orderDAO.DeleteOrder(orderId);
        }
    }
}

