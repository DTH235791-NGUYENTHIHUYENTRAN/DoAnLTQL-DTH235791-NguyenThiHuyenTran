using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTienGioBBD.Data
{
    public class NhanVien
    {
        [Key]
       
        public int MaNV { get; set; }

        [Required] // Tên nhân viên thì không nên để trống
        public string TenNV { get; set; }

        // Thêm dấu ? để khẳng định cho phép Null
        public string? TenDangNhap { get; set; }
        public string? MatKhau { get; set; }
        public string? SoDienThoai { get; set; }
        public string? ChucVu { get; set; }

        public bool TrangThai { get; set; }
    }
    }
    


