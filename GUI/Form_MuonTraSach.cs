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
    public partial class Form_MuonTraSach : Form
    {
        private MuonTraSachBLL MuonTra = new MuonTraSachBLL();
        private Decimal tongTien = 0;
        private int count = 0;
        public Form_MuonTraSach()
        {
            InitializeComponent();
        }

        private void Form_MuonTraSach_Load(object sender, EventArgs e)
        {
            dtp_NgayMuon.Value = DateTime.Now;
            dtp_HanTra.Value = DateTime.Now.AddDays(30);
            DataSet docGia = MuonTra.GetDG();
            for (int i = 0; i < docGia.Tables[0].Rows.Count; i++)
            {
                cbo_MaDG.Items.Add(docGia.Tables[0].Rows[i][0].ToString());
            }

            DataSet sach = MuonTra.GetSach();
            for (int i = 0; i < sach.Tables[0].Rows.Count; i++)
            {
                clb_SachMuon.Items.Add(sach.Tables[0].Rows[i][2].ToString());                
            }

            DataSet hoaDon = MuonTra.GetHD();
            for (int i = 0; i < hoaDon.Tables[0].Rows.Count; i++)
            {
                cbo_MaHD.Items.Add(hoaDon.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            cbo_MaDG.Text=string.Empty;
            cbo_MaDG.Items.Clear();
            dtp_NgayMuon.Text = string.Empty;
            dtp_HanTra.Text = string.Empty;
            txt_TienGuiKhach.Text = string.Empty;
            num_TienKhachDua.ResetText();
            txt_ThanhTien.Text = string.Empty;
            clb_SachMuon.Items.Clear();
            txt_TenDG.Text = string.Empty;
            txt_SDT.Text = string.Empty;
            cbo_MaHD.Text = string.Empty;
            cbo_MaHD.Items.Clear();
            Form_MuonTraSach_Load(sender, e);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbo_MaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbo_MaDG.SelectedItem.ToString();
            DataSet muonTra = MuonTra.GetDG(id);
            txt_TenDG.Text = muonTra.Tables[0].Rows[0][1].ToString();
            txt_SDT.Text = muonTra.Tables[0].Rows[0][4].ToString();

        }

        private void cbo_MaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbo_MaHD.SelectedItem.ToString();
            DataSet muonTra = MuonTra.GetHD(id);
            if(muonTra.Tables[0].Rows[0][9].ToString() == "1")
                rad_ChuaTra.Checked = true;
            else
                rad_DaTra.Checked = true;
        }

        private void btn_Them1Thang_Click(object sender, EventArgs e)
        {
            dtp_HanTra.Value = dtp_HanTra.Value.AddDays(30);
            tongTien += tongTien;
            txt_ThanhTien.Text = tongTien.ToString();
        }

        private void clb_SachMuon_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string name = clb_SachMuon.Text;
            DataSet sach = MuonTra.GetSach(name);

            if (e.CurrentValue.ToString() == "Unchecked")
            {
                count += 1;
                tongTien +=  Decimal.Parse(sach.Tables[0].Rows[0][6].ToString());
                txt_ThanhTien.Text = tongTien.ToString();
            }
            else
            {
                count -= 1;
                tongTien -= Decimal.Parse(sach.Tables[0].Rows[0][6].ToString());
                txt_ThanhTien.Text = tongTien.ToString();
            }

        }

        private void num_TienKhachDua_ValueChanged(object sender, EventArgs e)
        {
            if (tongTien == 0) return;
            Decimal tienGuiKhach = Decimal.Parse(num_TienKhachDua.Text) - tongTien;
            if (tienGuiKhach < 0)
            {
                MessageBox.Show("Cẩn thận có sai sót.");
                return;
            }
            txt_TienGuiKhach.Text = tienGuiKhach.ToString();
        }
    }
}
