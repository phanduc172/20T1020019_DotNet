namespace _20T1020019
{
    partial class FormSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMaSanPham = new TextBox();
            txtTenSanPham = new TextBox();
            dtpNgaySanXuat = new DateTimePicker();
            dtpNgayHetHan = new DateTimePicker();
            txtGiaBan = new TextBox();
            txtSoLuongNhap = new TextBox();
            picHinhDaiDien = new PictureBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            sanPhamBindingSource = new BindingSource(components);
            grdviewDanhSach = new DataGridView();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaySanXuatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayHetHanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaBanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soLuongNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hinhDaiDienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)picHinhDaiDien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdviewDanhSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(538, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 0;
            label1.Text = "Thông tin Sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 65);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã sản phẩm:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(686, 62);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 1;
            label3.Text = "Tên sản phẩm:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 118);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 1;
            label4.Text = "Ngày sản xuất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(67, 174);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 1;
            label5.Text = "Ngày hết hạn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 228);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 1;
            label6.Text = "Giá bán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(67, 282);
            label7.Name = "label7";
            label7.Size = new Size(145, 28);
            label7.TabIndex = 1;
            label7.Text = "Số lượng nhập:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(686, 115);
            label8.Name = "label8";
            label8.Size = new Size(132, 28);
            label8.TabIndex = 1;
            label8.Text = "Hình đại diện:";
            label8.Click += label8_Click;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(212, 62);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(401, 31);
            txtMaSanPham.TabIndex = 0;
            txtMaSanPham.TextChanged += txtMaSanPham_TextChanged;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(826, 62);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(367, 31);
            txtTenSanPham.TabIndex = 1;
            txtTenSanPham.TextChanged += txtTenSanPham_TextChanged;
            // 
            // dtpNgaySanXuat
            // 
            dtpNgaySanXuat.CustomFormat = "dd/MM/yyyy";
            dtpNgaySanXuat.Format = DateTimePickerFormat.Custom;
            dtpNgaySanXuat.Location = new Point(212, 115);
            dtpNgaySanXuat.Name = "dtpNgaySanXuat";
            dtpNgaySanXuat.Size = new Size(401, 31);
            dtpNgaySanXuat.TabIndex = 2;
            dtpNgaySanXuat.ValueChanged += dtpNgaySanXuat_ValueChanged;
            // 
            // dtpNgayHetHan
            // 
            dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            dtpNgayHetHan.Format = DateTimePickerFormat.Custom;
            dtpNgayHetHan.Location = new Point(212, 171);
            dtpNgayHetHan.Name = "dtpNgayHetHan";
            dtpNgayHetHan.Size = new Size(401, 31);
            dtpNgayHetHan.TabIndex = 3;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(212, 225);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(401, 31);
            txtGiaBan.TabIndex = 5;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Location = new Point(212, 279);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(401, 31);
            txtSoLuongNhap.TabIndex = 4;
            txtSoLuongNhap.TextChanged += txtSoLuongNhap_TextChanged;
            // 
            // picHinhDaiDien
            // 
            picHinhDaiDien.BorderStyle = BorderStyle.FixedSingle;
            picHinhDaiDien.Location = new Point(826, 115);
            picHinhDaiDien.Name = "picHinhDaiDien";
            picHinhDaiDien.Size = new Size(367, 195);
            picHinhDaiDien.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhDaiDien.TabIndex = 4;
            picHinhDaiDien.TabStop = false;
            picHinhDaiDien.Click += picHinhDaiDien_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(67, 340);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(240, 340);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(112, 34);
            btnCapNhat.TabIndex = 7;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // sanPhamBindingSource
            // 
            sanPhamBindingSource.DataSource = typeof(Model.SanPham);
            // 
            // grdviewDanhSach
            // 
            grdviewDanhSach.AutoGenerateColumns = false;
            grdviewDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdviewDanhSach.Columns.AddRange(new DataGridViewColumn[] { maSanPhamDataGridViewTextBoxColumn, tenSanPhamDataGridViewTextBoxColumn, ngaySanXuatDataGridViewTextBoxColumn, ngayHetHanDataGridViewTextBoxColumn, giaBanDataGridViewTextBoxColumn, soLuongNhapDataGridViewTextBoxColumn, hinhDaiDienDataGridViewTextBoxColumn });
            grdviewDanhSach.DataSource = sanPhamBindingSource;
            grdviewDanhSach.Location = new Point(43, 418);
            grdviewDanhSach.Name = "grdviewDanhSach";
            grdviewDanhSach.RowHeadersWidth = 62;
            grdviewDanhSach.RowTemplate.Height = 33;
            grdviewDanhSach.Size = new Size(1150, 252);
            grdviewDanhSach.TabIndex = 11;
            grdviewDanhSach.TabStop = false;
            grdviewDanhSach.CellContentClick += grdviewDanhSach_CellContentClick;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "maSanPham";
            maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            maSanPhamDataGridViewTextBoxColumn.Width = 160;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "tenSanPham";
            tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            tenSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            tenSanPhamDataGridViewTextBoxColumn.Width = 160;
            // 
            // ngaySanXuatDataGridViewTextBoxColumn
            // 
            ngaySanXuatDataGridViewTextBoxColumn.DataPropertyName = "ngaySanXuat";
            ngaySanXuatDataGridViewTextBoxColumn.HeaderText = "Ngày sản xuất";
            ngaySanXuatDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngaySanXuatDataGridViewTextBoxColumn.Name = "ngaySanXuatDataGridViewTextBoxColumn";
            ngaySanXuatDataGridViewTextBoxColumn.Width = 160;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "ngayHetHan";
            ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày hết hạn";
            ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            ngayHetHanDataGridViewTextBoxColumn.Width = 160;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            giaBanDataGridViewTextBoxColumn.DataPropertyName = "giaBan";
            giaBanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            giaBanDataGridViewTextBoxColumn.MinimumWidth = 8;
            giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            giaBanDataGridViewTextBoxColumn.Width = 120;
            // 
            // soLuongNhapDataGridViewTextBoxColumn
            // 
            soLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "soLuongNhap";
            soLuongNhapDataGridViewTextBoxColumn.HeaderText = "Số lượng nhập";
            soLuongNhapDataGridViewTextBoxColumn.MinimumWidth = 8;
            soLuongNhapDataGridViewTextBoxColumn.Name = "soLuongNhapDataGridViewTextBoxColumn";
            soLuongNhapDataGridViewTextBoxColumn.Width = 170;
            // 
            // hinhDaiDienDataGridViewTextBoxColumn
            // 
            hinhDaiDienDataGridViewTextBoxColumn.DataPropertyName = "hinhDaiDien";
            hinhDaiDienDataGridViewTextBoxColumn.HeaderText = "Hình đại diện";
            hinhDaiDienDataGridViewTextBoxColumn.MinimumWidth = 8;
            hinhDaiDienDataGridViewTextBoxColumn.Name = "hinhDaiDienDataGridViewTextBoxColumn";
            hinhDaiDienDataGridViewTextBoxColumn.Width = 160;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(427, 340);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 691);
            Controls.Add(btnXoa);
            Controls.Add(grdviewDanhSach);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(picHinhDaiDien);
            Controls.Add(dtpNgayHetHan);
            Controls.Add(dtpNgaySanXuat);
            Controls.Add(txtSoLuongNhap);
            Controls.Add(txtGiaBan);
            Controls.Add(txtTenSanPham);
            Controls.Add(txtMaSanPham);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)picHinhDaiDien).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdviewDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMaSanPham;
        private TextBox txtTenSanPham;
        private DateTimePicker dtpNgaySanXuat;
        private DateTimePicker dtpNgayHetHan;
        private TextBox txtGiaBan;
        private TextBox txtSoLuongNhap;
        private PictureBox picHinhDaiDien;
        private Button btnThem;
        private Button btnCapNhat;
        private BindingSource sanPhamBindingSource;
        private DataGridView grdviewDanhSach;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySanXuatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhDaiDienDataGridViewTextBoxColumn;
        private Button btnXoa;
    }
}