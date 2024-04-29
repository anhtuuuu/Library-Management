using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeMuonSach
    {
        private string maDG;
        private string maHD;
        private string maSach;
        private DateTime ngayMuon;
        private DateTime ngayTra;
        private int soLuong;
        private int thanhTien;
        private int trangThai;

        public ThongKeMuonSach()
        {
            this.maDG = "";
            this.maHD = "";
            this.maSach = "";
            this.ngayMuon = DateTime.Now;
            this.ngayTra = DateTime.Now;
            this.soLuong = 0;
            this.thanhTien = 0;
            this.trangThai = 0;
        }

        public ThongKeMuonSach(string maDG, string maHD, string maSach, DateTime ngayMuon, DateTime ngayTra, int soLuong, int thanhTien, int trangThai)
        {
            this.MaDG = maDG;
            this.MaHD = maHD;
            this.MaSach = maSach;
            this.NgayMuon = ngayMuon;
            this.NgayTra = ngayTra;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
            this.TrangThai = trangThai;
        }

        public string MaDG { get => maDG; set => maDG = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
