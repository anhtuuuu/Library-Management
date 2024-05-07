namespace GUI
{
    partial class Form_MuonTraSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MuonTraSach));
            this.lbl_TienGuiKhach = new System.Windows.Forms.Label();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.lbl_TienKhachDua = new System.Windows.Forms.Label();
            this.rad_DaTra = new System.Windows.Forms.RadioButton();
            this.rad_ChuaTra = new System.Windows.Forms.RadioButton();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_HanTra = new System.Windows.Forms.Label();
            this.dtp_HanTra = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayMuon = new System.Windows.Forms.Label();
            this.dtp_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lbl_MaDG = new System.Windows.Forms.Label();
            this.cbo_MaDG = new System.Windows.Forms.ComboBox();
            this.btn_Them1Thang = new System.Windows.Forms.Button();
            this.lbl_SachMuon = new System.Windows.Forms.Label();
            this.clb_SachMuon = new System.Windows.Forms.CheckedListBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_TenDG = new System.Windows.Forms.TextBox();
            this.lbl_TenDG = new System.Windows.Forms.Label();
            this.grp_TrangThai = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Muon = new System.Windows.Forms.Button();
            this.btn_Tra = new System.Windows.Forms.Button();
            this.num_TienKhachDua = new System.Windows.Forms.NumericUpDown();
            this.lbl_MaDH = new System.Windows.Forms.Label();
            this.cbo_MaHD = new System.Windows.Forms.ComboBox();
            this.txt_TienGuiKhach = new System.Windows.Forms.TextBox();
            this.grp_TrangThai.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienKhachDua)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TienGuiKhach
            // 
            this.lbl_TienGuiKhach.AutoSize = true;
            this.lbl_TienGuiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienGuiKhach.Location = new System.Drawing.Point(12, 186);
            this.lbl_TienGuiKhach.Name = "lbl_TienGuiKhach";
            this.lbl_TienGuiKhach.Size = new System.Drawing.Size(111, 16);
            this.lbl_TienGuiKhach.TabIndex = 222;
            this.lbl_TienGuiKhach.Text = "Tiền Gửi Khách";
            // 
            // imgHinhAnh
            // 
            this.imgHinhAnh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHinhAnh.ImageStream")));
            this.imgHinhAnh.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHinhAnh.Images.SetKeyName(0, "addimage.png");
            this.imgHinhAnh.Images.SetKeyName(1, "refresh.png");
            this.imgHinhAnh.Images.SetKeyName(2, "delete-181.png");
            this.imgHinhAnh.Images.SetKeyName(3, "Exit.png");
            this.imgHinhAnh.Images.SetKeyName(4, "back.jpg");
            this.imgHinhAnh.Images.SetKeyName(5, "sua1.png");
            this.imgHinhAnh.Images.SetKeyName(6, "search.png");
            this.imgHinhAnh.Images.SetKeyName(7, "save.png");
            this.imgHinhAnh.Images.SetKeyName(8, "DocGia.png");
            this.imgHinhAnh.Images.SetKeyName(9, "OIP.jpg");
            // 
            // lbl_TienKhachDua
            // 
            this.lbl_TienKhachDua.AutoSize = true;
            this.lbl_TienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienKhachDua.Location = new System.Drawing.Point(7, 144);
            this.lbl_TienKhachDua.Name = "lbl_TienKhachDua";
            this.lbl_TienKhachDua.Size = new System.Drawing.Size(115, 16);
            this.lbl_TienKhachDua.TabIndex = 220;
            this.lbl_TienKhachDua.Text = "Tiền Khách Đưa";
            // 
            // rad_DaTra
            // 
            this.rad_DaTra.AutoSize = true;
            this.rad_DaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_DaTra.ForeColor = System.Drawing.Color.Red;
            this.rad_DaTra.Location = new System.Drawing.Point(19, 47);
            this.rad_DaTra.Name = "rad_DaTra";
            this.rad_DaTra.Size = new System.Drawing.Size(114, 20);
            this.rad_DaTra.TabIndex = 219;
            this.rad_DaTra.Text = "Đã Trả Sách";
            this.rad_DaTra.UseVisualStyleBackColor = true;
            // 
            // rad_ChuaTra
            // 
            this.rad_ChuaTra.AutoSize = true;
            this.rad_ChuaTra.Checked = true;
            this.rad_ChuaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ChuaTra.ForeColor = System.Drawing.Color.Red;
            this.rad_ChuaTra.Location = new System.Drawing.Point(19, 21);
            this.rad_ChuaTra.Name = "rad_ChuaTra";
            this.rad_ChuaTra.Size = new System.Drawing.Size(130, 20);
            this.rad_ChuaTra.TabIndex = 218;
            this.rad_ChuaTra.TabStop = true;
            this.rad_ChuaTra.Text = "Chưa Trả Sách";
            this.rad_ChuaTra.UseVisualStyleBackColor = true;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(138, 230);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(229, 22);
            this.txt_ThanhTien.TabIndex = 201;
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(36, 233);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(85, 16);
            this.lbl_ThanhTien.TabIndex = 200;
            this.lbl_ThanhTien.Text = "Thành Tiền";
            // 
            // lbl_HanTra
            // 
            this.lbl_HanTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HanTra.AutoSize = true;
            this.lbl_HanTra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HanTra.Location = new System.Drawing.Point(46, 104);
            this.lbl_HanTra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_HanTra.Name = "lbl_HanTra";
            this.lbl_HanTra.Size = new System.Drawing.Size(61, 17);
            this.lbl_HanTra.TabIndex = 197;
            this.lbl_HanTra.Text = "Hạn Trả";
            // 
            // dtp_HanTra
            // 
            this.dtp_HanTra.Enabled = false;
            this.dtp_HanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_HanTra.Location = new System.Drawing.Point(138, 104);
            this.dtp_HanTra.Name = "dtp_HanTra";
            this.dtp_HanTra.Size = new System.Drawing.Size(139, 22);
            this.dtp_HanTra.TabIndex = 196;
            // 
            // lbl_NgayMuon
            // 
            this.lbl_NgayMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NgayMuon.AutoSize = true;
            this.lbl_NgayMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayMuon.Location = new System.Drawing.Point(26, 64);
            this.lbl_NgayMuon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NgayMuon.Name = "lbl_NgayMuon";
            this.lbl_NgayMuon.Size = new System.Drawing.Size(85, 17);
            this.lbl_NgayMuon.TabIndex = 195;
            this.lbl_NgayMuon.Text = "Ngày Mượn";
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(138, 64);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(139, 22);
            this.dtp_NgayMuon.TabIndex = 194;
            // 
            // lbl_MaDG
            // 
            this.lbl_MaDG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaDG.AutoSize = true;
            this.lbl_MaDG.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDG.Location = new System.Drawing.Point(33, 18);
            this.lbl_MaDG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaDG.Name = "lbl_MaDG";
            this.lbl_MaDG.Size = new System.Drawing.Size(86, 17);
            this.lbl_MaDG.TabIndex = 190;
            this.lbl_MaDG.Text = "Mã Độc Giả";
            // 
            // cbo_MaDG
            // 
            this.cbo_MaDG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_MaDG.FormattingEnabled = true;
            this.cbo_MaDG.Location = new System.Drawing.Point(138, 16);
            this.cbo_MaDG.Name = "cbo_MaDG";
            this.cbo_MaDG.Size = new System.Drawing.Size(229, 24);
            this.cbo_MaDG.TabIndex = 189;
            this.cbo_MaDG.SelectedIndexChanged += new System.EventHandler(this.cbo_MaDG_SelectedIndexChanged);
            // 
            // btn_Them1Thang
            // 
            this.btn_Them1Thang.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Them1Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them1Thang.Location = new System.Drawing.Point(285, 64);
            this.btn_Them1Thang.Name = "btn_Them1Thang";
            this.btn_Them1Thang.Size = new System.Drawing.Size(88, 57);
            this.btn_Them1Thang.TabIndex = 225;
            this.btn_Them1Thang.Text = "+ 1 tháng";
            this.btn_Them1Thang.UseVisualStyleBackColor = false;
            this.btn_Them1Thang.Click += new System.EventHandler(this.btn_Them1Thang_Click);
            // 
            // lbl_SachMuon
            // 
            this.lbl_SachMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SachMuon.AutoSize = true;
            this.lbl_SachMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SachMuon.Location = new System.Drawing.Point(25, 273);
            this.lbl_SachMuon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_SachMuon.Name = "lbl_SachMuon";
            this.lbl_SachMuon.Size = new System.Drawing.Size(82, 17);
            this.lbl_SachMuon.TabIndex = 236;
            this.lbl_SachMuon.Text = "Sách Mượn";
            // 
            // clb_SachMuon
            // 
            this.clb_SachMuon.FormattingEnabled = true;
            this.clb_SachMuon.Location = new System.Drawing.Point(138, 273);
            this.clb_SachMuon.Name = "clb_SachMuon";
            this.clb_SachMuon.Size = new System.Drawing.Size(230, 191);
            this.clb_SachMuon.TabIndex = 235;
            this.clb_SachMuon.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_SachMuon_ItemCheck);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(522, 59);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.ReadOnly = true;
            this.txt_SDT.Size = new System.Drawing.Size(211, 22);
            this.txt_SDT.TabIndex = 240;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(455, 62);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(37, 16);
            this.lbl_SDT.TabIndex = 239;
            this.lbl_SDT.Text = "SĐT";
            // 
            // txt_TenDG
            // 
            this.txt_TenDG.Location = new System.Drawing.Point(522, 22);
            this.txt_TenDG.Name = "txt_TenDG";
            this.txt_TenDG.ReadOnly = true;
            this.txt_TenDG.Size = new System.Drawing.Size(211, 22);
            this.txt_TenDG.TabIndex = 238;
            // 
            // lbl_TenDG
            // 
            this.lbl_TenDG.AutoSize = true;
            this.lbl_TenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDG.Location = new System.Drawing.Point(404, 25);
            this.lbl_TenDG.Name = "lbl_TenDG";
            this.lbl_TenDG.Size = new System.Drawing.Size(93, 16);
            this.lbl_TenDG.TabIndex = 237;
            this.lbl_TenDG.Text = "Tên Độc Giả";
            // 
            // grp_TrangThai
            // 
            this.grp_TrangThai.Controls.Add(this.rad_ChuaTra);
            this.grp_TrangThai.Controls.Add(this.rad_DaTra);
            this.grp_TrangThai.Enabled = false;
            this.grp_TrangThai.Location = new System.Drawing.Point(503, 333);
            this.grp_TrangThai.Name = "grp_TrangThai";
            this.grp_TrangThai.Size = new System.Drawing.Size(200, 100);
            this.grp_TrangThai.TabIndex = 241;
            this.grp_TrangThai.TabStop = false;
            this.grp_TrangThai.Text = "Trạng Thái";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btn_InHoaDon);
            this.groupBox2.Controls.Add(this.btn_Thoat);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_LamMoi);
            this.groupBox2.Location = new System.Drawing.Point(831, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(76, 239);
            this.groupBox2.TabIndex = 242;
            this.groupBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label14.Location = new System.Drawing.Point(1, 202);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 19);
            this.label14.TabIndex = 218;
            this.label14.Text = "In hóa đơn";
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InHoaDon.ImageIndex = 9;
            this.btn_InHoaDon.ImageList = this.imgHinhAnh;
            this.btn_InHoaDon.Location = new System.Drawing.Point(11, 165);
            this.btn_InHoaDon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_InHoaDon.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_InHoaDon.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(50, 34);
            this.btn_InHoaDon.TabIndex = 217;
            this.btn_InHoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.ImageIndex = 3;
            this.btn_Thoat.ImageList = this.imgHinhAnh;
            this.btn_Thoat.Location = new System.Drawing.Point(11, 14);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Thoat.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_Thoat.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(50, 34);
            this.btn_Thoat.TabIndex = 99;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label15.Location = new System.Drawing.Point(10, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 19);
            this.label15.TabIndex = 133;
            this.label15.Text = "Thoát";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label11.Location = new System.Drawing.Point(7, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 131;
            this.label11.Text = "Làm mới";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LamMoi.ImageIndex = 1;
            this.btn_LamMoi.ImageList = this.imgHinhAnh;
            this.btn_LamMoi.Location = new System.Drawing.Point(11, 90);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_LamMoi.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.TabIndex = 98;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Muon
            // 
            this.btn_Muon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Muon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Muon.Location = new System.Drawing.Point(778, 285);
            this.btn_Muon.Name = "btn_Muon";
            this.btn_Muon.Size = new System.Drawing.Size(122, 61);
            this.btn_Muon.TabIndex = 243;
            this.btn_Muon.Text = "Mượn";
            this.btn_Muon.UseVisualStyleBackColor = false;
            this.btn_Muon.Click += new System.EventHandler(this.btn_Muon_Click);
            // 
            // btn_Tra
            // 
            this.btn_Tra.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tra.Location = new System.Drawing.Point(778, 352);
            this.btn_Tra.Name = "btn_Tra";
            this.btn_Tra.Size = new System.Drawing.Size(122, 61);
            this.btn_Tra.TabIndex = 244;
            this.btn_Tra.Text = "Trả";
            this.btn_Tra.UseVisualStyleBackColor = false;
            this.btn_Tra.Click += new System.EventHandler(this.btn_Tra_Click);
            // 
            // num_TienKhachDua
            // 
            this.num_TienKhachDua.Location = new System.Drawing.Point(139, 144);
            this.num_TienKhachDua.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.num_TienKhachDua.Name = "num_TienKhachDua";
            this.num_TienKhachDua.Size = new System.Drawing.Size(228, 22);
            this.num_TienKhachDua.TabIndex = 245;
            this.num_TienKhachDua.ValueChanged += new System.EventHandler(this.num_TienKhachDua_ValueChanged);
            // 
            // lbl_MaDH
            // 
            this.lbl_MaDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaDH.AutoSize = true;
            this.lbl_MaDH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDH.Location = new System.Drawing.Point(398, 287);
            this.lbl_MaDH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaDH.Name = "lbl_MaDH";
            this.lbl_MaDH.Size = new System.Drawing.Size(92, 17);
            this.lbl_MaDH.TabIndex = 248;
            this.lbl_MaDH.Text = "Mã Hóa Đơn";
            // 
            // cbo_MaHD
            // 
            this.cbo_MaHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_MaHD.FormattingEnabled = true;
            this.cbo_MaHD.Location = new System.Drawing.Point(503, 285);
            this.cbo_MaHD.Name = "cbo_MaHD";
            this.cbo_MaHD.Size = new System.Drawing.Size(229, 24);
            this.cbo_MaHD.TabIndex = 247;
            this.cbo_MaHD.SelectedIndexChanged += new System.EventHandler(this.cbo_MaHD_SelectedIndexChanged);
            // 
            // txt_TienGuiKhach
            // 
            this.txt_TienGuiKhach.Location = new System.Drawing.Point(138, 186);
            this.txt_TienGuiKhach.Name = "txt_TienGuiKhach";
            this.txt_TienGuiKhach.ReadOnly = true;
            this.txt_TienGuiKhach.Size = new System.Drawing.Size(229, 22);
            this.txt_TienGuiKhach.TabIndex = 249;
            // 
            // Form_MuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(907, 497);
            this.Controls.Add(this.txt_TienGuiKhach);
            this.Controls.Add(this.lbl_MaDH);
            this.Controls.Add(this.cbo_MaHD);
            this.Controls.Add(this.num_TienKhachDua);
            this.Controls.Add(this.btn_Tra);
            this.Controls.Add(this.btn_Muon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_TrangThai);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.lbl_SDT);
            this.Controls.Add(this.txt_TenDG);
            this.Controls.Add(this.lbl_TenDG);
            this.Controls.Add(this.lbl_SachMuon);
            this.Controls.Add(this.clb_SachMuon);
            this.Controls.Add(this.btn_Them1Thang);
            this.Controls.Add(this.lbl_TienGuiKhach);
            this.Controls.Add(this.lbl_TienKhachDua);
            this.Controls.Add(this.txt_ThanhTien);
            this.Controls.Add(this.lbl_ThanhTien);
            this.Controls.Add(this.lbl_HanTra);
            this.Controls.Add(this.dtp_HanTra);
            this.Controls.Add(this.lbl_NgayMuon);
            this.Controls.Add(this.dtp_NgayMuon);
            this.Controls.Add(this.lbl_MaDG);
            this.Controls.Add(this.cbo_MaDG);
            this.Name = "Form_MuonTraSach";
            this.Text = "Form_MuonTraSach";
            this.Load += new System.EventHandler(this.Form_MuonTraSach_Load);
            this.grp_TrangThai.ResumeLayout(false);
            this.grp_TrangThai.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienKhachDua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TienGuiKhach;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.Label lbl_TienKhachDua;
        private System.Windows.Forms.RadioButton rad_DaTra;
        private System.Windows.Forms.RadioButton rad_ChuaTra;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label lbl_HanTra;
        private System.Windows.Forms.DateTimePicker dtp_HanTra;
        private System.Windows.Forms.Label lbl_NgayMuon;
        private System.Windows.Forms.DateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.Label lbl_MaDG;
        private System.Windows.Forms.ComboBox cbo_MaDG;
        private System.Windows.Forms.Button btn_Them1Thang;
        private System.Windows.Forms.Label lbl_SachMuon;
        private System.Windows.Forms.CheckedListBox clb_SachMuon;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_TenDG;
        private System.Windows.Forms.Label lbl_TenDG;
        private System.Windows.Forms.GroupBox grp_TrangThai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Muon;
        private System.Windows.Forms.Button btn_Tra;
        private System.Windows.Forms.NumericUpDown num_TienKhachDua;
        private System.Windows.Forms.Label lbl_MaDH;
        private System.Windows.Forms.ComboBox cbo_MaHD;
        private System.Windows.Forms.TextBox txt_TienGuiKhach;
    }
}