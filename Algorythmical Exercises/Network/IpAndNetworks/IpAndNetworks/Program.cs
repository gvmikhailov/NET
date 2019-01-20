using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Программа для поиска вхождения списка адресов в список сетей. На выходе в консоль отдается список сетей, в которые входят адреса.
// Написана для периодичекого мониторинга заблокированных ip Роскомнадзором в сетях облака Амазон.

namespace IpAndNetworks
{
    class Program
    {

        static List<string> addresses = new List<string>();
        static List<string> networks = new List<string>();
        static List<string> resultNt = new List<string>();
        static string pathAddr = @"D:\gm\SharpOld\dump.txt";
        static string pathNet = @"D:\gm\SharpOld\Networks.txt";
        static string log = @"D:\gm\SharpOld\Log.txt";

        static void Main(string[] args)
        {
            AddAllAddresses();
            var readyAddresses = addresses.Distinct();
            AddNetworks();
            foreach(string address in readyAddresses)
            {
                resultNt.Add(ReturnNetwork(address));
            }
            var rasultNets = resultNt.Distinct();
            foreach(string result in rasultNets)
            {
                if(result != string.Empty)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    continue;
                }
            }
        }

        public static string ReturnNetwork(string ip)
        {
            try
            {
                IPAddress incomingIp = IPAddress.Parse(ip);
                foreach (var subnet in networks)
                {
                    IPNetwork network = IPNetwork.Parse(subnet);

                    if (network.Contains(incomingIp))
                    {
                        return subnet;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(log, true))
                {
                    while (ex != null)
                    {
                        writer.WriteLine("Message : " + ex.Message + "ip address: " + ip);
                        ex = ex.InnerException;
                    }
                }
            }            
            return string.Empty;
        }

        public static void AddAllAddresses()
        {
            try
            {
                using (StreamReader sr = new StreamReader(pathAddr, Encoding.Default))
                {
                    string line;
                    Regex ip = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
                    string pattern = @"[^0-9\./]";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string [] ipArray = line.Split(' ');
                        for (int i = 0; i < ipArray.Length; i++)
                        {
                            if(ip.Match(ipArray[i]).Success)
                            {
                                string replaced = Regex.Replace(ipArray[i], pattern, string.Empty);
                                addresses.Add(replaced);
                            }
                            else
                            {
                                continue;
                            }
                        }                        
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddNetworks()
        {
            try
            {
                using (StreamReader sr = new StreamReader(pathNet, Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        networks.Add(line);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
