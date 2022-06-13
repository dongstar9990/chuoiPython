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
    public partial class frmDanhSachHoaDon : Form
    {
        //Luu trang thai la dang them hay dang cap nhat
        private string state;


        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }
        kenoicosodulieu con = new kenoicosodulieu();


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
        private void HienThi2_Button()
        {

            btnLuu.Enabled = false;
            btn_huy1.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            btnThem.Enabled = true;

        }
        private void dongcapnhat()
        {

            txtMaHD.Enabled = false;
            txtMaDH.Enabled = false;
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            cmbLoaiSD.Enabled = false;
            txtDonGia.Enabled = false;
            txtThang.Enabled = false;

        }
        private void motext()
        {
            txtMaHD.Enabled = true;
            txtMaDH.Enabled = true;
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            cmbLoaiSD.Enabled = true;
            txtDonGia.Enabled = true;
            txtThang.Enabled = true;

        }
        private void dongthemmoi()
        {

            txtMaDH.Enabled = false;
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            cmbLoaiSD.Enabled = false;
            txtDonGia.Enabled = false;

        }
        private bool them_dl()
        {
            
            try
            {

                kenoicosodulieu.OpenConnection();
                double thanhTien=0;
                double SoCu = Int32.Parse(txtChiSoCu.Text);
                double SoMoi = Int32.Parse(txtChiSoMoi.Text);
                double SoSD = SoMoi - SoCu;
                string sql = "insert into HOADON (MaHD, MADH, MaKH,TenKH,MaLoai,Thang,ChiSoCu,ChiSoMoi,SoSD,DonGia,ThanhTien)"+ 
               " VALUES (@MaHD, @MaDH, @MaKH,@TenKH,@MaLoai,@Thang,@ChiSoCu,@ChiSoMoi,@SoSD,@DonGia,@ThanhTien)";
                
                if (SoSD <= 20)
                {
                    thanhTien = SoSD * Double.Parse(txtDonGia.Text)*1.05;


                }
                else if(SoSD>20)
                {
                    thanhTien = SoSD * Double.Parse(txtDonGia.Text)*2.1;
                }
                bool isAdded = kenoicosodulieu.excuteSQL(sql, new SqlParameter[] {
                    new SqlParameter("MaHD", txtMaHD.Text), 
                    new SqlParameter("MaDH", txtMaDH.Text), 
                    new SqlParameter("MaKH", txtMaKH.Text),
                    new SqlParameter("TenKH", txtTenKH.Text),
                    new SqlParameter("MaLoai", cmbLoaiSD.SelectedValue.ToString()),
                    new SqlParameter("Thang", txtThang.Text),
                    new SqlParameter("ChiSoCu", SoCu), 
                    new SqlParameter("ChiSoMoi", SoMoi), 
                    new SqlParameter("SoSD", SoSD), 
                    new SqlParameter("DonGia", Convert.ToInt32(txtDonGia.Text)), 
                    new SqlParameter("ThanhTien",thanhTien)
                });


                if (isAdded)
                {
                    
                    dgrDanhSachHoaDon.DataSource = kenoicosodulieu.getDataInTable("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia,HOADON.Thang,  HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai");
                    dgrDanhSachHoaDon.Refresh();
                    ClearInformation();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                kenoicosodulieu.DisConnection();
            }

        }
        private bool sua_dl()
        {

            try
            {

                kenoicosodulieu.OpenConnection();
                double thanhTien = 0;
                int SoCu = Int32.Parse(txtChiSoCu.Text);
                int SoMoi = Int32.Parse(txtChiSoMoi.Text);
                int SoSD = SoMoi - SoCu;
                string sql = "update  HOADON set ChiSoCu=@ChiSoCu,ChiSoMoi=@ChiSoMoi,SoSD=@SoSD,DonGia=@DonGia,ThanhTien=@ThanhTien where HoaDon.MaHD=@MaHD";
                if (SoSD <= 20)
                {
                    thanhTien = SoSD * Double.Parse(txtDonGia.Text) * 1.05;
                }
                else if (SoSD > 20)
                {
                    thanhTien = SoSD * Double.Parse(txtDonGia.Text) * 2.1;
                }

                bool isEdited = kenoicosodulieu.excuteSQL(sql, new SqlParameter[] {
                new SqlParameter("@MaHD", txtMaHD.Text), 
           
                new SqlParameter("@ChiSoCu", SoCu), 
                new SqlParameter("@ChiSoMoi", SoMoi), 
                new SqlParameter("@SoSD", SoSD), 
                new SqlParameter("@DonGia", txtDonGia.Text), 
                new SqlParameter("@ThanhTien", thanhTien)
            });

                if (isEdited)
                {
                    //  MessageBox.Show("Cập nhật thành công");
                    dgrDanhSachHoaDon.DataSource = kenoicosodulieu.getDataInTable("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia,  HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai");
                    dgrDanhSachHoaDon.Refresh();
                    return true;
                }
                else
                {
                    return false;
                }
                //
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                kenoicosodulieu.DisConnection();
            }

        }
        //--------------//
        private void Form1_Load(object sender, EventArgs e)
        {
            kenoicosodulieu.OpenConnection();
            cmbLoaiSD.DataSource = kenoicosodulieu.getDataInTable("select * from LOAIHINHSD");
            cmbLoaiSD.DisplayMember = "LoaiSD";
            cmbLoaiSD.ValueMember = "MaLoai";
            btnLuu.Enabled = false;
            txtTimKiem.Focus();
            dgrDanhSachHoaDon.DataSource = kenoicosodulieu.getDataInTable("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia, HOADON.Thang, HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai");
            dgrDanhSachHoaDon.Refresh();
            kenoicosodulieu.DisConnection();
        }
        private void dgrHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                txtMaHD.Text = dgrDanhSachHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
                txtMaDH.Text = dgrDanhSachHoaDon.CurrentRow.Cells["MaDH"].Value.ToString();
                txtMaKH.Text = dgrDanhSachHoaDon.CurrentRow.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = dgrDanhSachHoaDon.CurrentRow.Cells["TenKH"].Value.ToString();
                cmbLoaiSD.Text = dgrDanhSachHoaDon.CurrentRow.Cells["LoaiSD"].Value.ToString();
                txtDonGia.Text = dgrDanhSachHoaDon.CurrentRow.Cells["DonGia"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rbTimTheoTen.Checked == true)
            {
                kenoicosodulieu.OpenConnection();
                dgrDanhSachHoaDon.DataSource = con.HienDL("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia,HOADON.Thang,  HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai and TenKH like N'%" + txtTimKiem.Text.Trim() + "%' ");
            }
            if (rbTimTheoMa.Checked == true)
            {
                kenoicosodulieu.OpenConnection();
                dgrDanhSachHoaDon.DataSource = con.HienDL("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia, HOADON.Thang, HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai and MaKH like N'%" + txtTimKiem.Text.Trim() + "%' ");
            }


        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "edit";
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            dongcapnhat();
            txtChiSoCu.Focus();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "add";
            btnThem.Enabled = false;
            btnLuu.Enabled = true;

            dongthemmoi();
            txtMaHD.Focus();


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            bool isAdded = false, isEdited = false;
            if (state == "add")
            {
                isAdded = them_dl();
            }
            else
            {
                isEdited = sua_dl();
            }
            if (isAdded || isEdited)
            {
                MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               
                ClearInformation();
                motext();
              
            }
            else
            {
                MessageBox.Show("Lưu không thành công. Có thể quá trình nhập của bạn không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                kenoicosodulieu.OpenConnection();
                string sql = "delete from HOADON where MaHD='" + txtMaHD.Text + "'";
                kenoicosodulieu.ExecuteSQL(sql);
                sql = "SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH, HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia, HOADON.Thang, HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai";
                dgrDanhSachHoaDon.DataSource = kenoicosodulieu.getDataInTable(sql);
                
                MessageBox.Show("Bạn đã xóa thành công hóa đơn " + txtMaHD.Text + "!!!","Thông Báo");
                dgrDanhSachHoaDon.DataSource = con.HienDL("SELECT HOADON.MaHD,HOADON.MaDH, HOADON.MaKH,HOADON.TenKH,LOAIHINHSD.LoaiSD,LOAIHINHSD.DonGia, HOADON.Thang, HOADON.ChiSoCu, HOADON.ChiSoMoi, HOADON.SoSD,  HOADON.ThanhTien,HOADON.GhiChu FROM HOADON INNER JOIN LOAIHINHSD ON HOADON.MaLoai = LOAIHINHSD.MaLoai");
                dgrDanhSachHoaDon.Refresh();
            }
            catch (Exception)
            {
            }
            finally
            {
                kenoicosodulieu.DisConnection();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btn_huy1_Click(object sender, EventArgs e)
        {
            ClearInformation();
            dgrDanhSachHoaDon.Refresh();
            HienThi2_Button();
            txtMaKH.Focus();
            txtMaKH.Enabled = true;
            txtMaDH.Enabled = true;
            txtMaHD.Enabled = true;
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtThang.Enabled = true;
            cmbLoaiSD.Enabled = true;
            txtChiSoCu.Enabled = true;
            txtChiSoMoi.Enabled = true;
            txtDonGia.Enabled = true;
        }


    }

}