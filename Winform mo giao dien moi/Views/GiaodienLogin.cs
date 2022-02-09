using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Winform_mo_giao_dien_moi.Models;
using Winform_mo_giao_dien_moi.Views;

namespace Winform_mo_giao_dien_moi.GiaoDien
{
    public partial class GiaodienLogin : Form
    {
        private readonly string Connect = @"Data Source=DESKTOP-3NM76MO\MSSQL;Initial Catalog=FinalQLyKs;Integrated Security=True";
        private List<Room> AllRoom = new List<Room>();
        private List<Room> FilterRoom;


        public GiaodienLogin()
        {
            InitializeComponent();
            GetPhong();

            using (SqlConnection conn = new SqlConnection(Connect))
            {
                conn.Open();
                string query = @"select Tbl_Phong.MAPHONG,Tbl_Phong.TENPHONG,Tbl_Phong.TINHTRANG ,
                                Tbl_KhachHang.TENKHACHHANG,Tbl_KhachHang.DIACHI,Tbl_KhachHang.SDT,Tbl_KhachHang.NGAYDEN,Tbl_Phong.MALOAIPHONG,
                                Tbl_KhachHang.NGAYDI from Tbl_Phong join Tbl_KhachHang on Tbl_Phong.MAPHONG= Tbl_KhachHang.MAPHONG"; ;
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Room r = new Room()
                        {

                            MAPHONG = reader[0].ToString(),
                            TENPHONG = reader[1].ToString(),
                            TINHTRANG = reader[2].ToString(),
                            TENKHACH = reader[3].ToString(),
                            DIACHI = reader[4].ToString(),
                            SDT = reader[5].ToString(),
                            MALOAIPHONG = reader[7].ToString(),
                            NGAYDEN = Convert.ToDateTime(reader[6]),
                            NGAYDI = Convert.ToDateTime(reader[8]),
                        };
                        AllRoom.Add(r);
                    }
                }
            }

            FilterRoom = new List<Room>(AllRoom);
        }

        private void GetPhong()
        {
            List<Room> ListP = new List<Room>();
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string Sql = "select Tbl_Phong.MAPHONG,Tbl_Phong.TENPHONG,Tbl_Phong.TINHTRANG , " +
                    "Tbl_KhachHang.TENKHACHHANG,Tbl_KhachHang.DIACHI,Tbl_KhachHang.SDT,Tbl_KhachHang.NGAYDEN," +
                    "Tbl_KhachHang.NGAYDI,Tbl_Phong.MALOAIPHONG from Tbl_Phong join Tbl_KhachHang on Tbl_Phong.MAPHONG = Tbl_KhachHang.MAPHONG";


                using (SqlCommand comand = new SqlCommand(Sql, ketnoi)) //Thực Thi Các Câu Lệnh Chức Năng Trong  SQL
                {


                    comand.CommandType = CommandType.Text;


                    SqlDataReader read = comand.ExecuteReader();
                    while (read.Read())
                    {
                        Room Phong = new Room();
                        Phong.MAPHONG = read[0].ToString();
                        Phong.TENPHONG = read[1].ToString();
                        Phong.TINHTRANG = read[2].ToString();
                        Phong.TENKHACH = read[3].ToString();
                        Phong.DIACHI = read[4].ToString();
                        Phong.SDT = read[5].ToString();
                        Phong.NGAYDEN = Convert.ToDateTime(read[6]);
                        Phong.NGAYDI = Convert.ToDateTime(read[7]);
                        Phong.MALOAIPHONG = read[8].ToString();



                        ListP.Add(Phong);
                    }

                    GridV_ThongTinPhong.DataSource = ListP;
                    GridV_ThongTinPhong.Columns[0].HeaderText = "Mã Phòng";
                    GridV_ThongTinPhong.Columns[1].HeaderText = "Tình Trạng";
                    GridV_ThongTinPhong.Columns[2].HeaderText = "Tên Phòng";
                    GridV_ThongTinPhong.Columns[3].HeaderText = "Tên Khách Hàng";
                    GridV_ThongTinPhong.Columns[4].HeaderText = "Địa Chỉ Khách Hàng";
                    GridV_ThongTinPhong.Columns[5].HeaderText = "Số Điện Thoại";
                    GridV_ThongTinPhong.Columns[6].HeaderText = "Mã Loại Phòng";
                    GridV_ThongTinPhong.Columns[7].HeaderText = "Ngày Nhận Phòng";
                    GridV_ThongTinPhong.Columns[8].HeaderText = "Ngày Trả Phòng";


                }

            }


        }

        private void GridV_ThongTinPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DateTime NgayNhan = Convert.ToDateTime(GridV_ThongTinPhong.Rows[e.RowIndex].Cells[7].Value);
            DateTime NgayTra = Convert.ToDateTime(GridV_ThongTinPhong.Rows[e.RowIndex].Cells[8].Value);
            string Maphong = (GridV_ThongTinPhong.Rows[e.RowIndex].Cells[0].Value).ToString();
            Lb_Phong.Text = Maphong;
            Lb_NgayO.Text = (NgayTra - NgayNhan).TotalDays.ToString();
            Lb_ThanhToan.Text = "...";

            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string sql = @"select Tbl_LoaiPhong.GIAPHONG from Tbl_Phong
                                join Tbl_LoaiPhong on Tbl_Phong.MALOAIPHONG = Tbl_LoaiPhong.MALOAIPHONG
                                where Tbl_Phong.MAPHONG = @Maphong";
                using (SqlCommand comand = new SqlCommand(sql, ketnoi))
                {
                    comand.CommandType = CommandType.Text;
                    comand.Parameters.AddWithValue("@MaPhong", Lb_Phong.Text);
                    SqlDataReader read = comand.ExecuteReader();
                    while (read.Read())
                    {
                        Lb_GiaPhong.Text = read[0].ToString();
                    }
                }
            }
            Lb_ThanhToan.Text = ((Convert.ToInt32(Lb_NgayO.Text) * Convert.ToInt32(Lb_GiaPhong.Text)).ToString());

        }

        private void Pb_ThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhong tp = new ThemPhong();
            this.Hide();
            tp.ShowDialog();
            this.Show();
            GridV_ThongTinPhong.DataSource = null;
            GetPhong();
        }

        private void GiaodienLogin_Load(object sender, EventArgs e)
        {


        }

        private void Bnt_TimMP_Click(object sender, EventArgs e)
        {
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string sql = "select Tbl_Phong.MAPHONG,Tbl_Phong.TENPHONG,Tbl_Phong.TINHTRANG ,Tbl_KhachHang.TENKHACHHANG,Tbl_KhachHang.DIACHI,Tbl_KhachHang.CMND,Tbl_KhachHang.NGAYDEN,Tbl_KhachHang.NGAYDI from Tbl_Phong join Tbl_KhachHang on Tbl_Phong.MAKHACHHANG = Tbl_KhachHang.MAKHACHHANG";
            }
        }

        private void Cb_BoxMP_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_TimKH_Click(object sender, EventArgs e)
        {
            GetPhong();
        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {

            using (SqlConnection ketnoi1 = new SqlConnection(Connect))
            {
                ketnoi1.Open();


                using (SqlConnection ketnoi = new SqlConnection(Connect))
                {

                    ketnoi.Open();



                    string doc = @"Update Tbl_Phong
                            set TINHTRANG=@TinhTrang
                            Where MAPHONG= @MaPhong";

                    using (SqlCommand thuhien = new SqlCommand(doc, ketnoi))
                    {
                        thuhien.CommandType = CommandType.Text;
                        thuhien.Parameters.AddWithValue("@MaPhong", Lb_Phong.Text);                  
                        thuhien.Parameters.AddWithValue("@TinhTrang", "Trống");
                 

                       thuhien.ExecuteNonQuery();
                      
                     
                        
                    }
                }
                using (SqlConnection ketnoi2 = new SqlConnection(Connect))
                {

                    ketnoi2.Open();
                    string Sql2 = @"delete from Tbl_KhachHang where MAPHONG=@MaPhong ";
                    using (SqlCommand comd = new SqlCommand(Sql2, ketnoi2))
                    {

                        comd.CommandType = CommandType.Text;
                        comd.Parameters.AddWithValue("@MaPhong", Lb_Phong.Text);


                        int result = comd.ExecuteNonQuery();
                        if (result > 0)

                        {
                            MessageBox.Show("Thanh Toán Thành Công");
                            GetPhong();
                        }
                        else MessageBox.Show("Thanh Toán Thất Bại");
                    }
                }




            }
    
        
        }

        private void TxbFindByID_TextChanged(object sender, EventArgs e)
        {
            //var selection = Cb_BoxMP.SelectedValue as Room;
            var items = AllRoom.Where(x => x.MAPHONG.Contains(TxbFindByID.Text));

            for (int i = AllRoom.Count - 1; i >= 0; i--)
            {
                var item = AllRoom[i];
                if (!items.Contains(item))
                    FilterRoom.Remove(item);
            }

            foreach (var item in items)
            {
                if (!FilterRoom.Contains(item)) FilterRoom.Add(item);
            }

            GridV_ThongTinPhong.DataSource = null;
            GridV_ThongTinPhong.DataSource = FilterRoom;
        }

        private void Pic_Create_Click(object sender, EventArgs e)
        {
            TaoTk tk = new TaoTk();
            tk.ShowDialog();
        }
    }
}
