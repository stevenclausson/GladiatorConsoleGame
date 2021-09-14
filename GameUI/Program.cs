using System;

namespace GameUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gladiator Game";
            string title = @"
*********************************************************************
/  _> | |  | . || . \| || . ||_ _|| . || . \ /  _> | . ||  \  \| __>
| <_/\| |_ |   || | || ||   | | | | | ||   / | <_/\|   ||     || _> 
`____/|___||_|_||___/|_||_|_| |_| `___'|_\_\ `____/|_|_||_|_|_||___> 
********************************************************************
";
            Console.WriteLine(title);
            Console.WriteLine("Created by: Steven Clausson");
            Console.WriteLine("version: 0.0.1");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello Gladiator!");
            Console.WriteLine("Please enter your name: ");
            string charName = Console.ReadLine();
            int gladiatorFame = 0;
            Combat.PreCombat(charName, gladiatorFame);

            Console.ReadLine();
        }
    }
}
