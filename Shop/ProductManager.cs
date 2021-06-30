using System;
using System.Collections.Generic;

namespace Shop
{
    public class ProductManager
    {
        Dictionary<string, Product> _products = new Dictionary<string, Product>();

        public void AddProduct()
        {
            Console.WriteLine("Nhap id san pham");
            var productId = Console.ReadLine();
            Console.WriteLine("Nhap ten san pham");
            var name = Console.ReadLine();
            Console.WriteLine("Nhap gia san pham");
            var price = Convert.ToDouble(Console.ReadLine());
            _products.Add(productId, new Product
            {
                ProductID = productId,
                Name = name,
                Price = price
            });
        }

        public void ShowList()
        {
            if (_products.Count > 0)
            {
                foreach (var key in _products.Keys)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}