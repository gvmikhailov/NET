using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurningGrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] turningMatrix = {
                { "X", ".", ".", "." },
                { ".", ".", ".", "." },
                { ".", "X", ".", "X" },
                { ".", ".", "X", "." }
            };
            string[,] passwordMatrix = {
                { "a", "i", "m", "e" },
                { "j", "f", "k", "n" },
                { "g", "b", "o", "c" },
                { "p", "h", "d", "l" }
            };
            List<string> password = new List<string>();
            Program start = new Program();
            start.StartMartix(turningMatrix, passwordMatrix, password);
            start.TurnMartix(ref turningMatrix);
            Console.WriteLine();
            start.StartMartix(turningMatrix, passwordMatrix, password);
            start.TurnMartix(ref turningMatrix);
            Console.WriteLine();
            start.StartMartix(turningMatrix, passwordMatrix, password);
            start.TurnMartix(ref turningMatrix);
            Console.WriteLine();
            start.StartMartix(turningMatrix, passwordMatrix, password);
            foreach (string letters in password)
            {
                Console.Write(letters);
            }
            Console.WriteLine();
        }
        public List<string> StartMartix(string[,] turningMatrix, string[,] passwordMatrix, List<string> password)
        { 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (turningMatrix[i, j] == "X")
                    {
                        password.Add(passwordMatrix[i, j]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return password;
        }
        public string[,] TurnMartix(ref string[,] turningMatrix)
        {
            int i;
            int j;
            int k;
            int l;
            string[,] intermediateMartix = new string[4, 4];
            for (j = 0, k=0; (j < turningMatrix.GetLength(1) && k < 4); j++, k++)
            {
                for (i = turningMatrix.GetLength(0) - 1, l = 0; (i >= 0 && l < 4); i--, l++)
                {
                    intermediateMartix[k, l] = turningMatrix[i, j];
                    Console.Write(intermediateMartix[k, l]);
                }
                Console.WriteLine();
            }
            turningMatrix = intermediateMartix;
            return turningMatrix;
        }
    }
}
