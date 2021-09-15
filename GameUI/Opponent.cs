using System;
using System.Collections.Generic;
using System.Text;

namespace GameUI
{
    public class Opponent
    {
        public string Name;
        public string homeLocation;
        public string lawBroken;
        public int Attack;
        public int Defense;
        public int Health;

        //public Opponent(string eName, string eHomeLocation, string eLawBroken, int eAttack, int eDefense, int eHealth)
        //{
        //    Name = eName;
        //    homeLocation = eHomeLocation;
        //    lawBroken = eLawBroken;
        //    Attack = eAttack;
        //    Defense = eDefense;
        //    Health = eHealth;
        //}

        public Opponent(string eName, string eHomeLocation, string eLawBroken, int eAttack, int eDefense, int eHealth)
        {
            string[] firstOpponents = { "Decimus", "Lucius", "Eithne", "Aamor" };
            Random rand = new Random();
            int opponentIndex = rand.Next(firstOpponents.Length);

            Name = eName;
            homeLocation = eHomeLocation;
            lawBroken = eLawBroken;
            Attack = eAttack;
            Defense = eDefense;
            Health = eHealth;
        }
    }
}
