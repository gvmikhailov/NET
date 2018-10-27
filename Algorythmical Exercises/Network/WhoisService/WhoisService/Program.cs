using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WhoisService
{
    class Program
    {
        static void Main(string[] args)
        {
            string domain = string.Empty;
            if (args.Length != 1)
            {
                Console.Clear();
                Console.WriteLine("Неверно заданы аргументы");
                PrintHelp();
                Environment.Exit(0);
            }
            else if (args[0] == "?")
            {
                Console.Clear();
                PrintHelp();
                Environment.Exit(0);
            }
            else
            { 
                domain = args[0];
            }
            try
            {
                XmlDocument whois = new XmlDocument();
                whois.Load($"https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey=bt_9ijuKlcRDk1piWuvAD6fub0fse5fE&domainName={domain}");
                XmlElement xRoot = whois.DocumentElement;
                PrintInfo(xRoot, domain);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        static void PrintInfo(XmlElement item, string domain)
        {
            Console.Clear();
            Console.WriteLine("Информация по домену {0}:", domain);
            foreach (XmlNode childNode in item.ChildNodes)
            {
                if (childNode.Name == "registryData")
                {
                    foreach(XmlNode child in childNode.ChildNodes)
                    {
                        if (child.Name == "rawText")
                        {
                            Console.WriteLine(child.InnerText);
                        }                        
                    }
                }
            }
        }
        static void PrintHelp()
        {
            Console.WriteLine("ИСПОЛЬЗОВАНИЕ:\n\tWhoisService.exe  ? | Domain Name\n\tЗдесь:\n\tDomain Name - Имя домена, данные по которому необходимо получить\n\t? - Вывод данного справочного сообщения\nПРИМЕРЫ:\n\tWhoisService.exe ?\n\tWhoisService.exe microsoft.com");
        }
    }
}
