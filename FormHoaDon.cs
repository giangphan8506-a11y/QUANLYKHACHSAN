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
    public partial class FormHoaDon : Form
    {
        private DateTime ngayNhan;
        private DateTime ngayTra;
        private decimal giaPhong;
        private HoaDonDAO dao = new HoaDonDAO();
        private string maNV;
        private string hoTen;
        public FormHoaDon(string maNV, string hoTen)
        {
            InitializeComponent();

            this.maNV = maNV;
            this.hoTen = hoTen;
        }
        private void LamMoi()
        {
            txtMaHoaDon.Clear();

            cbxMaThuePhong.SelectedIndex = -1;

            txtTongTien.Clear();

            dtpNgayLap.Value = DateTime.Now;

            txtNhanVien.Text =
                maNV + " - " + hoTen;

            dgvHoaDon.ClearSelection();
        }
        private void TaoCotDataGridView()
        {
            dgvHoaDon.Columns.Clear();

            dgvHoaDon.Columns.Add(
                "MaHoaDon",
                "Mã hóa đơn"
            );

            dgvHoaDon.Columns.Add(
                "MaThuePhong",
                "Mã thuê phòng"
            );

            dgvHoaDon.Columns.Add(
                "MaNV",
                "Mã nhân viên"
            );

            dgvHoaDon.Columns.Add(
                "TongTien",
                "Tổng tiền"
            );

            dgvHoaDon.Columns.Add(
                "NgayLap",
                "Ngày lập"
            );
        }
        private void LoadThuePhong()
        {
            SqlDataReader reader =
                dao.GetThuePhongDangThue();

            cbxMaThuePhong.Items.Clear();

            while (reader.Read())
            {
                string maThuePhong =
                    reader["MaThuePhong"].ToString();

                string maKH =
                    reader["MaKH"].ToString();

                string maPhong =
                    reader["MaPhong"].ToString();

                cbxMaThuePhong.Items.Add(
                    maThuePhong
                    + " - "
                    + maKH
                    + " - "
                    + maPhong
                );
            }

            reader.Close();
        }
        private void LoadData()
        {
            SqlDataReader reader = dao.GetAll();

            dgvHoaDon.Rows.Clear();

            while (reader.Read())
            {
                dgvHoaDon.Rows.Add(
                    reader["MaHoaDon"].ToString(),
                    reader["MaThuePhong"].ToString(),
                    reader["MaNV"].ToString(),
                    reader["TongTien"].ToString(),

                    Convert.ToDateTime(
                        reader["NgayLap"]
                    ).ToString("dd/MM/yyyy")
                );
            }

            reader.Close();
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            TaoCotDataGridView();
            LoadThuePhong();
            LoadData();
            txtNhanVien.Text = maNV + " - " + hoTen;

        }

        private void cbxMaThuePhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaThuePhong.SelectedIndex == -1)
                return;

            string maThuePhong =
                cbxMaThuePhong.Text
                .Split('-')[0]
                .Trim();

            SqlDataReader reader =
                dao.GetThuePhongDangThue();

            while (reader.Read())
            {
                if (reader["MaThuePhong"].ToString()
                    == maThuePhong)
                {
                    ngayNhan =
                        Convert.ToDateTime(
                            reader["NgayNhan"]
                        );

                    ngayTra =
                        Convert.ToDateTime(
                            reader["NgayTra"]
                        );

                    giaPhong =
                        Convert.ToDecimal(
                            reader["GiaPhong"]
                        );

                    break;
                }
            }

            reader.Close();

            int soNgay =
                (ngayTra - ngayNhan).Days;

            if (soNgay <= 0)
                soNgay = 1;

            decimal tongTien =
                soNgay * giaPhong;

            txtTongTien.Text =
                tongTien.ToString("N0");
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã hóa đơn
            if (txtMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập mã hóa đơn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            if (dao.KiemTraMaHoaDon(txtMaHoaDon.Text.Trim()))
            {
                MessageBox.Show(
                    "Mã hóa đơn đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Kiểm tra phiếu thuê
            if (cbxMaThuePhong.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phiếu thuê phòng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Kiểm tra tổng tiền
            if (txtTongTien.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Tổng tiền chưa được tính!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // ==============================
            // LẤY MÃ THUÊ PHÒNG
            // ==============================

            string maThuePhong =
                cbxMaThuePhong.Text
                .Split('-')[0]
                .Trim();


            // ==============================
            // LẤY TỔNG TIỀN
            // ==============================

            decimal tongTien =
                decimal.Parse(txtTongTien.Text);


            // ==============================
            // TẠO ĐỐI TƯỢNG HÓA ĐƠN
            // ==============================

            HoaDon hd = new HoaDon();

            hd.MaHoaDon =
                txtMaHoaDon.Text.Trim();

            hd.MaThuePhong =
                maThuePhong;

            hd.MaNV =
                maNV;

            hd.TongTien =
                tongTien;

            hd.NgayLap =
                dtpNgayLap.Value;


            // ==============================
            // LẬP HÓA ĐƠN
            // ==============================

            bool result =
                dao.LapHoaDon(hd);


            if (result)
            {
                MessageBox.Show(
                    "Lập hóa đơn thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadData();

                LoadThuePhong();
            }
            else
            {
                MessageBox.Show(
                    "Lập hóa đơn thất bại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();

            LoadThuePhong();

            LoadData();
        }
    }
}
