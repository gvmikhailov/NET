using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    class Program
    {
        internal static Random rnd = new Random();
        static void Main(string[] args)
        {
            Dictionary<string, string> plants = new Dictionary<string, string>()
            {
                { "Ambrosia", "Asteraceae" },
                { "Baobab", "Malvaceae"},
                { "Cabbage", "Brassicaceae"},
                { "Dindle", "Asteraceae" },
                { "Eucalyptus", "Myrtaceae" }
            };

            List<string> roses = new List<string>() { "Baby rose", "Dwarf wild rose", "Low rose", "Prairie rose" };
            List<string> rosesColour = new List<string>() { "Синий", "Желтый", "Розовый", "Черный", "Розовый" };

            string plantKey = plants.Keys.ElementAt(rnd.Next(0, plants.Count));
            string plantValue = plants[plantKey];
            int treeAge = rnd.Next(-10, 200);
            double flowerHeight = Math.Round(rnd.Next(-5, 11) + rnd.NextDouble(), 2);
            string roseName = roses[rnd.Next(0, roses.Count)];
            string roseColour = rosesColour[rnd.Next(0, rosesColour.Count)];

            Plant plant1 = new Plant(plantKey, plantValue);
            plant1.PrintPlantInfo();

            Tree plant2 = new Tree(plantKey, plantValue, treeAge);
            plant2.PrintPlantInfo();

            Flower plant3 = new Flower(plantKey, plantValue, flowerHeight);
            plant3.PrintPlantInfo();

            Rose plant4 = new Rose(roseName, "Rosa virginiana", flowerHeight, roseColour);
            plant4.PrintPlantInfo();
        }
    }
}
