using System;
using System.Collections.Generic;

namespace Shop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Xin moi ban chon cac lua chon sau");
            Console.WriteLine("1: Them san pham moi.\n 2: Danh sach san pham. \n 3: Xoa san pham. \n 4: Thoat chuong trinh");
            // var product = new Product();

            int a = Convert.ToInt32(Console.ReadLine());
            ProductManager productManager = new ProductManager();
            switch (a)
            {
                case 1: productManager.AddProduct() ;
                    break;
            }
        }
        
    }
}