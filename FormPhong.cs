using Microsoft.Data.SqlClient;

namespace QUANLYKHACHSAN
{
    public partial class FormPhong : Form
    {
        private PhongDAO dao = new PhongDAO();

        public FormPhong()
        {
            InitializeComponent();
            dgvPhong.Columns.Add("MaPhong", "Mã phòng");
            dgvPhong.Columns.Add("SoPhong", "Số phòng");
            dgvPhong.Columns.Add("LoaiPhong", "Loại phòng");
            dgvPhong.Columns.Add("GiaPhong", "Giá phòng");
            dgvPhong.Columns.Add("TrangThai", "Trạng thái");
        }

        // ==========================================
        // LOAD FORM
        // ==========================================
        private void FormPhong_Load(object sender, EventArgs e)
        {
            cbxLoaiPhong.Items.Clear();
            cbxLoaiPhong.Items.Add("Phòng đơn");
            cbxLoaiPhong.Items.Add("Phòng đôi");
            cbxLoaiPhong.Items.Add("VIP");

            cbxTrangThai.Items.Clear();
            cbxTrangThai.Items.Add("Trống");
            cbxTrangThai.Items.Add("Đang sử dụng");
            cbxTrangThai.Items.Add("Đang bảo trì");

            LoadData();
        }


        // ==========================================
        // HIỂN THỊ DANH SÁCH PHÒNG
        // ==========================================
        private void LoadData()
        {
            SqlDataReader reader = dao.GetAll();

            dgvPhong.Rows.Clear();

            while (reader.Read())
            {
                dgvPhong.Rows.Add(
                    reader["MaPhong"].ToString(),
                    reader["SoPhong"].ToString(),
                    reader["LoaiPhong"].ToString(),
                    reader["GiaPhong"].ToString(),
                    reader["TrangThai"].ToString()
                );
            }

            reader.Close();
        }


        // ==========================================
        // THÊM PHÒNG
        // ==========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "" ||
                txtSoPhong.Text.Trim() == "" ||
                cbxLoaiPhong.Text == "" ||
                txtGiaPhong.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!decimal.TryParse(txtGiaPhong.Text, out decimal giaPhong))
            {
                MessageBox.Show(
                    "Giá phòng không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Phong phong = new Phong();

            phong.MaPhong = txtMaPhong.Text.Trim();
            phong.SoPhong = txtSoPhong.Text.Trim();
            phong.LoaiPhong = cbxLoaiPhong.Text;
            phong.GiaPhong = giaPhong;

            // Phòng mới luôn bắt đầu ở trạng thái Trống
            phong.TrangThai = "Trống";

            bool result = dao.Insert(phong);

            if (result)
            {
                MessageBox.Show(
                    "Thêm phòng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show(
                    "Thêm phòng thất bại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // SỬA PHÒNG
        // ==========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!decimal.TryParse(txtGiaPhong.Text, out decimal giaPhong))
            {
                MessageBox.Show(
                    "Giá phòng không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string trangThaiCu = dgvPhong.CurrentRow.Cells[4].Value.ToString();
            string trangThaiMoi = cbxTrangThai.Text;

            // ==========================================
            // KHÔNG CHO SỬA TRẠNG THÁI ĐANG SỬ DỤNG
            // ==========================================
            if (trangThaiCu == "Đang sử dụng")
            {
                if (trangThaiMoi != "Đang sử dụng")
                {
                    MessageBox.Show(
                        "Phòng đang có khách thuê.\n" +
                        "Không thể thay đổi trạng thái phòng tại đây!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }


            // ==========================================
            // CHỈ CHO PHÉP:
            // Trống ↔ Đang sửa chữa
            // ==========================================
            if (trangThaiCu == "Trống")
            {
                if (trangThaiMoi != "Trống" &&
                    trangThaiMoi != "Đang bảo trì")
                {
                    MessageBox.Show(
                        "Không thể chuyển phòng Trống sang trạng thái này!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }


            if (trangThaiCu == "Đang bảo trì")
            {
                if (trangThaiMoi != "Đang bảo trì" &&
                    trangThaiMoi != "Trống")
                {
                    MessageBox.Show(
                        "Phòng đang bảo trì chỉ có thể giữ nguyên " +
                        "hoặc chuyển về Trống!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }


            Phong phong = new Phong();

            phong.MaPhong = txtMaPhong.Text.Trim();
            phong.SoPhong = txtSoPhong.Text.Trim();
            phong.LoaiPhong = cbxLoaiPhong.Text;
            phong.GiaPhong = giaPhong;
            phong.TrangThai = trangThaiMoi;

            bool result = dao.Update(phong);

            if (result)
            {
                MessageBox.Show(
                    "Cập nhật phòng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show(
                    "Cập nhật phòng thất bại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // XÓA PHÒNG
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string trangThai = dgvPhong.CurrentRow.Cells[4].Value.ToString();

            // Không cho xóa phòng đang sử dụng
            if (trangThai == "Đang sử dụng")
            {
                MessageBox.Show(
                    "Không thể xóa phòng đang có khách thuê!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phòng này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool ketQua = dao.Delete(txtMaPhong.Text.Trim());

                if (ketQua)
                {
                    MessageBox.Show(
                        "Xóa phòng thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadData();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show(
                        "Xóa phòng thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        // ==========================================
        // CLICK VÀO DATAGRIDVIEW
        // ==========================================
        private void dgvPhong_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvPhong.Rows[e.RowIndex];

            txtMaPhong.Text = row.Cells[0].Value.ToString();
            txtSoPhong.Text = row.Cells[1].Value.ToString();
            cbxLoaiPhong.Text = row.Cells[2].Value.ToString();
            txtGiaPhong.Text = row.Cells[3].Value.ToString();
            cbxTrangThai.Text = row.Cells[4].Value.ToString();
        }


        // ==========================================
        // LÀM MỚI
        // ==========================================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadData();
        }


        private void LamMoi()
        {
            txtMaPhong.Clear();
            txtSoPhong.Clear();
            txtGiaPhong.Clear();

            cbxLoaiPhong.SelectedIndex = -1;
            cbxTrangThai.SelectedIndex = -1;

            dgvPhong.ClearSelection();
        }
    }
}