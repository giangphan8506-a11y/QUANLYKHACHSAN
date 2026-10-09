using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class ThuePhongDAO
    {
        public SqlDataReader GetAll()
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
                SELECT MaThuePhong, MaKH, MaPhong,
                       NgayNhan, NgayTra, SoNguoi, TrangThai
                FROM ThuePhong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader(
                CommandBehavior.CloseConnection
            );

            return reader;
        }


        // ==========================================
        // THÊM THUÊ PHÒNG
        // ==========================================
        public bool Insert(ThuePhong tp)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
                INSERT INTO ThuePhong
                (MaThuePhong, MaKH, MaPhong,
                 NgayNhan, NgayTra, SoNguoi, TrangThai)
                VALUES
                (@MaThuePhong, @MaKH, @MaPhong,
                 @NgayNhan, @NgayTra, @SoNguoi, @TrangThai)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaThuePhong", tp.MaThuePhong);
            cmd.Parameters.AddWithValue("@MaKH", tp.MaKH);
            cmd.Parameters.AddWithValue("@MaPhong", tp.MaPhong);
            cmd.Parameters.AddWithValue("@NgayNhan", tp.NgayNhan);
            cmd.Parameters.AddWithValue("@NgayTra", tp.NgayTra);
            cmd.Parameters.AddWithValue("@SoNguoi", tp.SoNguoi);
            cmd.Parameters.AddWithValue("@TrangThai", tp.TrangThai);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }


        // ==========================================
        // SỬA THUÊ PHÒNG
        // ==========================================
        public bool Update(ThuePhong tp)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
                UPDATE ThuePhong
                SET MaKH = @MaKH,
                    MaPhong = @MaPhong,
                    NgayNhan = @NgayNhan,
                    NgayTra = @NgayTra,
                    SoNguoi = @SoNguoi,
                    TrangThai = @TrangThai
                WHERE MaThuePhong = @MaThuePhong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaThuePhong", tp.MaThuePhong);
            cmd.Parameters.AddWithValue("@MaKH", tp.MaKH);
            cmd.Parameters.AddWithValue("@MaPhong", tp.MaPhong);
            cmd.Parameters.AddWithValue("@NgayNhan", tp.NgayNhan);
            cmd.Parameters.AddWithValue("@NgayTra", tp.NgayTra);
            cmd.Parameters.AddWithValue("@SoNguoi", tp.SoNguoi);
            cmd.Parameters.AddWithValue("@TrangThai", tp.TrangThai);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }


        // ==========================================
        // XÓA THUÊ PHÒNG
        // ==========================================
        public bool Delete(string maThuePhong)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
                DELETE FROM ThuePhong
                WHERE MaThuePhong = @MaThuePhong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@MaThuePhong",
                maThuePhong
            );

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
            SELECT MaThuePhong,
                   MaKH,
                   MaPhong,
                   NgayNhan,
                   NgayTra,
                   SoNguoi,
                   TrangThai
            FROM ThuePhong
            WHERE MaThuePhong LIKE @TuKhoa
               OR MaKH LIKE @TuKhoa
               OR MaPhong LIKE @TuKhoa";

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

