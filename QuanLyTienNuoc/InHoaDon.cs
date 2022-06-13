using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyTienNuoc
{
    public partial class frmInHoaDon : Form
    {
        public static string MaHD = "";
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            if (!string.IsNullOrEmpty(MaHD))
            {
                this.txtMaHD.Text = MaHD;
            }
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1, txtMaHD.Text);

            this.rpInHoaDon.RefreshReport();

            this.rpInHoaDon.RefreshReport();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1,txtMaHD.Text);

            this.rpInHoaDon.RefreshReport();

        }

        private void btnTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               btnTimKiem_Click (sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
