using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeNhapSach
    {
        private string maSach;
        private string maLoaiSach;
        private string maNCC;
        private int soLuong;
        private int giaNhap;
        private DateTime ngayNhap;
        private int thanhTien;

        public ThongKeNhapSach()
        {
            this.maSach = "";
            this.maLoaiSach = "";
            this.maNCC = "";
            this.soLuong = 0;
            this.giaNhap = 0;
            this.ngayNhap = DateTime.Now;
            this.thanhTien = 0;
        }

        public ThongKeNhapSach(string maSach, string maLoaiSach, string maNCC, int soLuong, int giaNhap, DateTime ngayNhap, int thanhTien)
        {
            this.maSach = maSach;
            this.maLoaiSach = maLoaiSach;
            this.maNCC = maNCC;
            this.soLuong = soLuong;
            this.giaNhap = giaNhap;
            this.ngayNhap = ngayNhap;
            this.thanhTien = thanhTien;
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string MaLoaiSach { get => maLoaiSach; set => maLoaiSach = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
