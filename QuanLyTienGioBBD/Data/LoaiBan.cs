using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTienGioBBD.Data
{
    public class LoaiBan
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }
        public int GiaTienGio { get; set; }

        public virtual ObservableCollectionListSource<BanBiDa> BanBida { get; } = new();
    }
}
