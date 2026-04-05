using Microsoft.VisualBasic.Logging;
using QuanLyTienGioBBD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmTinhTien : Form
    {
        QLBidaDbContext db = new QLBidaDbContext();
        HoaDon hoaDon;
        KhachHang khDangChon = null;
        decimal tongTienTinh = 0;
        PrintDocument pd = new PrintDocument();

        public FrmTinhTien(HoaDon hd)
        {
            InitializeComponent();
            hoaDon = hd;
            pd.PrintPage += Pd_PrintPage;

        }

        private void FrmTinhTien_Load(object sender, EventArgs e)
        {

            cboThanhToan.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            cboThanhToan.SelectedIndex = 0;
            picQR.Visible = false;
            ResetKhachLe();
            HienThiThongTin();
        }

        void ResetKhachLe()
        {
            khDangChon = null;
            lblTenKH.Text = "Khách lẻ";
            lblLoaiKH.Text = "Loại KH: Thường";
            lblDiem.Text = "Điểm: 0";
            lblUudai.Text = "Ưu đãi: Không";
        }


        void HienThiThongTin()
        {
            
            
                var ban = db.Ban.FirstOrDefault(x => x.MaBan == hoaDon.BanBidaID);
                if (ban == null) return;

                DateTime batDau = hoaDon.GioBatDau;
                DateTime ketThuc = DateTime.Now;
                TimeSpan tg = ketThuc - batDau;

                // 1. Tính số phút (Làm tròn lên để không thiệt tiền giờ của quán)
                decimal soPhut = (decimal)Math.Ceiling(tg.TotalMinutes);
                if (soPhut < 0) soPhut = 0;

                // 2. Xác định giá bàn (VIP 100k, Thường 80k)
                decimal gia = (ban.LoaiBan == "VIP") ? 100000m : 80000m;
                decimal tienGoc = (soPhut / 60m) * gia;

                // 3. Xử lý giảm giá thành viên
                decimal phanTramGiam = 0m;
                if (khDangChon != null)
                {
                    // Kiểm tra loại khách để áp dụng ưu đãi
                    var loai = db.LoaiKhach.Find(khDangChon.LoaiKhachID);
                    if (loai != null && loai.TenLoai == "VIP")
                    {
                        phanTramGiam = 0.1m; // Giảm 10% cho khách VIP
                    }
                }

                // 4. Tính toán số tiền cuối cùng và LÀM TRÒN (Quan trọng để tránh số lẻ)
                decimal tienGiam = tienGoc * phanTramGiam;
                decimal tienChuaLamTron = tienGoc - tienGiam;

                // Làm tròn đến hàng nghìn (Ví dụ: 85.333 -> 85.000) giúp thanh toán tiền mặt dễ dàng
                tongTienTinh = Math.Round(tienChuaLamTron / 1000m) * 1000m;

                // 5. Hiển thị lên giao diện (Sử dụng định dạng "N0" để có dấu phẩy ngăn cách)
                lblBan.Text = "Bàn: " + ban.TenBan;
                lblBatDau.Text = "Bắt đầu: " + batDau.ToString("HH:mm");
                lblKetThuc.Text = "Kết thúc: " + ketThuc.ToString("HH:mm");
                lblThoiGian.Text = "Thời gian: " + (int)soPhut + " phút";
                lblGia.Text = "Giá: " + gia.ToString("N0") + " VND/giờ";

                lblTienGoc.Text = "Tiền gốc: " + tienGoc.ToString("N0") + " VND";

                // Hiển thị số tiền giảm giá rõ ràng
                if (phanTramGiam > 0)
                    lblGiamGia.Text = $"Giảm ({(phanTramGiam * 100):0}%): -" + tienGiam.ToString("N0") + " VND";
                else
                    lblGiamGia.Text = "Giảm: 0 VND";

                // Hiển thị tổng tiền cuối cùng đã được làm tròn
                lblTongTien.Text = "Tổng tiền: " + tongTienTinh.ToString("N0") + " VND";

                // Cập nhật lại tiền thừa ngay lập tức nếu nhân viên đã nhập txtTienKhach
                CapNhatTienThua();
            
            }

        // Tách hàm tính tiền thừa ra để dùng chung
        void CapNhatTienThua()
        {
            if (decimal.TryParse(txtTienKhach.Text, out decimal tienKhach))
            {
                decimal tienThua = tienKhach - tongTienTinh;
                if (tienThua < 0)
                    lblTienThua.Text = "Thiếu: " + Math.Abs(tienThua).ToString("N0") + " VND";
                else
                    lblTienThua.Text = "Thừa: " + tienThua.ToString("N0") + " VND";
            }
        }

       
       

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            try
            {
                var hd = db.HoaDon.Find(hoaDon.MaHD);
                if (hd == null) return;

                // Cập nhật giờ ra và tổng tiền vào DB
                hd.GioKetThuc = DateTime.Now;
                hd.TongTien = tongTienTinh;

                // Gán KhachHangID cho hóa đơn nếu có chọn khách
                if (khDangChon != null)
                {
                    hd.KhachHangID = khDangChon.ID; // Đảm bảo hóa đơn lưu đúng khách nào đã chơi

                    // Logic tích điểm
                    int diemMoi = (int)(tongTienTinh / 10000m);
                    khDangChon.Diem += diemMoi;

                    var loaiVip = db.LoaiKhach.FirstOrDefault(x => x.TenLoai == "VIP");
                    if (loaiVip != null && khDangChon.Diem >= 50 && khDangChon.LoaiKhachID != loaiVip.ID)
                    {
                        khDangChon.LoaiKhachID = loaiVip.ID;
                        MessageBox.Show($"Khách {khDangChon.TenKH} đã lên hạng VIP!", "Thông báo");
                    }
                }

                // Giải phóng bàn
                var ban = db.Ban.Find(hoaDon.BanBidaID);
                if (ban != null) ban.TrangThai = "Trống";

                db.SaveChanges(); // Chỉ cần gọi 1 lần duy nhất ở đây để lưu tất cả

                // In hóa đơn
                PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd, WindowState = FormWindowState.Maximized };
                ppd.ShowDialog();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Arial", 18, FontStyle.Bold);
            Font fHeader = new Font("Arial", 11, FontStyle.Bold);
            Font fBody = new Font("Arial", 10, FontStyle.Regular);
            Font fTotal = new Font("Arial", 12, FontStyle.Bold);
            Pen pen = new Pen(Color.Black, 1);

            float y = 20;
            int x = 10;
            int w = 300; // Độ rộng hóa đơn nhiệt thường dùng

            // Tiêu đề quán
            g.DrawString("BIDA HTran", fTitle, Brushes.Black, x + 80, y); y += 35;
            g.DrawString("ĐC: 123 đường abc, TP Long Xuyên", fBody, Brushes.Black, x + 30, y); y += 20;
            g.DrawString("ĐT: 0909689999", fBody, Brushes.Black, x + 85, y); y += 30;

            g.DrawString("HÓA ĐƠN THANH TOÁN", fHeader, Brushes.Black, x + 60, y); y += 25;
            g.DrawLine(pen, x, y, x + w, y); y += 10;

            // Thông tin bàn và khách
            g.DrawString(lblBan.Text, fBody, Brushes.Black, x, y);
            g.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy"), fBody, Brushes.Black, x + 150, y); y += 25;

            g.DrawString("Khách hàng: " + lblTenKH.Text, fBody, Brushes.Black, x, y); y += 25;
            g.DrawLine(pen, x, y, x + w, y); y += 10;

            // Chi tiết giờ giấc
            g.DrawString(lblBatDau.Text, fBody, Brushes.Black, x, y); y += 20;
            g.DrawString(lblKetThuc.Text, fBody, Brushes.Black, x, y); y += 20;
            g.DrawString(lblThoiGian.Text, fBody, Brushes.Black, x, y);
            g.DrawString(lblGia.Text, fBody, Brushes.Black, x + 150, y); y += 25;

            g.DrawLine(pen, x, y, x + w, y); y += 10;

            // Tiền bạc
            g.DrawString(lblTienGoc.Text, fBody, Brushes.Black, x, y); y += 25;
            g.DrawString(lblGiamGia.Text, fBody, Brushes.Black, x, y); y += 25;

            g.DrawString("THÀNH TIỀN:", fTotal, Brushes.Black, x, y);
            g.DrawString(tongTienTinh.ToString("N0") + " VND", fTotal, Brushes.Black, x + 150, y); y += 35;

            // Chân hóa đơn
            g.DrawString("Cảm ơn Quý khách - Hẹn gặp lại!", new Font("Arial", 9, FontStyle.Italic), Brushes.Black, x + 40, y);
        }



        private void cboThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            picQR.Visible = cboThanhToan.Text == "Chuyển khoản";
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length == 10 && sdt.All(char.IsDigit))
            {
                var kh = db.KhachHang.FirstOrDefault(x => x.DienThoai == sdt);
                if (kh != null)
                {
                    khDangChon = kh;
                    lblTenKH.Text = kh.TenKH;
                    lblDiem.Text = "Điểm: " + kh.Diem;
                    var loaiKH = db.LoaiKhach.Find(kh.LoaiKhachID);
                    lblLoaiKH.Text = "Loại KH: " + (loaiKH?.TenLoai ?? "Thường");
                    lblUudai.Text = (loaiKH?.TenLoai == "VIP") ? "Ưu đãi: Giảm 10%" : "Ưu đãi: Không";
                }
                else ResetKhachLe();
            }
            else ResetKhachLe();
            HienThiThongTin();
        }
    

        private void txtTienKhach_TextChanged(object sender, EventArgs e)
        {
            CapNhatTienThua();
        }
    }
}