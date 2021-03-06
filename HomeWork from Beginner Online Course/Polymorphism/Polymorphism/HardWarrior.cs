﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class HardWarrior : Warrior
    {
        public HardWarrior(string name, int health, string state) : base(name, health, state)
        {
            Name = name;
            Health = health;
            State = state;
        }
        public override void TakeDamege(int damage)
        {
            Health -= damage;
            base.TakeDamege(damage);
        }
    }
}
