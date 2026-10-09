using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class PhongDAO
    {
        public SqlDataReader GetAll()
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
                SELECT MaPhong, SoPhong, LoaiPhong, GiaPhong, TrangThai
                FROM Phong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader(
                CommandBehavior.CloseConnection
            );

            return reader;
        }

        public bool Insert(Phong phong)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            INSERT INTO Phong
            (MaPhong, SoPhong, LoaiPhong, GiaPhong, TrangThai)
            VALUES
            (@MaPhong, @SoPhong, @LoaiPhong, @GiaPhong, @TrangThai)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaPhong", phong.MaPhong);
            cmd.Parameters.AddWithValue("@SoPhong", phong.SoPhong);
            cmd.Parameters.AddWithValue("@LoaiPhong", phong.LoaiPhong);
            cmd.Parameters.AddWithValue("@GiaPhong", phong.GiaPhong);
            cmd.Parameters.AddWithValue("@TrangThai", phong.TrangThai);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }
        public bool Update(Phong phong)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            UPDATE Phong
            SET SoPhong = @SoPhong,
                LoaiPhong = @LoaiPhong,
                GiaPhong = @GiaPhong,
                TrangThai = @TrangThai
            WHERE MaPhong = @MaPhong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaPhong", phong.MaPhong);
            cmd.Parameters.AddWithValue("@SoPhong", phong.SoPhong);
            cmd.Parameters.AddWithValue("@LoaiPhong", phong.LoaiPhong);
            cmd.Parameters.AddWithValue("@GiaPhong", phong.GiaPhong);
            cmd.Parameters.AddWithValue("@TrangThai", phong.TrangThai);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }
        public bool Delete(string maPhong)
        {
            Database db = new Database();

            SqlConnection conn = db.GetConnection();

            conn.Open();

            string sql = @"
            DELETE FROM Phong
            WHERE MaPhong = @MaPhong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaPhong", maPhong);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }
        public bool UpdateTrangThai(string maPhong, string trangThai)
        {
            Database db = new Database();
            SqlConnection conn = db.GetConnection();
            conn.Open();

            string sql = @"
        UPDATE Phong
        SET TrangThai = @TrangThai
        WHERE MaPhong = @MaPhong";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected > 0;
        }

    }
}
