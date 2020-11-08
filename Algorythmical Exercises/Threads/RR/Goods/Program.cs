using System;
using System.Linq;

namespace Goods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;
            string shopId = String.Empty;
            string url = String.Empty; // Использовал этот: http://static.ozone.ru/multimedia/yml/facet/business.xml
            if (args.ElementAtOrDefault(0) == null)
                Console.WriteLine("Не передано имя команды!");
            else
                command = args[0].ToLower();

            if (args.ElementAtOrDefault(1) == null && command == "save")
                Console.WriteLine("Нельзя сохранить данные о товарах без указания id магазина!");
            else
                shopId = args[1];

            if (args.ElementAtOrDefault(2) == null && command == "save")
                Console.WriteLine("Не передана ссылка на xml с товарами!");
            else
                url = args[2].ToLower();

            MainMethodAsync(command, shopId, url);
        }
    }
}
