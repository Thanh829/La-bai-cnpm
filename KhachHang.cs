using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopLapTop.Models
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Level { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
