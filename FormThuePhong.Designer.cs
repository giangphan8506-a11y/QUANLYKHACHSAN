namespace QUANLYKHACHSAN
{
    partial class FormThuePhong
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeader = new Label();
            grbDatPhong = new GroupBox();
            nudSoNguoi = new NumericUpDown();
            dtpNgayTra = new DateTimePicker();
            dtpNgayNhan = new DateTimePicker();
            cbxKhachHang = new ComboBox();
            cbxPhong = new ComboBox();
            cbxTrangThai = new ComboBox();
            txtMaThuePhong = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblMaThuePhong = new Label();
            pnlchucNang = new Panel();
            panel1 = new Panel();
            btnTimKIem = new Button();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dgvThuePhong = new DataGridView();
            pnlHeader.SuspendLayout();
            grbDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoNguoi).BeginInit();
            pnlchucNang.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuePhong).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1347, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(19, 30, 54);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1347, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "QUẢN LÝ THUÊ PHÒNG";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbDatPhong
            // 
            grbDatPhong.Controls.Add(nudSoNguoi);
            grbDatPhong.Controls.Add(dtpNgayTra);
            grbDatPhong.Controls.Add(dtpNgayNhan);
            grbDatPhong.Controls.Add(cbxKhachHang);
            grbDatPhong.Controls.Add(cbxPhong);
            grbDatPhong.Controls.Add(cbxTrangThai);
            grbDatPhong.Controls.Add(txtMaThuePhong);
            grbDatPhong.Controls.Add(label7);
            grbDatPhong.Controls.Add(label6);
            grbDatPhong.Controls.Add(label5);
            grbDatPhong.Controls.Add(label4);
            grbDatPhong.Controls.Add(label3);
            grbDatPhong.Controls.Add(label2);
            grbDatPhong.Controls.Add(lblMaThuePhong);
            grbDatPhong.Dock = DockStyle.Top;
            grbDatPhong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDatPhong.Location = new Point(0, 60);
            grbDatPhong.Name = "grbDatPhong";
            grbDatPhong.Size = new Size(1347, 252);
            grbDatPhong.TabIndex = 1;
            grbDatPhong.TabStop = false;
            grbDatPhong.Text = "THÔNG TIN ĐẶT PHÒNG ";
            // 
            // nudSoNguoi
            // 
            nudSoNguoi.Location = new Point(792, 84);
            nudSoNguoi.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoNguoi.Name = "nudSoNguoi";
            nudSoNguoi.Size = new Size(352, 31);
            nudSoNguoi.TabIndex = 10;
            nudSoNguoi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Location = new Point(792, 139);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(352, 31);
            dtpNgayTra.TabIndex = 9;
            // 
            // dtpNgayNhan
            // 
            dtpNgayNhan.Location = new Point(204, 141);
            dtpNgayNhan.Name = "dtpNgayNhan";
            dtpNgayNhan.Size = new Size(352, 31);
            dtpNgayNhan.TabIndex = 9;
            // 
            // cbxKhachHang
            // 
            cbxKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKhachHang.FormattingEnabled = true;
            cbxKhachHang.Location = new Point(792, 31);
            cbxKhachHang.Name = "cbxKhachHang";
            cbxKhachHang.Size = new Size(352, 33);
            cbxKhachHang.TabIndex = 8;
            // 
            // cbxPhong
            // 
            cbxPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPhong.FormattingEnabled = true;
            cbxPhong.Location = new Point(204, 85);
            cbxPhong.Name = "cbxPhong";
            cbxPhong.Size = new Size(352, 33);
            cbxPhong.TabIndex = 8;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(204, 194);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(352, 33);
            cbxTrangThai.TabIndex = 8;
            // 
            // txtMaThuePhong
            // 
            txtMaThuePhong.Location = new Point(204, 35);
            txtMaThuePhong.Multiline = true;
            txtMaThuePhong.Name = "txtMaThuePhong";
            txtMaThuePhong.Size = new Size(352, 34);
            txtMaThuePhong.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(611, 146);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 6;
            label7.Text = "Ngày Trả :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(611, 91);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 5;
            label6.Text = "Số Người :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(611, 39);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 4;
            label5.Text = "Mã Khách Hàng :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 203);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 3;
            label4.Text = "Trạng Thái :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 148);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày Nhận :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 93);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Phòng :";
            // 
            // lblMaThuePhong
            // 
            lblMaThuePhong.AutoSize = true;
            lblMaThuePhong.Location = new Point(35, 41);
            lblMaThuePhong.Name = "lblMaThuePhong";
            lblMaThuePhong.Size = new Size(157, 25);
            lblMaThuePhong.TabIndex = 0;
            lblMaThuePhong.Text = "Mã Thuê Phòng :";
            // 
            // pnlchucNang
            // 
            pnlchucNang.Controls.Add(panel1);
            pnlchucNang.Controls.Add(btnThem);
            pnlchucNang.Controls.Add(btnHuy);
            pnlchucNang.Controls.Add(btnXoa);
            pnlchucNang.Controls.Add(btnSua);
            pnlchucNang.Dock = DockStyle.Top;
            pnlchucNang.Location = new Point(0, 312);
            pnlchucNang.Name = "pnlchucNang";
            pnlchucNang.Size = new Size(1347, 60);
            pnlchucNang.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKIem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(890, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 60);
            panel1.TabIndex = 4;
            // 
            // btnTimKIem
            // 
            btnTimKIem.BackColor = Color.FromArgb(25, 118, 210);
            btnTimKIem.FlatAppearance.BorderColor = Color.FromArgb(25, 118, 210);
            btnTimKIem.FlatStyle = FlatStyle.Flat;
            btnTimKIem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKIem.ForeColor = Color.White;
            btnTimKIem.Location = new Point(326, 4);
            btnTimKIem.Name = "btnTimKIem";
            btnTimKIem.Size = new Size(125, 50);
            btnTimKIem.TabIndex = 8;
            btnTimKIem.Text = "Tìm Kiếm";
            btnTimKIem.UseVisualStyleBackColor = false;
            btnTimKIem.Click += btnTimKIem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(0, 15);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(276, 34);
            txtTimKiem.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(201, 164, 92);
            btnThem.FlatAppearance.BorderColor = Color.FromArgb(201, 164, 92);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.Location = new Point(40, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(119, 119, 119);
            btnHuy.FlatAppearance.BorderColor = Color.FromArgb(119, 119, 119);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(640, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 50);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Làm Mới";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(185, 74, 72);
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(185, 74, 72);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(440, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 50);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(119, 119, 119);
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(119, 119, 119);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(240, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 50);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // dgvThuePhong
            // 
            dgvThuePhong.AllowUserToAddRows = false;
            dgvThuePhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThuePhong.BackgroundColor = Color.FromArgb(245, 239, 226);
            dgvThuePhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(201, 164, 92);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvThuePhong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvThuePhong.Dock = DockStyle.Fill;
            dgvThuePhong.Location = new Point(0, 372);
            dgvThuePhong.MultiSelect = false;
            dgvThuePhong.Name = "dgvThuePhong";
            dgvThuePhong.ReadOnly = true;
            dgvThuePhong.RowHeadersVisible = false;
            dgvThuePhong.RowHeadersWidth = 51;
            dgvThuePhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThuePhong.Size = new Size(1347, 279);
            dgvThuePhong.TabIndex = 3;
            dgvThuePhong.CellClick += dgvThuePhong_CellClick;
            // 
            // FormThuePhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 226);
            ClientSize = new Size(1347, 651);
            Controls.Add(dgvThuePhong);
            Controls.Add(pnlchucNang);
            Controls.Add(grbDatPhong);
            Controls.Add(pnlHeader);
            Name = "FormThuePhong";
            Text = "FormThuePhong";
            Load += FormThuePhong_Load;
            pnlHeader.ResumeLayout(false);
            grbDatPhong.ResumeLayout(false);
            grbDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoNguoi).EndInit();
            pnlchucNang.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuePhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private GroupBox grbDatPhong;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblMaThuePhong;
        private ComboBox cbxTrangThai;
        private TextBox txtMaThuePhong;
        private NumericUpDown nudSoNguoi;
        private DateTimePicker dtpNgayTra;
        private DateTimePicker dtpNgayNhan;
        private ComboBox cbxKhachHang;
        private ComboBox cbxPhong;
        private Panel pnlchucNang;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvThuePhong;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Button btnTimKIem;
    }
}