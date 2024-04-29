using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach_TacGia
    {
        private string maTG;
        private string maSach;

        public Sach_TacGia()
        {
            this.MaTG = "";
            this.MaSach = "";
        }

        public Sach_TacGia(string maTG, string maSach)
        {
            this.MaTG = maTG;
            this.MaSach = maSach;
        }

        public string MaTG { get => maTG; set => maTG = value; }
        public string MaSach { get => maSach; set => maSach = value; }
    }
}
