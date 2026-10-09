using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class NhanVienDAO
    {
        public SqlDataReader GetAll()
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();
            conn.Open();
            string sql = @"
                SELECT MaNV, HoTen, SoDienThoai, ChucVu, TaiKhoan, MatKhau
                FROM NhanVien";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader(
                CommandBehavior.CloseConnection
            );

            return reader;
        }
        public bool Insert(NhanVien nv)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            INSERT INTO NhanVien
            (MaNV, HoTen, SoDienThoai, ChucVu, TaiKhoan, MatKhau)
            VALUES
            (@MaNV, @HoTen, @SoDienThoai, @ChucVu, @TaiKhoan, @MatKhau)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
            cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
            cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
            cmd.Parameters.AddWithValue("@TaiKhoan", nv.TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", nv.MatKhau);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }
        public bool Update(NhanVien nv)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            UPDATE NhanVien
            SET HoTen = @HoTen,
                SoDienThoai = @SoDienThoai,
                ChucVu = @ChucVu,
                TaiKhoan = @TaiKhoan,
                MatKhau = @MatKhau
            WHERE MaNV = @MaNV";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
            cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
            cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
            cmd.Parameters.AddWithValue("@TaiKhoan", nv.TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", nv.MatKhau);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }
        public bool Delete(string maNV)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            DELETE FROM NhanVien
            WHERE MaNV = @MaNV";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNV", maNV);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }
    }
}
