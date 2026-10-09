using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class FormMain : Form
    {
        private string maNV;
        private string hoTen;
        private string chucVu;
        private Form formDangMo;
        private FormDangNhap formDangNhap;
        public FormMain(string maNV, string hoTen, string chucVu, FormDangNhap formDangNhap)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.chucVu = chucVu;
            this.formDangNhap = formDangNhap;
        }
        private void LoadThongKePhong()
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();

            conn.Open();

            // ==========================================
            // 1. ĐẾM TỔNG SỐ PHÒNG
            // ==========================================

            string sqlTongPhong = @"
            SELECT COUNT(*)
            FROM Phong";

            SqlCommand cmdTongPhong =
                new SqlCommand(sqlTongPhong, conn);

            int tongPhong =
                Convert.ToInt32(cmdTongPhong.ExecuteScalar());


            // ==========================================
            // 2. ĐẾM SỐ PHÒNG TRỐNG
            // ==========================================

            string sqlPhongTrong = @"
            SELECT COUNT(*)
            FROM Phong
            WHERE TrangThai = N'Trống'";

            SqlCommand cmdPhongTrong =
                new SqlCommand(sqlPhongTrong, conn);

            int phongTrong =
                Convert.ToInt32(cmdPhongTrong.ExecuteScalar());


            // ==========================================
            // 3. ĐẾM SỐ PHÒNG ĐANG SỬ DỤNG
            // ==========================================

            string sqlDangSuDung = @"
            SELECT COUNT(*)
            FROM Phong
            WHERE TrangThai = N'Đang sử dụng'";

            SqlCommand cmdDangSuDung =
                new SqlCommand(sqlDangSuDung, conn);

            int dangSuDung =
                Convert.ToInt32(cmdDangSuDung.ExecuteScalar());


            // ==========================================
            // 4. ĐẾM SỐ PHÒNG ĐANG BẢO TRÌ
            // ==========================================

            string sqlDangSuaChua = @"
            SELECT COUNT(*)
            FROM Phong
            WHERE TrangThai = N'Đang bảo trì'";

            SqlCommand cmdDangSuaChua =
                new SqlCommand(sqlDangSuaChua, conn);

            int dangSuaChua =
                Convert.ToInt32(cmdDangSuaChua.ExecuteScalar());


            // ==========================================
            // 5. HIỂN THỊ LÊN GIAO DIỆN
            // ==========================================

            lblSoTongPhong.Text =
                tongPhong.ToString();

            lblSoPhongTrong.Text =
                phongTrong.ToString();

            lblSoDangSuDung.Text =
                dangSuDung.ToString();

            lblSoDangSuaChua.Text =
                dangSuaChua.ToString();


            // ==========================================
            // 6. ĐÓNG KẾT NỐI
            // ==========================================

            conn.Close();
        }
        private void MoForm(Form form)
        {
            // Nếu đang có Form khác thì đóng Form đó
            if (formDangMo != null)
            {
                formDangMo.Close();
                formDangMo = null;
            }

            // Ẩn trang Tổng quan
            pnlTongQuan.Visible = false;

            // Thiết lập Form mới
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Đưa Form vào pnlNoiDung
            pnlNoiDung.Controls.Add(form);

            // Lưu Form đang mở
            formDangMo = form;

            // Hiển thị Form
            form.Show();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = "Xin chào, " + hoTen;
            LoadThongKePhong();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DoiMauNut(btnKhachHang);
            FormKhachHang form = new FormKhachHang();

            MoForm(form);
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            DoiMauNut(btnTongQuan);
            if (formDangMo != null)
            {
                formDangMo.Close();
                formDangMo = null;
            }

            pnlTongQuan.Visible = true;

            LoadThongKePhong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiMauNut(btnHoaDon);
            FormHoaDon form = new FormHoaDon(maNV, hoTen);

            MoForm(form);

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            DoiMauNut(btnNhanVien);
            if (chucVu != "Quản lý")
            {
                MessageBox.Show(
                    "Chỉ quản lý mới có quyền quản lý nhân viên!",
                    "Cảnh Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            FormNhanVien form = new FormNhanVien();
            MoForm(form);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            DoiMauNut(btnPhong);
            FormPhong form = new FormPhong();
            MoForm(form);
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            DoiMauNut(btnThuePhong);
            FormThuePhong form = new FormThuePhong();
            MoForm(form);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                formDangNhap.XoaThongTinDangNhap();
                this.Close();
                formDangNhap.Show();
            }
        }
        private void DoiMauNut(Button nutDangChon)
        {
            Button[] danhSachNut =
            {
            btnTongQuan,
            btnKhachHang,
            btnNhanVien,
            btnPhong,
            btnThuePhong,
            btnHoaDon
            };

            foreach (Button nut in danhSachNut)
            {
                nut.BackColor = ColorTranslator.FromHtml("7, 26, 42");
                nut.ForeColor = Color.White;
            }

            nutDangChon.BackColor = ColorTranslator.FromHtml("#C9A45C");
            nutDangChon.ForeColor = Color.White;
        }
    }
}
