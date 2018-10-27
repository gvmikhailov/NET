using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PortScanner
{
    class Program
    {
        public static string ipAddress;

        static void Main(string[] args)
        {
            int startPort = 0;
            int endPort = 0;
            string proto = string.Empty;
            if (args.Length == 0 || args[0] == "\\?")
            {
                Console.Clear();
                PrintHelp();
                Environment.Exit(0);
            }
            if (args.Length < 6)
            {
                Console.Clear();
                Console.WriteLine("Указаны не все обязательные аргументы");
                PrintHelp();
                Environment.Exit(0);
            }
            if ((args.Contains("\\a") && args.Contains("\\p") && args.Contains("\\u")) || (args.Contains("\\a") && args.Contains("\\r") && args.Contains("\\u")))
            {
                int indexA = Array.IndexOf(args, "\\a");
                ipAddress = args[indexA + 1];
                int indexR = Array.IndexOf(args, "\\r");
                string range = args[indexR + 1];
                string[] ports = range.Split(new char[] { '-' });
                int indexP = Array.IndexOf(args, "\\p");
                int indexU = Array.IndexOf(args, "\\u");
                proto = args[indexU + 1];

                try
                {
                    int tempStartPort = 0;
                    int tempEndPort = 0;
                    bool isRangeInt = (int.TryParse(ports[0], out tempStartPort) && int.TryParse(ports[1], out tempEndPort));
                    bool isInt = int.TryParse(args[indexP + 1], out startPort);
                    if (isInt == true && args.Contains("\\p") && args.Contains("\\u") && args.Contains("\\a"))
                    {
                        endPort = startPort;
                    }
                    else if(isRangeInt == true && args.Contains("\\r") && args.Contains("\\u") && args.Contains("\\a"))
                    {
                        startPort = tempStartPort;
                        endPort = tempEndPort;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Порт не может быть не числовым значением");
                        PrintHelp();
                        Environment.Exit(0);
                    }

                    if (proto != "TCP" && proto != "UDP" && proto != "BOTH")
                    {
                        Console.Clear();
                        Console.WriteLine("Неверно задан тип протокола!");
                        PrintHelp();                        
                        Environment.Exit(0);
                    }

                    if (endPort < startPort)
                    {
                        Console.Clear();
                        Console.WriteLine("Начальный порт не может быть больше конечного!");
                        PrintHelp();
                        Environment.Exit(0);
                    }

                    if(startPort < 0 || startPort > 65535 || endPort < 0 || endPort > 65535)
                    {
                        Console.Clear();
                        Console.WriteLine("Порт должен быть в интервале от 0 до 65535");
                        PrintHelp();
                        Environment.Exit(0);
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    PrintHelp();
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.Clear();
                PrintHelp();
                Environment.Exit(0);
            }
            
            if (proto == "TCP")
            {
                Parallel.For(startPort, endPort + 1, ScanTCP);
            }
            else if (proto == "UDP")
            {
                Parallel.For(startPort, endPort + 1, ScanUDP);
            }
            else
            {
                Parallel.For(startPort, endPort + 1, ScanUDP);
                Parallel.For(startPort, endPort + 1, ScanTCP);
            }

            int counter = proto == "BOTH"? ((endPort - startPort) + 1) *2 : ((endPort - startPort) + 1);
            while (Port.ports.Count < counter)
            {
                Thread.Sleep(1000);
            }
            var result = Port.ports.OrderBy(i => i.ProtoType).ThenBy(i => i.IpPort);
            Console.Clear();
            Console.WriteLine("Результат сканирования: ");
            foreach (var res in result)
            {
                Console.WriteLine($"{res.ProtoType} {res.IpPort} {res.State} - {res.Answer}");
            }
        }

        static void ScanTCP(int port)
        {            
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);                
                socket.Connect(ipPoint);
                if (socket.Connected)
                {
                    new Port("TCP", port, "Порт открыт", "Connect OK");
                }
                socket.Close();
            }
            catch (SocketException ex)
            {
                new Port("TCP", port, "Порт закрыт", ex.SocketErrorCode.ToString());
                socket.Close();
            }
            catch (Exception ex)
            {                
                Console.Clear();
                Console.WriteLine(ex.Message);
                PrintHelp();
                socket.Close();
            }
        }    

        static void ScanUDP(int port)
        {
            UdpClient client = new UdpClient();            
            Socket socket = client.Client;            
            socket.ReceiveTimeout = 5000;
            try
            {
                IPAddress ipAddr = IPAddress.Parse(ipAddress);
                IPEndPoint ip = new IPEndPoint(ipAddr, 0);
                client.Connect(ipAddress, port);
                string message = "R U Open?";
                byte[] dataSend = Encoding.ASCII.GetBytes(message);
                client.Send(dataSend, dataSend.Length);
                byte[] answerData = client.Receive(ref ip);
                string answer = Encoding.ASCII.GetString(answerData);
                new Port("UDP", port, "Порт открыт", "Connect OK");
                client.Close();
            }
            catch (SocketException ex)
            {
                new Port("UDP", port, "Порт закрыт", ex.SocketErrorCode.ToString());                
                client.Close();
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                PrintHelp();
                client.Close();
            }
        }

        static void PrintHelp()
        {
            Console.WriteLine("\nИСПОЛЬЗОВАНИЕ:\n\tPortScanner.exe \\? | {\\a IP Address IPv4}  {\\p Port | \\r Port Range} {\\u Protocol Type}\nЗдесь:\n\tIP Address IPv4 - Адрес узла IPv4 порты которого необходимо просканировать\n\tPort - Одиночный порт, который необходимо просканировать\n\tPort Range - Диапазон портов, который необходимо просканировать\n\tProtocol Type - тип протокола{TCP | UDP | BOTH}\n\n\tПараметры:\n\t\t\\? - Вывод данного справочного сообщения\nПРИМЕРЫ:\n\tPortScanner.exe \\a 192.168.0.1 \\p 25 \\u TCP\n\tPortScanner.exe \\a 192.168.0.5 \\r 158-160 \\u UDP\n\tPortScanner.exe \\a 192.168.0.10 \\r 21 \\u BOTH");
        }
    }
}
