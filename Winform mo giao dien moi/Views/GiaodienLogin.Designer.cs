namespace Winform_mo_giao_dien_moi.GiaoDien
{
    partial class GiaodienLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaodienLogin));
            this.GridV_ThongTinPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Pb_ThemPhong = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Pic_Create = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbFindByID = new System.Windows.Forms.TextBox();
            this.Btn_TimKH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Lb_GiaPhong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lb_ThanhToan = new System.Windows.Forms.Label();
            this.Lb_Phong = new System.Windows.Forms.Label();
            this.Lb_NgayO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_ThanhToan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridV_ThongTinPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ThemPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Create)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridV_ThongTinPhong
            // 
            this.GridV_ThongTinPhong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridV_ThongTinPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridV_ThongTinPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridV_ThongTinPhong.Location = new System.Drawing.Point(0, 454);
            this.GridV_ThongTinPhong.Name = "GridV_ThongTinPhong";
            this.GridV_ThongTinPhong.Size = new System.Drawing.Size(895, 231);
            this.GridV_ThongTinPhong.TabIndex = 0;
            this.GridV_ThongTinPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridV_ThongTinPhong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(-3, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Phòng Có  Khách :";
            // 
            // Pb_ThemPhong
            // 
            this.Pb_ThemPhong.BackColor = System.Drawing.Color.Azure;
            this.Pb_ThemPhong.Image = ((System.Drawing.Image)(resources.GetObject("Pb_ThemPhong.Image")));
            this.Pb_ThemPhong.Location = new System.Drawing.Point(472, 16);
            this.Pb_ThemPhong.Name = "Pb_ThemPhong";
            this.Pb_ThemPhong.Size = new System.Drawing.Size(58, 47);
            this.Pb_ThemPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_ThemPhong.TabIndex = 0;
            this.Pb_ThemPhong.TabStop = false;
            this.Pb_ThemPhong.Click += new System.EventHandler(this.Pb_ThemPhong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Pic_Create);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Pb_ThemPhong);
            this.groupBox1.Controls.Add(this.TxbFindByID);
            this.groupBox1.Controls.Add(this.Btn_TimKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nhanh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(295, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tạo Tài Khoản";
            // 
            // Pic_Create
            // 
            this.Pic_Create.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Create.Image")));
            this.Pic_Create.Location = new System.Drawing.Point(309, 13);
            this.Pic_Create.Name = "Pic_Create";
            this.Pic_Create.Size = new System.Drawing.Size(66, 50);
            this.Pic_Create.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Create.TabIndex = 8;
            this.Pic_Create.TabStop = false;
            this.Pic_Create.Click += new System.EventHandler(this.Pic_Create_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(435, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chức Năng Phòng";
            // 
            // TxbFindByID
            // 
            this.TxbFindByID.Location = new System.Drawing.Point(10, 69);
            this.TxbFindByID.Name = "TxbFindByID";
            this.TxbFindByID.Size = new System.Drawing.Size(157, 29);
            this.TxbFindByID.TabIndex = 7;
            this.TxbFindByID.TextChanged += new System.EventHandler(this.TxbFindByID_TextChanged);
            // 
            // Btn_TimKH
            // 
            this.Btn_TimKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_TimKH.ForeColor = System.Drawing.Color.Black;
            this.Btn_TimKH.Location = new System.Drawing.Point(10, 119);
            this.Btn_TimKH.Name = "Btn_TimKH";
            this.Btn_TimKH.Size = new System.Drawing.Size(75, 28);
            this.Btn_TimKH.TabIndex = 5;
            this.Btn_TimKH.Text = "Refresh";
            this.Btn_TimKH.UseVisualStyleBackColor = false;
            this.Btn_TimKH.Click += new System.EventHandler(this.Btn_TimKH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Mã Phòng Cần Tìm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Lb_GiaPhong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Lb_ThanhToan);
            this.groupBox2.Controls.Add(this.Lb_Phong);
            this.groupBox2.Controls.Add(this.Lb_NgayO);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Btn_ThanhToan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 211);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "VNĐ";
            // 
            // Lb_GiaPhong
            // 
            this.Lb_GiaPhong.AutoSize = true;
            this.Lb_GiaPhong.ForeColor = System.Drawing.Color.LimeGreen;
            this.Lb_GiaPhong.Location = new System.Drawing.Point(425, 55);
            this.Lb_GiaPhong.Name = "Lb_GiaPhong";
            this.Lb_GiaPhong.Size = new System.Drawing.Size(31, 21);
            this.Lb_GiaPhong.TabIndex = 10;
            this.Lb_GiaPhong.Text = ".......";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(295, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn Giá Phòng :";
            // 
            // Lb_ThanhToan
            // 
            this.Lb_ThanhToan.AutoSize = true;
            this.Lb_ThanhToan.ForeColor = System.Drawing.Color.LimeGreen;
            this.Lb_ThanhToan.Location = new System.Drawing.Point(218, 174);
            this.Lb_ThanhToan.Name = "Lb_ThanhToan";
            this.Lb_ThanhToan.Size = new System.Drawing.Size(28, 21);
            this.Lb_ThanhToan.TabIndex = 8;
            this.Lb_ThanhToan.Text = "......";
            // 
            // Lb_Phong
            // 
            this.Lb_Phong.AutoSize = true;
            this.Lb_Phong.ForeColor = System.Drawing.Color.LimeGreen;
            this.Lb_Phong.Location = new System.Drawing.Point(136, 55);
            this.Lb_Phong.Name = "Lb_Phong";
            this.Lb_Phong.Size = new System.Drawing.Size(31, 21);
            this.Lb_Phong.TabIndex = 7;
            this.Lb_Phong.Text = ".......";
            // 
            // Lb_NgayO
            // 
            this.Lb_NgayO.AutoSize = true;
            this.Lb_NgayO.ForeColor = System.Drawing.Color.LimeGreen;
            this.Lb_NgayO.Location = new System.Drawing.Point(154, 109);
            this.Lb_NgayO.Name = "Lb_NgayO";
            this.Lb_NgayO.Size = new System.Drawing.Size(28, 21);
            this.Lb_NgayO.TabIndex = 5;
            this.Lb_NgayO.Text = "......";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = " Tổng Tiền Phải Thanh Toán :";
            // 
            // Btn_ThanhToan
            // 
            this.Btn_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_ThanhToan.ForeColor = System.Drawing.Color.Black;
            this.Btn_ThanhToan.Location = new System.Drawing.Point(487, 156);
            this.Btn_ThanhToan.Name = "Btn_ThanhToan";
            this.Btn_ThanhToan.Size = new System.Drawing.Size(103, 39);
            this.Btn_ThanhToan.TabIndex = 4;
            this.Btn_ThanhToan.Text = "Tính Tiền";
            this.Btn_ThanhToan.UseVisualStyleBackColor = false;
            this.Btn_ThanhToan.Click += new System.EventHandler(this.Btn_ThanhToan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số  Ngày Khách Ở :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phòng Khách Ở :";
            // 
            // GiaodienLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(895, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridV_ThongTinPhong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiaodienLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện";
            this.Load += new System.EventHandler(this.GiaodienLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridV_ThongTinPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ThemPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Create)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridV_ThongTinPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pb_ThemPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_ThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lb_NgayO;
        private System.Windows.Forms.Label Lb_Phong;
        private System.Windows.Forms.Label Lb_ThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lb_GiaPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxbFindByID;
        private System.Windows.Forms.Button Btn_TimKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Pic_Create;
        private System.Windows.Forms.Label label9;
    }
}