using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private string maSach;
        private string maLoaiSach;
        private string tenSach;
        private string xuatXu;
        private int giaNhap;
        private int giaChoThue;
        private string donViTinh;
        private string maNhaCungCap;
        private int soLuong;
        private int trangThai;
        private string hinhAnh;
        private float khuyenMai;

        public Sach()
        {
            this.maSach = "";
            this.maLoaiSach = "";
            this.tenSach = "";
            this.xuatXu = "";
            this.giaNhap = 0;
            this.giaChoThue = 0;
            this.donViTinh = "";
            this.maNhaCungCap = "";
            this.soLuong = 0;
            this.trangThai = 0;
            this.hinhAnh = "";
            this.khuyenMai = 0;
        }

        public Sach(string maSach, string maLoaiSach, string tenSach, string xuatXu, int giaNhap, int giaChoThue, string donViTinh, string maNhaCungCap, int soLuong, int trangThai, string hinhAnh, float khuyenMai)
        {
            this.maSach = maSach;
            this.maLoaiSach = maLoaiSach;
            this.tenSach = tenSach;
            this.xuatXu = xuatXu;
            this.giaNhap = giaNhap;
            this.giaChoThue = giaChoThue;
            this.donViTinh = donViTinh;
            this.maNhaCungCap = maNhaCungCap;
            this.soLuong = soLuong;
            this.trangThai = trangThai;
            this.hinhAnh = hinhAnh;
            this.khuyenMai = khuyenMai;
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string MaLoaiSach { get => maLoaiSach; set => maLoaiSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int GiaChoThue { get => giaChoThue; set => giaChoThue = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public float KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
    }
}
