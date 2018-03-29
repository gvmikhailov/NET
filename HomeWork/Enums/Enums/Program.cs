using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum Food
    {
        Meat,
        Fish,
        Sausage,
        DryFood
    }
    class Program
    {
        static void Main(string[] args)
        {
            int satiety = 0;
            satiety = FeedCat(ref satiety, Food.DryFood);
            Console.WriteLine("После сухого корма сытость кошки {0}", satiety);
            satiety = FeedCat(ref satiety, Food.Fish);
            Console.WriteLine("После рыбы сытость кошки {0}", satiety);
            satiety = FeedCat(ref satiety, Food.Meat);
            Console.WriteLine("После мяса сытость кошки {0}", satiety);
            satiety = FeedCat(ref satiety, Food.Sausage);
            Console.WriteLine("После колбасы сытость кошки {0}", satiety);
        }
        static int FeedCat (ref int satiety, Food food4Cat)
        {
            switch(food4Cat)
            {
                case Food.DryFood:
                    return satiety + 10;            
                case Food.Fish:
                    return satiety + 20;                    
                case Food.Meat:
                    return satiety + 30;
                case Food.Sausage:
                    return satiety + 40;
            }
            return 0;
        }
    }
}
