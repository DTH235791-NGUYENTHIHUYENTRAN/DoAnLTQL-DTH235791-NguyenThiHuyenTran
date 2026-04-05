using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTienGioBBD.Data
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }

        public int BanBidaID { get; set; }

        public int? NhanVienID { get; set; }

        public int? KhachHangID { get; set; }

        public DateTime GioBatDau { get; set; } = DateTime.Now;

        public DateTime? GioKetThuc { get; set; }

        public decimal? TongTien { get; set; }

        // NAVIGATION
        public virtual Ban BanBida { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}