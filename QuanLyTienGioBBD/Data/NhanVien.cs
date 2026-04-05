using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTienGioBBD.Data
{
    public class NhanVien
    {
        [Key]
            public int MaNV { get; set; }
            public string TenNV { get; set; }
            public string TenDangNhap { get; set; }
            public string MatKhau { get; set; }
            public string SoDienThoai { get; set; }
            public string ChucVu { get; set; }
        }
    }
    


