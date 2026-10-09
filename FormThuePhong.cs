using Microsoft.Data.SqlClient;

namespace QUANLYKHACHSAN
{
    public partial class FormThuePhong : Form
    {
        private ThuePhongDAO dao = new ThuePhongDAO();
        private KhachHangDAO khachHangDAO = new KhachHangDAO();
        private PhongDAO phongDAO = new PhongDAO();

        public FormThuePhong()
        {
            InitializeComponent();
        }


        // ==========================================
        // LOAD FORM
        // ==========================================
        private void FormThuePhong_Load(object sender, EventArgs e)
        {
            TaoCotDataGridView();

            LoadKhachHang();
            LoadPhong();
            LoadData();
        }


        // ==========================================
        // TẠO CỘT DATAGRIDVIEW
        // ==========================================
        private void TaoCotDataGridView()
        {
            dgvThuePhong.Columns.Clear();

            dgvThuePhong.Columns.Add(
                "MaThuePhong",
                "Mã thuê phòng"
            );

            dgvThuePhong.Columns.Add(
                "MaKH",
                "Mã khách hàng"
            );

            dgvThuePhong.Columns.Add(
                "MaPhong",
                "Mã phòng"
            );

            dgvThuePhong.Columns.Add(
                "NgayNhan",
                "Ngày nhận"
            );

            dgvThuePhong.Columns.Add(
                "NgayTra",
                "Ngày trả"
            );

            dgvThuePhong.Columns.Add(
                "SoNguoi",
                "Số người"
            );

            dgvThuePhong.Columns.Add(
                "TrangThai",
                "Trạng thái"
            );

            dgvThuePhong.ReadOnly = true;
            dgvThuePhong.AllowUserToAddRows = false;
            dgvThuePhong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvThuePhong.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvThuePhong.MultiSelect = false;
            dgvThuePhong.RowHeadersVisible = false;
        }


        // ==========================================
        // LOAD DỮ LIỆU THUÊ PHÒNG
        // ==========================================
        private void LoadData()
        {
            SqlDataReader reader = dao.GetAll();

            dgvThuePhong.Rows.Clear();

            while (reader.Read())
            {
                dgvThuePhong.Rows.Add(
                    reader["MaThuePhong"].ToString(),
                    reader["MaKH"].ToString(),
                    reader["MaPhong"].ToString(),

                    Convert.ToDateTime(
                        reader["NgayNhan"]
                    ).ToString("dd/MM/yyyy"),

                    Convert.ToDateTime(
                        reader["NgayTra"]
                    ).ToString("dd/MM/yyyy"),

                    reader["SoNguoi"].ToString(),
                    reader["TrangThai"].ToString()
                );
            }

            reader.Close();
        }


        // ==========================================
        // LOAD KHÁCH HÀNG
        // ==========================================
        private void LoadKhachHang()
        {
            SqlDataReader reader = khachHangDAO.GetAll();

            cbxKhachHang.Items.Clear();

            while (reader.Read())
            {
                cbxKhachHang.Items.Add(
                    reader["MaKH"].ToString()
                    + " - "
                    + reader["HoTen"].ToString()
                );
            }

            reader.Close();
        }


        // ==========================================
        // LOAD PHÒNG
        // CHỈ LẤY PHÒNG TRỐNG
        // ==========================================
        private void LoadPhong(string maPhongDangSua = "")
        {
            SqlDataReader reader = phongDAO.GetAll();

            cbxPhong.Items.Clear();

            while (reader.Read())
            {
                string maPhong =
                    reader["MaPhong"].ToString();

                string soPhong =
                    reader["SoPhong"].ToString();

                string trangThai =
                    reader["TrangThai"].ToString();

                /*
                 * Khi thêm:
                 * chỉ lấy phòng Trống.
                 *
                 * Khi sửa:
                 * lấy phòng Trống + phòng hiện tại
                 * của phiếu đang sửa.
                 */

                if (trangThai == "Trống" ||
                    maPhong == maPhongDangSua)
                {
                    cbxPhong.Items.Add(
                        maPhong + " - " + soPhong
                    );
                }
            }

            reader.Close();
        }


        // ==========================================
        // THÊM PHIẾU THUÊ
        // ==========================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaThuePhong.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã thuê phòng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cbxKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn khách hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cbxPhong.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            DateTime ngayNhan =
                dtpNgayNhan.Value.Date;

            DateTime ngayTra =
                dtpNgayTra.Value.Date;


            if (ngayTra < ngayNhan)
            {
                MessageBox.Show(
                    "Ngày trả không được trước ngày nhận!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            string maKH =
                cbxKhachHang.Text
                .Split('-')[0]
                .Trim();

            string maPhong =
                cbxPhong.Text
                .Split('-')[0]
                .Trim();


            ThuePhong tp = new ThuePhong();

            tp.MaThuePhong =
                txtMaThuePhong.Text.Trim();

            tp.MaKH = maKH;

            tp.MaPhong = maPhong;

            tp.NgayNhan = ngayNhan;

            tp.NgayTra = ngayTra;

            tp.SoNguoi =
                (int)nudSoNguoi.Value;


            // QUAN TRỌNG:
            // Phiếu mới luôn là Đang thuê
            tp.TrangThai = "Đang thuê";


            bool result = dao.Insert(tp);


            if (result)
            {
                // Phòng chuyển sang Đang sử dụng
                phongDAO.UpdateTrangThai(
                    tp.MaPhong,
                    "Đang sử dụng"
                );


                MessageBox.Show(
                    "Thêm thuê phòng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                LoadData();

                LoadPhong();

                LamMoi();
            }
            else
            {
                MessageBox.Show(
                    "Thêm thuê phòng thất bại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // CLICK DATAGRIDVIEW
        // ==========================================
        private void dgvThuePhong_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            DataGridViewRow row =
                dgvThuePhong.Rows[e.RowIndex];


            txtMaThuePhong.Text =
                row.Cells[0].Value.ToString();


            // --------------------------
            // KHÁCH HÀNG
            // --------------------------

            string maKH =
                row.Cells[1].Value.ToString();


            foreach (var item in cbxKhachHang.Items)
            {
                if (item.ToString().StartsWith(maKH))
                {
                    cbxKhachHang.SelectedItem = item;
                    break;
                }
            }


            // --------------------------
            // PHÒNG
            // --------------------------

            string maPhong =
                row.Cells[2].Value.ToString();


            /*
             * Phòng hiện tại có thể đang
             * Đang sử dụng.
             *
             * Vì vậy khi sửa phiếu,
             * phải đưa phòng hiện tại
             * vào ComboBox.
             */

            LoadPhong(maPhong);


            foreach (var item in cbxPhong.Items)
            {
                if (item.ToString().StartsWith(maPhong))
                {
                    cbxPhong.SelectedItem = item;
                    break;
                }
            }


            // --------------------------
            // NGÀY
            // --------------------------

            dtpNgayNhan.Value =
                Convert.ToDateTime(
                    row.Cells[3].Value
                );

            dtpNgayTra.Value =
                Convert.ToDateTime(
                    row.Cells[4].Value
                );


            // --------------------------
            // SỐ NGƯỜI
            // --------------------------

            nudSoNguoi.Value =
                Convert.ToDecimal(
                    row.Cells[5].Value
                );
        }


        // ==========================================
        // SỬA PHIẾU THUÊ
        // ==========================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaThuePhong.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn phiếu cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            if (cbxKhachHang.SelectedIndex == -1 ||
                cbxPhong.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            DateTime ngayNhan =
                dtpNgayNhan.Value.Date;

            DateTime ngayTra =
                dtpNgayTra.Value.Date;


            if (ngayTra < ngayNhan)
            {
                MessageBox.Show(
                    "Ngày trả không được trước ngày nhận!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            string maKH =
                cbxKhachHang.Text
                .Split('-')[0]
                .Trim();


            string maPhongMoi =
                cbxPhong.Text
                .Split('-')[0]
                .Trim();


            ThuePhong tp = new ThuePhong();

            tp.MaThuePhong =
                txtMaThuePhong.Text.Trim();

            tp.MaKH = maKH;

            tp.MaPhong = maPhongMoi;

            tp.NgayNhan = ngayNhan;

            tp.NgayTra = ngayTra;

            tp.SoNguoi =
                (int)nudSoNguoi.Value;


            /*
             * KHÔNG cho sửa trạng thái.
             *
             * Phiếu hiện tại vẫn là
             * Đang thuê.
             */

            tp.TrangThai = "Đang thuê";


            bool result = dao.Update(tp);


            if (result)
            {
                /*
                 * Nếu đổi sang phòng khác:
                 *
                 * Phòng cũ phải trở lại Trống.
                 * Phòng mới trở thành Đang sử dụng.
                 */

                string maPhongCu =
                    dgvThuePhong
                    .CurrentRow
                    .Cells[2]
                    .Value
                    .ToString();


                if (maPhongCu != maPhongMoi)
                {
                    phongDAO.UpdateTrangThai(
                        maPhongCu,
                        "Trống"
                    );

                    phongDAO.UpdateTrangThai(
                        maPhongMoi,
                        "Đang sử dụng"
                    );
                }
                else
                {
                    phongDAO.UpdateTrangThai(
                        maPhongMoi,
                        "Đang sử dụng"
                    );
                }


                MessageBox.Show(
                    "Cập nhật thuê phòng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                LoadData();

                LoadPhong();

                LamMoi();
            }
            else
            {
                MessageBox.Show(
                    "Cập nhật thuê phòng thất bại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // XÓA PHIẾU THUÊ
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaThuePhong.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn phiếu cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            string trangThai =
                dgvThuePhong
                .CurrentRow
                .Cells[6]
                .Value
                .ToString();


            /*
             * Không cho xóa phiếu
             * đang có khách thuê.
             */

            if (trangThai == "Đang thuê")
            {
                MessageBox.Show(
                    "Không thể xóa phiếu đang thuê!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa phiếu này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );


            if (result == DialogResult.Yes)
            {
                bool ketQua =
                    dao.Delete(
                        txtMaThuePhong.Text.Trim()
                    );


                if (ketQua)
                {
                    MessageBox.Show(
                        "Xóa phiếu thuê thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadData();

                    LoadPhong();

                    LamMoi();
                }
                else
                {
                    MessageBox.Show(
                        "Xóa phiếu thuê thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        // ==========================================
        // LÀM MỚI
        // ==========================================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamMoi();

            LoadKhachHang();

            LoadPhong();

            LoadData();
        }


        private void LamMoi()
        {
            txtMaThuePhong.Clear();

            cbxKhachHang.SelectedIndex = -1;

            cbxPhong.SelectedIndex = -1;

            dtpNgayNhan.Value =
                DateTime.Now;

            dtpNgayTra.Value =
                DateTime.Now;

            nudSoNguoi.Value = 1;

            dgvThuePhong.ClearSelection();
        }

        private void btnTimKIem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            dgvThuePhong.Rows.Clear();

            SqlDataReader reader = dao.TimKiem(tuKhoa);

            while (reader.Read())
            {
                dgvThuePhong.Rows.Add(
                    reader["MaThuePhong"].ToString(),
                    reader["MaKH"].ToString(),
                    reader["MaPhong"].ToString(),
                    Convert.ToDateTime(reader["NgayNhan"])
                        .ToString("dd/MM/yyyy"),
                    Convert.ToDateTime(reader["NgayTra"])
                        .ToString("dd/MM/yyyy"),
                    reader["SoNguoi"].ToString(),
                    reader["TrangThai"].ToString()
                );
            }

            reader.Close();
        }
    }
}