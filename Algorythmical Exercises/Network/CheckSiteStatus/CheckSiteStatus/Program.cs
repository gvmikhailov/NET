using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CheckSiteStatus
{
    class Program
    {
        public static string state = "OK";

        static void Main(string[] args)
        {
            while(true)
            {     
                int status = GetStatusCode();
                if (Regex.IsMatch(status.ToString(), "^2.."))
                {
                    Console.Clear();
                    Console.WriteLine("{0} All OK, Status - {1}", DateTime.Now, status);
                    Thread.Sleep(300000);
                }
                else if (Regex.IsMatch(status.ToString(), "^3.."))
                {
                    Console.Clear();
                    Console.WriteLine("{0} Warning, Status - {1}", DateTime.Now, status);
                    GetStatus();
                    if (state != "WARNING")
                    {
                        state = "WARNING";
                        SendMail(status);                        
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0} Critical, Status - {1}", DateTime.Now, status);
                    GetStatus();
                    if (state != "CRITICAL")
                    {
                        state = "CRITICAL";
                        SendMail(status);                        
                    }
                }
            }           
        }

        static void GetStatus()
        {
            for (int i = 0; i < 5; i++)
            {
                int status = GetStatusCode();
                if (Regex.IsMatch(status.ToString(), "^2.."))
                {
                    Console.Clear();
                    Console.WriteLine("All OK, Status - {0}", status);
                    state = "OK";
                    SendMail(status);                    
                    break;
                }
                else
                {
                    Thread.Sleep(60000);
                }
            }
        }

        static int GetStatusCode()
        {
            int status;
            try
            {
                HttpWebRequest requestToSite = (HttpWebRequest)WebRequest.Create("https://av.ru/");
                HttpWebResponse responseFromSite = (HttpWebResponse)requestToSite.GetResponse();
                status = (int)responseFromSite.StatusCode;
                responseFromSite.Close();
            }
            catch (Exception)
            {
                status = 900;
            }
            return status;                        
        }

        static void SendMail(int status)
        {
            try
            {
                MailAddress from = new MailAddress("myMail@yandex.ru", "Monitoring System");
                MailAddress to = new MailAddress("mayMail@gmail.com");
                MailMessage m = new MailMessage(from, to);
                m.Subject = state;
                m.Body = $"{DateTime.Now} {state} - {status}";
                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
                smtp.Credentials = new NetworkCredential("myMail@yandex.ru", "myPassword");
                smtp.EnableSsl = true;
                smtp.Send(m);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Не удалось отравить электронное сообщение об ошибке по следующей причине: {ex.Message}\nПроверьте настройки почтового клиента!\nПроверка продолжается");
                Thread.Sleep(60000);
            }            
        }
    }
}
