using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class InGameMenu
    {
        public static ConsoleKey RunInGameMenu()
        {
            Console.Write("\n Please choose your course ahead:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "W) Weapon Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

            ConsoleKey userChoice = Console.ReadKey(true).Key;
            return userChoice;
        }
    }
}
