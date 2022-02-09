namespace Winform_mo_giao_dien_moi.Views
{
    partial class ThemPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhong));
            this.Txb_TenPhong = new System.Windows.Forms.TextBox();
            this.Txb_MaPhong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cb_MaLoaiP = new System.Windows.Forms.ComboBox();
            this.Cb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GV_InfoPhong = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_LuuInfo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dt_Tra = new System.Windows.Forms.DateTimePicker();
            this.Dt_Nhan = new System.Windows.Forms.DateTimePicker();
            this.Cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.Txb_DiaChi = new System.Windows.Forms.TextBox();
            this.Txb_KH = new System.Windows.Forms.TextBox();
            this.Txb_CMND = new System.Windows.Forms.TextBox();
            this.Txb_QuocTich = new System.Windows.Forms.TextBox();
            this.Txb_MaP = new System.Windows.Forms.TextBox();
            this.Txb_SDT = new System.Windows.Forms.TextBox();
            this.Txb_HoTen = new System.Windows.Forms.TextBox();
            this.Gv_KhachHang = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_InfoPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_TenPhong
            // 
            this.Txb_TenPhong.Location = new System.Drawing.Point(121, 95);
            this.Txb_TenPhong.Margin = new System.Windows.Forms.Padding(5);
            this.Txb_TenPhong.Name = "Txb_TenPhong";
            this.Txb_TenPhong.Size = new System.Drawing.Size(182, 29);
            this.Txb_TenPhong.TabIndex = 1;
            // 
            // Txb_MaPhong
            // 
            this.Txb_MaPhong.Location = new System.Drawing.Point(121, 44);
            this.Txb_MaPhong.Margin = new System.Windows.Forms.Padding(5);
            this.Txb_MaPhong.Name = "Txb_MaPhong";
            this.Txb_MaPhong.Size = new System.Drawing.Size(179, 29);
            this.Txb_MaPhong.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cb_MaLoaiP);
            this.groupBox1.Controls.Add(this.Cb_TinhTrang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txb_MaPhong);
            this.groupBox1.Controls.Add(this.Txb_TenPhong);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(431, 245);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông  Tin Phòng";
            // 
            // Cb_MaLoaiP
            // 
            this.Cb_MaLoaiP.FormattingEnabled = true;
            this.Cb_MaLoaiP.Items.AddRange(new object[] {
            "PL1",
            "PL2",
            "PL3",
            "PL4"});
            this.Cb_MaLoaiP.Location = new System.Drawing.Point(155, 194);
            this.Cb_MaLoaiP.Name = "Cb_MaLoaiP";
            this.Cb_MaLoaiP.Size = new System.Drawing.Size(148, 29);
            this.Cb_MaLoaiP.TabIndex = 3;
            // 
            // Cb_TinhTrang
            // 
            this.Cb_TinhTrang.FormattingEnabled = true;
            this.Cb_TinhTrang.Items.AddRange(new object[] {
            "Trống",
            "Có Khách"});
            this.Cb_TinhTrang.Location = new System.Drawing.Point(124, 137);
            this.Cb_TinhTrang.Name = "Cb_TinhTrang";
            this.Cb_TinhTrang.Size = new System.Drawing.Size(179, 29);
            this.Cb_TinhTrang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã  Loại Phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tình  Trạng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Phòng :";
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Them.ForeColor = System.Drawing.Color.Black;
            this.Btn_Them.Location = new System.Drawing.Point(10, 28);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(117, 50);
            this.Btn_Them.TabIndex = 7;
            this.Btn_Them.Text = "Thêm Phòng";
            this.Btn_Them.UseVisualStyleBackColor = false;
            this.Btn_Them.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.Btn_Xoa.Location = new System.Drawing.Point(165, 28);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(113, 50);
            this.Btn_Xoa.TabIndex = 8;
            this.Btn_Xoa.Text = "Xóa Phòng";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.Btn_Sua.Location = new System.Drawing.Point(308, 28);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(117, 50);
            this.Btn_Sua.TabIndex = 9;
            this.Btn_Sua.Text = "Sửa Phòng";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Sua);
            this.groupBox2.Controls.Add(this.Btn_Them);
            this.groupBox2.Controls.Add(this.Btn_Xoa);
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(2, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 88);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phím Chức Năng";
            // 
            // GV_InfoPhong
            // 
            this.GV_InfoPhong.BackgroundColor = System.Drawing.Color.White;
            this.GV_InfoPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_InfoPhong.Location = new System.Drawing.Point(0, 390);
            this.GV_InfoPhong.Name = "GV_InfoPhong";
            this.GV_InfoPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_InfoPhong.Size = new System.Drawing.Size(472, 249);
            this.GV_InfoPhong.TabIndex = 11;
            this.GV_InfoPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_InfoPhong_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(3, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh Sách Phòng :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Refresh);
            this.groupBox3.Controls.Add(this.Btn_LuuInfo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Dt_Tra);
            this.groupBox3.Controls.Add(this.Dt_Nhan);
            this.groupBox3.Controls.Add(this.Cb_GioiTinh);
            this.groupBox3.Controls.Add(this.Txb_DiaChi);
            this.groupBox3.Controls.Add(this.Txb_KH);
            this.groupBox3.Controls.Add(this.Txb_CMND);
            this.groupBox3.Controls.Add(this.Txb_QuocTich);
            this.groupBox3.Controls.Add(this.Txb_MaP);
            this.groupBox3.Controls.Add(this.Txb_SDT);
            this.groupBox3.Controls.Add(this.Txb_HoTen);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(476, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 341);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập Thông Tin Khách Đặt Phòng";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.Btn_Refresh.Location = new System.Drawing.Point(298, 303);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(211, 38);
            this.Btn_Refresh.TabIndex = 21;
            this.Btn_Refresh.Text = "Xóa";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_LuuInfo
            // 
            this.Btn_LuuInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_LuuInfo.ForeColor = System.Drawing.Color.Black;
            this.Btn_LuuInfo.Location = new System.Drawing.Point(3, 300);
            this.Btn_LuuInfo.Name = "Btn_LuuInfo";
            this.Btn_LuuInfo.Size = new System.Drawing.Size(211, 38);
            this.Btn_LuuInfo.TabIndex = 20;
            this.Btn_LuuInfo.Text = "Lưu";
            this.Btn_LuuInfo.UseVisualStyleBackColor = false;
            this.Btn_LuuInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(263, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 21);
            this.label15.TabIndex = 19;
            this.label15.Text = "Quốc Tịch :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(269, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 21);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ngày Đến :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(272, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "Ngày Trả  :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(9, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Mã KH :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(269, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "Số CMND :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(269, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Giới Tính :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã  Phòng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số ĐT :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa Chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Họ Tên :";
            // 
            // Dt_Tra
            // 
            this.Dt_Tra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_Tra.Location = new System.Drawing.Point(369, 264);
            this.Dt_Tra.Name = "Dt_Tra";
            this.Dt_Tra.Size = new System.Drawing.Size(117, 29);
            this.Dt_Tra.TabIndex = 9;
            this.Dt_Tra.Value = new System.DateTime(2020, 8, 25, 0, 0, 0, 0);
            // 
            // Dt_Nhan
            // 
            this.Dt_Nhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_Nhan.Location = new System.Drawing.Point(369, 202);
            this.Dt_Nhan.Name = "Dt_Nhan";
            this.Dt_Nhan.Size = new System.Drawing.Size(114, 29);
            this.Dt_Nhan.TabIndex = 8;
            this.Dt_Nhan.Value = new System.DateTime(2020, 8, 25, 0, 0, 0, 0);
            // 
            // Cb_GioiTinh
            // 
            this.Cb_GioiTinh.FormattingEnabled = true;
            this.Cb_GioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.Cb_GioiTinh.Location = new System.Drawing.Point(369, 30);
            this.Cb_GioiTinh.Name = "Cb_GioiTinh";
            this.Cb_GioiTinh.Size = new System.Drawing.Size(72, 29);
            this.Cb_GioiTinh.TabIndex = 5;
            // 
            // Txb_DiaChi
            // 
            this.Txb_DiaChi.Location = new System.Drawing.Point(104, 146);
            this.Txb_DiaChi.Name = "Txb_DiaChi";
            this.Txb_DiaChi.Size = new System.Drawing.Size(129, 29);
            this.Txb_DiaChi.TabIndex = 2;
            // 
            // Txb_KH
            // 
            this.Txb_KH.Location = new System.Drawing.Point(104, 262);
            this.Txb_KH.Name = "Txb_KH";
            this.Txb_KH.Size = new System.Drawing.Size(129, 29);
            this.Txb_KH.TabIndex = 4;
            // 
            // Txb_CMND
            // 
            this.Txb_CMND.Location = new System.Drawing.Point(366, 86);
            this.Txb_CMND.Name = "Txb_CMND";
            this.Txb_CMND.Size = new System.Drawing.Size(100, 29);
            this.Txb_CMND.TabIndex = 6;
            // 
            // Txb_QuocTich
            // 
            this.Txb_QuocTich.Location = new System.Drawing.Point(369, 146);
            this.Txb_QuocTich.Name = "Txb_QuocTich";
            this.Txb_QuocTich.Size = new System.Drawing.Size(100, 29);
            this.Txb_QuocTich.TabIndex = 7;
            // 
            // Txb_MaP
            // 
            this.Txb_MaP.Location = new System.Drawing.Point(104, 38);
            this.Txb_MaP.Name = "Txb_MaP";
            this.Txb_MaP.Size = new System.Drawing.Size(129, 29);
            this.Txb_MaP.TabIndex = 0;
            // 
            // Txb_SDT
            // 
            this.Txb_SDT.Location = new System.Drawing.Point(104, 205);
            this.Txb_SDT.Name = "Txb_SDT";
            this.Txb_SDT.Size = new System.Drawing.Size(129, 29);
            this.Txb_SDT.TabIndex = 3;
            // 
            // Txb_HoTen
            // 
            this.Txb_HoTen.Location = new System.Drawing.Point(104, 83);
            this.Txb_HoTen.Name = "Txb_HoTen";
            this.Txb_HoTen.Size = new System.Drawing.Size(129, 29);
            this.Txb_HoTen.TabIndex = 1;
            // 
            // Gv_KhachHang
            // 
            this.Gv_KhachHang.BackgroundColor = System.Drawing.Color.White;
            this.Gv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_KhachHang.Location = new System.Drawing.Point(539, 390);
            this.Gv_KhachHang.Name = "Gv_KhachHang";
            this.Gv_KhachHang.Size = new System.Drawing.Size(464, 249);
            this.Gv_KhachHang.TabIndex = 14;
            this.Gv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_KhachHang_CellClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label16.Location = new System.Drawing.Point(534, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 25);
            this.label16.TabIndex = 15;
            this.label16.Text = "List Khách Hàng :";
            // 
            // ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1003, 639);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Gv_KhachHang);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GV_InfoPhong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phòng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_InfoPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txb_TenPhong;
        private System.Windows.Forms.TextBox Txb_MaPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cb_TinhTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GV_InfoPhong;
        private System.Windows.Forms.ComboBox Cb_MaLoaiP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txb_HoTen;
        private System.Windows.Forms.TextBox Txb_MaP;
        private System.Windows.Forms.TextBox Txb_SDT;
        private System.Windows.Forms.TextBox Txb_QuocTich;
        private System.Windows.Forms.TextBox Txb_CMND;
        private System.Windows.Forms.TextBox Txb_DiaChi;
        private System.Windows.Forms.TextBox Txb_KH;
        private System.Windows.Forms.DateTimePicker Dt_Tra;
        private System.Windows.Forms.DateTimePicker Dt_Nhan;
        private System.Windows.Forms.ComboBox Cb_GioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Btn_LuuInfo;
        private System.Windows.Forms.DataGridView Gv_KhachHang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Btn_Refresh;
    }
}