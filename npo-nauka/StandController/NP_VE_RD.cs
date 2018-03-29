using System;
using System.Collections.Generic;
using System.Text;

namespace StandController
{
    class NP_VE_RD : IController
    {
        public string Model { get; set; }
        public string Status { get; set; }

        public NP_VE_RD (string model, string status)
        {
            Model = model;
            Status = status;
        }

        public int SendPLC(string device, string command)
        {
            try
            { 
            Status = Controller.VE_NP_RDStatus(command);
            
                Console.WriteLine($"Статус устройства {Model} - {Status}");
                return 1;            
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: невозможно соедениться с контроллером:" + e.ToString());
                return -1;
            }
        }

        public double GetPLC(string device)
        {
            return 1;
        }
    }
}
