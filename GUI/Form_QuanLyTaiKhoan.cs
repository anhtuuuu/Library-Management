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
    public partial class Form_QuanLyTaiKhoan : Form
    {
        public Form_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private void Form_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.qL_ThuVienDataSet.TaiKhoan);

            TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
            List<TaiKhoan> lstTaiKhoan = taiKhoanBLL.GetListTaiKhoan();
            dgv_TaiKhoan.DataSource = lstTaiKhoan;
        }

        private void dgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow data = dgv_TaiKhoan.Rows[index];
            txt_MaTK.Text = data.Cells[0].Value.ToString();
            txt_HoTen.Text = data.Cells[1].Value.ToString();
            txt_SDT.Text = data.Cells[2].Value.ToString();
            txt_Email.Text = data.Cells[3].Value.ToString();
            txt_TenTK.Text = data.Cells[4].Value.ToString();
            txt_MatKhau.Text = data.Cells[5].Value.ToString();
            string status = data.Cells[6].Value.ToString();
            chk_TrangThai.Checked = (status == "1" ? true : false);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {            
            txt_HoTen.ReadOnly = false; 
            txt_SDT.ReadOnly = false;
            txt_Email.ReadOnly = false;
            txt_TenTK.ReadOnly = false;
            txt_MatKhau.ReadOnly = false;
            chk_TrangThai.Enabled = true;
            btn_CapNhat.Enabled = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                MaTK = txt_MaTK.Text,
                HoTen = txt_HoTen.Text,
                Sdt = txt_SDT.Text,
                Email = txt_Email.Text,
                Username = txt_TenTK.Text,
                Password = txt_MatKhau.Text,
                TrangThai = (chk_TrangThai.Checked?1:0)
            };
            string result = taiKhoanBLL.SuaTaiKhoan(taiKhoan);
            switch(result) 
            {
                case "Required_Email":
                    MessageBox.Show("Vui lòng nhập đầy đủ Email");
                    return;
                case "Required_Password":
                    MessageBox.Show("Vui lòng nhập đầy đủ Password");
                    return;
                case "Required_Username":
                    MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản");
                    return;
                case "Successful_Change":
                    MessageBox.Show("Thay đổi thông tin thành công");
                    Form_QuanLyTaiKhoan_Load(sender, e);
                    return;
                default:
                    MessageBox.Show(result);
                    return;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "";
            Form_QuanLyTaiKhoan_Load(sender, e);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txt_TimKiem.Text;
            dgv_TaiKhoan.DataSource = taiKhoanBLL.Search(keyWord).Tables[0];
        }
    }
}
