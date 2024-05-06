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

    }
}
