using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public List<TaiKhoan> GetListTaiKhoan()
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            List<TaiKhoan> taiKhoans = taiKhoanDAL.GetListTaiKhoan();
            return taiKhoans;
        }

        public List<TaiKhoan> GetTaiKhoan(string id)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            List<TaiKhoan> taiKhoans = taiKhoanDAL.GetTaiKhoan(id);
            return taiKhoans;
        }

        public string Check_DangNhap(TaiKhoan taiKhoan)
        {
            if (taiKhoan.Username.Trim() == "") return "Required_TenTK";
            else if (taiKhoan.Password.Trim() == "") return "Required_MatKhau";
            else
            {
                TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
                return taiKhoanDAL.Check_DangNhap(taiKhoan);
            }
        }

        public bool kiemTraTenTaiKhoan(string s)
        {
            return Regex.IsMatch(s, "^[a-zA-Z0-9]{8,25}$");
        }

        public bool kiemTraEmail(string e)
        {
            return Regex.IsMatch(e, @"^[a-zA-Z0-9]{5,20}@gmail.com$");
        }

        public string Check_DangKy(TaiKhoan taiKhoan, string confirm)
        {
            if (taiKhoan.HoTen == "" || taiKhoan.Sdt == "" || taiKhoan.Email == "" || taiKhoan.Username == "" || taiKhoan.Password == "")
            {
                return "Required_Infomation";
            }
            if (!kiemTraTenTaiKhoan(taiKhoan.Username))
            {
                return "Wrong_Format_Username";
            }            
            if (!kiemTraEmail(taiKhoan.Email))
            {
                return "Wrong_Format_Email";
            }
            if(taiKhoan.Password != confirm)
            {
                return "Fail_Confirm";
            }
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.Check_DangKy(taiKhoan);
        }

        public string Send_OTP(string email)
        {
            if(email == "")
            {
                return "Required_Email";
            }
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.Send_OTP(email);
        }
        public TaiKhoan GetTaiKhoanEmail(string email)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.GetTaiKhoanEmail(email);
        }

        public string SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            if(taiKhoan.Email == "")
            {
                return "Required_Email";
            }
            if(taiKhoan.Password == "")
            {
                return "Required_Password";
            }
            if(taiKhoan.Username == "")
            {
                return "Required_Username";
            }
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.SuaTaiKhoan(taiKhoan);
        }

        public DataSet Search(string keyWord)
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            return taiKhoanDAL.Search(keyWord);
        }
    }
}
