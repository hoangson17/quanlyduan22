using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppQuanly
{
    internal class nhanvien1
    {
        private string MaNV;
        private string Hoten;
        private DateTime Ngaysinh;
        private string Diachi;
        private string Sdt;
        private string Chucvu;
        private string Email;
        private string Taikhoan;
        private string Matkhau;
        public nhanvien1()
        {
        }

        public nhanvien1(string maNV, string hoten, DateTime ngaysinh, string diachi, string sdt, string chucvu, string email, string taikhoan, string matkhau)
        {
            MaNV = maNV;
            Hoten = hoten;
            Ngaysinh = ngaysinh;
            Diachi = diachi;
            Sdt = sdt;
            Chucvu = chucvu;
            Email = email;
            Taikhoan = taikhoan;
            Matkhau1 = matkhau;
        }

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string Hoten1 { get => Hoten; set => Hoten = value; }
        public DateTime Ngaysinh1 { get => Ngaysinh; set => Ngaysinh = value; }
        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public string Sdt1 { get => Sdt; set => Sdt = value; }
        public string Chucvu1 { get => Chucvu; set => Chucvu = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Taikhoan1 { get => Taikhoan; set => Taikhoan = value; }
        public string Matkhau1 { get => Matkhau; set => Matkhau = value; }
    }
}
