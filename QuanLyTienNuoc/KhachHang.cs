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
    public partial class frmKhachHang : Form
    {
        kenoicosodulieu con = new kenoicosodulieu();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void HienThi2_Button()
        {

            btn_luu.Enabled = false;
            btn_huy.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_thoat.Enabled = true;
            btn_them.Enabled = true;

        }
        private void HienThi_Button()
        {
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_thoat.Enabled = false;
            btn_them.Enabled = false;
        }

        private void ClearInfomation()
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            txt_madh.Clear();
            txt_ghichu.Clear();
            txt_makh.Focus();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            kenoicosodulieu.OpenConnection();

            cmb_loaidien.DataSource = kenoicosodulieu.getDataInTable("select * from LOAIHINHSD");
            cmb_loaidien.DisplayMember = "LoaiSD";
            cmb_loaidien.ValueMember = "MaLoai";
            HienThi2_Button();
            txt_makh.Focus();
            dgr_thongtin.DataSource = kenoicosodulieu.getDataInTable("SELECT KHACHHANG.MaKH, KHACHHANG.MaDH, KHACHHANG.TenKH, KHACHHANG.DiaChi,KHACHHANG.SDT, KHACHHANG.GhiChu, LOAIHINHSD.LoaiSD FROM KHACHHANG INNER JOIN LOAIHINHSD ON KHACHHANG.MaLoai = LOAIHINHSD.MaLoai");

        }

        private void dgr_thongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgr_thongtin.CurrentRow.Index;
            txt_makh.Text = dgr_thongtin[0, i].Value.ToString();
            txt_madh.Text = dgr_thongtin[1, i].Value.ToString();
            txt_tenkh.Text = dgr_thongtin[2, i].Value.ToString();
            txt_diachi.Text = dgr_thongtin[3, i].Value.ToString();
            txt_sdt.Text = dgr_thongtin[4, i].Value.ToString();
            cmb_loaidien.Text = dgr_thongtin[5, i].Value.ToString();
            txt_ghichu.Text = dgr_thongtin[6, i].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {  
            try{
            kenoicosodulieu.OpenConnection();
            string sql = "delete from KHACHHANG where MaKH='" + txt_makh.Text + "'";
            kenoicosodulieu.ExecuteSQL(sql);
            //load lại dữ liệu lên DataGridView sau khi xóa
            sql = "SELECT KHACHHANG.MaKH, KHACHHANG.MaDH, KHACHHANG.TenKH, KHACHHANG.DiaChi,KHACHHANG.SDT, KHACHHANG.GhiChu, LOAIHINHSD.LoaiSD FROM KHACHHANG INNER JOIN LOAIHINHSD ON KHACHHANG.MaLoai = LOAIHINHSD.MaLoai";
            dgr_thongtin.DataSource = kenoicosodulieu.getDataInTable(sql);
            MessageBox.Show("Bạn đã xóa thành công khách hàng " + txt_makh.Text + "!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ClearInfomation();
            }
            catch(Exception)
            { }
            finally
            {
                kenoicosodulieu.DisConnection();
            }
        }
      
        private string action = "";


        private void btn_luu_Click(object sender, EventArgs e)
        {
             try
                {

            kenoicosodulieu.OpenConnection();
            
            HienThi2_Button();
            if (action=="Insert ")
            {
                string sql = "insert into KHACHHANG values (N'" + txt_makh.Text + "',N'" + txt_madh.Text + "',N'" + txt_tenkh.Text + "',N'" + cmb_loaidien.SelectedValue.ToString() + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "',N'" + txt_ghichu.Text + "')";
                kenoicosodulieu.ExecuteSQL(sql);
                MessageBox.Show("Lưu thành công!", "Thông Báo" , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
              string  sql = " Update KHACHHANG set MaDH =N'" + txt_madh.Text + "',TenKH=N'" + txt_tenkh.Text + "',DiaChi =N'" + txt_diachi.Text + "', SDT = N'" + txt_sdt.Text + "',MaLoai = N'" + cmb_loaidien.SelectedValue.ToString() + "', GhiChu = N'" + txt_ghichu.Text + "' where MaKH=N'" + txt_makh.Text + "'";
              MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                kenoicosodulieu.ExecuteSQL(sql);
            }
           
            dgr_thongtin.DataSource = kenoicosodulieu.getDataInTable("SELECT KHACHHANG.MaKH, KHACHHANG.MaDH, KHACHHANG.TenKH, KHACHHANG.DiaChi,KHACHHANG.SDT, KHACHHANG.GhiChu, LOAIHINHSD.LoaiSD FROM KHACHHANG INNER JOIN LOAIHINHSD ON KHACHHANG.MaLoai = LOAIHINHSD.MaLoai");
            
                
                }
             catch (Exception) { MessageBox.Show("Không thể lưu đối tượng!", "Thông Báo" , MessageBoxButtons.OK, MessageBoxIcon.Error); }
             
        }
            

        private void btn_them_Click(object sender, EventArgs e)
        {
            action="Insert ";
            txt_makh.Enabled = true;
            ClearInfomation();
            HienThi_Button();
            txt_makh.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_makh.Enabled = false;
            action.Equals("Update ");
            HienThi_Button();
            txt_tenkh.Focus(); 
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ClearInfomation();
            HienThi2_Button();
            txt_makh.Focus();
            txt_makh.Enabled = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không?", "Thông báo",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void txt_makh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_tenkh.Focus();
        }

        private void txt_tenkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_diachi.Focus();
        }

        private void txt_diachi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_sdt.Focus();
        }

        private void txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmb_loaidien.Focus();
        }

        private void txt_mact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_ghichu.Focus();
        }

        private void cmb_loaidien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_madh.Focus();   
        }

       

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
             if (rbTimTheoTen.Checked == true)
            {
                kenoicosodulieu.OpenConnection();
                dgr_thongtin.DataSource = con.HienDL("select K.MaKH, K.MaDH,L.LoaiSD, K.TenKH, K.DiaChi, K.SDT,  K.GhiChu from KHACHHANG K inner join   LOAIHINHSD L on k.MaLoai = L.MaLoai where K.TenKH like'%" + txtTimKiem.Text.Trim() + "%' ");
            }
            if (rbTimTheoMa.Checked == true)
            {
                kenoicosodulieu.OpenConnection();
                dgr_thongtin.DataSource = con.HienDL("select K.MaKH, K.MaDH,L.LoaiSD, K.TenKH, K.DiaChi, K.SDT,  K.GhiChu from KHACHHANG K inner join   LOAIHINHSD L on k.MaLoai = L.MaLoai where K.MaKH like'%" + txtTimKiem.Text.Trim() + "%' ");


      }
        }

    }
}
