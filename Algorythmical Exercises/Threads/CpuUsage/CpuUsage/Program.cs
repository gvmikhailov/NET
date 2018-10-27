using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Management;

namespace CpuUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            int coreCount = 0;
            foreach (var item in new ManagementObjectSearcher("Select NumberOfLogicalProcessors from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfLogicalProcessors"].ToString());
            }
            while (true)
            {
                PerformanceCounter[] pc = new PerformanceCounter[coreCount];
                Parallel.For(0, coreCount, i =>
                {         
                    Thread.Sleep(1000);
                    pc[i] = new PerformanceCounter("Processor", "% Processor Time", i.ToString());
                    pc[i].NextValue();
                    Thread.Sleep(1000);  
                });
                for (int i = 0; i < pc.Length; i++)
                {
                    Console.WriteLine($"Processor {i} usage = " + pc[i].NextValue() + "%");
                }

                PerformanceCounter total = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                total.NextValue();
                Thread.Sleep(1000);
                Console.WriteLine("Total Processor usage = " + total.NextValue() + " %");

                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
