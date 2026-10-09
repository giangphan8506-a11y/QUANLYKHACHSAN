using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class HoaDonDAO
    {
        public SqlDataReader GetAll()
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
                SELECT MaHoaDon,
                       MaThuePhong,
                       MaNV,
                       TongTien,
                       NgayLap
                FROM HoaDon";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader(
                CommandBehavior.CloseConnection
            );

            return reader;
        }
        public SqlDataReader GetThuePhongDangThue()
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            SELECT tp.MaThuePhong,
                   tp.MaKH,
                   tp.MaPhong,
                   tp.NgayNhan,
                   tp.NgayTra,
                   p.GiaPhong
            FROM ThuePhong tp
            INNER JOIN Phong p
                ON tp.MaPhong = p.MaPhong
            WHERE tp.TrangThai = N'Đang thuê'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader(
                CommandBehavior.CloseConnection
            );

            return reader;
        }
        public bool LapHoaDon(HoaDon hd)
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();

            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                // ==============================
                // 1. THÊM HÓA ĐƠN
                // ==============================

                string sqlHoaDon = @"
            INSERT INTO HoaDon
            (
                MaHoaDon,
                MaThuePhong,
                MaNV,
                TongTien,
                NgayLap
            )
            VALUES
            (
                @MaHoaDon,
                @MaThuePhong,
                @MaNV,
                @TongTien,
                @NgayLap
            )";

                SqlCommand cmdHoaDon =
                    new SqlCommand(
                        sqlHoaDon,
                        conn,
                        transaction
                    );

                cmdHoaDon.Parameters.AddWithValue(
                    "@MaHoaDon",
                    hd.MaHoaDon
                );

                cmdHoaDon.Parameters.AddWithValue(
                    "@MaThuePhong",
                    hd.MaThuePhong
                );

                cmdHoaDon.Parameters.AddWithValue(
                    "@MaNV",
                    hd.MaNV
                );

                cmdHoaDon.Parameters.AddWithValue(
                    "@TongTien",
                    hd.TongTien
                );

                cmdHoaDon.Parameters.AddWithValue(
                    "@NgayLap",
                    hd.NgayLap
                );

                cmdHoaDon.ExecuteNonQuery();


                // ==============================
                // 2. ĐỔI PHIẾU THUÊ → ĐÃ TRẢ
                // ==============================

                string sqlThuePhong = @"
            UPDATE ThuePhong
            SET TrangThai = N'Đã trả'
            WHERE MaThuePhong = @MaThuePhong";

                SqlCommand cmdThuePhong =
                    new SqlCommand(
                        sqlThuePhong,
                        conn,
                        transaction
                    );

                cmdThuePhong.Parameters.AddWithValue(
                    "@MaThuePhong",
                    hd.MaThuePhong
                );

                cmdThuePhong.ExecuteNonQuery();


                // ==============================
                // 3. LẤY MÃ PHÒNG
                // ==============================

                string sqlLayMaPhong = @"
            SELECT MaPhong
            FROM ThuePhong
            WHERE MaThuePhong = @MaThuePhong";

                SqlCommand cmdLayMaPhong =
                    new SqlCommand(
                        sqlLayMaPhong,
                        conn,
                        transaction
                    );

                cmdLayMaPhong.Parameters.AddWithValue(
                    "@MaThuePhong",
                    hd.MaThuePhong
                );

                string maPhong =
                    cmdLayMaPhong.ExecuteScalar().ToString();


                // ==============================
                // 4. ĐỔI PHÒNG → TRỐNG
                // ==============================

                string sqlPhong = @"
            UPDATE Phong
            SET TrangThai = N'Trống'
            WHERE MaPhong = @MaPhong";

                SqlCommand cmdPhong =
                    new SqlCommand(
                        sqlPhong,
                        conn,
                        transaction
                    );

                cmdPhong.Parameters.AddWithValue(
                    "@MaPhong",
                    maPhong
                );

                cmdPhong.ExecuteNonQuery();


                // ==============================
                // 5. XÁC NHẬN
                // ==============================

                transaction.Commit();

                conn.Close();

                return true;
            }
            catch
            {
                // Có lỗi → hoàn tác tất cả
                transaction.Rollback();

                conn.Close();

                return false;
            }
        }
        public bool KiemTraMaHoaDon(string maHoaDon)
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
        SELECT COUNT(*)
        FROM HoaDon
        WHERE MaHoaDon = @MaHoaDon";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@MaHoaDon",
                maHoaDon
            );

            int count =
                Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
    }
}
