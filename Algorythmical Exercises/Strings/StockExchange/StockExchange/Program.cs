using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace StockExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllCompanies();
            Random rnd = new Random();
            int count = rnd.Next(8, 16);
            Console.WriteLine("Будем следить за котировками {0} случайных компаний", count);
            List<string> shortNames = new List<string>();
            Console.WriteLine("Список компаний: ");
            for (int i = 0; i < count; i++)
            {
                string company = Company.companies[rnd.Next(0, Company.companies.Count)].ShortName;
                string companyName = Company.companies[rnd.Next(0, Company.companies.Count)].FullName;
                shortNames.Add(company);                
                Console.WriteLine("{0,20}\t{1,50}",company,companyName);
                new Company(company, companyName, 0, 0, '\u2022');
            }
            Thread.Sleep(10000);

            while (true)
            {
                foreach (Company c in Company.selectedCompanies)
                {
                    c.LastOld = c.LastNew;
                }
                ParallelLoopResult result = Parallel.ForEach<string>(shortNames, GetQuotes);
                while (result.IsCompleted == false)
                {
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.WriteLine("{0,20}\t{1,50}\t{2,7}\t{3,6}\t", "Краткое наименование", "Полное наименование", "Курс", "Статус");
                foreach (Company c in Company.selectedCompanies)
                {                    
                    if (c.LastNew - c.LastOld > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0,20}\t{1,50}\t{2,7}\t",c.ShortName, c.FullName, c.LastNew);
                        c.Arrow = '\u2191';
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0,6}", c.Arrow);
                        Console.WriteLine();
                    }
                    if (c.LastNew - c.LastOld < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0,20}\t{1,50}\t{2,7}\t", c.ShortName, c.FullName, c.LastNew);
                        c.Arrow = '\u2193';
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,6}", c.Arrow);
                        Console.WriteLine();
                    }
                    if(c.LastNew - c.LastOld == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0,20}\t{1,50}\t{2,7}\t", c.ShortName, c.FullName, c.LastNew);
                        c.Arrow = '\u2194';
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("{0,6}", c.Arrow);
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Thread.Sleep(600000);
            }
        }

        static void GetQuotes(string cmp)
        {
            XmlDocument company = new XmlDocument();
            company.Load($"http://iss.moex.com/iss/engines/stock/markets/shares/boards/tqbr/securities.xml?securities={cmp}");
            XmlElement root = company.DocumentElement;
            foreach (XmlNode node in root)
            {
                XmlNode attr = node.Attributes.GetNamedItem("id");
                if (attr.Value == "marketdata")
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name == "rows")
                        {
                            XmlNode attribsRowSECLAST;
                            if (childNode.HasChildNodes == true)
                            {
                                foreach (XmlNode nextChildNode in childNode.ChildNodes)
                                {
                                    attribsRowSECLAST = nextChildNode.Attributes.GetNamedItem("LAST");
                                    if (String.IsNullOrEmpty(attribsRowSECLAST.Value))
                                    {
                                        attribsRowSECLAST.Value = "0";
                                    }
                                    foreach(Company cmpNew in Company.selectedCompanies)
                                    {
                                        if(cmpNew.ShortName == cmp)
                                        {
                                            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                                            cmpNew.LastNew = double.Parse(attribsRowSECLAST.Value, formatter);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                foreach (Company cmpNew in Company.companies)
                                {
                                    if (cmpNew.ShortName == cmp)
                                    {
                                        cmpNew.LastNew = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        static void GetAllCompanies()
        {
            XmlDocument company = new XmlDocument();
            company.Load("https://iss.moex.com/iss/engines/stock/markets/shares/securities.xml");
            XmlElement root = company.DocumentElement;
            foreach (XmlNode node in root)
            {
                XmlNode attr = node.Attributes.GetNamedItem("id");
                if (attr.Value == "securities")
                {
                    foreach(XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name == "rows")
                        {
                            foreach(XmlNode nextChildNode in childNode.ChildNodes)
                            { 
                                XmlNode attribsRowSECID = nextChildNode.Attributes.GetNamedItem("SECID");                                
                                XmlNode attribsRowSECNAME = nextChildNode.Attributes.GetNamedItem("SECNAME");
                                new Company(attribsRowSECID.Value, attribsRowSECNAME.Value);                                
                            }
                        }
                    }
                }
            }
        }
    }
}
