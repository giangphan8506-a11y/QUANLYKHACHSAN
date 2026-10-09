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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            dgvNhanVien.Columns.Add("MaNV", "Mã Nhân Viên");
            dgvNhanVien.Columns.Add("HoTen", "Họ Tên");
            dgvNhanVien.Columns.Add("SoDienThoai", "Số Điện Thoại");
            dgvNhanVien.Columns.Add("ChucVu", "Chức Vụ");
            dgvNhanVien.Columns.Add("TaiKhoan", "Tài Khoản");
            dgvNhanVien.Columns.Add("MatKhau", "Mật Khẩu");
        }
        private void LoadData()
        {
            NhanVienDAO nhanvienDAO = new NhanVienDAO();
            SqlDataReader reader = nhanvienDAO.GetAll();

            dgvNhanVien.Rows.Clear();

            while (reader.Read())
            {
                dgvNhanVien.Rows.Add(
                    reader["MaNV"].ToString(),
                    reader["HoTen"].ToString(),
                    reader["SoDienThoai"].ToString(),
                    reader["ChucVu"].ToString(),
                    reader["TaiKhoan"].ToString(),
                    reader["MatKhau"].ToString()
                );
            }

            reader.Close();
        }
        private void LamMoi()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            cbxChucVu.SelectedIndex = -1;
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            cbxChucVu.Items.Add("Quản lý");
            cbxChucVu.Items.Add("Lễ tân");
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVienDAO nhanvienDAO = new NhanVienDAO();
            NhanVien nv = new NhanVien();

            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            nv.SoDienThoai = txtSoDienThoai.Text;
            nv.ChucVu = cbxChucVu.Text;
            nv.TaiKhoan = txtTaiKhoan.Text;
            nv.MatKhau = txtMatKhau.Text;

            bool result = nhanvienDAO.Insert(nv);

            if (result)
            {
                MessageBox.Show("Thêm nhân viên thành công!");

                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVienDAO nhanvienDAO = new NhanVienDAO();
            NhanVien nv = new NhanVien();

            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            nv.SoDienThoai = txtSoDienThoai.Text;
            nv.ChucVu = cbxChucVu.Text;
            nv.TaiKhoan = txtTaiKhoan.Text;
            nv.MatKhau = txtMatKhau.Text;

            bool result = nhanvienDAO.Update(nv);

            if (result)
            {
                MessageBox.Show("Sửa nhân viên thành công!");

                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVienDAO nhanvienDAO = new NhanVienDAO();
            string maNV = txtMaNV.Text;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool ketQua = nhanvienDAO.Delete(maNV);

                if (ketQua)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!");
                }
            }

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            txtSoDienThoai.Text = row.Cells[2].Value.ToString();
            cbxChucVu.Text = row.Cells[3].Value.ToString();
            txtTaiKhoan.Text = row.Cells[4].Value.ToString();
            txtMatKhau.Text = row.Cells[5].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadData();
        }

        private void pnlChucNang_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
