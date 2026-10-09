namespace QUANLYKHACHSAN
{
    partial class FormPhong
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeader = new Label();
            grbPhong = new GroupBox();
            txtSoPhong = new TextBox();
            txtGiaPhong = new TextBox();
            txtMaPhong = new TextBox();
            cbxTrangThai = new ComboBox();
            cbxLoaiPhong = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblMaPhong = new Label();
            pnlChucNang = new Panel();
            pnlTimKiem = new Panel();
            txtTimKiem = new TextBox();
            btnXoa = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvPhong = new DataGridView();
            btnTimKiem = new Button();
            pnlHeader.SuspendLayout();
            grbPhong.SuspendLayout();
            pnlChucNang.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1228, 60);
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
            lblHeader.Size = new Size(1228, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "QUẢN LÝ PHÒNG";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbPhong
            // 
            grbPhong.Controls.Add(txtSoPhong);
            grbPhong.Controls.Add(txtGiaPhong);
            grbPhong.Controls.Add(txtMaPhong);
            grbPhong.Controls.Add(cbxTrangThai);
            grbPhong.Controls.Add(cbxLoaiPhong);
            grbPhong.Controls.Add(label3);
            grbPhong.Controls.Add(label5);
            grbPhong.Controls.Add(label4);
            grbPhong.Controls.Add(label2);
            grbPhong.Controls.Add(lblMaPhong);
            grbPhong.Dock = DockStyle.Top;
            grbPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbPhong.Location = new Point(0, 60);
            grbPhong.Name = "grbPhong";
            grbPhong.Size = new Size(1228, 231);
            grbPhong.TabIndex = 1;
            grbPhong.TabStop = false;
            grbPhong.Text = "THÔNG TIN PHÒNG";
            // 
            // txtSoPhong
            // 
            txtSoPhong.Location = new Point(200, 108);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(339, 34);
            txtSoPhong.TabIndex = 5;
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.Location = new Point(791, 46);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(339, 34);
            txtGiaPhong.TabIndex = 5;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(200, 47);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(339, 34);
            txtMaPhong.TabIndex = 5;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(791, 106);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(339, 36);
            cbxTrangThai.TabIndex = 4;
            // 
            // cbxLoaiPhong
            // 
            cbxLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLoaiPhong.FormattingEnabled = true;
            cbxLoaiPhong.Location = new Point(200, 175);
            cbxLoaiPhong.Name = "cbxLoaiPhong";
            cbxLoaiPhong.Size = new Size(339, 36);
            cbxLoaiPhong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 183);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 2;
            label3.Text = "Loại Phòng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(643, 113);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 1;
            label5.Text = "Trạng Thái :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(645, 52);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 0;
            label4.Text = "Giá Phòng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 115);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 1;
            label2.Text = "Số Phòng :";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(53, 54);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(125, 28);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = " Mã Phòng :";
            // 
            // pnlChucNang
            // 
            pnlChucNang.Controls.Add(pnlTimKiem);
            pnlChucNang.Controls.Add(btnXoa);
            pnlChucNang.Controls.Add(btnHuy);
            pnlChucNang.Controls.Add(btnSua);
            pnlChucNang.Controls.Add(btnThem);
            pnlChucNang.Dock = DockStyle.Top;
            pnlChucNang.Location = new Point(0, 291);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(1228, 60);
            pnlChucNang.TabIndex = 2;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Dock = DockStyle.Right;
            pnlTimKiem.Location = new Point(771, 0);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(457, 60);
            pnlTimKiem.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(0, 14);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(276, 34);
            txtTimKiem.TabIndex = 5;
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
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Làm Mới";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(119, 119, 119);
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
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvPhong
            // 
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.BackgroundColor = Color.FromArgb(245, 239, 226);
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(201, 164, 92);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPhong.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPhong.Dock = DockStyle.Fill;
            dgvPhong.Location = new Point(0, 351);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowHeadersVisible = false;
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(1228, 274);
            dgvPhong.TabIndex = 3;
            dgvPhong.CellClick += dgvPhong_CellClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(25, 118, 210);
            btnTimKiem.FlatAppearance.BorderColor = Color.FromArgb(25, 118, 210);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(328, 6);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(125, 50);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // FormPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 226);
            ClientSize = new Size(1228, 625);
            Controls.Add(dgvPhong);
            Controls.Add(pnlChucNang);
            Controls.Add(grbPhong);
            Controls.Add(pnlHeader);
            Name = "FormPhong";
            Text = "FormPhong";
            Load += FormPhong_Load;
            pnlHeader.ResumeLayout(false);
            grbPhong.ResumeLayout(false);
            grbPhong.PerformLayout();
            pnlChucNang.ResumeLayout(false);
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private GroupBox grbPhong;
        private TextBox txtSoPhong;
        private TextBox txtGiaPhong;
        private TextBox txtMaPhong;
        private ComboBox cbxTrangThai;
        private ComboBox cbxLoaiPhong;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label lblMaPhong;
        private Panel pnlChucNang;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvPhong;
        private Panel pnlTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}