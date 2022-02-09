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
using Winform_mo_giao_dien_moi.GiaoDien;
using Winform_mo_giao_dien_moi.Models;

namespace Winform_mo_giao_dien_moi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Taikhoan.txt");
            //LoginFrom login = new LoginFrom();
            //login.ShowDialog();
            Clipboard.SetText(path);
            MessageBox.Show(path);

        }

        void ClearText()
        {
            Txb_TaiKhoan.Text = string.Empty;
            Txb_MatKhau.Text = string.Empty;
        }

        private void Bnt_DangNhap_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "Btn_Thoat")
            {
                this.Close();


            }
            else if (btn.Name == "Btn_DangNhap")
            {
                string paths = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Taikhoan.txt");
                List<Account> accounts = DataAccess.DocFile(paths);
             
                if (accounts.Count > 0)
                {
                    foreach (Account item in accounts)
                    {
                        if (Txb_TaiKhoan.Text=="")
                        {
                            MessageBox.Show("Tài Khoản Không Được Trống");
                            return;
                        }
                        if (item.TenDangNhap == Txb_TaiKhoan.Text && item.MatKhau == Txb_MatKhau.Text)
                        {
                            GiaodienLogin Login = new GiaodienLogin();
                            this.Hide();
                            Login.ShowDialog();
                            this.Show();
                        }
                        else if (item.TenDangNhap != Txb_TaiKhoan.Text)
                        {
                            MessageBox.Show("Tài Khoản Không Tồn Tại");
                            return;
                        }
                        else if (Txb_MatKhau.Text=="")
                        {
                            MessageBox.Show("Nhập Mật Khẩu");
                            return;
                        }
                        else MessageBox.Show("Sai Mật Khẩu"); return;
                    }
                }

            }
        }
    }
}
