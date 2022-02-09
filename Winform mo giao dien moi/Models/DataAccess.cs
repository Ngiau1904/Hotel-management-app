using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Winform_mo_giao_dien_moi.Models
{
    public class DataAccess
    {
        public static List<Account> DocFile(string path)
        {
            //Doc noi dung file taikhoan.txt
            string data = File.ReadAllText(path).Replace("\n", "");
            List<Account> accounts = new List<Account>();
            if (!string.IsNullOrEmpty(data))
            {
                string[] lines = data.Split('\n');
                foreach (string line in lines)
                {
                    Account acc = new Account();
                    string[] s = line.Split('-');
                    acc.HoTen = s[0];
                    acc.TenDangNhap = s[1];
                    acc.MatKhau = s[2];
                    acc.Email = s[3];
                    acc.SoDienThoai = s[4];
                    accounts.Add(acc);
                }
            }
            
            return accounts;
        }
       public static void Ghifile (string Path,string Contents)
        {
            File.AppendAllText(Path, Contents);
        }


    }
}
