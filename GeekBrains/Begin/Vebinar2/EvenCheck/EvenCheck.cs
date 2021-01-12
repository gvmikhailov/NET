using System;

namespace Even
{
    public class EvenCheck
    {
        public static void Main(string[] args)
        {
            int number;
            if (Int32.TryParse(args[0], out number) == true)
            {
                if(number%2 == 0)                
                    Console.WriteLine($"Введенное число {number} является четным");
                else
                    Console.WriteLine($"Введенное число {number} является нечетным");
            }
            else
            {
                Console.WriteLine("Введенное число не является целым числом!");
            }
        }
    }
}
