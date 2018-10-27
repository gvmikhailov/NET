using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/11/2013_04_25_cikly_v_si-sharp_operatory_break_i_continue.html

namespace Cycle2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = string.Empty;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
                if (password == "root")
                {
                    break;
                }
                Console.WriteLine("Вы ввели неправильный пароль!");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Ура!, вы ввели правильный пароль!");
        }
    }
}
