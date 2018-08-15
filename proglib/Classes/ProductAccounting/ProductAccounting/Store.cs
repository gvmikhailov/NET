using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccounting
{
    class Store
    {
        static Dictionary<string, int> products = new Dictionary<string, int>();

        public string Operation { get; set; }
        public int OperationId { get; set; }

        internal Store(int operationId, string operation)
        {
            Operation = operation;
            OperationId = operationId;
        }

        internal void TakeOperation(Products prod)
        {
            switch (Operation)
            {
                case ("Приемка товара"):
                {
                    TakeAcceptanceOrDeliveryOrWriteOff(prod.ProductName, prod.Quantity, Operation);
                    break;
                }
                case ("Отпуск товара"): 
                {
                    TakeAcceptanceOrDeliveryOrWriteOff(prod.ProductName, -prod.Quantity, Operation);
                    break;
                }
                case ("Списание товара"):
                    {
                        TakeAcceptanceOrDeliveryOrWriteOff(prod.ProductName, -prod.Quantity, Operation);
                        break;
                    }
                case ("Запрос остатков"):
                {
                    GetProductBalance(prod.ProductName);
                    break;
                }
            }
        }

        private static void TakeAcceptanceOrDeliveryOrWriteOff(string product, int quantity, string operation)
        {
            if (products.ContainsKey(product))
            {
                int temp = products[product] + quantity;
                if (temp < 0)
                {
                    Console.WriteLine("Невозможно выполнить операцию {0} - возникает отрицательный остаток по товару", operation);
                    Console.WriteLine();
                }
                else
                {
                    products[product] += quantity;
                    Console.WriteLine("Операция {0} - выполнена успешно", operation);
                    Console.WriteLine();
                }
            }
            else
            {
                if (quantity < 0)
                {
                    Console.WriteLine("Невозможно выполнить операцию {0} - возникает отрицательный остаток по товару", operation);
                }
                else
                {
                    products.Add(product, quantity);
                    Console.WriteLine("Операция {0} - выполнена успешно", operation);
                    Console.WriteLine();
                }
            }
        }

        private static void GetProductBalance(string product)
        {
            if (products.ContainsKey(product))
            {
                Console.WriteLine("Остаток на складе продукта {0} - {1}", product, products[product]);                
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Запрошенного продукта нет на складе");
                Console.WriteLine();
            }
        }

        internal void TakeInventarization()
        {
            Console.WriteLine("На данный момент всего продуктов на складе:");
            foreach (var m in products)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
        }
    }
}
