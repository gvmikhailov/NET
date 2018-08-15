using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccounting
{
    class Products
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Counter { get; set; }

        internal Products(int counter, string productName, int quantity)
        {
            Counter = counter;
            ProductName = productName;
            Quantity = quantity;
        }

        internal void GetInfo()
        {
            Console.WriteLine("Информация о продукте {0}:\nНаименование: {1}\nКоличество: {2}", Counter, ProductName, Quantity);
        }
    }
}
