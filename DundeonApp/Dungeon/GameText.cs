using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dungeon
{
    public class GameText
    {

        public static void GameTitleAndOpeningMessage()
        {
            Console.Title = "FIGHT OR FLIGHT DUNGEON";
            Console.WriteLine(" How long can you last...?\n\n");
            Console.WriteLine(" Welcome to the game!\n" +
              " This game is scored by how many rooms you can" +
              " escape.\n Fight your way out or take flight...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            PrintUtility.Print(" The choice is yours.", 70);
            PrintUtility.Print(" GOOD LUCK PLAYER!", 100);
            PrintUtility.Print(" YOU'LL NEED IT!", 200);
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
        }

        public static void GivePlayerScore()
        {
            
        }
    }//end class
}//end namespace
