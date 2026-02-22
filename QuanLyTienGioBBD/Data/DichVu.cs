using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTienGioBBD.Data
{
    public class DichVu   
    {
        [Key]
        public int ID { get; set; }

        public string TenDichVu { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
    }
}
