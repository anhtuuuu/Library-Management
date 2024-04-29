using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private string maHD;
        private string maSach;
        private int soLuong;
        private int donGia;
        private int thanhTien;
        private double khuyenMai;

        public ChiTietHoaDon()
        {
            this.maHD = "";
            this.maSach = "";
            this.soLuong = 0;
            this.donGia = 0;
            this.thanhTien = 0;
            this.khuyenMai = 0;
        }

        public ChiTietHoaDon(string maHD, string maSach, int soLuong, int donGia, int thanhTien, double khuyenMai)
        {
            this.maHD = maHD;
            this.maSach = maSach;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
            this.khuyenMai = khuyenMai;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public double KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
    }
}
