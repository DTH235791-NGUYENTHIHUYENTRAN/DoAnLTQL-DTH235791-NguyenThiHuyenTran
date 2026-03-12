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
using Microsoft.VisualBasic;

namespace QuanLyTienGioBBD
{
    public partial class FrmQuanLyBan : Form
    {
        QLBidaDbContext context = new QLBidaDbContext();
        public FrmQuanLyBan()
        {
            InitializeComponent();
        }
        void LoadBan()
        {
            context = new QLBidaDbContext();

            var ds = context.BanBida
                .Select(b => new
                {
                    MaBan = b.ID,
                    TenBan = b.TenBan,
                    LoaiBan = b.LoaiBan.TenLoaiBan,
                    TrangThai = b.TrangThai,
                    // Lấy giờ bắt đầu của hóa đơn chưa thanh toán (nếu có)
                    GioBatDau = context.HoaDon
                        .Where(h => h.BanBidaID == b.ID && h.GioKetThuc == null)
                        .Select(h => h.GioBatDau)
                        .FirstOrDefault()
                })
                .ToList();

            dgvBan.DataSource = ds;
        }

        private void FrmQuanLyBan_Load(object sender, EventArgs e)
        {
            dgvBan.AutoGenerateColumns = false;
            LoadBan();
        }


        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text)) return;

            int maBan = int.Parse(txtMaBan.Text);
            var ban = context.BanBida.Find(maBan);

            if (ban.TrangThai == "Đang chơi")
            {
                MessageBox.Show("Bàn này đã có khách đang chơi!");
                return;
            }

            try
            {
                // Tạo hóa đơn mới để tính giờ
                HoaDon hd = new HoaDon();
                hd.BanBidaID = maBan;
                hd.GioBatDau = DateTime.Now; // Ghi nhận giờ vào
                hd.GioKetThuc = null;        // Chưa có giờ ra

                context.HoaDon.Add(hd);

                // Đổi trạng thái bàn
                ban.TrangThai = "Đang chơi";

                context.SaveChanges();
                LoadBan();
                MessageBox.Show($"Đã bắt đầu tính giờ cho {ban.TenBan}");
            }
            catch (Exception ex)
            {
                // Lấy thông báo lỗi chi tiết nhất
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nChi tiết: " + ex.InnerException.Message;
                }
                MessageBox.Show(errorMessage, "Lỗi khi lưu dữ liệu");
            }
        }
        private void btntt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaBan.Text, out int maBan)) return;

            // Tìm hóa đơn của bàn này mà chưa kết thúc giờ
            var hd = context.HoaDon
                .FirstOrDefault(p => p.BanBidaID == maBan && p.GioKetThuc == null);

            if (hd == null)
            {
                MessageBox.Show("Bàn này đang trống, không thể thanh toán!");
                return;
            }

            if (MessageBox.Show("Xác nhận kết thúc giờ chơi và thanh toán?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Chốt giờ kết thúc ngay lúc này
                hd.GioKetThuc = DateTime.Now;

                // Trả bàn về trạng thái Trống
                var ban = context.BanBida.Find(maBan);
                ban.TrangThai = "Trống";

                context.SaveChanges();

                // MỞ FORM CHI TIẾT ĐỂ TÍNH TIỀN GIỜ + TIỀN NƯỚC
                FrmHoaDon_ChiTiet f = new FrmHoaDon_ChiTiet(hd.MaHD);
                f.ShowDialog();

                LoadBan();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiban_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaBan.Text, out int maBanCu)) return;

            var hd = context.HoaDon.FirstOrDefault(p => p.BanBidaID == maBanCu && p.GioKetThuc == null);
            if (hd == null)
            {
                MessageBox.Show("Bàn này không có khách để đổi!");
                return;
            }

            string input = Interaction.InputBox("Nhập mã bàn muốn chuyển đến:", "Đổi bàn", "");
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int maBanMoi)) return;

            var banMoi = context.BanBida.Find(maBanMoi);
            if (banMoi == null || banMoi.TrangThai == "Đang chơi")
            {
                MessageBox.Show("Bàn mới không tồn tại hoặc đang có khách!");
                return;
            }

            // Thực hiện đổi bàn cho hóa đơn
            var banCu = context.BanBida.Find(maBanCu);
            hd.BanBidaID = maBanMoi;
            banCu.TrangThai = "Trống";
            banMoi.TrangThai = "Đang chơi";

            context.SaveChanges();
            MessageBox.Show("Đổi bàn thành công!");
            LoadBan();
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBan.Rows[e.RowIndex];

                // Gán dữ liệu vào các TextBox (đảm bảo tên cột trong ngoặc trùng với DataPropertyName)
                txtMaBan.Text = row.Cells["MaBan"].Value?.ToString();
                txtLoaiBan.Text = row.Cells["LoaiBan"].Value?.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }
    }
}

