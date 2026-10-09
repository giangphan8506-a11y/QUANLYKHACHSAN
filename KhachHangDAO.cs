using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class KhachHangDAO
    {
        public SqlDataReader GetAll()
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();
            conn.Open();

            string sql = @"
                SELECT MaKH, HoTen, SoDienThoai, CCCD
                FROM KhachHang";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader(
                CommandBehavior.CloseConnection
            );

            return reader;
        }
        public bool Insert(KhachHang kh)
        {
                Database db = new Database();
                SqlConnection conn = db.GetConnection();
                conn.Open();
                string sql = @"
                INSERT INTO KhachHang (MaKH, HoTen, SoDienThoai, CCCD)
                VALUES (@MaKH, @HoTen, @SoDienThoai, @CCCD)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
                cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@CCCD", kh.CCCD);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
        }
        public bool Update(KhachHang kh)
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            UPDATE KhachHang
            SET HoTen = @HoTen,
                SoDienThoai = @SoDienThoai,
                CCCD = @CCCD
            WHERE MaKH = @MaKH";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
            cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("@CCCD", kh.CCCD);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }
        public bool Delete(string maKH)
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            DELETE FROM KhachHang
            WHERE MaKH = @MaKH";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaKH", maKH);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }
        public SqlDataReader TimKiem(string tuKhoa)
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
        SELECT MaKH, HoTen, SoDienThoai, CCCD
            FROM KhachHang
            WHERE MaKH LIKE @TuKhoa
               OR HoTen LIKE @TuKhoa
               OR SoDienThoai LIKE @TuKhoa
               OR CCCD LIKE @TuKhoa";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@TuKhoa",
                "%" + tuKhoa + "%"
            );

            SqlDataReader reader = cmd.ExecuteReader(
                CommandBehavior.CloseConnection
            );

            return reader;
        }
    }
}
