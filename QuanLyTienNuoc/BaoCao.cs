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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.HOADON' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Fill(this.DataSet3.HOADON);
            // TODO: This line of code loads data into the 'DataSet3.HOADON' table. You can move, or remove it, as needed.
          

            this.reportViewer1.RefreshReport();
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {        
            //this.HOADONTableAdapter.Fill(this.DataSet3.HOADON, txtThongKe.Text,cmbThongKe.Text);
            this.HOADONTableAdapter.Fill(this.DataSet3.HOADON);
            this.reportViewer1.RefreshReport();    
      
        }

        

        private void mnuLoaiHinhSD_Click(object sender, EventArgs e)
        {
            BaoCao2 frm = new BaoCao2();
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
            
        }     
 
    }
}
