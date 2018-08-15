using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    class Book : Printing
    {
		private int _pageCount;
		
		public string Subject { get; set; }
		public string Author { get; set; }
		public int PageCount
		{
			get
			{
				return _pageCount;
			}
			set
			{
				if (value < 1)
				{
					_pageCount = 20;
					Console.WriteLine("Страниц не может быть меньше 1, установлено значение 20");
				}
				else if (value > 3604)
				{
					_pageCount = 1000;
					Console.WriteLine("Самая большая книга - 3604 страницы, установлено значение 1000");
				}
				else
				{
					_pageCount = value;
				}
			}
		}
		
		internal Book (string publishHouse, int yearOfPrint, string title, string author, string subject, int pageCount) : base(publishHouse, yearOfPrint, title)
		{
			Subject = subject;
			Author = author;
			PageCount = pageCount;
		}
		
		internal override void GetInfo()
        {
			base.GetInfo();
            Console.WriteLine("Книга {0} автора {1} из {2} страниц", Subject, Author, PageCount);
        }
	}
}