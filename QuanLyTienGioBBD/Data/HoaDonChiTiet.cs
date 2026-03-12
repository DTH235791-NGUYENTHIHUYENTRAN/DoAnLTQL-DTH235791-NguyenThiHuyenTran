using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTienGioBBD.Data
{
    [Table("HoaDonChiTiet")]
    public class HoaDonChiTiet
    {
        [Key]
        public int ID { get; set; }

        public int HoaDonID { get; set; }
        public int DichVuID { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        // Thêm 2 cột này vào để khớp với SQL vừa tạo
        public DateTime? GioBatDau { get; set; }
        public DateTime? GioKetThuc { get; set; }

        [ForeignKey("HoaDonID")]
        public virtual HoaDon HoaDon { get; set; }

        [ForeignKey("DichVuID")]
        public virtual DichVu DichVu { get; set; }
    }
}

