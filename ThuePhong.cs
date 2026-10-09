using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class ThuePhong
    {
        private string maThuePhong;
        private string maKH;
        private string maPhong;
        private DateTime ngayNhan;
        private DateTime ngayTra;
        private int soNguoi;
        private string trangThai;

        public string MaThuePhong
        {
            get { return maThuePhong; }
            set { maThuePhong = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        public DateTime NgayNhan
        {
            get { return ngayNhan; }
            set { ngayNhan = value; }
        }

        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }

        public int SoNguoi
        {
            get { return soNguoi; }
            set { soNguoi = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
    }
}
