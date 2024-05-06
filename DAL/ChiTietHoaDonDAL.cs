using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL:DatabaseAccess
    {
        public DataSet GetCTHD(HoaDon hoaDon)
        {
            string query = "SELECT * FROM ChiTietHoaDon WHERE MaHD = '" + hoaDon.MaHD + "'";
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
