using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dungeon
{
    class PlayerAutoSelection
    {
        public static Player PlayerSelection(Weapon equippedWeapon)
        {
            Console.WriteLine(" Now we will select your hero.");
            Thread.Sleep(1500);

            PlayerLibrary.Palidin palidin = new PlayerLibrary.Palidin("Merith Of Algar", 70, 40, 100, 100, DungeonLibrary.Race.HumanPalidin, equippedWeapon, -35);
            PlayerLibrary.Dwarf dwarf = new PlayerLibrary.Dwarf("Argrath the Mighty", 60, 25, 100, 100, DungeonLibrary.Race.MountainDwarf, equippedWeapon, -15);
            PlayerLibrary.Centaur centar = new PlayerLibrary.Centaur("Brogan The Brave", 50, 25, 100, 100, DungeonLibrary.Race.Centaur, equippedWeapon, 0);
            PlayerLibrary.Thief thief = new PlayerLibrary.Thief("Snelaglas the Faint", 40, 15, 100, 100, DungeonLibrary.Race.ElvenThief, equippedWeapon, 30);
            PlayerLibrary.Halfling halfling = new PlayerLibrary.Halfling("Tep of the Glade", 35, 5, 100, 100, DungeonLibrary.Race.Halfling, equippedWeapon, 40);

            DungeonLibrary.Player[] players = { palidin, dwarf, centar, thief, halfling };
            Random rand2 = new Random();
            int rand2Number = rand2.Next(players.Length);
            DungeonLibrary.Player player = players[rand2Number];
            Console.WriteLine(" Your hero is " + player.Name + ".");
            Thread.Sleep(5000);
            Console.Clear();

            PrintUtility.Print(" Adventure forth!", 60);
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Blue;
            PrintUtility.Print(" JUST DON'T DIE...");
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
            return player;
        }
    }
}
