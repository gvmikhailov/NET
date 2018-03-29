using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/34/2013_11_16_abstraktnye_klassy_metody_i_svojstva_v_si-sharp.html

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Human russian = new Russian("Ivan");
            Human englishman = new Englishman("John");
            Human hawaiian = new Hawaiian("AAlona");
            hawaiian.SayHello();
            russian.SayHello();
            englishman.SayHello();
        }
    }
}
