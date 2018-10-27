using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Дается n точек в метрическом пространстве, найти пару точек, расстояние между которыми наименьшее

namespace ShortestPointsDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numbersOfPoints = rnd.Next(5, 101);
            List<int> coordinateX = new List<int>();
            List<int> coordinateY = new List<int>();
            List<int> coordinateZ = new List<int>();
            for (int i = 0; i < numbersOfPoints; i++)
            {
                coordinateX.Add(rnd.Next(-100, 101));
                coordinateY.Add(rnd.Next(-100, 101));
                coordinateZ.Add(rnd.Next(-100, 101));
            }
            GetPoints(coordinateX, coordinateY, coordinateZ);
        }

        static void GetPoints(List<int> coordinateX, List<int> coordinateY, List<int> coordinateZ)
        {
            Dictionary<string, double> distances = new Dictionary<string, double>();
            for (int j = 0; j < coordinateX.Count; j++)
            {
                for (int k = j+1; k < coordinateX.Count; k++)
                {
                    string key = (j + 1).ToString() + (k + 1).ToString();
                    double value = Math.Round(Math.Sqrt(Math.Pow((coordinateX[j] - coordinateX[k]), 2) + Math.Pow((coordinateY[j] - coordinateY[k]), 2) + Math.Pow((coordinateZ[j] - coordinateZ[k]), 2)), 2);
                    distances.Add(key, value);
                }
            }
            distances = distances.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            string pairPoints = distances.Keys.ElementAt(0);
            int point1 = (int)char.GetNumericValue(pairPoints[0]) - 1; 
            int point2 = (int)char.GetNumericValue(pairPoints[1]) - 1;
            Console.WriteLine("Кратчайшее расстояние между точками с координатами({0},{1},{2}) и ({3},{4},{5})", coordinateX[point1], coordinateY[point1], coordinateZ[point1], coordinateX[point2], coordinateY[point2], coordinateZ[point2]);
        }
    }
}
