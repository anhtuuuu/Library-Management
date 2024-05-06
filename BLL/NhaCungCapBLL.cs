using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL nhaCungCapDAL = new NhaCungCapDAL();
        public List<NhaCungCap> GetListNhaCungCap()
        {
            return nhaCungCapDAL.GetListNhaCungCap();
        }

        public string ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            if(nhaCungCap.TenNCC.Trim() == "")
            {
                return "Required_Name";
            }
            if (nhaCungCap.DiaChi.Trim() == "")
            {
                return "Required_Address";
            }
            if (nhaCungCap.Sdt.Trim() == "")
            {
                return "Required_Phone";
            }
            return nhaCungCapDAL.ThemNhaCungCap(nhaCungCap);
        }

        public string SuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (nhaCungCap.TenNCC.Trim() == "")
            {
                return "Required_Name";
            }
            if (nhaCungCap.DiaChi.Trim() == "")
            {
                return "Required_Address";
            }
            if (nhaCungCap.Sdt.Trim() == "")
            {
                return "Required_Phone";
            }
            return nhaCungCapDAL.SuaNhaCungCap(nhaCungCap);
        }
        public string XoaNhaCungCap(NhaCungCap nhaCungCap)
        {
            return nhaCungCapDAL.XoaNhaCungCap(nhaCungCap);
        }
        public DataSet SearchNCC(string keyWord)
        {
            return nhaCungCapDAL.SearchNCC(keyWord);
        }
    }
}
