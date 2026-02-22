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
    public partial class FrmBanBiDa : Form
    {
        public FrmBanBiDa()
        {
            InitializeComponent();
        }

        QLBidaDbContext context = new QLBidaDbContext();
        bool xuLyThem = false;
        int id;
        private void BatTatChucNang(bool giaTri)
        {
            btnHuy.Enabled = giaTri;
            btnLuu.Enabled = giaTri;

            txtTen.Enabled = giaTri;
            txtGia.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void FrmBanBiDa_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<LoaiBan> lb = context.LoaiBan.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lb;



            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bindingSource, "TenLoaiBan", false, DataSourceUpdateMode.Never);

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", bindingSource, "GiaTienGio", false, DataSourceUpdateMode.Never);

            dgvLoaiBan.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtTen.Clear();
            txtGia.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            if (dgvLoaiBan.CurrentRow == null) return;

            LoaiBan lb = dgvLoaiBan.CurrentRow.DataBoundItem as LoaiBan;
            if (lb != null)
            {
                id = lb.ID;
            }
        }

            private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiBan.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa loại bàn?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoaiBan lb = dgvLoaiBan.CurrentRow.DataBoundItem as LoaiBan;
                if (lb != null)
                {
                    LoaiBan xoa = context.LoaiBan.Find(lb.ID);
                    if (xoa != null)
                    {
                        context.LoaiBan.Remove(xoa);
                        context.SaveChanges();
                    }
                }

                FrmBanBiDa_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại bàn!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập giá mỗi giờ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtGia.Text, out int giaMoiGio))
            {
                MessageBox.Show("Giá mỗi giờ phải là số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                LoaiBan lb = new LoaiBan();
                lb.TenLoaiBan = txtTen.Text;
                lb.GiaTienGio = giaMoiGio;

                context.LoaiBan.Add(lb);
                context.SaveChanges();
            }
            else
            {
                LoaiBan lb = context.LoaiBan.Find(id);
                if (lb != null)
                {
                    lb.TenLoaiBan = txtTen.Text;
                    lb.GiaTienGio = giaMoiGio;

                    context.LoaiBan.Update(lb);
                    context.SaveChanges();
                }
            }

            FrmBanBiDa_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmBanBiDa_Load(sender, e);
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




