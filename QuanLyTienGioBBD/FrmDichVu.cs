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
    public partial class FrmDichVu : Form
    {
        public FrmDichVu()
        {
            InitializeComponent();
        }
        QLBidaDbContext context = new QLBidaDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnHuyBo.Enabled = giaTri;
            btnLuu.Enabled = giaTri;

            txttenDv.Enabled = giaTri;
            txtDonGia.Enabled = giaTri;
            txtSoLuong.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<DichVu> dv = context.DichVu.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dv;

            txttenDv.DataBindings.Clear();
            txttenDv.DataBindings.Add("Text", bindingSource, "TenDichVu", false, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            dgvDichVu.DataSource = bindingSource;

            // Hiển thị đẹp (tuỳ chọn)
            dgvDichVu.Columns["ID"].HeaderText = "ID";
            dgvDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDichVu.Columns["SoLuong"].HeaderText = "Số lượng";

            dgvDichVu.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDichVu.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txttenDv.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvDichVu.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa dịch vụ?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvDichVu.CurrentRow.Cells["ID"].Value.ToString());

                DichVu dv = context.DichVu.Find(id);
                if (dv != null)
                {
                    context.DichVu.Remove(dv);
                    context.SaveChanges();
                }

                FrmDichVu_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttenDv.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtDonGia.Text, out int donGia))
            {
                MessageBox.Show("Đơn giá phải là số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Số lượng phải là số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                DichVu dv = new DichVu();
                dv.TenDichVu = txttenDv.Text;
                dv.DonGia = donGia;
                dv.SoLuong = soLuong;

                context.DichVu.Add(dv);
                context.SaveChanges();
            }
            else
            {
                DichVu dv = context.DichVu.Find(id);
                if (dv != null)
                {
                    dv.TenDichVu = txttenDv.Text;
                    dv.DonGia = donGia;
                    dv.SoLuong = soLuong;

                    context.DichVu.Update(dv);
                    context.SaveChanges();
                }
            }

            FrmDichVu_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            FrmDichVu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}



