using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://acm.timus.ru/problem.aspx?space=1&num=1585

namespace NumberOfPinguins
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberOfStrings = rnd.Next(1,101);            
            string[] penguinTitle = { "Emperor Penguin", "Little Penguin", "Macaroni Penguin" };
            List<string> penguinList = new List<string>();
            for (int i = 0; i < numberOfStrings; i++)
            {
                int mIndex = rnd.Next(0, penguinTitle.Length);
                penguinList.Add(penguinTitle[mIndex]);
                Console.Write(penguinList[i] + "; ");
            }
            Console.WriteLine();
            MaxPinguins(penguinList);
        }
        static void MaxPinguins(List<string> penguinList)
        {
            int EmperorPenguin = 0;
            int MacaroniPenguin = 0;
            int LittlePenguin = 0;
            foreach (string item in penguinList)
            {
                if (item == "Emperor Penguin")
                {
                    EmperorPenguin++;
                }
                if (item == "Little Penguin")
                {
                    LittlePenguin++;
                }
                if (item == "Macaroni Penguin")
                {
                    MacaroniPenguin++;
                }
            }
            int maxValue = EmperorPenguin;
            string maxValueTitle = "Emperor Penguin";
            if (LittlePenguin > maxValue && LittlePenguin > MacaroniPenguin)
            {
                maxValue = LittlePenguin;
                maxValueTitle = "Little Penguin";
            }
            else if (MacaroniPenguin > maxValue && MacaroniPenguin > LittlePenguin)
            {
                maxValue = MacaroniPenguin;
                maxValueTitle = "Macaroni Penguin";
            }
            Console.WriteLine("Наибольшее колличество - " + maxValue + " " + maxValueTitle);
        }
    }
}
