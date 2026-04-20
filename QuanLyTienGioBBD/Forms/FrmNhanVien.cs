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

namespace QuanLyTienGioBBD
{
    public partial class FrmNhanVien : Form
    {
        private QLBidaDbContext db = new QLBidaDbContext();
        private int? maDangChon = null;
        private string role;
        private bool dangThem = false;

        public FrmNhanVien(string role)
        {
            InitializeComponent();
            this.role = role;
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            LoadData();
            BatTatChinhSua(false);
        }

        private void LoadChucVu()
        {
            cboChucVu.Items.Clear();
            
            cboChucVu.Items.AddRange(new string[] { "Admin", "Ca Sáng", "Ca Chiều", "Ca Tối", "Nhân viên" });
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.SelectedIndex = 2; // Mặc định chọn Nhân viên
        }

        private void BatTatChinhSua(bool allows)
        {
            bool isAdmin = string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);
            bool isManager = string.Equals(role, "Quản lý", StringComparison.OrdinalIgnoreCase);

            txtHoVaTen.Enabled = allows;
            txtSoDienThoai.Enabled = allows;
            txtMatKhau.Enabled = allows;

           
            txtTenDangNhap.Enabled = allows;

           
            cboChucVu.Enabled = allows && (isAdmin || isManager);

          
            btnThem.Enabled = !allows;
            btnSua.Enabled = !allows;
            btnLuu.Enabled = allows;
            btnHuyBo.Enabled = allows;
        }

        private void CapNhatTrangThaiTaiKhoan(bool allows)
        {
            string cv = cboChucVu.Text;
           
            bool chucVuCoTaiKhoan = (cv != "Nhân viên");

          
            txtTenDangNhap.Enabled = allows && chucVuCoTaiKhoan;
            txtMatKhau.Enabled = allows && chucVuCoTaiKhoan;

            if (!chucVuCoTaiKhoan)
            {
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                txtTenDangNhap.BackColor = Color.LightGray;
                txtMatKhau.BackColor = Color.LightGray;
            }
            else
            {
                
                txtTenDangNhap.BackColor = allows ? Color.White : Color.LightGray;
                txtMatKhau.BackColor = allows ? Color.White : Color.LightGray;
            }
        }
           
        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnLuu.Enabled) CapNhatTrangThaiTaiKhoan(true);

        }
        private void LoadData()
        {
            try
            {
                db = new QLBidaDbContext(); 
                var list = db.NhanVien
                   // .Where(nv => nv.TrangThai == true)
                    .Select(nv => new {
                        nv.MaNV,
                        nv.TenNV,
                        nv.SoDienThoai,
                        TinhTrang = nv.TrangThai == true ? "Đang làm" : "Đã nghỉ",
                        nv.TenDangNhap,
                        nv.MatKhau,
                        nv.ChucVu
                    }).ToList();

                dgvNhanVien.DataSource = list;

                if (dgvNhanVien.Columns["MatKhau"] != null)
                    dgvNhanVien.Columns["MatKhau"].Visible = false;

                DinhDangLuoi();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        
    }
          

        private void DinhDangLuoi()
        {
            if (dgvNhanVien.Columns["MaNV"] == null) return;
            dgvNhanVien.Columns["MaNV"].HeaderText = "ID";
            dgvNhanVien.Columns["TenNV"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["SoDienThoai"].HeaderText = "SĐT";
            dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tài Khoản";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["TinhTrang"].HeaderText = "Trạng Thái";
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
            {
            dangThem = true;
            maDangChon = null;
            ClearForm();
            BatTatChinhSua(true);
            txtHoVaTen.Focus();
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên nhân viên!");
                txtHoVaTen.Focus();
                return;
            }

            try
            {
                using (var context = new QLBidaDbContext())
                {
                    bool canCoTaiKhoan = (cboChucVu.Text != "Nhân viên");
                    string tenDN = txtTenDangNhap.Text.Trim();

                    if (dangThem) 
                    {
                       
                        if (canCoTaiKhoan && !string.IsNullOrEmpty(tenDN))
                        {
                            if (context.NhanVien.Any(x => x.TenDangNhap == tenDN))
                            {
                                MessageBox.Show("Tên đăng nhập này đã tồn tại!");
                                return;
                            }
                        }

                        NhanVien nvMoi = new NhanVien
                        {
                            TenNV = txtHoVaTen.Text.Trim(),
                            SoDienThoai = txtSoDienThoai.Text.Trim(),
                            ChucVu = cboChucVu.Text,
                            TenDangNhap = canCoTaiKhoan ? (string.IsNullOrEmpty(tenDN) ? null : tenDN) : null,
                            MatKhau = canCoTaiKhoan ? (string.IsNullOrEmpty(txtMatKhau.Text) ? "123" : txtMatKhau.Text) : null,
                            TrangThai = true
                        };
                        context.NhanVien.Add(nvMoi);
                    }
                    else 
                    {
                        var nvSua = context.NhanVien.Find(maDangChon);
                        if (nvSua != null)
                        {
                            nvSua.TenNV = txtHoVaTen.Text.Trim();
                            nvSua.SoDienThoai = txtSoDienThoai.Text.Trim();
                            nvSua.ChucVu = cboChucVu.Text;

                           
                            if (canCoTaiKhoan)
                            {
                               
                                if (!string.IsNullOrEmpty(tenDN) && context.NhanVien.Any(x => x.TenDangNhap == tenDN && x.MaNV != (int)maDangChon))
                                {
                                    MessageBox.Show("Tên đăng nhập đã được người khác sử dụng!");
                                    return;
                                }
                                nvSua.TenDangNhap = string.IsNullOrEmpty(tenDN) ? null : tenDN;
                                if (!string.IsNullOrWhiteSpace(txtMatKhau.Text)) nvSua.MatKhau = txtMatKhau.Text;
                            
                        }
                            else
                            {
                                nvSua.TenDangNhap = null;
                                nvSua.MatKhau = null;
                            }
                           
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Lưu thành công!");
                    dangThem = false;
                    BatTatChinhSua(false);
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.InnerException?.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Lỗi: " + msg);
            }
            }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            try
            {
                using (var context = new QLBidaDbContext())
                {
                    var nv = context.NhanVien.Find(maDangChon);
                    if (nv == null) return;

                   
                    if (nv.ChucVu == "Admin")
                    {
                        MessageBox.Show("Không thể xóa tài khoản Admin!");
                        return;
                    }

                    var result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {nv.TenNV}?\n(Dữ liệu lịch sử của nhân viên này vẫn sẽ được giữ lại)",
                                                 "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                       
                        nv.TrangThai = false;

                        context.SaveChanges();

                        MessageBox.Show("Đã xóa nhân viên thành công!");
                        maDangChon = null;
                        ClearForm();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            dangThem = false;
            BatTatChinhSua(false);
            LoadData();
            ClearForm();

        }

        private void ClearForm()
        {
            txtMaNV.Clear();
            txtHoVaTen.Clear();
            txtSoDienThoai.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();           
            cboChucVu.Text = "Nhân viên";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || btnLuu.Enabled) return;

            var row = dgvNhanVien.Rows[e.RowIndex];

          
            if (row.Cells["MaNV"].Value == null || row.Cells["MaNV"].Value == DBNull.Value) return;

            maDangChon = Convert.ToInt32(row.Cells["MaNV"].Value);
            txtMaNV.Text = maDangChon.ToString();

            txtHoVaTen.Text = row.Cells["TenNV"].Value?.ToString() ?? "";
            txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? "";
            txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString() ?? "";
            txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString() ?? "";
            cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString() ?? "Nhân viên";

            CapNhatTrangThaiTaiKhoan(false);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn sửa!");
                return;
            }
            dangThem = false;
            BatTatChinhSua(true); 
            CapNhatTrangThaiTaiKhoan(true);
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;


        }
        }
    }

