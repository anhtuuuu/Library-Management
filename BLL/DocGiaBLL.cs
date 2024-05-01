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
    public class DocGiaBLL
    {
        DocGiaDAL docGiaDAL = new DocGiaDAL();
        public List<DocGia> GetListDocGia()
        {
            return docGiaDAL.GetListDocGia();
        }

        public string ThemDocGia(DocGia docGia)
        {
            if (docGia.TenDG == "")
            {
                return "Required_Name";
            }
            if (docGia.DiaChi == "")
            {
                return "Required_Address";
            }
            if (docGia.Email == "")
            {
                return "Required_Email";
            }
            if (docGia.Sdt == "")
            {
                return "Required_Phone";
            }
            return docGiaDAL.ThemDocGia(docGia);
        }

        public string SuaDocGia(DocGia docGia)
        {
            if (docGia.TenDG == "")
            {
                return "Required_Name";
            }
            if (docGia.DiaChi == "")
            {
                return "Required_Address";
            }
            if (docGia.Email == "")
            {
                return "Required_Email";
            }
            if (docGia.Sdt == "")
            {
                return "Required_Phone";
            }
            return docGiaDAL.SuaDocGia(docGia);
        }

        public string XoaDocGia(DocGia docGia)
        {
            return docGiaDAL.XoaDocGia(docGia);
        }

        public DataSet SearchDocGia(string keyWord)
        {
            return docGiaDAL.SearchDocGia(keyWord);
        }
    }
}
