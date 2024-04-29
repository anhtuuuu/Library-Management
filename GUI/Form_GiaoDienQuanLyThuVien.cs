using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_GiaoDienQuanLyThuVien : Form
    {
        public Form_GiaoDienQuanLyThuVien()
        {
            InitializeComponent();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            Form_QuanLyTaiKhoan quanLyTaiKhoan = new Form_QuanLyTaiKhoan();
            quanLyTaiKhoan.ShowDialog();
        }

        private void btn_KhoSach_Click(object sender, EventArgs e)
        {
            Form_QuanLySach form_QuanLySach = new Form_QuanLySach();
            form_QuanLySach.ShowDialog();
        }

        private void btn_LoaiSach_Click(object sender, EventArgs e)
        {
            Form_LoaiSach form_LoaiSach = new Form_LoaiSach();
            form_LoaiSach.ShowDialog();
        }

        private void btn_MuonTraSach_Click(object sender, EventArgs e)
        {
            Form_MuonTraSach form_MuonTraSach = new Form_MuonTraSach();
            form_MuonTraSach.ShowDialog(); 
        }

        private void btn_NhapSach_Click(object sender, EventArgs e)
        {
            Form_NhapSach form_NhapSach = new Form_NhapSach();
            form_NhapSach.ShowDialog();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            Form_QuanLyHoaDon form_QuanLyHoaDon = new Form_QuanLyHoaDon();
            form_QuanLyHoaDon.ShowDialog();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ThongKeNhapSach_Click(object sender, EventArgs e)
        {
            Form_ThongKeNhapSach form_ThongKeNhapSach = new Form_ThongKeNhapSach();
            form_ThongKeNhapSach.ShowDialog();
        }

        private void btn_ThongKeMuonSach_Click(object sender, EventArgs e)
        {
            Form_ThongKeMuonSach form_ThongKeMuonSach = new Form_ThongKeMuonSach();
            form_ThongKeMuonSach.ShowDialog();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
