namespace QuanLyTienNuoc
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mdiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhatThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhSachHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiHinh = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đangXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mdiKhachHang,
            this.mniHoaDon,
            this.mniTimKiem,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(791, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mdiKhachHang
            // 
            this.mdiKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiKhachHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mdiKhachHang.Name = "mdiKhachHang";
            this.mdiKhachHang.Size = new System.Drawing.Size(153, 23);
            this.mdiKhachHang.Text = "Quản lý khách hàng";
            this.mdiKhachHang.Click += new System.EventHandler(this.mdiKhachHang_Click_1);
            // 
            // mniHoaDon
            // 
            this.mniHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapNhatThongTin,
            this.mnuDanhSachHoaDon});
            this.mniHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniHoaDon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mniHoaDon.Name = "mniHoaDon";
            this.mniHoaDon.Size = new System.Drawing.Size(130, 23);
            this.mniHoaDon.Text = "Quản lý hóa đơn";
            // 
            // mnuCapNhatThongTin
            // 
            this.mnuCapNhatThongTin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mnuCapNhatThongTin.Name = "mnuCapNhatThongTin";
            this.mnuCapNhatThongTin.Size = new System.Drawing.Size(205, 24);
            this.mnuCapNhatThongTin.Text = "Cập nhật thông tin";
            this.mnuCapNhatThongTin.Click += new System.EventHandler(this.mnuCapNhatThongTin_Click);
            // 
            // mnuDanhSachHoaDon
            // 
            this.mnuDanhSachHoaDon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mnuDanhSachHoaDon.Name = "mnuDanhSachHoaDon";
            this.mnuDanhSachHoaDon.Size = new System.Drawing.Size(205, 24);
            this.mnuDanhSachHoaDon.Text = "Danh sách hóa đơn";
            this.mnuDanhSachHoaDon.Click += new System.EventHandler(this.mnuDanhSachHoaDon_Click);
            // 
            // mniTimKiem
            // 
            this.mniTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniTimKiem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mniTimKiem.Name = "mniTimKiem";
            this.mniTimKiem.Size = new System.Drawing.Size(73, 23);
            this.mniTimKiem.Text = "Tra cứu";
            this.mniTimKiem.Click += new System.EventHandler(this.mniTimKiem_Click_1);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThang,
            this.mnuLoaiHinh});
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // mnuThang
            // 
            this.mnuThang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mnuThang.Name = "mnuThang";
            this.mnuThang.Size = new System.Drawing.Size(221, 24);
            this.mnuThang.Text = "Thông tin khách hàng";
            this.mnuThang.Click += new System.EventHandler(this.mnuThang_Click_1);
            // 
            // mnuLoaiHinh
            // 
            this.mnuLoaiHinh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mnuLoaiHinh.Name = "mnuLoaiHinh";
            this.mnuLoaiHinh.Size = new System.Drawing.Size(221, 24);
            this.mnuLoaiHinh.Text = "Thông tin hóa đơn";
            this.mnuLoaiHinh.Click += new System.EventHandler(this.mnuLoaiHinh_Click_1);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đangXuấtToolStripMenuItem,
            this.trợGiúpToolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.trợGiúpToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.đổiMậtKhẩuToolStripMenuItem.Image = global::QuanLyTienNuoc.Properties.Resources.change_password_icon;
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đangXuấtToolStripMenuItem
            // 
            this.đangXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.đangXuấtToolStripMenuItem.Image = global::QuanLyTienNuoc.Properties.Resources.Other_Power_Log_Off_Metro_icon;
            this.đangXuấtToolStripMenuItem.Name = "đangXuấtToolStripMenuItem";
            this.đangXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.đangXuấtToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.đangXuấtToolStripMenuItem.Text = "Đang xuất";
            this.đangXuấtToolStripMenuItem.Click += new System.EventHandler(this.đangXuấtToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.trợGiúpToolStripMenuItem1.Image = global::QuanLyTienNuoc.Properties.Resources.Button_Help_icon;
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(227, 24);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem1.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem1_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.thoátToolStripMenuItem.Image = global::QuanLyTienNuoc.Properties.Resources.Button_Close_icon3;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyTienNuoc.Properties.Resources.tải_xuống;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "Lê Ngọc Hòa";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabel1.Text = "@Quản lý tiền nước 2016";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(546, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTienNuoc.Properties.Resources._20140627_004019_2419105;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 467);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ TIỀN NƯỚC";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mdiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mniHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mniTimKiem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThang;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiHinh;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhatThongTin;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhSachHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đangXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
    }
}