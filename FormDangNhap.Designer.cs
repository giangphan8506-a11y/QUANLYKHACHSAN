namespace QUANLYKHACHSAN
{
    partial class FormDangNhap
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
            pnlHeader = new Panel();
            lblHeader = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            lblTaiKhoan = new Label();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1089, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(255, 192, 128);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1089, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ĐĂNG NHẬP HỆ THỐNG";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(lblMatKhau);
            panel1.Controls.Add(lblTaiKhoan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 571);
            panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(185, 74, 72);
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(185, 74, 72);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(472, 283);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(240, 51);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(217, 164, 65);
            btnDangNhap.FlatAppearance.BorderColor = Color.FromArgb(217, 164, 65);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangNhap.Location = new Point(95, 283);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(240, 51);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(236, 83);
            txtTaiKhoan.Multiline = true;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(476, 31);
            txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(236, 191);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = 'X';
            txtMatKhau.Size = new Size(476, 31);
            txtMatKhau.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblMatKhau.ForeColor = Color.White;
            lblMatKhau.Location = new Point(58, 191);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(130, 31);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật Khẩu :";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblTaiKhoan.ForeColor = Color.White;
            lblTaiKhoan.Location = new Point(58, 83);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(131, 31);
            lblTaiKhoan.TabIndex = 0;
            lblTaiKhoan.Text = "Tài Khoản :";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 42, 68);
            ClientSize = new Size(1089, 631);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Name = "FormDangNhap";
            Text = "Đăng Nhập";
            Load += FormDangNhap_Load;
            pnlHeader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Panel panel1;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private Label lblTaiKhoan;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}
