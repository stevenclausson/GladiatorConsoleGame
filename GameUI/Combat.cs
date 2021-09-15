using System;
using System.Collections.Generic;
using System.Text;

namespace GameUI
{
    public static class Combat
    {


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
                gladiatorFame++;
                Combat2(cName, gladiatorFame);
            }
            else if(gladiatorFame > 10 && gladiatorFame <= 20)
            { 
                gladiatorFame++;
                Combat3(cName, gladiatorFame);
            }

            else if(gladiatorFame > 20)
            {
                gladiatorFame++;
                Combat4(cName, gladiatorFame);
            }
            else
            {
                FinalBattle(cName);
            }
        }

        public static void Combat1(string cName, int gladiatorFame)
        {
            string[] firstOpponents = { "Decimus", "Lucius", "Eithne", "Aamor" };
            Random rand = new Random();
            int opponentIndex = rand.Next(firstOpponents.Length);
            Opponent Enemy = new Opponent(firstOpponents[opponentIndex],"Germania Frontier","Tax Evader", 1, 1, 5);

            Console.Clear();
            Console.WriteLine("Today we have two new gladiators vying for your support!");
            Console.WriteLine($"On the Red Team we have {cName}. New blood here to show his ability!");
            Console.WriteLine($"On the Blue Team, we have {Enemy.Name},! A {Enemy.lawBroken} from the barbaric {Enemy.homeLocation}!");
            Console.WriteLine("PRESS ENTER TO BEGIN");
            Console.ReadLine();
            PreCombat(cName, gladiatorFame);
        }

        public static void Combat2(string cName, int gladiatorFame)
        {
            string[] firstOpponents = { "Greg", "Charles", "Emily", "Chuggy" };
            Random rand = new Random();
            int opponentIndex = rand.Next(firstOpponents.Length);
            Opponent Enemy = new Opponent(firstOpponents[opponentIndex], "Germania Frontier", "Tax Evader", 1, 1, 5);

            Console.Clear();
            Console.WriteLine("Today we have two men ready to compete for your attention!");
            Console.WriteLine($"On the Red Team we have {cName}!");
            Console.WriteLine($"On the Blue Team, we have {Enemy.Name},! A {Enemy.lawBroken} from the barbaric {Enemy.homeLocation}!");
            Console.WriteLine("PRESS ENTER TO BEGIN");
            Console.ReadLine();
            PreCombat(cName, gladiatorFame);
        }

        public static void Combat3(string cName, int gladiatorFame)
        {
            Console.Clear();
            Console.WriteLine("Today we have two experienced gladiators waiting to spill blood for the citizens of Rome!");
            Console.WriteLine($"On the Red Team we have {cName}!");
            Console.WriteLine("On the Blue Team, we have Elrond! A bad guy!");
            Console.WriteLine("PRESS ENTER TO BEGIN");
            Console.ReadLine();
            PreCombat(cName, gladiatorFame);
        }
        public static void Combat4(string cName, int gladiatorFame)
        {
            Console.Clear();
            Console.WriteLine("Today we have two veteran gladiators just eager to demonstrate their combat prowess to the crowd!");
            Console.WriteLine($"On the Red Team we have {cName}!");
            Console.WriteLine("On the Blue Team, we have Jimbo! Another random bad guy!");
            Console.WriteLine("PRESS ENTER TO BEGIN");
            Console.ReadLine();
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
