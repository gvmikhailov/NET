using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

// Расстояние между городами

namespace DistanceCities
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<string> cities = new List<string>() { "Лангепас", "Новосибирск", "Сургут", "Бангкок", "Улан-Батор", "Нью-Йорк", "Мельбурн", "Кимры", "Бердичев", "Юрмала", "Лондон", "Барселона",
                                                       "Пинск", "Рио-де-Жанейро", "Ла-Пас", "Кейптаун", "Адис-Абеба"};
            string city1 = cities[rnd.Next(0, cities.Count)];
            string city2 = cities[rnd.Next(0, cities.Count)];
            string urlCity1 = "http://search.maps.sputnik.ru/search/addr?q=" + city1;
            string urlCity2 = "http://search.maps.sputnik.ru/search/addr?q=" + city2;
            string answerCity1 = GetJSONFromApi(urlCity1);
            string answerCity2 = GetJSONFromApi(urlCity2);
            double latitudeCity1, longitudeCity1, latitudeCity2, longitudeCity2;
            GetCoordinates(answerCity1, out latitudeCity1, out longitudeCity1);
            GetCoordinates(answerCity2, out latitudeCity2, out longitudeCity2);
            Console.WriteLine("Широта - {0} и долгота - {1} города {2}", latitudeCity1, longitudeCity1, city1);
            Console.WriteLine("Широта - {0} и долгота - {1} города {2}", latitudeCity2, longitudeCity2, city2);
            double distance = GetDistance(latitudeCity1, latitudeCity2, longitudeCity1, longitudeCity2);
            Console.WriteLine("Расстояние между городами {0} и {1} {2} км.", city1, city2, distance);
        }

        static string GetJSONFromApi(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.Accept = "application/json";
            request.UserAgent = "Mozilla/5.0 ....";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder output = new StringBuilder();
            output.Append(reader.ReadToEnd());
            response.Close();
            return output.ToString();
        }

        static void GetCoordinates(string answer, out double latitude, out double longitude)
        {
            var myCoordinates = JObject.Parse(answer);
            latitude = (double)myCoordinates["result"]["viewport"]["TopLat"];
            longitude = (double)myCoordinates["result"]["viewport"]["BotLon"];
        }

        static double GetDistance(double la1, double la2, double lo1, double lo2)
        {
            double distance;
            double disRad;
            double la1Rad = (la1 * Math.PI) / 180;
            double la2Rad = (la2 * Math.PI) / 180;
            double lo1Rad = (lo1 * Math.PI) / 180;
            double lo2Rad = (lo2 * Math.PI) / 180;
            disRad = Math.Acos((Math.Sin(la1Rad) * Math.Sin(la2Rad)) + (Math.Cos(la1Rad) * Math.Cos(la2Rad) * Math.Cos(lo2Rad - lo1Rad)));
            distance = Math.Round(6371 * disRad, 3);
            return distance;
        }
    }
}
