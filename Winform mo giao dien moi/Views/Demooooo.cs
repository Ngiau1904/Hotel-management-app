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

namespace Winform_mo_giao_dien_moi.Views
{
    public partial class Demooooo : Form
    {
        public Demooooo()
        {
            InitializeComponent();
        }
        public bool ktraMPhong(string Maphong)
        {
           

            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string query = "select MAPHONG from Tbl_KhachHang where MAPHONG= @MaPhong";
                using (SqlCommand command = new SqlCommand(query, ketnoi))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@MaPhong", Maphong);
                    var reader = command.ExecuteReader();                
                    if (reader.HasRows == true) return true;
                    else return false;
                }
            }
        }

        private readonly string Connect = @"Data Source=DESKTOP-3NM76MO\MSSQL;Initial Catalog=FinalQLyKs;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection ketnoi = new SqlConnection(Connect))
            {
                ketnoi.Open();
                string sql = @"insert into Tbl_KhachHang  (MAKHACHHANG,TENKHACHHANG,DIACHI,GIOTINH,SDT,CMND,NGAYDEN,NGAYDI,MAPHONG,QUOCTICH)
                                values (@MaKh,@TenKH,@DiaChi,@GioiTinh,@Sdt,@Cmnd,@NgayDen,@NgayDi,@MaPhong,@QuocTich)";
                using (SqlCommand comand= new SqlCommand(sql,ketnoi))
                {
                    if (ktraMPhong(Txb_MP.Text)==true)
                    {
                        MessageBox.Show("Đã Có Người Dùng Mã Phòng Này");
                        return;
                    }
                    comand.CommandType = CommandType.Text;
                    comand.Parameters.AddWithValue("@MaKh", Txb_MaKH.Text);
                    comand.Parameters.AddWithValue("@TenKH", Txb_HoTen.Text);
                    comand.Parameters.AddWithValue("@DiaChi", Txb_DiaChi.Text);
                    comand.Parameters.AddWithValue("@GioiTinh", Cb_GioiTinh.SelectedItem.ToString());
                    comand.Parameters.AddWithValue("@Sdt", Txb_SDT.Text);
                    comand.Parameters.AddWithValue("@Cmnd", Txb_CMND.Text);
                    comand.Parameters.AddWithValue("@NgayDen", dt_NgayNhan.Value);
                    comand.Parameters.AddWithValue("@NgayDi", dt_NgayTra.Value);
                    comand.Parameters.AddWithValue("@MaPhong", Txb_MP.Text);
                    comand.Parameters.AddWithValue("@QuocTich", Txb_QuocTich.Text);

                    int result = comand.ExecuteNonQuery();
                    if (result > 0)

                    {
                        MessageBox.Show("Thêm Thành Công");
                                            
                    }
                }
            }
        }
    }
}
