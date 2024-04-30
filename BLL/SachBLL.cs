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
    public class SachBLL
    {
        public List<Sach> GetListSach()
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.GetListSach();
        }
        public string ThemSach(Sach sach)
        {
            if(sach.MaLoaiSach == "")
            {
                return "Required_MLS";
            }
            if(sach.MaNhaCungCap == "")
            {
                return "Required_MNCC";
            }
            SachDAL sachDAL = new SachDAL();
            return sachDAL.ThemSach(sach);
        }

        public DataSet GetLoaiSach()
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.GetLoaiSach();
        }
        public DataSet GetNhaCungCap()
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.GetNhaCungCap();
        }

        public string SuaSach(Sach sach)
        {
            if (sach.MaLoaiSach == "")
            {
                return "Required_MLS";
            }
            if (sach.MaNhaCungCap == "")
            {
                return "Required_MNCC";
            }
            SachDAL sachDAL = new SachDAL();
            return sachDAL.SuaSach(sach);
        }
        public string XoaSach(Sach sach)
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.XoaSach(sach);
        }
        public DataSet SearchSach(string keyWord)
        {
            SachDAL sachDAL = new SachDAL();
            return sachDAL.SearchSach(keyWord);
        }
    }
}
