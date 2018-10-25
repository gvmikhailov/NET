using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortScanner
{
    class Port
    {
        internal static readonly List<Port> ports = new List<Port>();

        public string ProtoType { get; set; }
        public int IpPort { get; set; }
        public string Answer { get; set; }
        public string State { get; set; }
        
        internal Port (string protoType, int port, string state, string answer)
        {
            ProtoType = protoType;
            IpPort = port;
            Answer = answer;
            State = state;
            ports.Add(this);
        }
    }
}
