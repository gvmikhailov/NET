using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace StandController
{
    class PE_BP : IController
    {
        private double _indication;

        public string Model { get; set; }
        public string Direction { get; set; }
        public double Limit { get; set; }

        public double Indication
        {
            get
            {
                return _indication;
            }
            set
            {
                if(value < 0)
                {
                    _indication = 0;
                }
                else if (value > 99.9)
                {
                    _indication = 99.9;
                }
                else
                {
                    _indication = value;
                }
            }
        }

        public PE_BP(string model, double indication, string direction, double limit)
        {
            Model = model;            
            Indication = indication;
            Direction = direction;
            Limit = limit;
        }

        public int SendPLC(string device, string command)
        {
            return 1;
        }

        public double GetPLC(string device)
        {
            try
            {
                Indication = Controller.PE_BPIndication(Indication, Direction, Limit);
                Console.WriteLine($"Показания {device} - {Indication}");
                return 1;
            }    
            catch (Exception e)
            {
                Console.WriteLine("ERROR: невозможно соедениться с контроллером:" + e.ToString());
                return -1;
            }  
        }
    }
}
