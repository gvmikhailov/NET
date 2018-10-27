using System;
using System.Collections.Generic;
using System.Linq;	
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rnd = new Random();
			List<string> publishHouse = new List<string>() {"Аврора", "АСТ", "Вузовская книга", "Диалектика", "Логос", "Познание"};
            List<string> titles = new List<string>() { "Книга", "Журнал", "Учебник" };
            Dictionary<string,string> books = new Dictionary<string,string>() { 
			["Война и мир"] = "Л.Н. Толстой", 
			["Преступление и наказание"] = "Ф.М. Достоевский", 
			["Отцы и дети"] = "И.С. Тургенев", 
			["Двенадцать стульев"] = "Илья Ильф и Евгений Петров", 
			["Мастер и Маргарита"] = "М.А. Булгаков"};
			List<string> subjects = new List<string>() { "Детектив", "Приключения", "Драма", "Фантастика"};
            List<string> magazines = new List<string>() { "PlayBoy", "Крокодил", "Мурзилка", "Вертикальный мир", "Cosmopolitan" };
			List<string> textbooksAuthors = new List<string>() { "И.И. Иванов", "П.П. Петров", "С.С. Сидоров", "Г.В. Михайлов", "С.С. Собянин" };
            Dictionary<string,string> textbooks = new Dictionary<string,string> () { 
			["Курс Термодинамики"] = "Изучение курса термодинамики", 
			["Курс Физики"] = "Изучение курса физики", 
			["Родная Литература"] = "Изучение литературы в старшей школе", 
			["Мировая Экономика"] = "Учебник для технических специальностей", 
			["Learning English"] = "Курс английского языка уровня Beginner"};
			int counterBook = rnd.Next(0, books.Count);
			int counterTextBook = rnd.Next(0, textbooks.Count);
			
			Printing printing1 = new Printing(publishHouse[rnd.Next(0, publishHouse.Count)], rnd.Next(1400, 2023), titles[rnd.Next(0, titles.Count)]);
			printing1.GetInfo();
			
			Magazine magazine1 = new Magazine(publishHouse[rnd.Next(0, publishHouse.Count)], rnd.Next(1400, 2023), "Журнал", magazines[rnd.Next(0, magazines.Count)], rnd.Next(1, 13));
			magazine1.GetInfo();
			
			Book book1 = new Book(publishHouse[rnd.Next(0, publishHouse.Count)], rnd.Next(1400, 2023), "Книга", books.ElementAt(counterBook).Value, subjects[rnd.Next(0, subjects.Count)], rnd.Next(-100, 10000));
			book1.GetInfo();
        
			Textbook textbook1 = new Textbook(publishHouse[rnd.Next(0, publishHouse.Count)], rnd.Next(1400, 2023), "Учебник", textbooksAuthors[rnd.Next(0, textbooksAuthors.Count)], "Научное издание", rnd.Next(-100, 10000), textbooks.ElementAt(counterTextBook).Value);
			textbook1.GetInfo();
        }
    }
}
