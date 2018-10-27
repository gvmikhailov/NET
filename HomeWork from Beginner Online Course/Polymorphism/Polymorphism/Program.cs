using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://mycsharp.ru/post/33/2013_10_19_virtualnye_metody_v_si-sharp_pereopredelenie_metodov.html

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int damage = rnd.Next(0, 101);
            int addedHealth = rnd.Next(10, 101);
            LightWarrior warrior2 = new LightWarrior("Zyama", 100, "Alive");
            warrior2.TakeDamege(damage);
            warrior2.GiveHealth(addedHealth);
            warrior2.TakeStatus();
            HardWarrior warrior3 = new HardWarrior("Mahu", 100, "Alive");
            warrior3.TakeDamege(damage);
            warrior3.GiveHealth(addedHealth);
            warrior3.TakeStatus();            
        }
    }
}
