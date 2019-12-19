using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class TextMethods
    {
        /*  -------------------------- Methods Text------------------------------- */
        public void GameTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("Welcome to");
            Console.WriteLine("");
            Console.WriteLine(" XXXXX  X  X  XXXX   X     X  X     X     X      XXX   XXXX X    X  XXX  X    ");
            Console.WriteLine("   X    X  X  X        X  X   X X  XX    X X    X      X     X   X   X   X    ");
            Console.WriteLine("   X    XXXX  XXX       X     X  X  X   XXXXX    XX    XXX   X   X   X   X    ");
            Console.WriteLine("   X    X  X  X        X  X   X     X   X   X      X   X      X X    X   X    ");
            Console.WriteLine("   X    X  X  XXXX   X     X  X     X  X     X  XXX    XXXX    X    XXX  XXXX ");
            Console.WriteLine("");
            Console.WriteLine("Adventure");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public string StartGameText()
        {
            string startGameText = "You are calmly walking around in the forrest enjoying a nice relaxing day. \nSuddently as you turn around a corner ";
            return startGameText;
        }

        public string AfterVictory()
        {
            string afterVictory = "\nNow after your victory, feeling like The strongest adventure in world. \nYou decide to continue on in your adventure";
            return afterVictory;

        }
    }
}
