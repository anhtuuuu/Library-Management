﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSachBLL
    {
        LoaiSachDAL loaiSachDAL = new LoaiSachDAL();
        public List<LoaiSach> GetListLoaiSach() 
        {
            return loaiSachDAL.GetListLoaiSach();
        }
        public string ThemLoaiSach(LoaiSach loaiSach)
        {
            if(loaiSach.TenLoaiSach == "")
            {
                return "Required_Name";
            }
            return loaiSachDAL.ThemLoaiSach(loaiSach);
        }
        public string SuaLoaiSach(LoaiSach loaiSach)
        {
            if (loaiSach.TenLoaiSach == "")
            {
                return "Required_Name";
            }
            return loaiSachDAL.SuaLoaiSach(loaiSach);
        }
        public string XoaLoaiSach(LoaiSach loaiSach)
        {
            return loaiSachDAL.XoaLoaiSach(loaiSach) ;
        }
        public DataSet SearchLoaiSach(string keyWord)
        {
            DataSet dataSet = loaiSachDAL.SearchLoaiSach(keyWord);
            return dataSet;
        }
    }
}
