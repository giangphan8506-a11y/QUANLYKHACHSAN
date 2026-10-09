using Microsoft.Data.SqlClient;

namespace QUANLYKHACHSAN
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (taiKhoan == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT MaNV, HoTen, ChucVu
                FROM NhanVien
                WHERE TaiKhoan = @TaiKhoan
                  AND MatKhau = @MatKhau";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string maNV = reader["MaNV"].ToString();
                    string hoTen = reader["HoTen"].ToString();
                    string chucVu = reader["ChucVu"].ToString();

                    MessageBox.Show(
                        "Đăng nhập thành công!\n" +
                        "Nhân viên: " + hoTen, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    reader.Close();

                    FormMain formMain = new FormMain(maNV, hoTen, chucVu, this);

                    formMain.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void XoaThongTinDangNhap()
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }
    }
}
