using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTienGioBBD.Data
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }

        public int BanBidaID { get; set; }

        public int? NhanVienID { get; set; }   // cho phép null
        public int? KhachHangID { get; set; }  // cho phép null

        public DateTime? GioBatDau { get; set; }

        public DateTime? GioKetThuc { get; set; } // cho phép null

        public decimal? TongTien { get; set; } // cho phép null

        public virtual BanBiDa BanBida { get; set; } = null!;
        public virtual NhanVien? NhanVien { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
    }
}
