namespace QUANLYKHACHSAN
{
    partial class FormKhachHang
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
            grbKhachHang = new GroupBox();
            txtCCCD = new TextBox();
            txtMaKH = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            lblCCCD = new Label();
            lblSoDienThoai = new Label();
            lblHoTenKH = new Label();
            lblMaKH = new Label();
            pnlChucNang = new Panel();
            panel1 = new Panel();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvKhachHang = new DataGridView();
            pnlHeader.SuspendLayout();
            grbKhachHang.SuspendLayout();
            pnlChucNang.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1286, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(245, 239, 226);
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(19, 30, 54);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1286, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "QUẢN LÝ KHÁCH HÀNG ";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbKhachHang
            // 
            grbKhachHang.BackColor = Color.FromArgb(245, 239, 226);
            grbKhachHang.Controls.Add(txtCCCD);
            grbKhachHang.Controls.Add(txtMaKH);
            grbKhachHang.Controls.Add(txtSoDienThoai);
            grbKhachHang.Controls.Add(txtHoTen);
            grbKhachHang.Controls.Add(lblCCCD);
            grbKhachHang.Controls.Add(lblSoDienThoai);
            grbKhachHang.Controls.Add(lblHoTenKH);
            grbKhachHang.Controls.Add(lblMaKH);
            grbKhachHang.Dock = DockStyle.Top;
            grbKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbKhachHang.ForeColor = Color.FromArgb(19, 30, 54);
            grbKhachHang.Location = new Point(0, 60);
            grbKhachHang.Margin = new Padding(2);
            grbKhachHang.Name = "grbKhachHang";
            grbKhachHang.Padding = new Padding(2);
            grbKhachHang.Size = new Size(1286, 149);
            grbKhachHang.TabIndex = 1;
            grbKhachHang.TabStop = false;
            grbKhachHang.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(747, 85);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(311, 34);
            txtCCCD.TabIndex = 4;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(230, 28);
            txtMaKH.Multiline = true;
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(311, 34);
            txtMaKH.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(747, 27);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(311, 34);
            txtSoDienThoai.TabIndex = 4;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(230, 85);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(311, 34);
            txtHoTen.TabIndex = 4;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(575, 92);
            lblCCCD.Margin = new Padding(2, 0, 2, 0);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(72, 28);
            lblCCCD.TabIndex = 3;
            lblCCCD.Text = "CCCD :";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(575, 34);
            lblSoDienThoai.Margin = new Padding(2, 0, 2, 0);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(155, 28);
            lblSoDienThoai.TabIndex = 2;
            lblSoDienThoai.Text = "Số Điện Thoại :";
            // 
            // lblHoTenKH
            // 
            lblHoTenKH.AutoSize = true;
            lblHoTenKH.Location = new Point(37, 92);
            lblHoTenKH.Margin = new Padding(2, 0, 2, 0);
            lblHoTenKH.Name = "lblHoTenKH";
            lblHoTenKH.Size = new Size(117, 28);
            lblHoTenKH.TabIndex = 1;
            lblHoTenKH.Text = "Họ Và Tên :";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Location = new Point(37, 34);
            lblMaKH.Margin = new Padding(2, 0, 2, 0);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(173, 28);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã Khách Hàng :";
            // 
            // pnlChucNang
            // 
            pnlChucNang.BackColor = Color.FromArgb(245, 239, 226);
            pnlChucNang.Controls.Add(panel1);
            pnlChucNang.Controls.Add(btnHuy);
            pnlChucNang.Controls.Add(btnXoa);
            pnlChucNang.Controls.Add(btnSua);
            pnlChucNang.Controls.Add(btnThem);
            pnlChucNang.Dock = DockStyle.Top;
            pnlChucNang.Location = new Point(0, 209);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(1286, 60);
            pnlChucNang.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(829, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 60);
            panel1.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(25, 118, 210);
            btnTimKiem.FlatAppearance.BorderColor = Color.FromArgb(25, 118, 210);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(324, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(125, 50);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(0, 15);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(278, 34);
            txtTimKiem.TabIndex = 4;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(44, 62, 80);
            btnHuy.FlatAppearance.BorderColor = Color.FromArgb(44, 62, 80);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
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
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
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
            btnSua.BackColor = Color.FromArgb(44, 62, 80);
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(44, 62, 80);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(240, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 50);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(201, 164, 92);
            btnThem.FlatAppearance.BorderColor = Color.FromArgb(201, 164, 92);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnThem.Location = new Point(40, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.FromArgb(245, 239, 226);
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(201, 164, 92);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 269);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1286, 401);
            dgvKhachHang.TabIndex = 3;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 670);
            Controls.Add(dgvKhachHang);
            Controls.Add(pnlChucNang);
            Controls.Add(grbKhachHang);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            Load += FormKhachHang_Load;
            pnlHeader.ResumeLayout(false);
            grbKhachHang.ResumeLayout(false);
            grbKhachHang.PerformLayout();
            pnlChucNang.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private GroupBox grbKhachHang;
        private Label lblCCCD;
        private Label lblSoDienThoai;
        private Label lblHoTenKH;
        private Label lblMaKH;
        private TextBox txtCCCD;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private TextBox txtMaKH;
        private Panel pnlChucNang;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvKhachHang;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}