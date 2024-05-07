using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MuonTraSachDAL:DatabaseAccess
    {
        HoaDonDAL HDDAL = new HoaDonDAL();
        public List<HoaDon> GetListHD()
        {
            return HDDAL.GetListHoaDon();
        }
        public DataSet GetHD()
        {
            string query = "SELECT * FROM HoaDon";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetHD(string id)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHD = '" + id + "'";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetDG()
        {
            return HDDAL.GetDocGia();
        }
        public DataSet GetDG(string id)
        {
            string query = "SELECT * FROM DocGia WHERE MaDG = '" + id + "'";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetSach()
        {
            return HDDAL.GetSach();
        }
        public DataSet GetSach(string name)
        {
            string query = "SELECT * FROM Sach WHERE TenSach = N'" + name + "'";
            try
            {
                DataSet data = GetData(query);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string InsertHoaDon(HoaDon hoaDon)
        {
            string query = "INSERT INTO HoaDon VALUES('" + hoaDon.MaHD + "','" + hoaDon.MaDG + "','" + hoaDon.NgayLap + "','" + hoaDon.HanTra + "','" + hoaDon.NgayLap + "'," + hoaDon.SoLuong + "," + hoaDon.TienKhachDua + "," + hoaDon.TienGuiKhach + "," + hoaDon.ThanhTien + "," + hoaDon.TrangThai + ")";
            try
            {
                Command(query);
                return "Successful_Change";
            }
            catch (Exception ex)
            {
                return "Fail_Change " + ex.Message;
            }
        }
        public string InsertChitietHoaDon(ChiTietHoaDon cthd)
        {
            string query = "INSERT INTO ChiTietHoaDon VALUES('" + cthd.MaHD + "','" + cthd.MaSach +"'," + cthd.SoLuong + "," + cthd.DonGia + "," + cthd.ThanhTien + ")";
            try
            {
                Command(query);
                return "Successful_Change";
            }
            catch (Exception ex)
            {
                return "Fail_Change " + ex.Message;
            }
        }

        public string TraSach(string maHD)
        {
            string query = "UPDATE HoaDon SET TrangThai = 0 WHERE MaHD = '" + maHD + "' ";
            try
            {
                Command(query);
                return "Successful_Change";
            }
            catch (Exception ex)
            {
                return "Fail_Change " + ex.Message;
            }
        }

    }
}
