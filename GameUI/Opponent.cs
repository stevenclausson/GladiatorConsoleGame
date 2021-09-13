using System;
using System.Collections.Generic;
using System.Text;

namespace GameUI
{
    public class Opponent
    {
        public int Attack;
        public int Defense;
        public int Health;

        public Opponent(int eAttack, int eDefense, int eHealth)
        {
            Attack = eAttack;
            Defense = eDefense;
            Health = eHealth;
        }
    }
}
