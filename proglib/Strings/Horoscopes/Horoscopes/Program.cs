using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscopes
{
    class Program
    {
        static Dictionary<string, string> signsOfTheZodiac = new Dictionary<string, string>
        { 
            ["Овен"] = "aries",
            ["Телец"] = "taurus",
            ["Близнецы"] = "gemini",
            ["Рак"] = "cancer",
            ["Лев"] = "leo",
            ["Дева"] = "virgo",
            ["Весы"] = "libra",
            ["Скорпион"] = "scorpio",
            ["Стрелец"] = "sagittarius",
            ["Козерог"] = "capricorn",
            ["Водолей"] = "aquarius",
            ["Рыбы"] = "pisces"
        };

        static void Main(string[] args)
        {
            Random rnd = new Random();
            string signOfTheZodiac = signsOfTheZodiac.ElementAt(rnd.Next(0, signsOfTheZodiac.Count)).Value;
            string signOfTheZodiacRus = signsOfTheZodiac.FirstOrDefault(x => x.Value == signOfTheZodiac).Key;
            Console.WriteLine("Гороскоп на сегодня для знака зодиака {0}:", signOfTheZodiacRus);
            HorFromUrl1(signOfTheZodiac);
            HorFromUrl2(signOfTheZodiac);
            HorFromUrl3(signOfTheZodiac);
        }

        static void HorFromUrl1(string signOfTheZodiac)
        {
            string url = String.Format("https://horo.mail.ru/prediction/{0}/today/", signOfTheZodiac);
            HtmlWeb horoscope = new HtmlWeb();
            HtmlDocument doc = horoscope.Load(url);
            string text1 = doc.DocumentNode.SelectNodes("/html/body/div[2]/div[4]/div[2]/div[4]/div/div/div/div[2]/div/div/div[2]/div[1]/div/div/p[1]")[0].InnerText;
            string text2 = doc.DocumentNode.SelectNodes("/html/body/div[2]/div[4]/div[2]/div[4]/div/div/div/div[2]/div/div/div[2]/div[1]/div/div/p[2]")[0].InnerText;
            Console.WriteLine(text1);
            Console.WriteLine(text2);
        }

        static void HorFromUrl2(string signOfTheZodiac)
        {
            string url = String.Format("https://www.elle.ru/astro/{0}/day/", signOfTheZodiac);
            HtmlWeb horoscope = new HtmlWeb();
            HtmlDocument doc = horoscope.Load(url);
            string text1 = doc.DocumentNode.SelectNodes("/html/body/div[2]/div[4]/div[1]/div[1]/div/div[2]/div/p")[0].InnerText;
            Console.WriteLine(text1);
        }

        static void HorFromUrl3(string signOfTheZodiac)
        {
            string url = String.Format("http://orakul.com/horoscope/astrologic/general/{0}/today.html", signOfTheZodiac);
            HtmlWeb horoscope = new HtmlWeb();
            HtmlDocument doc = horoscope.Load(url);
            string text1 = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[1]/div[1]/div[1]/div[2]/div[4]/p[1]")[0].InnerText;
            Console.WriteLine(text1.TrimStart());
        }
    }
}
