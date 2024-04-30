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
    public partial class Form_QuanLyDocGia : Form
    {
        public Form_QuanLyDocGia()
        {
            InitializeComponent();
        }

        private void Form_QuanLyDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThuVienDataSet6.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.qL_ThuVienDataSet6.DocGia);

        }
    }
}
