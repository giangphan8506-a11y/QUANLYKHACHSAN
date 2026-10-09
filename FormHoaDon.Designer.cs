namespace QUANLYKHACHSAN
{
    partial class FormHoaDon
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
            panel1 = new Panel();
            label1 = new Label();
            grbThongTinHoaDon = new GroupBox();
            dtpNgayLap = new DateTimePicker();
            cbxMaThuePhong = new ComboBox();
            txtTongTien = new TextBox();
            txtNhanVien = new TextBox();
            txtMaHoaDon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblMaHD = new Label();
            pnlChucNang = new Panel();
            btnLamMoi = new Button();
            btnLapHoaDon = new Button();
            dgvHoaDon = new DataGridView();
            panel1.SuspendLayout();
            grbThongTinHoaDon.SuspendLayout();
            pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1293, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 30, 54);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1293, 60);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HÓA ĐƠN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbThongTinHoaDon
            // 
            grbThongTinHoaDon.Controls.Add(dtpNgayLap);
            grbThongTinHoaDon.Controls.Add(cbxMaThuePhong);
            grbThongTinHoaDon.Controls.Add(txtTongTien);
            grbThongTinHoaDon.Controls.Add(txtNhanVien);
            grbThongTinHoaDon.Controls.Add(txtMaHoaDon);
            grbThongTinHoaDon.Controls.Add(label6);
            grbThongTinHoaDon.Controls.Add(label5);
            grbThongTinHoaDon.Controls.Add(label4);
            grbThongTinHoaDon.Controls.Add(label3);
            grbThongTinHoaDon.Controls.Add(lblMaHD);
            grbThongTinHoaDon.Dock = DockStyle.Top;
            grbThongTinHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbThongTinHoaDon.Location = new Point(0, 60);
            grbThongTinHoaDon.Name = "grbThongTinHoaDon";
            grbThongTinHoaDon.Size = new Size(1293, 184);
            grbThongTinHoaDon.TabIndex = 1;
            grbThongTinHoaDon.TabStop = false;
            grbThongTinHoaDon.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(858, 81);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(352, 34);
            dtpNgayLap.TabIndex = 7;
            // 
            // cbxMaThuePhong
            // 
            cbxMaThuePhong.FormattingEnabled = true;
            cbxMaThuePhong.Location = new Point(858, 28);
            cbxMaThuePhong.Name = "cbxMaThuePhong";
            cbxMaThuePhong.Size = new Size(352, 36);
            cbxMaThuePhong.TabIndex = 6;
            cbxMaThuePhong.SelectedIndexChanged += cbxMaThuePhong_SelectedIndexChanged;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(225, 132);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(352, 34);
            txtTongTien.TabIndex = 5;
            // 
            // txtNhanVien
            // 
            txtNhanVien.Location = new Point(225, 81);
            txtNhanVien.Multiline = true;
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.ReadOnly = true;
            txtNhanVien.Size = new Size(352, 34);
            txtNhanVien.TabIndex = 5;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(225, 29);
            txtMaHoaDon.Multiline = true;
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(352, 34);
            txtMaHoaDon.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(650, 88);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 4;
            label6.Text = "Ngày Lập :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(650, 36);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 3;
            label5.Text = "Mã Thuê Phòng :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 139);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 2;
            label4.Text = "Tổng Tiền :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 88);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 1;
            label3.Text = "Nhân Viên Lập :";
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Location = new Point(45, 36);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(143, 28);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã Hóa Đơn :";
            // 
            // pnlChucNang
            // 
            pnlChucNang.Controls.Add(btnLamMoi);
            pnlChucNang.Controls.Add(btnLapHoaDon);
            pnlChucNang.Dock = DockStyle.Top;
            pnlChucNang.Location = new Point(0, 244);
            pnlChucNang.Name = "pnlChucNang";
            pnlChucNang.Size = new Size(1293, 60);
            pnlChucNang.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(201, 164, 92);
            btnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(201, 164, 92);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLamMoi.Location = new Point(1020, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(259, 50);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.BackColor = Color.FromArgb(108, 124, 102);
            btnLapHoaDon.FlatAppearance.BorderColor = Color.FromArgb(108, 124, 102);
            btnLapHoaDon.FlatAppearance.BorderSize = 0;
            btnLapHoaDon.FlatStyle = FlatStyle.Flat;
            btnLapHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.Location = new Point(229, 5);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(259, 50);
            btnLapHoaDon.TabIndex = 0;
            btnLapHoaDon.Text = "Lập Hóa Đơn";
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.FromArgb(245, 239, 226);
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(201, 164, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(0, 304);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1293, 350);
            dgvHoaDon.TabIndex = 3;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 226);
            ClientSize = new Size(1293, 654);
            Controls.Add(dgvHoaDon);
            Controls.Add(pnlChucNang);
            Controls.Add(grbThongTinHoaDon);
            Controls.Add(panel1);
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            Load += FormHoaDon_Load;
            panel1.ResumeLayout(false);
            grbThongTinHoaDon.ResumeLayout(false);
            grbThongTinHoaDon.PerformLayout();
            pnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox grbThongTinHoaDon;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblMaHD;
        private DateTimePicker dtpNgayLap;
        private ComboBox cbxMaThuePhong;
        private TextBox txtTongTien;
        private TextBox txtNhanVien;
        private TextBox txtMaHoaDon;
        private Panel pnlChucNang;
        private Button btnLamMoi;
        private Button btnLapHoaDon;
        private DataGridView dgvHoaDon;
    }
}