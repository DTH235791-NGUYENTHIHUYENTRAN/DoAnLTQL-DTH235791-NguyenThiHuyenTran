using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTienGioBBD.Data
{
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }

        public string TenKH { get; set; }   // 🔥 sửa lại
        public string DienThoai { get; set; }
        public int Diem { get; set; }
        public int LoaiKhachID { get; set; }

        public virtual LoaiKhach LoaiKhach { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; } = new List<HoaDon>();
    }
}
