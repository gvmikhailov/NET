using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLast2
{
    class TClass<T>
    {
        public static void Print(IEnumerable<T> sequence)
        {
            foreach (T m in sequence)
            {
                Console.Write(m.ToString() + ", ");
            }
        }

        public static IEnumerable<T> FilterLast(IEnumerable<T> sequence, int n)
        {
            IEnumerable<T> output = new List<T>();
            foreach (T m in sequence)
            {
                if(output.Count() < sequence.Count() - n)
                {
                    output = output.Concat(new[] { m });
                }
                else
                {
                    break;
                }
            }

            return output;
        }
    }
}
