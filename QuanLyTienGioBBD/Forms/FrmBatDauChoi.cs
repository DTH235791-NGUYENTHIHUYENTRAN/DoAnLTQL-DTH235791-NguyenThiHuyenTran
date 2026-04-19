using QuanLyTienGioBBD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmBatDauChoi : Form
    {
        private Ban ban;
        private QLBidaDbContext db = new QLBidaDbContext();

        public FrmBatDauChoi(Ban b)
        {
            InitializeComponent();
            ban = b;
        }

        private void FrmBatDauChoi_Load(object sender, EventArgs e)
        {
            lblBan.Text = ban.TenBan;
            LoadNhanVien();
            dtpBatDau.Value = DateTime.Now;
        }

        void LoadNhanVien()
        {
            db = new QLBidaDbContext();
            var dsNV = db.NhanVien
              .Where(nv => nv.ChucVu == "Nhân viên" && nv.TrangThai == true)
              .ToList();

            cboNhanVien.DataSource = dsNV;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.SelectedIndex = -1;


        }



            private void btnBatDau_Click(object sender, EventArgs e)
                   {
            if (cboNhanVien.SelectedValue == null) { MessageBox.Show("Chọn nhân viên!"); return; }

            var b = db.Ban.Find(ban.MaBan);
            if (db.HoaDon.Any(x => x.BanBidaID == ban.MaBan && x.GioKetThuc == null))
            {
                MessageBox.Show("Bàn đang chơi!"); return;
            }

            HoaDon hd = new HoaDon()
            {
                BanBidaID = b.MaBan,
                NhanVienID = (int)cboNhanVien.SelectedValue,
                GioBatDau = dtpBatDau.Value
            };

            b.TrangThai = "Đang chơi";
            db.HoaDon.Add(hd);
            db.SaveChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        

        private void btnHuy_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }
    }
}
