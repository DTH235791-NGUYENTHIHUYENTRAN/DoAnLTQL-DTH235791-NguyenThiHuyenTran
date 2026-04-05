using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTienGioBBD.Data;


namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmQuanLyBan : Form
    {
        string role;
        QLBidaDbContext db = new QLBidaDbContext();
        Ban banDangChon = null;

        public FrmQuanLyBan(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void FrmQuanLyBan_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Đang chơi");

            cboLoaiBan.Items.Add("VIP");
            cboLoaiBan.Items.Add("Thuong");

            LoadBan();

        }

        public void LoadBan()
        {
            db = new QLBidaDbContext(); // Refresh DB
            flowLayoutPanelThuong.Controls.Clear();
            var dsBan = db.Ban.ToList();

            foreach (var ban in dsBan)
            {
                Button btn = new Button { Width = 120, Height = 90 };
                bool dangChoi = db.HoaDon.Any(x => x.BanBidaID == ban.MaBan && x.GioKetThuc == null);
                string tt = dangChoi ? "đang chơi" : "trống";

                btn.Text = $"[{ban.MaBan}] {ban.TenBan}\n{tt}";
                btn.BackColor = (ban.LoaiBan == "VIP") ? (dangChoi ? Color.DeepPink : Color.Pink) : (dangChoi ? Color.Red : Color.Green);
                btn.ForeColor = Color.White;

                btn.Click += (s, e) => {
                    banDangChon = ban;
                    txtTenBan.Text = ban.TenBan;
                    cboTrangThai.Text = dangChoi ? "Đang chơi" : "Trống";
                    cboLoaiBan.Text = ban.LoaiBan;
                };
                flowLayoutPanelThuong.Controls.Add(btn);
            
        }
        }

      

        private bool XacNhanAdmin()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập mật khẩu Admin:", "Xác nhận", "");

            if (string.IsNullOrWhiteSpace(input))
                return false;

            if (input == "123") return true;

            MessageBox.Show("Sai mật khẩu!");
            return false;

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!XacNhanAdmin()) return;

            if (string.IsNullOrWhiteSpace(txtTenBan.Text) ||
                string.IsNullOrWhiteSpace(cboTrangThai.Text))
            {
                MessageBox.Show("Nhập đủ thông tin!");
                return;
            }

            string tenBan = txtTenBan.Text.Trim();

            if (db.Ban.Any(x => x.TenBan.ToLower() == tenBan.ToLower()))
            {
                MessageBox.Show("Tên bàn đã tồn tại!");
                return;
            }

            Ban b = new Ban()
            {
                TenBan = tenBan,
                TrangThai = cboTrangThai.Text,
                LoaiBan = cboLoaiBan.Text
            };

            db.Ban.Add(b);
            db.SaveChanges();

            MessageBox.Show("Thêm thành công!");
            LoadBan();
            banDangChon = null;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!XacNhanAdmin()) return;

            if (banDangChon == null)
            {
                MessageBox.Show("Chọn bàn!");
                return;
            }

            var ban = db.Ban.Find(banDangChon.MaBan);
            if (ban == null) return;

            ban.TenBan = txtTenBan.Text.Trim();          
            ban.LoaiBan = cboLoaiBan.Text;

            db.SaveChanges();

            MessageBox.Show("Sửa thành công!");
            LoadBan();
            banDangChon = null;

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!XacNhanAdmin()) return;

            if (banDangChon == null)
            {
                MessageBox.Show("Chọn bàn!");
                return;
            }

            if (MessageBox.Show("Xóa bàn này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var ban = db.Ban.Find(banDangChon.MaBan);

            if (ban != null)
            {
                db.Ban.Remove(ban);
                db.SaveChanges();
            }
            MessageBox.Show("Xóa thành công!");
            LoadBan();
            banDangChon = null;

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (banDangChon == null) return;
            FrmBatDauChoi f = new FrmBatDauChoi(banDangChon);
            if (f.ShowDialog() == DialogResult.OK) LoadBan();

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (banDangChon == null) return;
            var hd = db.HoaDon.FirstOrDefault(x => x.BanBidaID == banDangChon.MaBan && x.GioKetThuc == null);
            if (hd == null) { MessageBox.Show("Bàn trống!"); return; }

            FrmTinhTien f = new FrmTinhTien(hd);
            if (f.ShowDialog() == DialogResult.OK) LoadBan();
        }
            

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}




