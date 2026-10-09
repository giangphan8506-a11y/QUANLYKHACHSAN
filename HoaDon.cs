using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class HoaDon
    {
        private string maHoaDon;
        private string maThuePhong;
        private string maNV;
        private Decimal tongTien;
        private DateTime ngayLap;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        public string MaThuePhong
        {
            get { return maThuePhong; }
            set { maThuePhong = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public Decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

    }
}
