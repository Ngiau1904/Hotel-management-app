using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_mo_giao_dien_moi.Models;

namespace Winform_mo_giao_dien_moi
{
    public partial class TaoTk : Form
    {
        public TaoTk()
        {
            InitializeComponent();
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "Btn_Thoat")
            {
                this.Close();
            }
            else if (btn.Name == "Btn_Tao")
            {

                //DDuong dan file Taikhoan.txt
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Taikhoan.txt");
                List<Account> accounts = DataAccess.DocFile(path);
                if (Txb_mk.Text == Txb_mk2.Text)
                {                 
                    if (accounts.Count > 0)
                    {
                        foreach (Account item in accounts)
                        {
                            if (Txb_TenDn.Text=="")
                            {
                                MessageBox.Show("Tài Khoản Không Được Bỏ Trống");
                            }
                            if (item.TenDangNhap == Txb_TenDn.Text)
                            {
                                MessageBox.Show("Tên Tài Khoản Đăng Nhập Bị Trùng!");
                                return;
                            }
                            else if (item.Email == Txb_Email.Text)
                            {
                                MessageBox.Show("Email Đã Được Sử Dụng");
                                ClearText();
                                return;
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Mật Khẩu Phải Trùng");
                    return;
                }


                //Ghi FIle
                string path2 = Directory.GetCurrentDirectory() + "/Data/Taikhoan.txt";
                string contents2 = string.Format("{0}-{1}-{2}-{3}-{4}\n", Txb_HoTen.Text
                    , Txb_TenDn.Text, Txb_mk.Text, Txb_Email.Text, Txb_Sdt.Text);
                DataAccess.Ghifile(path2, contents2);
                MessageBox.Show("Tạo Thành Công");
            }


        }


      
        void ClearText()
        {
            Txb_Email.Text = string.Empty;
            Txb_HoTen.Text = string.Empty;
            Txb_Sdt.Text = string.Empty;
            Txb_TenDn.Text = string.Empty;

        }

        //Xóa Text Tham Khảo
        //void ClearText()
        //{
        //    foreach (Control item in tableLayoutPanel1.Controls)
        //    {
        //        if (item is TextBox)
        //        {
        //            TextBox txb = item as TextBox;
        //            txb.Text = string.Empty;
        //        }
        //    }
        //}
    }
}
