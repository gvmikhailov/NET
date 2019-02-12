using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Программа для поиска вхождения списка адресов в список сетей. На выходе в консоль отдается список сетей, в которые входят адреса.
// Написана для периодичекого мониторинга заблокированных ip Роскомнадзором в сетях Atlassian.

namespace IpAndNetworks
{
    class Program
    {

        static List<string> addresses = new List<string>();
        static List<string> networks = new List<string>();
        static List<string> resultAddr = new List<string>();
        static string pathAddr = @"D:\gm\SharpOld\dump.txt";
        static string pathNet = @"D:\gm\SharpOld\Networks.txt";
        static string log = @"D:\gm\SharpOld\Log.txt";
        static string adds = @"D:\gm\SharpOld\Addresses.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Let`s Start...");
            AddAllAddresses();
            var readyAddresses = addresses.Distinct();
            AddNetworks();
            foreach(string address in readyAddresses)
            {
                resultAddr.Add(ReturnNetwork(address));
            }
            List<string> resultAddrs = resultAddr.Distinct().ToList();
            var nets = AggregateNets(resultAddrs);

            using (StreamWriter writer = new StreamWriter(adds, true))
            {
                foreach (string result in nets)
                {
                    if (result != string.Empty)
                    {
                        writer.WriteLine(result);
                    }
                    else
                    {
                        continue;
                    }
                }               
            }
            Console.WriteLine("Finish");
            Console.ReadKey();
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
                        return ip;
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

        public static List<string> AggregateNets (List<string> addresses)
        {
            List<string> nets = new List<string>();
            Regex half = new Regex(@"\d{1,3}$");
            for (int i = 0; i < addresses.Count; i++)
            {
                string part = half.Replace(addresses[i], "");
                int counter = 0;
                for (int j = i; j < addresses.Count; j++)
                {
                    if (addresses[j].Contains(part))
                    {
                        counter += 1;
                    }
                    else
                    {
                        continue;
                    }
                }
                int cnt = 0;
                foreach (string prt in nets)
                {
                    if (prt.Contains(part))
                    {
                        cnt += 1;
                    }
                }
                if (counter >= 2 && cnt == 0)
                {
                    nets.Add(part + "0/24");
                }
                else if (counter < 2 && cnt == 0)
                {
                    nets.Add(addresses[i] + "/32");
                }
                else
                {
                    continue;
                }
            }
            return nets;
        }         
    }
}
