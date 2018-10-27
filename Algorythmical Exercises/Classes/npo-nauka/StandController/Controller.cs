using System;
using System.Collections.Generic;
using System.Text;

namespace StandController
{
    class Controller
    {
        public static List<double> allIndication = new List<double>();
        public static string VE_NP_RDStatus (string command)
        {            
            if (command == "on")
            {
                return "On";
            }
            else if (command == "off")
            {
                return "Off";
            }
            else
            {
                return "Error - wrong command";
            }
        }

        public static double PE_BPIndication(double indication, string direction, double limit)
        {
            double iteration = 5.5;
            if (direction == "decrease")
            {
                Console.WriteLine("Идет процесс...");
                while (indication > limit)
                {
                    indication -= iteration;
                    Console.Write(indication + ", ");
                    System.Threading.Thread.Sleep(500);
                }                
                return indication;
            }
            else
            {
                Console.WriteLine("Идет процесс...");
                while (indication < limit)
                {
                    indication += iteration;
                    Console.Write(indication + ", ");
                    System.Threading.Thread.Sleep(500);
                }                
                return indication;
            }
        }

        public static string ChangeStateGT (string state)
        {
            return state;
        }
        
        public static double MeasureGT (double indication, int counter)
        {
            Random rnd = new Random();          
            for (int i = 0; i < counter; i++)
            {
                double intIndication = rnd.Next(48, 50);
                double doubIndication = rnd.NextDouble();
                indication = Math.Round((intIndication + doubIndication), 2);
                allIndication.Add(indication);
                Console.Write((indication) + "; ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
            double sumIndication = 0.0;
            foreach (double n in allIndication)
            {
                sumIndication += n;
            }
            double indicationAvg = Math.Round((sumIndication / allIndication.Count),2);
            return indicationAvg;
        }
    }
}
