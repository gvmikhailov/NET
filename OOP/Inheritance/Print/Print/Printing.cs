using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    class Printing
    {
        private int _yearOfPrint;

        public string PublishingHouse { get; set; }
        public string Title { get; set; }
        public int YearOfPrint
        {
            get
            {
                return _yearOfPrint;
            }
            set
            {
                if(value < 1564)
                {
                    Console.WriteLine("Первая печатная книга была напечатана в 1564!");
                    _yearOfPrint = 1564;
                }
                else if (value > DateTime.Now.Year)
                {
                    Console.WriteLine("Год выпуска не может быть больше текущего!");
                    _yearOfPrint = DateTime.Now.Year;
                }
                else
                {
                    _yearOfPrint = value;
                }
            }
        }

        internal Printing(string publishHouse, int yearOfPrint, string title)
        {
            PublishingHouse = publishHouse;
            YearOfPrint = yearOfPrint;
            Title = title;
        }

        internal virtual void GetInfo()
        {
            Console.WriteLine("Печатное издание {0} издательства {1} выпущено в {2} году", Title, PublishingHouse, YearOfPrint);
        }
    }
}
