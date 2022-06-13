using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTienNuoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

       
        private void mnuThang_Click(object sender, EventArgs e)
        {
            BaoCao _BaoCao = new BaoCao();
            _BaoCao.Show();
        }

        private void mnuLoaiHinh_Click(object sender, EventArgs e)
        {
            BaoCao2 _BaoCao2 = new BaoCao2();
            _BaoCao2.ShowDialog();

        }

        

        private void mdiKhachHang_Click_1(object sender, EventArgs e)
        {
           
            frmKhachHang _frmKhachHang = new frmKhachHang();
            _frmKhachHang.Show();
            

        }

        private void mniTimKiem_Click_1(object sender, EventArgs e)
        {
            frmTimKiem _frmTimKiem = new frmTimKiem();
            _frmTimKiem.ShowDialog();

        }

        private void mnuThang_Click_1(object sender, EventArgs e)
        {
            BaoCao _BaoCao = new BaoCao();
            _BaoCao.ShowDialog();
        }

        private void mnuLoaiHinh_Click_1(object sender, EventArgs e)
        {
            BaoCao2 _BaoCao2 = new BaoCao2();
            _BaoCao2.ShowDialog();

        }

        private void mnuDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            frmDanhSachHoaDon _frmDanhSachHoaDon = new frmDanhSachHoaDon();
            _frmDanhSachHoaDon.ShowDialog();
        }

        private void mnuCapNhatThongTin_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTin _frmDanhSachHoaDon = new frmCapNhatThongTin();
            _frmDanhSachHoaDon.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //frmDangNhap f12 = new frmDangNhap();
            //this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer t1 = new Timer();
            t1.Interval = 100;
            t1.Start();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoimatkhau dmk = new frmDoimatkhau();
            dmk.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
          
            
        }

        private void đangXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtrogiup tr = new frmtrogiup();
            tr.ShowDialog();
        }

    }
}
