using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using S22.Imap;

namespace IMAPConsoleMailChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                using (ImapClient client = new ImapClient("imap.yandex.ru", 993, "myMail@yandex.ru", "myPassword", AuthMethod.Login, true))
                {
                    while(true)
                    {
                        Console.Clear();
                        Console.WriteLine("Ждем новых писем...");                    
                        IEnumerable<uint> uids = client.Search(SearchCondition.Unseen());
                        if(uids.Count() > 0)
                        {
                            IEnumerable<MailMessage> messages = client.GetMessages(uids, FetchOptions.HeadersOnly);
                            Console.WriteLine("Получаем только заголовки...");
                            ReadMessage(messages);
                        }
                        else
                        { 
                            Thread.Sleep(60000);
                        }
                    }                                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ReadMessage(IEnumerable<MailMessage> mess)
        {            
            foreach (var mes in mess)
            {
                Console.WriteLine("От: {0}", mes.From);
                Console.WriteLine("Тема: {0}", mes.Subject);
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
