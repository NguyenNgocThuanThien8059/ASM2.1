using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> BookList = new List<Book>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(" === Danh Sach Cac Cuon Sach === ");
                Console.WriteLine(" 1. Them 1 cuon sach ");
                Console.WriteLine(" 2. Xoa 1 cuon sach ");
                Console.WriteLine(" 3. Cap nhat thong tin sach ");
                Console.WriteLine(" 4. Xuat danh sach cac cuon sach ");
                Console.WriteLine(" 5. Tim kiem sach ");
                Console.WriteLine(" 6. Thoat ");
                Console.Write(" Chon chuc nang (1 - 6): ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Them1CuonSach(BookList);
                        break;
                    case 2:
                        XuatDanhSachCuonSach(BookList);
                        int pos;
                        Console.WriteLine(" Nhap vi tri can xoa: ");
                        pos = int.Parse(Console.ReadLine());
                        Xoa1CuonSach(BookList, pos);
                        break;
                    case 3:
                        CapNhatThongTinSach(BookList);
                        break;
                    case 4:
                        XuatDanhSachCuonSach(BookList);
                        break;
                    case 6:
                        exit = true;
                        Console.WriteLine(" Ket thuc chuong trinh. ");
                        break;
                    default:
                        Console.WriteLine(" Tuy chon khong hop le. Vui long chon lai. ");
                        break;
                }
            }
        }
        static void Them1CuonSach(List<Book> BookList)
        {
            Console.WriteLine(" === Nhap thong tin sach: === ");
            Book Sach = new Book();
            Sach.Input();
            BookList.Add(Sach);
            Console.WriteLine(" Them sach thanh cong! ");
        }
        static void Xoa1CuonSach(List<Book> BookList , int pos)
        {
            int STT = 1;
            foreach (Book Sach in BookList)
            {
                STT++;
            }
            while(pos < 1 || pos > STT)
            {
                Console.WriteLine(" Khong tim thay vi tri sach can xoa! Vui long nhap lai. ");
                pos = int.Parse(Console.ReadLine());
            }
            BookList.RemoveAt(pos - 1);
        }
        static void CapNhatThongTinSach(List<Book> BookList)
        {
            int BookIDSearch;
            Console.WriteLine(" Nhap ma sach can thay doi thong tin: ");
            BookIDSearch = int.Parse(Console.ReadLine());
            var Result = from Sach in BookList where Sach.BookID == BookIDSearch select Sach;
            Console.WriteLine(" Can thay doi..... ");
            Console.WriteLine(" 1. Ten Sach ");
            Console.WriteLine(" 2. Tac Gia Sach ");
            Console.WriteLine(" 3. Don Gia Sach ");
            Console.WriteLine(" 4. Khong can thay doi ");
            int choice = int.Parse(Console.ReadLine());
            while(choice < 1 || choice > 4)
            {
                Console.WriteLine(" Tuy chon khong hop le. Vui long chon lai. ");
                choice = int.Parse(Console.ReadLine());
            }
            switch(choice)
            {
                case 1:
                    Console.WriteLine(" Nhap du lieu moi: ");
                    string NewBookName = Console.ReadLine();
                    Result.First().BookName = NewBookName;
                    break;
                case 2:
                    Console.WriteLine(" Nhap du lieu moi: ");
                    string NewBookAuthor = Console.ReadLine();
                    Result.First().BookAuthor = NewBookAuthor;
                    break;
                case 3:
                    Console.WriteLine(" Nhap du lieu moi: ");
                    double NewBookPrice = double.Parse(Console.ReadLine());
                    Result.First().BookPrice = NewBookPrice;
                    break;
                case 4:
                    break;
            }
        }
        static void XuatDanhSachCuonSach(List<Book> BookList)
        {
            int STT = 1;
            Console.WriteLine(" === Thong tin tat ca cac cuon sach === ");
            foreach (Book Sach in BookList)
            {
                Console.WriteLine(" {0} / ", STT);
                Sach.Output();
                STT++;
            }
        }
    }
}
