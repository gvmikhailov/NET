﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StandController 
{
    class GT : IController
    {
        private double _indication;

        public string Model { get; set; }
        public string State { get; set; }
        public double Indication
        {
            get
            {
                return _indication;
            }
            set
            {
                if (value < 0)
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

        public GT(string model, string state, double indication)
        {
            Model = model;
            State = state;
            Indication = indication;
        }

        public int SendPLC(string device, string command)
        {
            try
            {
                State = Controller.ChangeStateGT(command);
                Console.WriteLine($"Статус устройства {Model} - {State}");
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
            try
            {
                Indication = Controller.MeasureGT(Indication, 30);
                Console.WriteLine($"Среднее показание {device} - {Indication}");
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
