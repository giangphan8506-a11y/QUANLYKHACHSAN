namespace QUANLYKHACHSAN
{
    partial class FormNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeaderNhanVien = new Panel();
            lblHeaderNhanVien = new Label();
            grbNhanVien = new GroupBox();
            cbxChucVu = new ComboBox();
            txtMatKhau = new TextBox();
            txtSoDienThoai = new TextBox();
            txtTaiKhoan = new TextBox();
            txtHoTen = new TextBox();
            txtMaNV = new TextBox();
            lblMatKhau = new Label();
            lblTaiKhoan = new Label();
            lblChucVu = new Label();
            lblSoDienThoai = new Label();
            lblHoTen = new Label();
            lblMaNV = new Label();
            pnlChucNang = new Panel();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvNhanVien = new DataGridView();
            pnlHeaderNhanVien.SuspendLayout();
            grbNhanVien.SuspendLayout();
            pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // pnlHeaderNhanVien
            // 
            pnlHeaderNhanVien.Controls.Add(lblHeaderNhanVien);
            pnlHeaderNhanVien.Dock = DockStyle.Top;
            pnlHeaderNhanVien.Location = new Point(0, 0);
            pnlHeaderNhanVien.Name = "pnlHeaderNhanVien";
            pnlHeaderNhanVien.Size = new Size(1203, 60);
            pnlHeaderNhanVien.TabIndex = 0;
            // 
            // lblHeaderNhanVien
            // 
            lblHeaderNhanVien.BackColor = Color.FromArgb(245, 239, 226);
            lblHeaderNhanVien.Dock = DockStyle.Fill;
            lblHeaderNhanVien.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderNhanVien.ForeColor = Color.FromArgb(19, 30, 54);
            lblHeaderNhanVien.Location = new Point(0, 0);
            lblHeaderNhanVien.Name = "lblHeaderNhanVien";
            lblHeaderNhanVien.Size = new Size(1203, 60);
            lblHeaderNhanVien.TabIndex = 0;
            lblHeaderNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            lblHeaderNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbNhanVien
            // 
            grbNhanVien.BackColor = Color.FromArgb(245, 239, 226);
            grbNhanVien.Controls.Add(cbxChucVu);
            grbNhanVien.Controls.Add(txtMatKhau);
            grbNhanVien.Controls.Add(txtSoDienThoai);
            grbNhanVien.Controls.Add(txtTaiKhoan);
            grbNhanVien.Controls.Add(txtHoTen);
            grbNhanVien.Controls.Add(txtMaNV);
            grbNhanVien.Controls.Add(lblMatKhau);
            grbNhanVien.Controls.Add(lblTaiKhoan);
            grbNhanVien.Controls.Add(lblChucVu);
            grbNhanVien.Controls.Add(lblSoDienThoai);
            grbNhanVien.Controls.Add(lblHoTen);
            grbNhanVien.Controls.Add(lblMaNV);
            grbNhanVien.Dock = DockStyle.Top;
            grbNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbNhanVien.Location = new Point(0, 60);
            grbNhanVien.Name = "grbNhanVien";
            grbNhanVien.Size = new Size(1203, 220);
            grbNhanVien.TabIndex = 1;
            grbNhanVien.TabStop = false;
            grbNhanVien.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // cbxChucVu
            // 
            cbxChucVu.FormattingEnabled = true;
            cbxChucVu.Location = new Point(815, 39);
            cbxChucVu.Name = "cbxChucVu";
            cbxChucVu.Size = new Size(352, 36);
            cbxChucVu.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(815, 139);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(352, 34);
            txtMatKhau.TabIndex = 6;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(234, 139);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(352, 34);
            txtSoDienThoai.TabIndex = 6;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(815, 89);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(352, 34);
            txtTaiKhoan.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(234, 89);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(352, 34);
            txtHoTen.TabIndex = 6;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(234, 40);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(352, 34);
            txtMaNV.TabIndex = 6;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(690, 146);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(115, 28);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật Khẩu :";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Location = new Point(690, 96);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(116, 28);
            lblTaiKhoan.TabIndex = 4;
            lblTaiKhoan.Text = "Tài Khoản :";
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(690, 47);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(101, 28);
            lblChucVu.TabIndex = 3;
            lblChucVu.Text = "Chức Vụ :";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(47, 146);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(155, 28);
            lblSoDienThoai.TabIndex = 2;
            lblSoDienThoai.Text = "Số Điện Thoại :";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(47, 96);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(117, 28);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ Và Tên :";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(47, 47);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(158, 28);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã Nhân Viên :";
            // 
            // pnlChucNang
            // 
            pnlChucNang.BackColor = Color.FromArgb(245, 239, 226);
            pnlChucNang.Controls.Add(btnHuy);
            pnlChucNang.Controls.Add(btnXoa);
            pnlChucNang.Controls.Add(btnSua);
            pnlChucNang.Controls.Add(btnThem);
            pnlChucNang.Dock = DockStyle.Top;
            pnlChucNang.Location = new Point(0, 280);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(1203, 60);
            pnlChucNang.TabIndex = 2;
            pnlChucNang.Paint += pnlChucNang_Paint;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(119, 119, 119);
            btnHuy.FlatAppearance.BorderColor = Color.FromArgb(119, 119, 119);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
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
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
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
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
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
            btnThem.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(40, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.FromArgb(245, 239, 226);
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(201, 164, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 340);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1203, 357);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 697);
            Controls.Add(dgvNhanVien);
            Controls.Add(pnlChucNang);
            Controls.Add(grbNhanVien);
            Controls.Add(pnlHeaderNhanVien);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            Load += FormNhanVien_Load;
            pnlHeaderNhanVien.ResumeLayout(false);
            grbNhanVien.ResumeLayout(false);
            grbNhanVien.PerformLayout();
            pnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderNhanVien;
        private Label lblHeaderNhanVien;
        private GroupBox grbNhanVien;
        private TextBox txtMatKhau;
        private TextBox txtSoDienThoai;
        private TextBox txtTaiKhoan;
        private TextBox txtHoTen;
        private TextBox txtMaNV;
        private Label lblMatKhau;
        private Label lblTaiKhoan;
        private Label lblChucVu;
        private Label lblSoDienThoai;
        private Label lblHoTen;
        private Label lblMaNV;
        private Panel pnlChucNang;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvNhanVien;
        private ComboBox cbxChucVu;
    }
}