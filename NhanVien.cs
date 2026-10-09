using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYKHACHSAN
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private string soDienThoai;
        private string chucVu;
        private string taiKhoan;
        private string matKhau;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

    }
}
