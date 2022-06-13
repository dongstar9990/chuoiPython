using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace QuanLyTienNuoc
{
    public partial class BaoCao2 : Form
    {
        public BaoCao2()
        {
            InitializeComponent();
        }

        private void Baocao2_Load(object sender, EventArgs e)
        {
           
            this.KHACHHANGTableAdapter.Fill(this.DataSet2.KHACHHANG);
            this.reportViewer2.RefreshReport();  
           
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.KHACHHANGTableAdapter.Fill(this.DataSet2.KHACHHANG);
            this.reportViewer2.RefreshReport();
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn không?", "Thông báo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close(); ;
            
        }
    }
}
