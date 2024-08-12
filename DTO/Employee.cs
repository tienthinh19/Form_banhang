using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiTienThinh_22102363.DTO
{
    public class Employee
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public int AccountId { get; set; }
        public string FullName { get; set; }
        public string DiaChi { get; set; }
        public DateTime DateofBirth { get; set; }
        public byte[] Picture { get; set; }
    }

}
