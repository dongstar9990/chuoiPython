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
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }
        kenoicosodulieu cls = new kenoicosodulieu();
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string update = "update DangNhap set MK='" + textBox3.Text + "' where(TenDN=N'" + textBox1.Text + "' and MK='" + textBox2.Text + "')";
            string ten = textBox1.Text;
            if (ten == "")
            {
                this.lbstatus1.ForeColor = Color.Red;
                this.lbstatus1.Text = "Bạn chưa nhập tên truy cập!";
            }
            else
            {
                if (textBox2.Text == "")
                {
                    this.lbstatus1.ForeColor = Color.Red;
                    this.lbstatus1.Text = "Bạn chưa nhập mật khẩu!";
                   // MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (textBox3.Text == "")
                    {
                        this.lbstatus1.ForeColor = Color.Red;
                        this.lbstatus1.Text = "Bạn chưa nhập mật khẩu mới!";
                        //MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (textBox4.Text == "")
                        {
                            this.lbstatus1.ForeColor = Color.Red;
                            this.lbstatus1.Text = "Bạn chưa nhập lại mật khẩu!";
                           // MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (textBox3.Text == textBox4.Text)
                            {
                                 this.Hide();
                                cls.HienDL(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công", "Thông Báo");
                                //this.Close();
                                frmDangNhap dn = new frmDangNhap();
                                dn.ShowDialog();
                            }
                            else
                            {
                                this.lbstatus1.ForeColor = Color.Red;
                                this.lbstatus1.Text = "Bạn nhập lại mật khẩu không đúng!";
                                //MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
                textBox4.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
                textBox4.PasswordChar = '*';
            }
        }
    }
}
