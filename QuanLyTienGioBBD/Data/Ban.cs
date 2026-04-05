using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTienGioBBD.Data
{
    public class Ban
    {
        [Key]
        public int MaBan { get; set; }
        public string TenBan { get; set; }
        public string TrangThai { get; set; }
        public string LoaiBan { get; set; }
        public DateTime? GioBatDau { get; set; }

    }
}
