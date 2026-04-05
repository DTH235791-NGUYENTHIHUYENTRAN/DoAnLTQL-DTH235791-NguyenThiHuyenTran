using System;
using System.Collections.Generic;

namespace QuanLyTienGioBBD.Data
{
    public class LoaiKhach
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
    }
}