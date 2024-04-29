using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string maHD;
        private string maDG;
        private DateTime ngayLap;
        private DateTime hanTra;
        private int tienKhachDua;
        private int tienGuiKhach;
        private int thanhTien;
        public HoaDon() 
        {
            this.maHD = "";
            this.maDG = "";
            this.ngayLap = DateTime.Now;
            this.hanTra = DateTime.Now;
            this.tienKhachDua = 0;
            this.tienGuiKhach = 0;
            this.thanhTien = 0;
        }

        public HoaDon(string maHD, string maDG, DateTime ngayLap, DateTime hanTra, int tienKhachDua, int tienGuiKhach, int thanhTien)
        {
            this.maHD = maHD;
            this.maDG = maDG;
            this.ngayLap = ngayLap;
            this.hanTra = hanTra;
            this.tienKhachDua = tienKhachDua;
            this.tienGuiKhach = tienGuiKhach;
            this.thanhTien = thanhTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaDG { get => maDG; set => maDG = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public DateTime HanTra { get => hanTra; set => hanTra = value; }
        public int TienKhachDua { get => tienKhachDua; set => tienKhachDua = value; }
        public int TienGuiKhach { get => tienGuiKhach; set => tienGuiKhach = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
