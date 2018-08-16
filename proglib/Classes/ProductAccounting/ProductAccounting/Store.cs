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
                    TakeAcceptanceOrDeliveryOrWriteOff(prod.ProductName, prod.Quantity, Operation, OperationId);
                    break;
                }
                case ("Отпуск товара"): 
                {
                    TakeAcceptanceOrDeliveryOrWriteOff(prod.ProductName, -prod.Quantity, Operation, OperationId);
                    break;
                }
                case ("Списание товара"):
                    {
                        TakeAcceptanceOrDeliveryOrWriteOff(prod.ProductName, -prod.Quantity, Operation, OperationId);
                        break;
                    }
                case ("Запрос остатков"):
                {
                    GetProductBalance(prod.ProductName, OperationId);
                    break;
                }
            }
        }

        private static void TakeAcceptanceOrDeliveryOrWriteOff(string product, int quantity, string operation, int operationId)
        {
            if (products.ContainsKey(product))
            {
                int temp = products[product] + quantity;
                if (temp < 0)
                {
                    Console.WriteLine("Невозможно выполнить операцию {0} - возникает отрицательный остаток по товару", operation);
                    Logging.log.Add(new Logging(operationId, product, quantity, operation, "Error", "Возникает отрицательный остаток по товару"));
                    Console.WriteLine();
                }
                else
                {
                    products[product] += quantity;
                    Console.WriteLine("Операция {0} - выполнена успешно", operation);
                    Logging.log.Add(new Logging(operationId, product, quantity, operation, "ОК", "Операция выполена успешно"));
                    Console.WriteLine();
                }
            }
            else
            {
                if (quantity < 0)
                {
                    Logging.log.Add(new Logging(operationId, product, quantity, operation, "Error", "Возникает отрицательный остаток по товару"));
                    Console.WriteLine("Невозможно выполнить операцию {0} - возникает отрицательный остаток по товару", operation);
                }
                else
                {
                    products.Add(product, quantity);
                    Console.WriteLine("Операция {0} - выполнена успешно", operation);
                    Logging.log.Add(new Logging(operationId, product, quantity, operation, "ОК", "Операция выполена успешно"));
                    Console.WriteLine();
                }
            }
        }

        private static void GetProductBalance(string product, int operationId)
        {
            if (products.ContainsKey(product))
            {
                Console.WriteLine("Остаток на складе продукта {0} - {1}", product, products[product]);
                Logging.log.Add(new Logging(operationId, product, products[product], "Запрос остатков", "ОК", "Операция выполена успешно"));
                Console.WriteLine();
            }
            else
            {
                Logging.log.Add(new Logging(operationId, product, products[product], "Запрос остатков", "ОК", "Запрошенного продукта нет на складе"));
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
            Logging.log.Add(new Logging(OperationId, "Инвентаризация", "ОК", "Инвентаризация проведена успешно"));
        }
    }
}
