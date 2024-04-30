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
    public partial class Form_LoaiSach : Form
    {
        public Form_LoaiSach()
        {
            InitializeComponent();
        }

        private void Form_LoaiSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet2.LoaiSach' table. You can move, or remove it, as needed.
            this.loaiSachTableAdapter.Fill(this.qL_ThuVienDataSet2.LoaiSach);

        }

        
        private void dgv_LoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow data = dgv_LoaiSach.Rows[index];
            txt_MaLoaiSach.Text = data.Cells[0].Value.ToString();
            txt_TenLoaiSach.Text = data.Cells[1].Value.ToString();
        }

      

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Refresh()
        {
            txt_MaLoaiSach.Text = string.Empty;
            txt_TenLoaiSach.Text = string.Empty;
            txt_TimKiem.Text = string.Empty;
        }

        private void OpenText()
        {
            txt_TenLoaiSach.ReadOnly = false;
        }

        private void CloseText()
        {
            txt_TenLoaiSach.ReadOnly=true;
            btn_CapNhat.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Sua.Enabled = true;
            OpenText();
            btn_CapNhat.Enabled = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            OpenText();
            btn_CapNhat.Enabled = true;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_CapNhat.Enabled = false;
            CloseText();
            Refresh();
        }
    }
}
