using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTienGioBBD.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int BanBidaID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime GioBatDau { get; set; }
        public DateTime? GioKetThuc { get; set; }
        public decimal TongTien { get; set; }

        public virtual BanBiDa BanBida { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
