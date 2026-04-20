using Microsoft.VisualBasic.Logging;
using QuanLyTienGioBBD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Color = System.Drawing.Color;
using DataTable = System.Data.DataTable;
using System.Runtime.InteropServices;



namespace QuanLyTienGioBBD.Forms
{
    public partial class FrmTinhTien : Form
    {
        QLBidaDbContext db = new QLBidaDbContext();
        HoaDon hoaDon;
        KhachHang khDangChon = null;
        decimal tongTienTinh = 0;

        public FrmTinhTien(HoaDon hd)
        {
            InitializeComponent();
            this.hoaDon = hd;

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
            lblLoaiKH.ForeColor = Color.Black;
            lblDiem.Text = "Điểm: 0";
            lblUuDai.Text = "Ưu đãi: Không";
        }
        void HienThiThongTin()
        {           

            var ban = db.Ban.FirstOrDefault(x => x.MaBan == hoaDon.BanBidaID);
            if (ban == null) return;

            lblBan.Text = "Bàn: " + ban.TenBan; 

            decimal tienTichLuy = hoaDon.TienDaTichLuy ?? 0m;


            DateTime batDauHienTai = hoaDon.GioBatDau;

            DateTime ketThuc = DateTime.Now;

            TimeSpan tgHienTai = ketThuc - batDauHienTai;          

            int phutHienTai = (int)tgHienTai.TotalMinutes;

            if (phutHienTai < 0) phutHienTai = 0;

            decimal giaHienTai = (ban.LoaiBan.ToUpper() == "VIP") ? 100000m : 80000m;

            decimal tienBanHienTai = (phutHienTai / 60m) * giaHienTai;


            lblBatDau.Text = "Bắt đầu (Bàn này): " + batDauHienTai.ToString("HH:mm");

            lblKetThuc.Text = "Kết thúc: " + ketThuc.ToString("HH:mm");

            lblGiaBan.Text = "Giá: " + giaHienTai.ToString("N0") + " VND/giờ";



            lblThoiGian.Text = "Tổng thời gian chơi: " + phutHienTai + " phút";
           

            lblTienBanHienTai.Text = "Tiền bàn hiện tại: " + tienBanHienTai.ToString("N0") + " VND";

            lblTienBanCu.Text = "Tiền các bàn cũ: " + tienTichLuy.ToString("N0") + " VND";

            if (!string.IsNullOrEmpty(hoaDon.GhiChu))

            {            
                lblGhiChuBanCu.Text = "Lịch sử chặng chơi:\n" + hoaDon.GhiChu.Replace("; ", Environment.NewLine);
            }

            else

            {

                lblGhiChuBanCu.Text = "Lịch sử chặng chơi: (Không có)";

            }          

            decimal tienGocTong = tienTichLuy + tienBanHienTai;

            decimal phanTramGiam = 0m;

            if (khDangChon != null)

            {

                var loai = db.LoaiKhach.Find(khDangChon.LoaiKhachID);

                if (loai != null && loai.TenLoai.ToUpper() == "VIP")

                {

                    phanTramGiam = 0.1m; 

                }

            }
            decimal tienGiam = tienGocTong * phanTramGiam;         

            tongTienTinh = Math.Round((tienGocTong - tienGiam) / 1000m) * 1000m;

            lblUuDai.Text = "Ưu đãi: " + (phanTramGiam * 100).ToString("0") + "%";

            lblTienGoc.Text = "Tiền gốc tổng: " + tienGocTong.ToString("N0") + " VND";

            lblGiamGia.Text = "Giảm giá: -" + tienGiam.ToString("N0") + " VND";


            lblGiamGia.ForeColor = phanTramGiam > 0 ? System.Drawing.Color.Red : System.Drawing.Color.Black;

            lblTongTien.Text = "Tổng tiền thanh toán: " + tongTienTinh.ToString("N0") + " VND";


            if (cboThanhToan.Text == "Chuyển khoản")

            {

                CapNhatQRThanhToan(tongTienTinh, ban.TenBan);

            }

            CapNhatTienThua();


        }       
        void CapNhatTienThua()
        {
            if (cboThanhToan.Text == "Chuyển khoản")
            {
                btnThanhToan.Enabled = true;
                lblTienThua.Text = "Thừa: 0 VND";
                return;
            }

            if (decimal.TryParse(txtTienKhach.Text, out decimal tienKhach))
            {
                decimal tienThua = tienKhach - tongTienTinh;
                if (tienThua < 0)
                {
                    lblTienThua.Text = "Thiếu: " + Math.Abs(tienThua).ToString("N0") + " VND";
                    btnThanhToan.Enabled = false;
                }
                else
                {
                    lblTienThua.Text = "Thừa: " + tienThua.ToString("N0") + " VND";
                    btnThanhToan.Enabled = true;
                }
            }
            else
            {
                btnThanhToan.Enabled = false;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận thanh toán và in hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                var hd = db.HoaDon.Find(hoaDon.MaHD);
                var ban = db.Ban.Find(hoaDon.BanBidaID);
                if (hd == null || ban == null) return;

                hd.GioKetThuc = DateTime.Now;
                ban.TrangThai = "Trống";

                decimal giaHienTai = (ban.LoaiBan != null && ban.LoaiBan.ToUpper() == "VIP") ? 100000m : 80000m;
                decimal tienTichLuy = hd.TienDaTichLuy ?? 0m;
                int phutHienTai = (int)(hd.GioKetThuc.Value - hd.GioBatDau).TotalMinutes;
                decimal tienBanHienTaiHT = (phutHienTai / 60m) * giaHienTai;
                decimal tienGocTong = tienTichLuy + tienBanHienTaiHT;

                decimal phanTramGiam = 0m;
                string tenHienThi = "Khách lẻ";

                if (khDangChon != null)
                {
                    tenHienThi = khDangChon.TenKH; 
                    var loai = db.LoaiKhach.Find(khDangChon.LoaiKhachID);
                    if (loai != null && loai.TenLoai.ToUpper().Contains("VIP")) phanTramGiam = 0.1m;
                    hd.KhachHangID = khDangChon.ID;
                }

                decimal tienGiamGia = tienGocTong * phanTramGiam;
                decimal thanhTienLamTron = Math.Round((tienGocTong - tienGiamGia) / 1000m) * 1000m;

                hd.TongTien = thanhTienLamTron;
                db.SaveChanges();

                
                DataTable dtIn = new DataTable();
                dtIn.Columns.Add("MaHD", typeof(int));             
                dtIn.Columns.Add("TenBan", typeof(string));        
                dtIn.Columns.Add("GioBatDau", typeof(string));   
                dtIn.Columns.Add("GioKetThuc", typeof(string));     
                dtIn.Columns.Add("TongTien", typeof(decimal));      
                dtIn.Columns.Add("NgayLap", typeof(string));        
                dtIn.Columns.Add("GiamGia", typeof(decimal));       
                dtIn.Columns.Add("ThanhTien", typeof(decimal));     
                dtIn.Columns.Add("qr", typeof(byte[]));             
                dtIn.Columns.Add("TienDaTichLuy", typeof(decimal)); 
                dtIn.Columns.Add("TienBanHienTai", typeof(decimal)); 
                dtIn.Columns.Add("GioBatDauCu", typeof(string));    
                dtIn.Columns.Add("GhiChu", typeof(string));         
                dtIn.Columns.Add("GiaBan", typeof(decimal));        
                dtIn.Columns.Add("TenKH", typeof(string));          

                byte[] qrCode = (cboThanhToan.Text == "Chuyển khoản") ? ImageToByteArray(picQR.Image) : null;

               
                dtIn.Rows.Add(
                    hd.MaHD,
                    ban.TenBan,
                    hd.GioBatDau.ToString("HH:mm"),
                    hd.GioKetThuc?.ToString("HH:mm"),
                    Math.Round(tienGocTong),
                    DateTime.Now.ToString("dd/MM/yyyy"),
                    Math.Round(tienGiamGia),
                    thanhTienLamTron,
                    qrCode,
                    Math.Round(tienTichLuy),
                    Math.Round(tienBanHienTaiHT),
                    (tienTichLuy > 0) ? hd.GioBatDau.ToString("HH:mm") : "",
                    hd.GhiChu ?? "",
                    giaHienTai,
                    tenHienThi 
                );

                using (InHoaDon frm = new InHoaDon(dtIn))
                {
                    frm.ShowDialog();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
            }
        private byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void CapNhatQRThanhToan(decimal soTien, string tenBan)
        {
            string url = $"https://img.vietqr.io/image/VietinBank-108878054275-compact2.png?amount={soTien:0}&addInfo=Thanh toan {tenBan}";
            picQR.Load(url);
        }

        private void cboThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            picQR.Visible = cboThanhToan.Text == "Chuyển khoản";
            CapNhatTienThua();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string sdtInput = txtSDT.Text.Trim();
            if (sdtInput.Length >= 10)
            {
               
                var kh = db.KhachHang.ToList().FirstOrDefault(x => x.DienThoai.Trim() == sdtInput);
                if (kh != null)
                {
                    khDangChon = kh;
                    lblTenKH.Text = "Khách: " + kh.TenKH; 
                    lblDiem.Text = "Điểm: " + kh.Diem;

                    var loai = db.LoaiKhach.Find(kh.LoaiKhachID);
                    lblLoaiKH.Text = "Loại KH: " + (loai?.TenLoai ?? "Thường");
                  
                    lblLoaiKH.ForeColor = (loai?.TenLoai == "VIP") ? Color.Red : Color.Black;
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
