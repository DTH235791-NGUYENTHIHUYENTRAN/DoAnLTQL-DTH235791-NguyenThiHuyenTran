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
    public partial class FrmKhachHang : Form
    {

        private string role;
        private QLBidaDbContext db = new QLBidaDbContext();
        private int? idDangChon = null;

        public FrmKhachHang(string role)
        {
            InitializeComponent();
            this.role = role;

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadLoaiKhach();
            LoadUuDai();
            LoadData();

            // Phân quyền chuyên nghiệp
            bool isAdmin = string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);
            btnXoa.Visible = isAdmin;
            txtDiem.ReadOnly = !isAdmin;
            txtDiem.BackColor = isAdmin ? Color.White : Color.LightYellow; // Đổi màu để nhân viên biết không sửa được
        }

        void LoadLoaiKhach()
        {
            using (var context = new QLBidaDbContext())
            {
                cboLoaiKH.DataSource = context.LoaiKhach.ToList();
                cboLoaiKH.DisplayMember = "TenLoai";
                cboLoaiKH.ValueMember = "ID";
                cboLoaiKH.SelectedIndex = -1;
            }
        }

        void LoadUuDai()
        {
            cboUuDai.Items.Clear();
            cboUuDai.Items.AddRange(new object[] { "0%", "5%", "10%", "15%", "20%" });
            cboUuDai.SelectedIndex = 0;
        }

        void LoadData()
        {
            db = new QLBidaDbContext();
            var data = db.KhachHang
                .Select(kh => new
                {
                    kh.ID,
                    kh.TenKH,
                    SDT = kh.DienThoai,
                    LoaiKH = kh.LoaiKhach.TenLoai,
                    kh.Diem,
                    kh.LoaiKhachID
                })
                .ToList();

            dgvKhachHang.DataSource = data;
            DinhDangLuoi();
        }

        void DinhDangLuoi()
        {
            if (dgvKhachHang.Columns["ID"] != null) dgvKhachHang.Columns["ID"].HeaderText = "Mã KH";
            if (dgvKhachHang.Columns["TenKH"] != null) dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách";
            if (dgvKhachHang.Columns["SDT"] != null) dgvKhachHang.Columns["SDT"].HeaderText = "SĐT";
            if (dgvKhachHang.Columns["LoaiKH"] != null) dgvKhachHang.Columns["LoaiKH"].HeaderText = "Hạng";
            if (dgvKhachHang.Columns["Diem"] != null) dgvKhachHang.Columns["Diem"].HeaderText = "Điểm Tích Lũy";
            if (dgvKhachHang.Columns["LoaiKhachID"] != null) dgvKhachHang.Columns["LoaiKhachID"].Visible = false;

            // XỊN: Tô màu cho khách VIP để nhân viên dễ nhận diện
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.Cells["LoaiKH"].Value?.ToString() == "VIP")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                    row.DefaultCellStyle.Font = new Font(dgvKhachHang.Font, FontStyle.Bold);
                }
            }
        }

        void ClearForm()
        {
            txtMaKH.Clear(); txtTenKH.Clear(); txtDienThoai.Clear();
            txtDiem.Text = "0"; cboLoaiKH.SelectedIndex = -1;
            idDangChon = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearForm();           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách để sửa!");
                return;
            }
            // Logic sửa thực tế nằm ở nút Lưu (btnLuu) sau khi người dùng thay đổi text
            txtTenKH.Focus();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idDangChon == null) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này? Dữ liệu hóa đơn cũ có thể bị ảnh hưởng.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var kh = db.KhachHang.Find(idDangChon);
                if (kh != null)
                {
                    db.KhachHang.Remove(kh);
                    db.SaveChanges();
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Đã xóa khách hàng.");
                }
            }

        }

        private void btntk_Click(object sender, EventArgs e)
        {
            // Tìm kiếm thông minh: Gõ đến đâu tìm đến đó
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            var result = db.KhachHang
                .Where(x => x.TenKH.ToLower().Contains(keyword) || x.DienThoai.Contains(keyword))
                .Select(kh => new
                {
                    kh.ID,
                    kh.TenKH,
                    SDT = kh.DienThoai,
                    LoaiKH = kh.LoaiKhach.TenLoai,
                    kh.Diem,
                    kh.LoaiKhachID
                }).ToList();

            dgvKhachHang.DataSource = result;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            ClearForm();           
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Nhắc nhở");
                return;
            }

            try
            {
                int diem = 0;
                int.TryParse(txtDiem.Text, out diem);

                if (idDangChon == null) // Thêm mới
                {
                    db.KhachHang.Add(new KhachHang
                    {
                        TenKH = txtTenKH.Text.Trim(),
                        DienThoai = txtDienThoai.Text.Trim(),
                        LoaiKhachID = (int)cboLoaiKH.SelectedValue,
                        Diem = diem
                    });
                }
                else // Sửa
                {
                    var kh = db.KhachHang.Find(idDangChon);
                    if (kh != null)
                    {
                        kh.TenKH = txtTenKH.Text.Trim();
                        kh.DienThoai = txtDienThoai.Text.Trim();
                        kh.LoaiKhachID = (int)cboLoaiKH.SelectedValue;
                        kh.Diem = diem;

                        // XỊN: Tự động thăng hạng nếu đủ 100 điểm
                        if (kh.Diem >= 100)
                        {
                            var vipType = db.LoaiKhach.FirstOrDefault(l => l.TenLoai == "VIP");
                            if (vipType != null) kh.LoaiKhachID = vipType.ID;
                        }
                    }
                }
                db.SaveChanges();
                LoadData();
                ClearForm();
                MessageBox.Show("Đã cập nhật danh sách khách hàng!", "Thành công");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }



        }


        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvKhachHang.Rows[e.RowIndex];
            idDangChon = Convert.ToInt32(row.Cells["ID"].Value);

            txtMaKH.Text = idDangChon.ToString();
            txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
            txtDienThoai.Text = row.Cells["SDT"].Value?.ToString();
            txtDiem.Text = row.Cells["Diem"].Value?.ToString();
            cboLoaiKH.SelectedValue = row.Cells["LoaiKhachID"].Value;

            // XỊN: Tự nhảy ưu đãi theo hạng khách
            string hang = row.Cells["LoaiKH"].Value?.ToString();
            if (hang == "VIP") cboUuDai.Text = "10%";
            else if (hang == "Thành viên") cboUuDai.Text = "5%";
            else cboUuDai.Text = "0%";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // XỊN: Gõ tới đâu tìm tới đó (Real-time Search)
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var query = db.KhachHang.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.TenKH.ToLower().Contains(keyword) || x.DienThoai.Contains(keyword));
            }

            dgvKhachHang.DataSource = query.Select(kh => new
            {
                kh.ID,
                kh.TenKH,
                SDT = kh.DienThoai,
                LoaiKH = kh.LoaiKhach.TenLoai,
                kh.Diem,
                kh.LoaiKhachID
            }).ToList();

            DinhDangLuoi();
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
        }

     
    



