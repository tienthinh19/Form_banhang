using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BuiTienThinh_22102363.BUS;

namespace BuiTienThinh_22102363
{
    public partial class Chart : Form
    {
        private OrderBUS orderBUS;

        public Chart()
        {
            InitializeComponent();
            orderBUS = new OrderBUS();
            LoadChart(DateTime.Today.AddDays(-7), DateTime.Today);
        }

        private void LoadChart(DateTime startDate, DateTime endDate)
        {
            // Lấy tất cả các đơn hàng từ BUS
            DataTable orders = orderBUS.GetOrdersByDateRange(startDate, endDate);

            // Kiểm tra nếu orders null hoặc không có dòng nào
            if (orders == null || orders.Rows.Count == 0)
            {
                textBox1.Text = "0"; // Hiển thị 0 nếu không có đơn hàng
                chart1.Series.Clear(); // Xóa biểu đồ nếu không có dữ liệu
                return;
            }

            // Nhóm các đơn hàng theo ngày và đếm số lượng
            var ordersGroupedByDate = new Dictionary<DateTime, int>();
            foreach (DataRow row in orders.Rows)
            {
                DateTime date = Convert.ToDateTime(row["OrderDate"]); // Sử dụng cột OrderDate từ DAO
                if (ordersGroupedByDate.ContainsKey(date))
                {
                    ordersGroupedByDate[date] += Convert.ToInt32(row["OrderCount"]);
                }
                else
                {
                    ordersGroupedByDate[date] = Convert.ToInt32(row["OrderCount"]);
                }
            }

            // Xóa series cũ
            chart1.Series.Clear();

            // Tạo mới series và thêm vào chart
            Series series = new Series
            {
                Name = "Orders",
                ChartType = SeriesChartType.Column
            };
            chart1.Series.Add(series);

            // Tạo danh sách tất cả các ngày trong khoảng thời gian
            var allDates = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                     .Select(d => startDate.AddDays(d))
                                     .ToList();

            // Thêm dữ liệu vào series cho từng ngày trong khoảng thời gian
            foreach (var date in allDates)
            {
                int orderCount = ordersGroupedByDate.ContainsKey(date.Date) ? ordersGroupedByDate[date.Date] : 0;
                series.Points.AddXY(date.ToString("dd/MM/yyyy"), orderCount);
            }

            // Cấu hình trục X và Y
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Number of Orders";
            chart1.ChartAreas[0].AxisX.Interval = 1;

            // Tùy chỉnh nhãn trục X
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Định dạng nhãn ngày

            // Đặt tiêu đề cho chart
            chart1.Titles.Clear();
            chart1.Titles.Add("Order Summary");

            // Cập nhật tổng số lượng đơn hàng
            int totalOrders = orders.AsEnumerable().Sum(row => row.Field<int>("OrderCount"));
            textBox1.Text = totalOrders.ToString();
        }













        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            LoadChart(today, today);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime endDate = DateTime.Today;
            DateTime startDate = endDate.AddDays(-7);
            LoadChart(startDate, endDate);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadChart(dateTimePicker1.Value, dateTimePicker2.Value);

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadChart(dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
