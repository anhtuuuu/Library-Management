namespace GUI
{
    partial class Form_QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyHoaDon));
            this.lbl_TienGuiKhach = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TienKhachDua = new System.Windows.Forms.Label();
            this.lbl_NgayLap = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbo_MaDG = new System.Windows.Forms.ComboBox();
            this.lbl_MaHD = new System.Windows.Forms.Label();
            this.lbl_MaDG = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.imgHinhAnh = new System.Windows.Forms.ImageList(this.components);
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.lbl_HanTra = new System.Windows.Forms.Label();
            this.dtp_HanTra = new System.Windows.Forms.DateTimePicker();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienKhachDuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienGuiKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_ThuVienDataSet4 = new GUI.QL_ThuVienDataSet4();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.num_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.num_TienKhachDua = new System.Windows.Forms.NumericUpDown();
            this.num_TienGuiKhach = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.lbl_Tim = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.hoaDonTableAdapter = new GUI.QL_ThuVienDataSet4TableAdapters.HoaDonTableAdapter();
            this.clb_SachDaMuon = new System.Windows.Forms.CheckedListBox();
            this.lbl_SachDaMuon = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.lbl_NgayTra = new System.Windows.Forms.Label();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienKhachDua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienGuiKhach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TienGuiKhach
            // 
            this.lbl_TienGuiKhach.AutoSize = true;
            this.lbl_TienGuiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienGuiKhach.Location = new System.Drawing.Point(481, 125);
            this.lbl_TienGuiKhach.Name = "lbl_TienGuiKhach";
            this.lbl_TienGuiKhach.Size = new System.Drawing.Size(111, 16);
            this.lbl_TienGuiKhach.TabIndex = 213;
            this.lbl_TienGuiKhach.Text = "Tiền Gửi Khách";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(609, 165);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(143, 22);
            this.txt_ThanhTien.TabIndex = 212;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 211;
            this.label4.Text = "Thành Tiền";
            // 
            // lbl_TienKhachDua
            // 
            this.lbl_TienKhachDua.AutoSize = true;
            this.lbl_TienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TienKhachDua.Location = new System.Drawing.Point(477, 77);
            this.lbl_TienKhachDua.Name = "lbl_TienKhachDua";
            this.lbl_TienKhachDua.Size = new System.Drawing.Size(115, 16);
            this.lbl_TienKhachDua.TabIndex = 209;
            this.lbl_TienKhachDua.Text = "Tiền Khách Đưa";
            // 
            // lbl_NgayLap
            // 
            this.lbl_NgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NgayLap.AutoSize = true;
            this.lbl_NgayLap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayLap.Location = new System.Drawing.Point(44, 123);
            this.lbl_NgayLap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NgayLap.Name = "lbl_NgayLap";
            this.lbl_NgayLap.Size = new System.Drawing.Size(70, 17);
            this.lbl_NgayLap.TabIndex = 208;
            this.lbl_NgayLap.Text = "Ngày Lập";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Enabled = false;
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLap.Location = new System.Drawing.Point(128, 119);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(240, 22);
            this.dtp_NgayLap.TabIndex = 207;
            // 
            // cbo_MaDG
            // 
            this.cbo_MaDG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_MaDG.Enabled = false;
            this.cbo_MaDG.FormattingEnabled = true;
            this.cbo_MaDG.Location = new System.Drawing.Point(128, 73);
            this.cbo_MaDG.Name = "cbo_MaDG";
            this.cbo_MaDG.Size = new System.Drawing.Size(271, 24);
            this.cbo_MaDG.TabIndex = 206;
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHD.Location = new System.Drawing.Point(22, 22);
            this.lbl_MaHD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(92, 17);
            this.lbl_MaHD.TabIndex = 205;
            this.lbl_MaHD.Text = "Mã Hóa Đơn";
            // 
            // lbl_MaDG
            // 
            this.lbl_MaDG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaDG.AutoSize = true;
            this.lbl_MaDG.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDG.Location = new System.Drawing.Point(28, 73);
            this.lbl_MaDG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_MaDG.Name = "lbl_MaDG";
            this.lbl_MaDG.Size = new System.Drawing.Size(86, 17);
            this.lbl_MaDG.TabIndex = 203;
            this.lbl_MaDG.Text = "Mã Độc Giả";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label13.Location = new System.Drawing.Point(10, 270);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 200;
            this.label13.Text = "Chi tiết";
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
            this.imgHinhAnh.Images.SetKeyName(10, "OIP (1).jpg");
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XemChiTiet.ImageIndex = 10;
            this.btn_XemChiTiet.ImageList = this.imgHinhAnh;
            this.btn_XemChiTiet.Location = new System.Drawing.Point(14, 233);
            this.btn_XemChiTiet.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_XemChiTiet.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_XemChiTiet.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(50, 34);
            this.btn_XemChiTiet.TabIndex = 193;
            this.btn_XemChiTiet.UseVisualStyleBackColor = true;
            this.btn_XemChiTiet.Click += new System.EventHandler(this.btn_XemChiTiet_Click);
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(128, 25);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.ReadOnly = true;
            this.txt_MaHD.Size = new System.Drawing.Size(143, 22);
            this.txt_MaHD.TabIndex = 219;
            // 
            // lbl_HanTra
            // 
            this.lbl_HanTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HanTra.AutoSize = true;
            this.lbl_HanTra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HanTra.Location = new System.Drawing.Point(53, 158);
            this.lbl_HanTra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_HanTra.Name = "lbl_HanTra";
            this.lbl_HanTra.Size = new System.Drawing.Size(61, 17);
            this.lbl_HanTra.TabIndex = 221;
            this.lbl_HanTra.Text = "Hạn Trả";
            // 
            // dtp_HanTra
            // 
            this.dtp_HanTra.Enabled = false;
            this.dtp_HanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_HanTra.Location = new System.Drawing.Point(128, 156);
            this.dtp_HanTra.Name = "dtp_HanTra";
            this.dtp_HanTra.Size = new System.Drawing.Size(240, 22);
            this.dtp_HanTra.TabIndex = 220;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoGenerateColumns = false;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maDGDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.hanTraDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.tienKhachDuaDataGridViewTextBoxColumn,
            this.tienGuiKhachDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dgv_HoaDon.DataSource = this.hoaDonBindingSource;
            this.dgv_HoaDon.Location = new System.Drawing.Point(-1, 399);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoaDon.Size = new System.Drawing.Size(936, 166);
            this.dgv_HoaDon.TabIndex = 223;
            this.dgv_HoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // maDGDataGridViewTextBoxColumn
            // 
            this.maDGDataGridViewTextBoxColumn.DataPropertyName = "MaDG";
            this.maDGDataGridViewTextBoxColumn.HeaderText = "MaDG";
            this.maDGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDGDataGridViewTextBoxColumn.Name = "maDGDataGridViewTextBoxColumn";
            this.maDGDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDGDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // hanTraDataGridViewTextBoxColumn
            // 
            this.hanTraDataGridViewTextBoxColumn.DataPropertyName = "HanTra";
            this.hanTraDataGridViewTextBoxColumn.HeaderText = "HanTra";
            this.hanTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hanTraDataGridViewTextBoxColumn.Name = "hanTraDataGridViewTextBoxColumn";
            this.hanTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.hanTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienKhachDuaDataGridViewTextBoxColumn
            // 
            this.tienKhachDuaDataGridViewTextBoxColumn.DataPropertyName = "TienKhachDua";
            this.tienKhachDuaDataGridViewTextBoxColumn.HeaderText = "TienKhachDua";
            this.tienKhachDuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienKhachDuaDataGridViewTextBoxColumn.Name = "tienKhachDuaDataGridViewTextBoxColumn";
            this.tienKhachDuaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tienKhachDuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienGuiKhachDataGridViewTextBoxColumn
            // 
            this.tienGuiKhachDataGridViewTextBoxColumn.DataPropertyName = "TienGuiKhach";
            this.tienGuiKhachDataGridViewTextBoxColumn.HeaderText = "TienGuiKhach";
            this.tienGuiKhachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienGuiKhachDataGridViewTextBoxColumn.Name = "tienGuiKhachDataGridViewTextBoxColumn";
            this.tienGuiKhachDataGridViewTextBoxColumn.ReadOnly = true;
            this.tienGuiKhachDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.trangThaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qL_ThuVienDataSet4;
            // 
            // qL_ThuVienDataSet4
            // 
            this.qL_ThuVienDataSet4.DataSetName = "QL_ThuVienDataSet4";
            this.qL_ThuVienDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(519, 26);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(72, 16);
            this.lbl_SoLuong.TabIndex = 224;
            this.lbl_SoLuong.Text = "Số Lượng";
            // 
            // num_SoLuong
            // 
            this.num_SoLuong.Location = new System.Drawing.Point(609, 26);
            this.num_SoLuong.Name = "num_SoLuong";
            this.num_SoLuong.ReadOnly = true;
            this.num_SoLuong.Size = new System.Drawing.Size(143, 22);
            this.num_SoLuong.TabIndex = 226;
            // 
            // num_TienKhachDua
            // 
            this.num_TienKhachDua.Location = new System.Drawing.Point(609, 75);
            this.num_TienKhachDua.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.num_TienKhachDua.Name = "num_TienKhachDua";
            this.num_TienKhachDua.ReadOnly = true;
            this.num_TienKhachDua.Size = new System.Drawing.Size(143, 22);
            this.num_TienKhachDua.TabIndex = 227;
            // 
            // num_TienGuiKhach
            // 
            this.num_TienGuiKhach.Location = new System.Drawing.Point(609, 125);
            this.num_TienGuiKhach.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.num_TienGuiKhach.Name = "num_TienGuiKhach";
            this.num_TienGuiKhach.ReadOnly = true;
            this.num_TienGuiKhach.Size = new System.Drawing.Size(143, 22);
            this.num_TienGuiKhach.TabIndex = 228;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_XemChiTiet);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(850, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 312);
            this.groupBox1.TabIndex = 229;
            this.groupBox1.TabStop = false;
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
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label10.Location = new System.Drawing.Point(15, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 130;
            this.label10.Text = "Sửa";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label11.Location = new System.Drawing.Point(7, 190);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 131;
            this.label11.Text = "Làm mới";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.ImageIndex = 5;
            this.btn_Sua.ImageList = this.imgHinhAnh;
            this.btn_Sua.Location = new System.Drawing.Point(11, 82);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Sua.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_Sua.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(50, 34);
            this.btn_Sua.TabIndex = 97;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LamMoi.ImageIndex = 1;
            this.btn_LamMoi.ImageList = this.imgHinhAnh;
            this.btn_LamMoi.Location = new System.Drawing.Point(11, 153);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_LamMoi.MaximumSize = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.MinimumSize = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(50, 34);
            this.btn_LamMoi.TabIndex = 98;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CapNhat.Location = new System.Drawing.Point(426, 336);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(115, 38);
            this.btn_CapNhat.TabIndex = 230;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            // 
            // lbl_Tim
            // 
            this.lbl_Tim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Tim.AutoSize = true;
            this.lbl_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tim.Location = new System.Drawing.Point(5, 372);
            this.lbl_Tim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Tim.Name = "lbl_Tim";
            this.lbl_Tim.Size = new System.Drawing.Size(41, 18);
            this.lbl_Tim.TabIndex = 232;
            this.lbl_Tim.Text = "Tìm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_TimKiem.Location = new System.Drawing.Point(56, 371);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_TimKiem.MaximumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.MinimumSize = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(156, 22);
            this.txt_TimKiem.TabIndex = 231;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // clb_SachDaMuon
            // 
            this.clb_SachDaMuon.Enabled = false;
            this.clb_SachDaMuon.FormattingEnabled = true;
            this.clb_SachDaMuon.Location = new System.Drawing.Point(609, 202);
            this.clb_SachDaMuon.Name = "clb_SachDaMuon";
            this.clb_SachDaMuon.Size = new System.Drawing.Size(230, 191);
            this.clb_SachDaMuon.TabIndex = 233;
            // 
            // lbl_SachDaMuon
            // 
            this.lbl_SachDaMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SachDaMuon.AutoSize = true;
            this.lbl_SachDaMuon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SachDaMuon.Location = new System.Drawing.Point(473, 204);
            this.lbl_SachDaMuon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_SachDaMuon.Name = "lbl_SachDaMuon";
            this.lbl_SachDaMuon.Size = new System.Drawing.Size(104, 17);
            this.lbl_SachDaMuon.TabIndex = 234;
            this.lbl_SachDaMuon.Text = "Sách Đã Mượn";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(128, 245);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.ReadOnly = true;
            this.txt_TrangThai.Size = new System.Drawing.Size(143, 22);
            this.txt_TrangThai.TabIndex = 236;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(31, 245);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(83, 16);
            this.lbl_TrangThai.TabIndex = 235;
            this.lbl_TrangThai.Text = "Trạng Thái";
            // 
            // lbl_NgayTra
            // 
            this.lbl_NgayTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NgayTra.AutoSize = true;
            this.lbl_NgayTra.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTra.Location = new System.Drawing.Point(53, 199);
            this.lbl_NgayTra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_NgayTra.Name = "lbl_NgayTra";
            this.lbl_NgayTra.Size = new System.Drawing.Size(67, 17);
            this.lbl_NgayTra.TabIndex = 238;
            this.lbl_NgayTra.Text = "Ngày Trả";
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Enabled = false;
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTra.Location = new System.Drawing.Point(128, 197);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(240, 22);
            this.dtp_NgayTra.TabIndex = 237;
            // 
            // Form_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(938, 568);
            this.Controls.Add(this.lbl_NgayTra);
            this.Controls.Add(this.dtp_NgayTra);
            this.Controls.Add(this.txt_TrangThai);
            this.Controls.Add(this.lbl_TrangThai);
            this.Controls.Add(this.lbl_SachDaMuon);
            this.Controls.Add(this.clb_SachDaMuon);
            this.Controls.Add(this.lbl_Tim);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.num_TienGuiKhach);
            this.Controls.Add(this.num_TienKhachDua);
            this.Controls.Add(this.num_SoLuong);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.lbl_HanTra);
            this.Controls.Add(this.dtp_HanTra);
            this.Controls.Add(this.txt_MaHD);
            this.Controls.Add(this.lbl_TienGuiKhach);
            this.Controls.Add(this.txt_ThanhTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_TienKhachDua);
            this.Controls.Add(this.lbl_NgayLap);
            this.Controls.Add(this.dtp_NgayLap);
            this.Controls.Add(this.cbo_MaDG);
            this.Controls.Add(this.lbl_MaHD);
            this.Controls.Add(this.lbl_MaDG);
            this.Name = "Form_QuanLyHoaDon";
            this.Text = "Form_QuanLyHoaDon";
            this.Load += new System.EventHandler(this.Form_QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThuVienDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienKhachDua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TienGuiKhach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TienGuiKhach;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TienKhachDua;
        private System.Windows.Forms.Label lbl_NgayLap;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.ComboBox cbo_MaDG;
        private System.Windows.Forms.Label lbl_MaHD;
        private System.Windows.Forms.Label lbl_MaDG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ImageList imgHinhAnh;
        private System.Windows.Forms.Button btn_XemChiTiet;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label lbl_HanTra;
        private System.Windows.Forms.DateTimePicker dtp_HanTra;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.NumericUpDown num_SoLuong;
        private System.Windows.Forms.NumericUpDown num_TienKhachDua;
        private System.Windows.Forms.NumericUpDown num_TienGuiKhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Label lbl_Tim;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private QL_ThuVienDataSet4 qL_ThuVienDataSet4;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QL_ThuVienDataSet4TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienKhachDuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienGuiKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox clb_SachDaMuon;
        private System.Windows.Forms.Label lbl_SachDaMuon;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.Label lbl_NgayTra;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
    }
}