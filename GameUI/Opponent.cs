using System;
using System.Collections.Generic;
using System.Text;

namespace GameUI
{
    public class Opponent
    {
        public string Name;
        public int Attack;
        public int Defense;
        public int Health;

        public Opponent(string eName, int eAttack, int eDefense, int eHealth)
        {
            Name = eName;
            Attack = eAttack;
            Defense = eDefense;
            Health = eHealth;
        }
    }
}
