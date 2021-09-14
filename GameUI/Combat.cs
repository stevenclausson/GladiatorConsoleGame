using System;
using System.Collections.Generic;
using System.Text;

namespace GameUI
{
    public class Combat
    {
        Player Gladiator = new Player("Gladiator", 10, 1, 1, 5, 1, 0);

        public static void PreCombat(string cName, int gladiatorFame)
        {
            Console.WriteLine("Welcome citizens! A marvelous day at the arena once again!");
            if (gladiatorFame <= 0)
            {
                gladiatorFame++;
                Combat1(cName, gladiatorFame);
            }
            else if (gladiatorFame > 0 && gladiatorFame <= 10)
            {
                Console.WriteLine("Today we have two men ready to compete for your attention!");
                gladiatorFame++;
                //Combat 2
            }
            else if(gladiatorFame > 10 && gladiatorFame <= 20)
            {
                Console.WriteLine("Today we have two experienced gladiators waiting to spill blood for the citizens of Rome!");
                gladiatorFame++;
                //Combat 3
            }

            else if(gladiatorFame > 20)
            {
                Console.WriteLine("Today we have two veteran gladiators just eager to demonstrate their combat prowess to the crowd!");
                gladiatorFame++;
                // Combat 4
            }
        }

        public static void Combat1(string cName, int gladiatorFame)
        {
            Console.Clear();
            Console.WriteLine("Today we have two new gladiators vying for your support!");
            Console.WriteLine($"On the Red Team we have {cName}. New blood here to show his ability!");
            Console.WriteLine("On the Blue Team, we have Darius! A tax evader from the barbaric frontier of Germania!");
            Console.WriteLine("PRESS ENTER TO BEGIN");
            Console.ReadLine();
            PreCombat(cName, gladiatorFame);
        }

        public static void Combat2(string cName, int gladiatorFame)
        {
            Console.Clear();
            Console.WriteLine("Combat 2");
            PreCombat(cName, gladiatorFame);
        }

        public static void Combat3(string cName, int gladiatorFame)
        {
            Console.Clear();
            Console.WriteLine("Combat 3");
            PreCombat(cName, gladiatorFame);
        }
        public static void Combat4(string cName, int gladiatorFame)
        {
            Console.Clear();
            Console.WriteLine("Combat 4");
            PreCombat(cName, gladiatorFame);
        }
        public static void FinalBattle(string cName)
        {
            Console.Clear();
            Console.WriteLine("The Final Fight");
            Messages.Closing();
        }
    }
}
