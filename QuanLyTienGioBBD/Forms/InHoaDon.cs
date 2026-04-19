using Microsoft.Reporting.WinForms;
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
    public partial class InHoaDon : Form
    {
        private DataTable _dtHoaDon;
        public InHoaDon(DataTable dt)
        {
            InitializeComponent();
            this._dtHoaDon = dt;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Chỉ định đường dẫn file báo cáo (.rdlc)
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTienGioBBD.RptHoaDon.rdlc";

                // 2. Cho phép hiển thị ảnh (QR Code) được truyền dưới dạng mảng byte từ DataTable
                reportViewer1.LocalReport.EnableExternalImages = true;

                // 3. Xóa các nguồn dữ liệu cũ và nạp DataSet mới
                reportViewer1.LocalReport.DataSources.Clear();

                // LƯU Ý: Tên "DataSet1" phải đặt trùng khớp hoàn toàn với tên DataSet trong file thiết kế RDLC
                ReportDataSource rds = new ReportDataSource("DataSet1", _dtHoaDon);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 4. Làm mới và hiển thị báo cáo
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

