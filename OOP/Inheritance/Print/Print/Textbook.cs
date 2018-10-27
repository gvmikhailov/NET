using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    class Textbook : Book
    {
		public string Function { get; set; }
		
		internal Textbook(string publishHouse, int yearOfPrint, string title, string author, string subject, int pageCount, string function) : base(publishHouse, yearOfPrint, title, author, subject, pageCount)
		{
			Function = function;
		}
		
		internal override void GetInfo()
        {
			base.GetInfo();
            Console.WriteLine("Назначение - {0}", Function);
        }
	}
}