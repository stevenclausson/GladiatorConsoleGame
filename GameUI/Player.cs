using System;
using System.Collections.Generic;
using System.Text;

namespace GameUI
{
    public class Player
    {
        public string Name;
        public int Health;
        public int Stamina;
        public int Experience;
        public int Fame;
        public int Attack;
        public int Defense;

        public Player(string pName, int pHealth,int pAttack, int pDefense, int pStamina, int pExperience, int pFame)
        {
            Name = pName;
            Health = pHealth;
            Stamina = pStamina;
            Experience = pExperience;
            Fame = pFame;
            Defense = pDefense;
            Attack = pAttack;
        }
    }
}
