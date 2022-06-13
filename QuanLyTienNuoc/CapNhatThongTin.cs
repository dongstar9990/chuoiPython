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
    public partial class frmCapNhatThongTin : Form
    {
        kenoicosodulieu con = new kenoicosodulieu();
        public frmCapNhatThongTin()
        {
            InitializeComponent();
        }
        private void ClearInformation()
        {
            txtMaDH.Clear();
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtThang.Clear();
            cmbLoaiSD.Text = "";
            txtChiSoCu.Clear();
            txtChiSoMoi.Clear();
            txtDonGia.Clear();
        }        
        private void frmCapNhatThongTin_Load(object sender, EventArgs e)
        {
            kenoicosodulieu.OpenConnection();
            txtMaDH.Enabled = false;
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            cmbLoaiSD.Enabled = false;
            txtDonGia.Enabled = false;
            cmbLoaiSD.DataSource = kenoicosodulieu.getDataInTable("select * from LOAIHINHSD");
            cmbLoaiSD.DisplayMember = "LoaiSD";
            cmbLoaiSD.ValueMember = "MaLoai";
           
            txtTimKiem.Focus();
            dgrCapNhatThongTin.DataSource = kenoicosodulieu.getDataInTable("SELECT KHACHHANG.MaKH,KHACHHANG.MaDH,KHACHHANG.TenKH, LOAIHINHSD.LoaiSD, LOAIHINHSD.DonGia FROM  KHACHHANG ,LOAIHINHSD WHERE KHACHHANG.MaLoai= LOAIHINHSD.MaLoai");
            dgrCapNhatThongTin.Refresh();
            kenoicosodulieu.DisConnection();
            
        }

        private void dgrCapNhatThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDH.Text = dgrCapNhatThongTin.CurrentRow.Cells["MaDH"].Value.ToString();
            txtMaKH.Text = dgrCapNhatThongTin.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgrCapNhatThongTin.CurrentRow.Cells["TenKH"].Value.ToString();
            cmbLoaiSD.Text = dgrCapNhatThongTin.CurrentRow.Cells["LoaiSD"].Value.ToString();
            txtDonGia.Text = dgrCapNhatThongTin.CurrentRow.Cells["DonGia"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            if (rbTimTheoTen.Checked == true)
            {
                kenoicosodulieu.OpenConnection();
                dgrCapNhatThongTin.DataSource = con.HienDL("SELECT KHACHHANG.MaKH,KHACHHANG.MaDH,KHACHHANG.TenKH, LOAIHINHSD.LoaiSD, LOAIHINHSD.DonGia FROM  KHACHHANG , LOAIHINHSD where KHACHHANG.LoaiSD=LOAIHINHSD.LoaiSD and TenKH like N'%" + txtTimKiem.Text.Trim() + "%' ");
            }
            if (rbTimTheoMa.Checked == true)
            {
                kenoicosodulieu.OpenConnection();
                dgrCapNhatThongTin.DataSource = con.HienDL("SELECT KHACHHANG.MaKH,KHACHHANG.MaDH,KHACHHANG.TenKH, LOAIHINHSD.LoaiSD, LOAIHINHSD.DonGia FROM  KHACHHANG CROSS JOIN LOAIHINHSD and MaKH like '%" + txtTimKiem.Text.Trim() + "%' ");
            }

        }
   
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();

        }

       
        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            kenoicosodulieu.OpenConnection();
            double thanhTien = 0;
            int SoCu = Int32.Parse(txtChiSoCu.Text);
            int SoMoi = Int32.Parse(txtChiSoMoi.Text);
            int SoSD = SoMoi - SoCu;


            if (SoSD <= 20)
            {
                thanhTien = SoSD * Double.Parse(txtDonGia.Text) * 1.05;


            }
            else if (SoSD > 20)
            {
                thanhTien = SoSD * Double.Parse(txtDonGia.Text) * 2.1;
            }
           
                dgrCapNhatThongTin.CurrentRow.Cells["MaHD"].Value = txtMaHD.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["MaDH"].Value = txtMaDH.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["MaKH"].Value = txtMaKH.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["TenKH"].Value = txtTenKH.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["LoaiSD"].Value = cmbLoaiSD.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["DonGia"].Value = txtDonGia.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["Thang"].Value = txtThang.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["ChiSoCu"].Value = txtChiSoCu.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["ChiSoMoi"].Value = txtChiSoMoi.Text;
                dgrCapNhatThongTin.CurrentRow.Cells["SoSD"].Value = SoSD;
                dgrCapNhatThongTin.CurrentRow.Cells["ThanhTien"].Value = thanhTien;
                dgrCapNhatThongTin.CurrentRow.Cells["clmThanhToan"].Value = "Chưa thanh toán";
                string sql = "insert into HOADON (MaHD, MADH, MaKH,TenKH,MaLoai,Thang,ChiSoCu,ChiSoMoi,SoSD,DonGia,ThanhTien,ThanhToan)  VALUES(@MaHD, @MaDH, @MaKH,@TenKH,@MaLoai,@Thang,@ChiSoCu,@ChiSoMoi,@SoSD,@DonGia,@ThanhTien,@clmThanhToan)";

                bool isAdded = kenoicosodulieu.excuteSQL(sql, new SqlParameter[] {
                    new SqlParameter("@MaHD", txtMaHD.Text), 
                    new SqlParameter("@MaDH", txtMaDH.Text), 
                    new SqlParameter("@MaKH", txtMaKH.Text),
                    new SqlParameter("@TenKH", txtTenKH.Text),
                    new SqlParameter("@MaLoai", cmbLoaiSD.SelectedValue.ToString()),
                    new SqlParameter("@Thang", txtThang.Text),
                    new SqlParameter("@ChiSoCu", SoCu), 
                    new SqlParameter("@ChiSoMoi", SoMoi), 
                    new SqlParameter("@SoSD", SoSD), 
                    new SqlParameter("@DonGia", txtDonGia.Text), 
                    new SqlParameter("@ThanhTien", thanhTien),
                    new SqlParameter("@clmThanhToan", "Chưa thanh toán")
                    });
                if (isAdded)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearInformation();
                    dgrCapNhatThongTin.Refresh();
                }
                else
                {

                    MessageBox.Show("Cập nhật không  thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgrCapNhatThongTin.Refresh();
                }
                 
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (rbTimTheoTen.Checked == true)
            {
                kenoicosodulieu.OpenConnection();
               dgrCapNhatThongTin .DataSource = con.HienDL("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia,HOADON.Thang,  HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai and TenKH like N'%" + txtTimKiem.Text.Trim() + "%' ");
            }
            if (rbTimTheoMa.Checked == true)
            {
                kenoicosodulieu.OpenConnection();
                dgrCapNhatThongTin.DataSource = con.HienDL("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia, HOADON.Thang, HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai and MaKH like '%" + txtTimKiem.Text.Trim() + "%' ");
            }


        }

        private void btn_huy1_Click(object sender, EventArgs e)
        {
            
        }

    }

}