namespace QuanLyTienNuoc
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.txt_madh = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_loaidien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.dgr_thongtin = new System.Windows.Forms.DataGridView();
            this.clm_mkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_mct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_tkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_lsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_gc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTimTheoMa = new System.Windows.Forms.RadioButton();
            this.rbTimTheoTen = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_thongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_madh
            // 
            this.txt_madh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madh.Location = new System.Drawing.Point(640, 115);
            this.txt_madh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_madh.Name = "txt_madh";
            this.txt_madh.Size = new System.Drawing.Size(142, 26);
            this.txt_madh.TabIndex = 69;
            this.txt_madh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mact_KeyDown);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.Location = new System.Drawing.Point(640, 176);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(225, 62);
            this.txt_ghichu.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(505, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Ghi chú:";
            // 
            // cmb_loaidien
            // 
            this.cmb_loaidien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_loaidien.FormattingEnabled = true;
            this.cmb_loaidien.Items.AddRange(new object[] {
            "Hộ gia đình",
            "Kinh doanh"});
            this.cmb_loaidien.Location = new System.Drawing.Point(640, 41);
            this.cmb_loaidien.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_loaidien.Name = "cmb_loaidien";
            this.cmb_loaidien.Size = new System.Drawing.Size(142, 27);
            this.cmb_loaidien.TabIndex = 60;
            this.cmb_loaidien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_loaidien_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(505, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 62;
            this.label6.Text = "Mã đồng hồ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(505, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Loại hình SD:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(159, 212);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(200, 26);
            this.txt_sdt.TabIndex = 65;
            this.txt_sdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sdt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(51, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 64;
            this.label5.Text = "SDT:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(159, 156);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(295, 26);
            this.txt_diachi.TabIndex = 63;
            this.txt_diachi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_diachi_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(51, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 61;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(159, 103);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(295, 26);
            this.txt_tenkh.TabIndex = 59;
            this.txt_tenkh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tenkh_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(51, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tên KH:";
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(159, 39);
            this.txt_makh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(157, 26);
            this.txt_makh.TabIndex = 57;
            this.txt_makh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_makh_KeyDown);
            // 
            // dgr_thongtin
            // 
            this.dgr_thongtin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgr_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_mkh,
            this.clm_mct,
            this.clm_tkh,
            this.clm_lsd,
            this.clm_dc,
            this.clm_sdt,
            this.clm_gc});
            this.dgr_thongtin.Location = new System.Drawing.Point(19, 401);
            this.dgr_thongtin.Margin = new System.Windows.Forms.Padding(2);
            this.dgr_thongtin.Name = "dgr_thongtin";
            this.dgr_thongtin.RowTemplate.Height = 24;
            this.dgr_thongtin.Size = new System.Drawing.Size(974, 182);
            this.dgr_thongtin.TabIndex = 58;
            this.dgr_thongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_thongtin_CellClick);
            // 
            // clm_mkh
            // 
            this.clm_mkh.DataPropertyName = "MaKH";
            this.clm_mkh.HeaderText = "Mã KH";
            this.clm_mkh.Name = "clm_mkh";
            // 
            // clm_mct
            // 
            this.clm_mct.DataPropertyName = "MaDH";
            this.clm_mct.HeaderText = "Mã DH";
            this.clm_mct.Name = "clm_mct";
            // 
            // clm_tkh
            // 
            this.clm_tkh.DataPropertyName = "TenKH";
            this.clm_tkh.HeaderText = "Tên KH";
            this.clm_tkh.Name = "clm_tkh";
            // 
            // clm_lsd
            // 
            this.clm_lsd.DataPropertyName = "LoaiSD";
            this.clm_lsd.HeaderText = "Loại SD";
            this.clm_lsd.Name = "clm_lsd";
            this.clm_lsd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clm_dc
            // 
            this.clm_dc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_dc.DataPropertyName = "DiaChi";
            this.clm_dc.HeaderText = "Địa Chỉ";
            this.clm_dc.Name = "clm_dc";
            // 
            // clm_sdt
            // 
            this.clm_sdt.DataPropertyName = "SDT";
            this.clm_sdt.HeaderText = "Số Điện Thoại";
            this.clm_sdt.Name = "clm_sdt";
            // 
            // clm_gc
            // 
            this.clm_gc.DataPropertyName = "GhiChu";
            this.clm_gc.HeaderText = "Ghi Chú";
            this.clm_gc.Name = "clm_gc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(51, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "Mã KH:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txt_madh);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_loaidien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(11, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(971, 253);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_them.Image = global::QuanLyTienNuoc.Properties.Resources.add_contact_icon;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(35, 340);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 47);
            this.btn_them.TabIndex = 51;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_huy.Image = global::QuanLyTienNuoc.Properties.Resources.Actions_dialog_cancel_icon;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(636, 340);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(89, 47);
            this.btn_huy.TabIndex = 56;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_thoat.Image = global::QuanLyTienNuoc.Properties.Resources.Button_Close_icon1;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(870, 340);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(99, 47);
            this.btn_thoat.TabIndex = 55;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_xoa.Image = global::QuanLyTienNuoc.Properties.Resources.delete_file_icon;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(758, 340);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(86, 47);
            this.btn_xoa.TabIndex = 54;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_sua.Image = global::QuanLyTienNuoc.Properties.Resources.edit_icon;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(307, 340);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(89, 47);
            this.btn_sua.TabIndex = 53;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_luu.Image = global::QuanLyTienNuoc.Properties.Resources.Save_icon;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(169, 340);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(90, 47);
            this.btn_luu.TabIndex = 52;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbTimTheoMa);
            this.panel1.Controls.Add(this.rbTimTheoTen);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 77);
            this.panel1.TabIndex = 59;
            // 
            // rbTimTheoMa
            // 
            this.rbTimTheoMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTimTheoMa.AutoSize = true;
            this.rbTimTheoMa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTimTheoMa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbTimTheoMa.Location = new System.Drawing.Point(225, 38);
            this.rbTimTheoMa.Name = "rbTimTheoMa";
            this.rbTimTheoMa.Size = new System.Drawing.Size(138, 23);
            this.rbTimTheoMa.TabIndex = 5;
            this.rbTimTheoMa.Text = "Tìm theo MaKH";
            this.rbTimTheoMa.UseVisualStyleBackColor = true;
            // 
            // rbTimTheoTen
            // 
            this.rbTimTheoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTimTheoTen.AutoSize = true;
            this.rbTimTheoTen.Checked = true;
            this.rbTimTheoTen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTimTheoTen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rbTimTheoTen.Location = new System.Drawing.Point(226, 14);
            this.rbTimTheoTen.Name = "rbTimTheoTen";
            this.rbTimTheoTen.Size = new System.Drawing.Size(113, 23);
            this.rbTimTheoTen.TabIndex = 4;
            this.rbTimTheoTen.TabStop = true;
            this.rbTimTheoTen.Text = "Tìm theo tên";
            this.rbTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.Image = global::QuanLyTienNuoc.Properties.Resources.Search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(623, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(122, 41);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tra cứu";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(385, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(193, 26);
            this.txtTimKiem.TabIndex = 2;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1004, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgr_thongtin);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_thongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_madh;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_loaidien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.DataGridView dgr_thongtin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTimTheoMa;
        private System.Windows.Forms.RadioButton rbTimTheoTen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_mkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_mct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_tkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_lsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_gc;
    }
}