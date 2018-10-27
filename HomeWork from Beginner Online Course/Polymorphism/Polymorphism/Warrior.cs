using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Warrior
    {
        private int _health;
        public string State { get; set; }
        public string Name { get; set; }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > 100)
                {
                    _health = 100;
                }
                else
                { 
                    _health = value;
                }
            }
        }
        public Warrior(string name, int health, string state)
        {
            Name = name;
            Health = health;
            State = state;
        }
        public virtual void TakeDamege(int damage)
        {            
            if (Health <= 0)
            {
                State = "Dead";
                Console.WriteLine("Нанесен урон {0}. Воин мертв", damage);
            }
            else
            {
                State = "Alive";
                Console.WriteLine("Нанесен урон {0}. Воин жив - оставшее количество жизней - {1}", damage, Health);
            }                        
        }
        public void GiveHealth(int health)
        {
            Health = health + Health;
            State = "Alive";
            Console.WriteLine("Воину добавлено {0} жизней, теперь у него {1} жизней", health, Health);                                  
        }
        public void TakeStatus()
        {
            if(State == "Alive")
            {
                Console.WriteLine("Воин жив, у него {0} жизней", Health);
            }
            else
            {
                Console.WriteLine("Воин мертв");
            }            
        }
    }
}
