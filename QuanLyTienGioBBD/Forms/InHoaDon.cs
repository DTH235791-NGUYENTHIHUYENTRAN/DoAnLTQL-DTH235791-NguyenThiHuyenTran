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
                
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyTienGioBBD.RptHoaDon.rdlc";
                reportViewer1.LocalReport.EnableExternalImages = true;
         
                reportViewer1.LocalReport.DataSources.Clear();
             
                ReportDataSource rds = new ReportDataSource("DataSet1", _dtHoaDon);
                reportViewer1.LocalReport.DataSources.Add(rds);
               
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

