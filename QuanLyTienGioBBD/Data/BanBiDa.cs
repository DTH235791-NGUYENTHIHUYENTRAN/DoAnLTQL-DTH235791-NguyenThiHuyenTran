using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTienGioBBD.Data
{
    public class BanBiDa
    {
        public int ID { get; set; }
        public int LoaiBanID { get; set; }
        public string TenBan { get; set; }
        public string TrangThai { get; set; }
        public bool DangSuDung { get; set; }

        public virtual LoaiBan LoaiBan { get; set; } = null!;
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
