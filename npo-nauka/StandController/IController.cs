using System;
using System.Collections.Generic;
using System.Text;

namespace StandController
{
    interface IController
    {
        string Model { get; set; }
        int SendPLC(string device, string command);
        double GetPLC(string device);
    }
}
