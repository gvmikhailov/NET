using System;

namespace StandController
{
    class Program
    {
        static void Main(string[] args)
        {
            NP_VE_RD ve1 = new NP_VE_RD("VE1", "Off");
            ve1.SendPLC(ve1.Model, "on");
            NP_VE_RD ve2 = new NP_VE_RD("VE2", "Off");
            ve2.SendPLC(ve2.Model, "on");
            NP_VE_RD ve3 = new NP_VE_RD("VE3", "On");
            ve3.SendPLC(ve3.Model, "off");
            NP_VE_RD ve5 = new NP_VE_RD("VE5", "On");
            ve5.SendPLC(ve5.Model, "off");
            NP_VE_RD np1 = new NP_VE_RD("NP1", "On");
            np1.SendPLC(np1.Model, "on");
            PE_BP pe2 = new PE_BP("PE2", 99.9, "decrease",20);
            pe2.GetPLC(pe2.Model);
            Console.WriteLine("Камера-колпак KK1 откачана до предельного остаточного давления");          
            ve2.SendPLC(ve2.Model, "off");            
            np1.SendPLC(np1.Model, "off");
            pe2.Direction = "increase";
            pe2.Limit = 99.0;
            pe2.GetPLC(pe2.Model);
            ve3.SendPLC(ve3.Model, "on");
            GT gt = new GT("GT", "off", 0.0);
            gt.SendPLC(gt.Model, "diagn");
            gt.SendPLC(gt.Model, "on");
            gt.SendPLC(gt.Model, "measure");
            gt.GetPLC(gt.Model);
            NP_VE_RD ve6 = new NP_VE_RD("VE6", "On");
            ve6.SendPLC(ve6.Model, "off");
            PE_BP bp3 = new PE_BP("BP3", 99.9, "decrease", 15);
            bp3.GetPLC(bp3.Model);
            NP_VE_RD ve10 = new NP_VE_RD("VE10", "Off");
            NP_VE_RD ve11 = new NP_VE_RD("VE11", "On");
            if (ve10.SendPLC(ve10.Model, "on") == 1)
            {
                Console.WriteLine("Включен в работу газовый балон Б1 (рабочий)");
            }
            else
            {
                ve11.SendPLC(ve11.Model, "on");
                Console.WriteLine("Включен в работу газовый балон Б2 (резервный)");
            }                
            NP_VE_RD ve8 = new NP_VE_RD("VE8", "Off");
            ve8.SendPLC(ve8.Model, "on");
            NP_VE_RD rd1 = new NP_VE_RD("RD1", "Off");
            rd1.SendPLC(rd1.Model, "on");            
            Console.WriteLine("Идет измерение потока гелия в течение 30 секунд:");
            gt.GetPLC(gt.Model);
            var protokol = Controller.allIndication;
            ve8.SendPLC(ve8.Model, "off");
            ve6.SendPLC(ve6.Model, "on");
            rd1.SendPLC(rd1.Model, "off");
            gt.SendPLC(gt.Model, "on");
            ve1.SendPLC(ve1.Model, "off");
            pe2.Indication = 0.1;
            pe2.Limit = 100;
            pe2.Direction = "increase";
            pe2.GetPLC(pe2.Model);
            ve5.SendPLC(ve5.Model, "on");
        }
    }
}
