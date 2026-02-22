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
    public partial class frmKhachHang : Form
    {

        public frmKhachHang()
        {
            InitializeComponent();
        }
        QLBidaDbContext context = new QLBidaDbContext();       
        bool xuLyThem = false; 
        int id;
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuybo.Enabled = giaTri;
            txtHoTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;


            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btntk.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            var kh = context.KhachHang.ToList();

           
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;

            txtHoTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();

            txtHoTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoTen.Clear();
            txtDienThoai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoVaTen = txtHoTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    context.KhachHang.Add(kh);

                    context.SaveChanges();
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoVaTen = txtHoTen.Text;
                        kh.DienThoai = txtDienThoai.Text;
                        context.KhachHang.Update(kh);

                        context.SaveChanges();
                    }
                }

                frmKhachHang_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();

                frmKhachHang_Load(sender, e);
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtHoTen.Text.Trim();

            var ketQua = context.KhachHang
                .Where(k => k.HoVaTen.Contains(tuKhoa) || k.DienThoai.Contains(tuKhoa))
                .ToList();

            dataGridView1.DataSource = ketQua;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;

            var wb = excel.Workbooks.Add();
            var ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

            ws.Cells[1, 1] = "ID";
            ws.Cells[1, 2] = "Họ tên";
            ws.Cells[1, 3] = "Tên đăng nhập";
            ws.Cells[1, 4] = "Điện thoại";
            ws.Cells[1, 5] = "Địa chỉ";

            var list = context.NhanVien.ToList();

            int row = 2;
            foreach (var nv in list)
            {
                ws.Cells[row, 1] = nv.ID;
                ws.Cells[row, 2] = nv.HoVaTen;
                ws.Cells[row, 3] = nv.TenDangNhap;
                ws.Cells[row, 4] = nv.DienThoai;
                ws.Cells[row, 5] = nv.DiaChi;
                row++;
            }

            MessageBox.Show("Xuất Excel thành công!");
        }
    


        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "CSV file (*.csv)|*.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                var lines = System.IO.File.ReadAllLines(open.FileName);

                for (int i = 1; i < lines.Length; i++) // bỏ dòng tiêu đề
                {
                    var parts = lines[i].Split(',');

                    KhachHang kh = new KhachHang()
                    {
                        HoVaTen = parts[1],
                        DienThoai = parts[2],

                    };

                    context.KhachHang.Add(kh);
                }

                context.SaveChanges();
                frmKhachHang_Load(sender, e);

                MessageBox.Show("Nhập dữ liệu thành công!");
            }
        }
    }
}