using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class Phong
    {
        private string maPhong;
        private string soPhong;
        private string loaiPhong;
        private decimal giaPhong;
        private string trangThai;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        public string SoPhong
        {
            get { return soPhong; }
            set { soPhong = value; }
        }

        public string LoaiPhong
        {
            get { return loaiPhong; }
            set { loaiPhong = value; }
        }

        public decimal GiaPhong
        {
            get { return giaPhong; }
            set { giaPhong = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
    }
}
