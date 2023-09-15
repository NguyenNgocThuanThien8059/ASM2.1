using System;

namespace QuanLySach
{
    internal class Book
    {
        private int MaSach;
        private string TenSach;
        private string TacGia;
        private double DonGia;
        public int BookID
        {
            get => MaSach;
            set => MaSach = value;
        }
        public string BookName
        {
            get => TenSach;
            set => TenSach = value;
        }
        public string BookAuthor
        {
            get => TacGia;
            set => TacGia = value;
        }
        public double BookPrice
        {
            get => DonGia;
            set => DonGia = value;
        }
        public Book()
        {

        }
        public Book(int ID, string Name, string Author, double Price)
        {
            ID = MaSach;
            Name = TenSach;
            Author = TacGia;
            Price = DonGia;
        }
        public void Input()
        {
            Console.Write(" Nhap Ma Sach: ");
            BookID = int.Parse(Console.ReadLine());
            Console.Write(" Nhap Ten Sach: ");
            BookName = Console.ReadLine();
            Console.Write(" Nhap Tac Gia: ");
            BookAuthor = Console.ReadLine();
            Console.Write(" Nhap Don Gia: ");
            BookPrice = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine(" MaSach: {0} | TenSach: {1} | TacGia: {2} | DonGia: {3} ", MaSach, TenSach, TacGia, DonGia);
        }
    }
}
