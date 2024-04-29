using BLL;
using DTO;
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
    public partial class Form_DangNhap : Form
    {
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TaiKhoan.Text;
            string password = txt_MatKhau.Text;
            TaiKhoan taiKhoan = new TaiKhoan(username,password);

            string result = taiKhoanBLL.Check_DangNhap(taiKhoan);

            switch (result)
            {
                case "Required_TenTK":
                    MessageBox.Show("Vui lòng nhập tên tài khoản");
                    return;
                case "Required_MatKhau":
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    return;
                case "Fail_Login":
                    MessageBox.Show("Đăng nhập thất bại, tài khoản hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "Succsessful_Login":
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_GiaoDienQuanLyThuVien form_GiaoDienQuanLyThuVien = new Form_GiaoDienQuanLyThuVien();
                    form_GiaoDienQuanLyThuVien.ShowDialog();
                    return;
            }
            
        }

        private void chk_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienMatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

        private void link_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QuenMatKhau quenMatKhau = new Form_QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void link_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_DangKy form_DangKy = new Form_DangKy();
            form_DangKy.ShowDialog();
        }
    }
}
