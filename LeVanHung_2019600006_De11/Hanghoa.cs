using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHung_2019600006_De11
{
    class Hanghoa
    {
        string maHang;
        string tenHang;
        int soLuong;
        double donGia;

        public string TenHang { get => tenHang; set => tenHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public string MaHang { get => maHang; set => maHang = value; }

        public Hanghoa() { }
        public Hanghoa(string mahang, string tenhang, int soluong, double dongia)
        {
            this.MaHang = mahang;
            this.TenHang = tenhang;
            this.SoLuong = soluong;
            this.DonGia = dongia;
        }
        public double Tinhtongtien()
        {
            return this.SoLuong * this.DonGia;
        }
        public override string ToString()
        {
            return string.Format("\t{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}"
               , this.MaHang, this.TenHang, this.SoLuong, this.DonGia, this.Tinhtongtien());
        }
    }
}
