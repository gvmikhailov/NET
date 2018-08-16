using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int counter = 1;
            List<string> products = new List<string>() { "Хлеб Бородинский", "Мыло туалетное", "Спички балабановские", "Мука Настена", "Свинина тушеная", "Шоколад Аленка", "Крупа гречневая" };
            List<string> operations = new List<string>() { "Приемка товара", "Отпуск товара", "Списание товара", "Инвентаризация", "Запрос остатков" };

            Products prod1 = new Products(counter, products[0], 100);
            counter++;
            Products prod2 = new Products(counter, products[1], 100);
            counter++;
            Products prod3 = new Products(counter, products[2], 100);
            counter++;
            Products prod4 = new Products(counter, products[3], 100);
            counter++;
            Products prod5 = new Products(counter, products[4], 100);
            counter++;
            Products prod6 = new Products(counter, products[5], 100);
            counter++;
            Products prod7 = new Products(counter, products[6], 100);
            counter++;
            Store op7 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            Store op8 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            Store op9 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            Store op10 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            Store op11 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            Store op12 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            Store op13 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            op7.TakeOperation(prod1);
            op8.TakeOperation(prod2);
            op9.TakeOperation(prod3);
            op10.TakeOperation(prod4);
            op11.TakeOperation(prod5);
            op12.TakeOperation(prod6);
            op13.TakeOperation(prod7);

            Products prod8 = new Products(counter, products[rnd.Next(0, products.Count)], rnd.Next(1, 100));
            counter++;
            Store op1 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            op1.TakeOperation(prod8);

            Products prod9 = new Products(counter, products[rnd.Next(0, products.Count)], rnd.Next(1, 100));
            counter++;
            Store op2 = new Store(rnd.Next(1000, 9999), "Отпуск товара");
            op2.TakeOperation(prod9);

            Products prod10 = new Products(counter, products[rnd.Next(0, products.Count)], rnd.Next(1, 100));
            counter++;
            Store op3 = new Store(rnd.Next(1000, 9999), "Списание товара");
            op3.TakeOperation(prod10);

            Products prod11 = new Products(counter, products[rnd.Next(0, products.Count)], rnd.Next(1, 100));
            counter++;
            Store op4 = new Store(rnd.Next(1000, 9999), "Запрос остатков");
            op4.TakeOperation(prod11);

            Products prod12 = new Products(counter, "Вода минеральная Архыз", rnd.Next(1, 100));
            counter++;
            Store op5 = new Store(rnd.Next(1000, 9999), "Приемка товара");
            op5.TakeOperation(prod12);

            Store op6 = new Store(rnd.Next(1000, 9999), "Инвентаризация");
            op6.TakeInventarization();

            Logging.ShowLogging();
        }
    }
}
