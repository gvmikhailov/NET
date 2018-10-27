using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    class Magazine : Printing
    {
		private int _number;
		
		public string Name {get; set;}
		public int Number 
		{
			get
			{
				return _number;
			} 
			set
			{
				if(value < 1 || value > 12)
				{
					_number = 6;
				}
				else
				{
					_number = value;
				}
			}
		}
		
		internal Magazine (string publishHouse, int yearOfPrint, string title, string name, int number) : base(publishHouse, yearOfPrint, title)
		{
			Number = number;
			Name = name;
		}
		
		internal override void GetInfo()
        {
			base.GetInfo();
            Console.WriteLine("Журнал {0} номер {1}", Name, Number);
        }
	}
}
	