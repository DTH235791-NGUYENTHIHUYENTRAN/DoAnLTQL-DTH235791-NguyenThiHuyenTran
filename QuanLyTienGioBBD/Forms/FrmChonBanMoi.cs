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
    public partial class FrmChonBanMoi : Form
    {
       
        public int MaBanDuocChon { get; set; }

        QLBidaDbContext db = new QLBidaDbContext();
        public FrmChonBanMoi()
        {
            InitializeComponent();
        }

        private void FrmChonBanMoi_Load(object sender, EventArgs e)
        {
            var dsBanTrong = db.Ban.Where(x => x.TrangThai == "Trống").ToList();

            if (dsBanTrong.Count == 0)
            {
                MessageBox.Show("Hiện không còn bàn nào trống!");
                this.Close();
                return;
            }

            // Đổ dữ liệu vào ComboBox
            cboBanTrong.DataSource = dsBanTrong;
            cboBanTrong.DisplayMember = "TenBan"; 
            cboBanTrong.ValueMember = "MaBan";   
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboBanTrong.SelectedValue != null)
            {
                
                MaBanDuocChon = (int)cboBanTrong.SelectedValue;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

