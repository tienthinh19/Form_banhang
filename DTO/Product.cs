using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiTienThinh_22102363.DTO
{
    internal class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public int CategoryId { get; set; }
        public byte[] Picture { get; set; }
    }
}

