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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        kenoicosodulieu con = new kenoicosodulieu();

        private void fromTimKiem_Load(object sender, EventArgs e)
        {
            cmbCachTim.Text = "Mã KH";
            comboBox1.Text = "Mã HD";
            dataGridView1.DataSource = con.HienDL("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.TenKH,LOAIHINHSD.LoaiSD,HOADON.Thang,LOAIHINHSD.DonGia,HOADON.SoSD,HOADON.ThanhTien,HOADON.ThanhToan,HOADON.NgayLap FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai  ");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbCachTim.Text == "Mã KH")
            {
                kenoicosodulieu.OpenConnection();
                dgvThongTin.DataSource = con.HienDL("select K.MaKH, K.MaDH, K.TenKH, K.DiaChi, K.SDT, L.LoaiSD, K.GhiChu from KHACHHANG K inner join HOADON H on K.MaKH = H.MaKH inner join LOAIHINHSD L on H.MaLoai = L.MaLoai where K.MaKH like N'%" + txtTuTim.Text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Mã DH")
            {
                kenoicosodulieu.OpenConnection();
                dgvThongTin.DataSource = con.HienDL("select K.MaKH, K.MaDH, K.TenKH, K.DiaChi, K.SDT, L.LoaiSD, K.GhiChu from KHACHHANG K inner join HOADON H on K.MaKH = H.MaKH inner join LOAIHINHSD L on H.MaLoai = L.MaLoai where K.MaDH like N'%" + txtTuTim.Text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Tên KH")
            {
                kenoicosodulieu.OpenConnection();
                dgvThongTin.DataSource = con.HienDL("select K.MaKH, K.MaDH, K.TenKH, K.DiaChi, K.SDT, L.LoaiSD, K.GhiChu from KHACHHANG K inner join HOADON H on K.MaKH = H.MaKH inner join LOAIHINHSD L on H.MaLoai = L.MaLoai where K.TenKH like N'%" + txtTuTim.Text.Trim() + "%' ");
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
           
        }

        private void txtTuTim_TextChanged(object sender, EventArgs e)
        {
            if (cmbCachTim.Text == "Mã KH")
            {
                kenoicosodulieu.OpenConnection();
                dgvThongTin.DataSource = con.HienDL("select K.MaKH, K.MaDH, K.TenKH, K.DiaChi, K.SDT, L.LoaiSD, K.GhiChu from KHACHHANG K inner join HOADON H on K.MaKH = H.MaKH inner join LOAIHINHSD L on H.MaLoai = L.MaLoai where K.MaKH like N'%" + txtTuTim.Text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Mã DH")
            {
                kenoicosodulieu.OpenConnection();
                dgvThongTin.DataSource = con.HienDL("select K.MaKH, K.MaDH, K.TenKH, K.DiaChi, K.SDT, L.LoaiSD, K.GhiChu from KHACHHANG K inner join HOADON H on K.MaKH = H.MaKH inner join LOAIHINHSD L on H.MaLoai = L.MaLoai where K.MaDH like N'%" + txtTuTim.Text.Trim() + "%' ");
            }
            if (cmbCachTim.Text == "Tên KH")
            {
                kenoicosodulieu.OpenConnection();
                dgvThongTin.DataSource = con.HienDL("select K.MaKH, K.MaDH, K.TenKH, K.DiaChi, K.SDT, L.LoaiSD, K.GhiChu from KHACHHANG K inner join HOADON H on K.MaKH = H.MaKH inner join LOAIHINHSD L on H.MaLoai = L.MaLoai where K.TenKH like N'%" + txtTuTim.Text.Trim() + "%' ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã HD")
            {
                kenoicosodulieu.OpenConnection();
                dataGridView1.DataSource = con.HienDL("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia,HOADON.Thang,  HOADON.SoSD,  HOADON.ThanhTien,HOADON.ThanhToan,HOADON.NgayLap FROM HOADON , LOAIHINHSD WHERE HOADON.MaLoai = LOAIHINHSD.MaLoai and  MaHD like '%" + textBox1.Text.Trim() + "%' ");
            }
            if (comboBox1.Text == "Mã DH")
            {
                kenoicosodulieu.OpenConnection();
                dataGridView1.DataSource = con.HienDL("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia,HOADON.Thang,   HOADON.SoSD,  HOADON.ThanhTien,HOADON.ThanhToan,HOADON.NgayLap FROM HOADON , LOAIHINHSD WHERE HOADON.MaLoai = LOAIHINHSD.MaLoai and MaDH like N'%" + textBox1.Text.Trim() + "%' ");
            }
            //if (comboBox1.Text == "Ma KH")
            //{
            //    UtilityDB.OpenConnection();
            //    dataGridView1.DataSource = con.HienDL("select MaHD,MaDH,TenKH,MaLoai,Thang,SoSD,DonGia from HOADON where MaKH like '%" + textBox1.Text.Trim() + "%' ");
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
            
        }
  
         private void dataGridView1_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.CurrentRow.Index;

            try
            {
                txtMaHD.Text = dataGridView1[0, CurrentRow].Value.ToString();
                txtMaDH.Text = dataGridView1[1, CurrentRow].Value.ToString();
                txtTenKH.Text = dataGridView1[2, CurrentRow].Value.ToString();
                txtLoaiSD.Text = dataGridView1[3, CurrentRow].Value.ToString();
                txtThang.Text = dataGridView1[5, CurrentRow].Value.ToString();
                txtSoSD.Text = dataGridView1[6, CurrentRow].Value.ToString();
                txtDonGia.Text = dataGridView1[4, CurrentRow].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            try
            {
                    kenoicosodulieu.OpenConnection();
                    DateTime NgayLap = DateTime.Parse(txtNgayLap.Text);
                    string sql = "update  HOADON set HOADON.ThanhToan = N'Đã thanh toán',NgayLap='" + NgayLap + "' where HoaDon.MaHD=@MaHD";
                    bool isEdited = kenoicosodulieu.excuteSQL(sql, new System.Data.SqlClient.SqlParameter[] { 
                            new SqlParameter("@MaHD", txtMaHD.Text)

                        });
                    dataGridView1.DataSource = kenoicosodulieu.getDataInTable("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia,  HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.ThanhToan,HOADON.NgayLap FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai");
                    dataGridView1.Refresh();
                    kenoicosodulieu.DisConnection();
                    if (isEdited)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            catch (Exception)
            {
            }
            finally
            {
                kenoicosodulieu.DisConnection();
            }
        }

       

        private void btnXemHoaDon_Click_1(object sender, EventArgs e)
        {
            frmInHoaDon.MaHD = txtMaHD.Text;
            frmInHoaDon frm = new frmInHoaDon();
            frm.Show();
            frmInHoaDon.MaHD = txtMaHD.Text;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       

    }
}