using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Winform_mo_giao_dien_moi.Models;

namespace Winform_mo_giao_dien_moi.Views
{
    public partial class ThemPhong : Form
    {
        private readonly string Connect = @"Data Source=DESKTOP-3NM76MO\MSSQL;Initial Catalog=FinalQLyKs;Integrated Security=True";

        public object Phong { get; private set; }

        public ThemPhong()
        {
            InitializeComponent();
            GetPhong();
            GetKH();
        }
        private void GetPhong()
        {
            List<ThemRoom> ListPhong = new List<ThemRoom>();
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string Sql = "select * from Tbl_Phong";
                using (SqlCommand comand = new SqlCommand(Sql, ketnoi)) //Thực Thi Các Câu Lệnh Chức Năng Trong  SQL
                {


                    comand.CommandType = CommandType.Text;


                    SqlDataReader read = comand.ExecuteReader();
                    while (read.Read())
                    {
                        ThemRoom Phong1 = new ThemRoom();
                        Phong1.MAPHONG = read[0].ToString();
                        Phong1.TENPHONG = read[1].ToString();
                        Phong1.TINHTRANG = read[2].ToString();
                        Phong1.MALOAIPHONG = read[3].ToString();

                        ListPhong.Add(Phong1);
                    }
                    GV_InfoPhong.DataSource = ListPhong;
                    GV_InfoPhong.Columns[0].HeaderText = "Mã Phòng";
                    GV_InfoPhong.Columns[1].HeaderText = "Tên Phòng";
                    GV_InfoPhong.Columns[2].HeaderText = "Tình Trạng";
                    GV_InfoPhong.Columns[3].HeaderText = "Mã Loại Phòng";


                }
            }
        }
        #region Chức Năng Phòng
        public bool ktraMPhong(string Maphong)
        {
            #region Kiemtra
            //SqlConnection ketnoi = new SqlConnection(Connect);
            //ketnoi.Open();
            //string sql = "select MAPHONG from Tbl_Phong where MAPHONG='"+Maphong+"'";
            //SqlCommand comand = new SqlCommand(sql, ketnoi);
            //SqlDataReader read = comand.ExecuteReader();
            //if (read.Read()==true) //Nếu đã tồn tại mã phòng trong csdl thì trả về true
            //{
            //    ketnoi.Close();
            //    return true;
            //}
            //ketnoi.Close();
            //return false; 
            #endregion
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string query = "select MAPHONG from Tbl_Phong where MAPHONG= @MaPhong";
                using (SqlCommand command = new SqlCommand(query, ketnoi))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@MaPhong", Maphong);

                    var reader = command.ExecuteReader();

                    //Nếu có row thì trả về true không thì false :| 

                    if (reader.HasRows == true) return true;
                    else return false;
                }
            }
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {

                ketnoi.Open();


                
                string doc = @"Update Tbl_Phong
                            set TENPHONG= @TenPhong, 
                            TINHTRANG=@TinhTrang, MALOAIPHONG= @MaLoaiPhong
                            Where MAPHONG= @MaPhong";
               
                using (SqlCommand thuhien = new SqlCommand(doc, ketnoi))
                {
                    thuhien.CommandType = CommandType.Text;
                    thuhien.Parameters.AddWithValue("@MaPhong", Txb_MaPhong.Text);
                    thuhien.Parameters.AddWithValue("@TenPhong", Txb_TenPhong.Text);
                    thuhien.Parameters.AddWithValue("@TinhTrang", Cb_TinhTrang.SelectedItem.ToString());
                    thuhien.Parameters.AddWithValue("@MaLoaiPhong", Cb_MaLoaiP.SelectedItem.ToString());

                    int kq = thuhien.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa Thành Công");
                        GV_InfoPhong.DataSource = null;
                        GetPhong();
                    }
                    else MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void GV_InfoPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaPhong.Text = GV_InfoPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txb_TenPhong.Text = GV_InfoPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
            Cb_TinhTrang.SelectedItem = GV_InfoPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
            Cb_MaLoaiP.SelectedItem = GV_InfoPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
            Txb_MaP.Text = GV_InfoPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string Sql = @"insert into Tbl_Phong (MAPHONG,TENPHONG,TINHTRANG,MALOAIPHONG)
                                values (@MaPhong,@TenPhong,@TinhTrang,@MaLoaiPhong)";
                using (SqlCommand comand = new SqlCommand(Sql, ketnoi))
                {
                    if (ktraMPhong(Txb_MaPhong.Text) == true)
                    {
                        MessageBox.Show("Trùng Mã Phòng");
                        return;
                    }
                    if (Txb_MaPhong.Text == "" || Txb_TenPhong.Text == "")
                    {
                        MessageBox.Show("Vui Lòng Không Bỏ Trống Thông Tin Phòng");
                        return;
                    }


                    comand.CommandType = CommandType.Text;
                    comand.Parameters.AddWithValue("@MaPhong", Txb_MaPhong.Text);
                    comand.Parameters.AddWithValue("@TenPhong", Txb_TenPhong.Text);
                    comand.Parameters.AddWithValue("@TinhTrang", Cb_TinhTrang.SelectedItem.ToString());
                    comand.Parameters.AddWithValue("@MaLoaiPhong", Cb_MaLoaiP.SelectedItem.ToString());


                    //TAI5 LA2 D CO KHACH NEN NO D HIEN

                    int result = comand.ExecuteNonQuery();
                    if (result > 0)

                    {
                        MessageBox.Show("Thêm Thành Công");
                        GV_InfoPhong.DataSource = null;

                        GetPhong();
                    }
                    else MessageBox.Show("Thêm Thất Bại");
                }
            }
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection ketnoi1 = new SqlConnection(Connect))
            {
                ketnoi1.Open();
                

                using (SqlConnection ketnoi2 = new SqlConnection(Connect))
                {

                    ketnoi2.Open();
                    string Sql2 = @"delete from Tbl_Phong where MAPHONG=@MaPhong ";
                    using (SqlCommand comd = new SqlCommand(Sql2, ketnoi2))
                    {

                        comd.CommandType = CommandType.Text;
                        comd.Parameters.AddWithValue("@MaPhong", Txb_MaPhong.Text);

                        int result = comd.ExecuteNonQuery();
                        if (result > 0)

                        {
                            MessageBox.Show("Xóa Thành Công");
                            GV_InfoPhong.DataSource = null;
                            GetPhong();
                        }
                        else MessageBox.Show("Xóa Thất Bại");
                    }
                }




            }
        }

        #endregion
        #region  Đặt Phòng


        public bool ktraMAKH(string MaKhach)
        {
          
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string query = "select MAKHACHHANG from Tbl_KhachHang where MAKHACHHANG= @MaKhach";
                using (SqlCommand command = new SqlCommand(query, ketnoi))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@MaKhach", MaKhach);

                    var reader = command.ExecuteReader();

                    //Nếu có row thì trả về true không thì false :| 

                    if (reader.HasRows == true) return true;
                    else return false;
                }
            }
        }
        private void GetKH()
        {
            List<Customer> ListPhong = new List<Customer>();
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string Sql = "select * from Tbl_KhachHang";
                using (SqlCommand comand = new SqlCommand(Sql, ketnoi)) //Thực Thi Các Câu Lệnh Chức Năng Trong  SQL
                {
                    comand.CommandType = CommandType.Text;
                    SqlDataReader read = comand.ExecuteReader();
                    while (read.Read())
                    {
                        Customer kh = new Customer();
                        kh.MAKHACHHANG = read[0].ToString();
                        kh.TENKHACHHANG = read[1].ToString();
                        kh.MAPHONG = read[8].ToString();
                       

                        ListPhong.Add(kh);
                    }
                    Gv_KhachHang.DataSource = ListPhong;
                    Gv_KhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
                    Gv_KhachHang.Columns[1].HeaderText = "Tên Khách Hàng ";
                    Gv_KhachHang.Columns[2].HeaderText = "Mã Phòng";



                }
            }
        }
        private void button1_Click(object sender, EventArgs e) //Btn_Luu
        {

            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                if (ktraMAKH(Txb_KH.Text) == true)
                {
                    MessageBox.Show("Trùng Mã Khách Hàng");
                    return;
                }
                if (Txb_KH.Text == "" || Txb_CMND.Text == "" || Txb_DiaChi.Text == "" ||
                    Txb_HoTen.Text == "" || Txb_KH.Text == "" || Txb_MaP.Text == "" ||
                    Txb_QuocTich.Text == "" || Txb_SDT.Text == "" || Cb_GioiTinh.SelectedItem.ToString()=="") 
                {
                    MessageBox.Show("Vui Lòng Không Bỏ Trống Thông Tin");
                }
                string sql = @"insert into Tbl_KhachHang  (MAKHACHHANG,TENKHACHHANG,DIACHI,GIOTINH,SDT,CMND,NGAYDEN,NGAYDI,MAPHONG,QUOCTICH)
                                values (@MaKh,@TenKH,@DiaChi,@GioiTinh,@Sdt,@Cmnd,@NgayDen,@NgayDi,@MaPhong,@QuocTich)";
                using (SqlCommand comand = new SqlCommand(sql, ketnoi))
                {              
                    comand.CommandType = CommandType.Text;
                    comand.Parameters.AddWithValue("@MaKh", Txb_KH.Text);
                    comand.Parameters.AddWithValue("@TenKH", Txb_HoTen.Text);
                    comand.Parameters.AddWithValue("@DiaChi", Txb_DiaChi.Text);
                    comand.Parameters.AddWithValue("@GioiTinh", Cb_GioiTinh.SelectedItem.ToString());
                    comand.Parameters.AddWithValue("@Sdt", Txb_SDT.Text);
                    comand.Parameters.AddWithValue("@Cmnd", Txb_CMND.Text);
                    comand.Parameters.AddWithValue("@NgayDen", Dt_Nhan.Value);
                    comand.Parameters.AddWithValue("@NgayDi", Dt_Tra.Value);
                    comand.Parameters.AddWithValue("@MaPhong", Txb_MaP.Text.ToString());
                    comand.Parameters.AddWithValue("@QuocTich", Txb_QuocTich.Text);

                    int result = comand.ExecuteNonQuery();
                    if (result > 0)
                      
                    {
                        MessageBox.Show("Thêm Thành Công");
                        GetKH();
                    }

                }
               
                string doc = @"Update Tbl_Phong
                           set TINHTRANG=@TinhTrang
                            Where MAPHONG= @MaPhong";

                using (SqlCommand thuhien = new SqlCommand(doc, ketnoi))
                {
                    thuhien.CommandType = CommandType.Text;
                    thuhien.Parameters.AddWithValue("@TinhTrang", "Có Khách");
                    thuhien.Parameters.AddWithValue("@MaPhong", Txb_MaP.Text.ToString());

                    thuhien.ExecuteNonQuery();
                }
            }

        }


        #endregion

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection ketnoi1 = new SqlConnection(Connect))
            {
                ketnoi1.Open();


                using (SqlConnection ketnoi2 = new SqlConnection(Connect))
                {

                    ketnoi2.Open();
                    string Sql2 = @"delete from Tbl_KhachHang where MAPHONG=@MaPhong ";
                    using (SqlCommand comd = new SqlCommand(Sql2, ketnoi2))
                    {

                        comd.CommandType = CommandType.Text;
                        comd.Parameters.AddWithValue("@MaPhong", Txb_MaP.Text);

                      comd.ExecuteNonQuery();
                        GetKH();
                    }
                }




            }
        }

        private void Gv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_MaP.Text = Gv_KhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
