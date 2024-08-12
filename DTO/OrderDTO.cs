using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiTienThinh_22102363.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
       
        public int EmployeeId { get; set; }
    }
}
