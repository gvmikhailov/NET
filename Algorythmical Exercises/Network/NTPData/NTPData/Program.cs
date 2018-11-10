using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NTPData
{
    class Program
    {
        static void Main(string[] args)
        {
            string ntpServer = "time.windows.com";
            DateTime ntpTime = GetNetworkTime(ntpServer);
            if(ntpTime == DateTime.MinValue)
            {
                Console.WriteLine("Не удалось соедениться с сервером времени, или такого сервера не существует");
            }
            else
            {
                Console.WriteLine(ntpTime);
            }            
        }

        static DateTime GetNetworkTime(string ntpServer)
        {
            try
            {
                IPAddress[] address = Dns.GetHostEntry(ntpServer).AddressList;
                IPEndPoint ep = new IPEndPoint(address[0], 123);
                return GetNetworkTime(ep);
            }
            catch
            {
                Console.WriteLine("Невозможно преобразовать в ip адрес имя " + ntpServer);
                DateTime error = DateTime.MinValue;
                return error;
            }            
        }

        static DateTime GetNetworkTime(IPEndPoint ep)
        {
            try
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                s.Connect(ep);
                byte[] ntpData = new byte[48];
                ntpData[0] = 0x1B;
                for (int i = 1; i < 48; i++)
                {
                    ntpData[i] = 0;
                }
                s.Send(ntpData);
                s.Receive(ntpData);
                byte offsetTransmitTime = 40;
                ulong intpart = 0;
                ulong fractpart = 0;
                for (int i = 0; i <= 3; i++)
                {
                    intpart = 256 * intpart + ntpData[offsetTransmitTime + i];
                }                   
                for (int i = 4; i <= 7; i++)
                {
                    fractpart = 256 * fractpart + ntpData[offsetTransmitTime + i];
                }                    
                ulong milliseconds = (intpart * 1000 + (fractpart * 1000) / 0x100000000L);
                s.Close();
                TimeSpan timeSpan = TimeSpan.FromTicks((long)milliseconds * TimeSpan.TicksPerMillisecond);
                DateTime dateTime = new DateTime(1900, 1, 1);
                dateTime += timeSpan;
                TimeSpan offsetAmount = TimeZone.CurrentTimeZone.GetUtcOffset(dateTime);
                DateTime networkDateTime = (dateTime + offsetAmount);
                return networkDateTime;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                DateTime error = DateTime.MinValue;
                return error;
            }
        }
    }
}
