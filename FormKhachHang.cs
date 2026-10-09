using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QUANLYKHACHSAN
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            dgvKhachHang.Columns.Add("MaKH", "Mã khách hàng");
            dgvKhachHang.Columns.Add("HoTen", "Họ Và Tên");
            dgvKhachHang.Columns.Add("SoDienThoai", "Số điện thoại");
            dgvKhachHang.Columns.Add("CCCD", "CCCD");
        }
        private void LamMoi()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtSoDienThoai.Text = "";
            txtCCCD.Text = "";
        }
        private void LoadData()
        {
            KhachHangDAO khachhangDAO = new KhachHangDAO();
            SqlDataReader reader = khachhangDAO.GetAll();

            dgvKhachHang.Rows.Clear();

            while (reader.Read())
            {
                dgvKhachHang.Rows.Add(
                    reader["MaKH"].ToString(),
                    reader["HoTen"].ToString(),
                    reader["SoDienThoai"].ToString(),
                    reader["CCCD"].ToString()
                );
            }

            reader.Close();
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHangDAO khachhangDAO = new KhachHangDAO();
            string maKH = txtMaKH.Text;
            string hoTen = txtHoTen.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string cccd = txtCCCD.Text;

            KhachHang kh = new KhachHang();

            kh.MaKH = maKH;
            kh.HoTen = hoTen;
            kh.SoDienThoai = soDienThoai;
            kh.CCCD = cccd;

            bool result = khachhangDAO.Insert(kh);

            if (result)
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");

                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHangDAO khachHangDAO = new KhachHangDAO();
            string maKH = txtMaKH.Text;
            string hoTen = txtHoTen.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string cccd = txtCCCD.Text;

            KhachHang kh = new KhachHang();

            kh.MaKH = maKH;
            kh.HoTen = hoTen;
            kh.SoDienThoai = soDienThoai;
            kh.CCCD = cccd;

            bool result = khachHangDAO.Update(kh);

            if (result)
            {
                MessageBox.Show("Sửa khách hàng thành công!");

                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại!");
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            txtSoDienThoai.Text = row.Cells[2].Value.ToString();
            txtCCCD.Text = row.Cells[3].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHangDAO khachhangDAO = new KhachHangDAO();
            string maKH = txtMaKH.Text;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khách hàng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool ketQua = khachhangDAO.Delete(maKH);

                if (ketQua)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            KhachHangDAO khachhangDAO = new KhachHangDAO();
            string tuKhoa = txtTimKiem.Text.Trim();

            dgvKhachHang.Rows.Clear();

            SqlDataReader reader = khachhangDAO.TimKiem(tuKhoa);

            while (reader.Read())
            {
                dgvKhachHang.Rows.Add(
                    reader["MaKH"].ToString(),
                    reader["HoTen"].ToString(),
                    reader["SoDienThoai"].ToString(),
                    reader["CCCD"].ToString()
                );
            }

            reader.Close();
        }
    }
}
