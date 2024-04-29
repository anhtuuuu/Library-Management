using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia
    {
        private string maTG;
        private string hoTen;
        private DateTime ngaySinh;
        private int gioiTinh;

        public TacGia()
        {
            this.MaTG = "";
            this.HoTen = "";
            this.NgaySinh = DateTime.Now;
            this.GioiTinh = 0;
        }

        public TacGia(string maTG, string hoTen, DateTime ngaySinh, int gioiTinh)
        {
            this.MaTG = maTG;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
        }

        public string MaTG { get => maTG; set => maTG = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
