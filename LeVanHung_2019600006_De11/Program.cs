using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHung_2019600006_De11
{
    class Program
    {
        //Sửa mới file
        // File này tạo new branch
        static private List<Hanghoa> DsHanghoa = new List<Hanghoa>();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n--------- MAIN MENU ---------");
                Console.WriteLine("  1. Nhap vao danh sach.");
                Console.WriteLine("  2. Hien thi danh sach.");
                Console.WriteLine("  3. Sua thong tin.");
                Console.WriteLine("  4. Xoa mat hang.");
                Console.WriteLine("  5. Thoat.");
                Console.WriteLine("-----------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nNhap lua chon cua ban: ");
                Console.ResetColor();
                string k = Console.ReadLine();
                switch (k)
                {
                    case "1":
                        Console.WriteLine("\n-----------NHAP DS-----------");
                        NhapDS();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nDa nhap xong. Nhan Enter de tiep tuc!");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.WriteLine("\n----------HIEN THI-----------");
                        if (!DsHanghoa.Any())//Kiểm tra xem danh sách đã được nhập vào chưa
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDanh sach rong. Nhan Enter de lua chon nhap ds!");
                            Console.ReadLine();
                            Console.ResetColor();
                        }
                        else
                        {
                            HienthiDS();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nDanh sach hang vua nhap. Nhan Enter de tiep tuc!");
                            Console.ReadLine();
                            Console.ResetColor();
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n----------SUA TT-----------");
                        if (!DsHanghoa.Any())//Kiểm tra nếu ds rỗng thì ko thể sửa tt
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDanh sach rong. Khong the sua thong tin!");
                            Console.WriteLine("Nhan Enter de tiep tuc!");
                            Console.ReadLine();
                            Console.ResetColor();
                        }
                        else
                        {
                            SuaTT();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nDanh sach hang vua sua TT. Nhan Enter de tiep tuc!");
                            Console.ReadLine();
                            Console.ResetColor();
                        }
                        break;
                    case "4":
                        Console.WriteLine("\n-------------XOA-------------");
                        if (!DsHanghoa.Any())//Kiểm tra nếu ds rỗng thì ko thể xóa
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDanh sach rong. Khong the xoa!");
                            Console.WriteLine("Nhan Enter de tiep tuc!");
                            Console.ReadLine();
                            Console.ResetColor();
                        }
                        else
                        {
                            Xoa();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nDanh sach hang sau khi xoa. Nhan Enter de tiep tuc!");
                            Console.ReadLine();
                            Console.ResetColor();
                        }
                        break;
                    case "5":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nBan lua chon sai. Nhan Enter de lua chon lai!");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }
            } while (true);
        }
        static private void NhapDS()
        {
            string mahang, tenhang;
            int soluong;
            double dongia;
            Console.Write("\nNhap ma hang: ");
            mahang = Console.ReadLine();
            Console.Write("Nhap ten hang: ");
            tenhang = Console.ReadLine();
            Console.Write("So luong hang: ");
            soluong = int.Parse(Console.ReadLine());
            Console.Write("Don gia: ");
            dongia = double.Parse(Console.ReadLine());
            Hanghoa Hanghoamoi = new Hanghoa(mahang, tenhang, soluong, dongia);
            DsHanghoa.Add(Hanghoamoi);
        }
        static private void HienthiDS()
        {
            Console.WriteLine("\n\t{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}\n"
                , "Ma Hang", "Ten Hang", "So Luong", "Don Gia", "Tong Tien");
            foreach (Hanghoa x in DsHanghoa)
            {
                Console.WriteLine(x.ToString());
            }
        }
        static private void SuaTT()
        {
            Console.Write("\nNhap vao ma hang can sua thong tin: ");
            string mahang = Console.ReadLine();
            while (check(mahang))
            {
                Console.Write("Ma hang khong ton tai, nhap lai: ");
                mahang = Console.ReadLine();
            }
            string mahangmoi, tenhangmoi;
            int soluongmoi;
            double dongiamoi;
            Console.Write("\nNhap ma hang moi: ");
            mahangmoi = Console.ReadLine();
            Console.Write("Nhap ten hang moi: ");
            tenhangmoi = Console.ReadLine();
            Console.Write("So luong moi: ");
            soluongmoi = int.Parse(Console.ReadLine());
            Console.Write("Don gia moi: ");
            dongiamoi = double.Parse(Console.ReadLine());
            for (int i = 0; i < DsHanghoa.Count; i++)
            {
                if (DsHanghoa[i].MaHang == mahang)
                {
                    DsHanghoa[i].MaHang = mahangmoi;
                    DsHanghoa[i].TenHang = tenhangmoi;
                    DsHanghoa[i].SoLuong = soluongmoi;
                    DsHanghoa[i].DonGia = dongiamoi;
                }
            }
            HienthiDS();
        }
        static private void Xoa()
        {

            Console.Write("\nNhap vao ma hang can xoa: ");
            string maHang = Console.ReadLine();
            while (check(maHang))
            {
                Console.Write("Ma hang khong ton tai, nhap lai: ");
                maHang = Console.ReadLine();
            }
            for (int i = 0; i < DsHanghoa.Count; i++)
            {
                if (DsHanghoa[i].MaHang == maHang)
                {
                    DsHanghoa.RemoveAt(i);
                }
            }
            HienthiDS();
        }
        private static bool check(string ma)
        {
            foreach(Hanghoa i in DsHanghoa)
            {
                if(i.MaHang==ma)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
    }
    //Tiếp tục code
}
