using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Dungeon
{
    public class WeaponAndPlayerAutoSelect
    {
        public static void WeaponAndPlayerSelection()
        {
            Console.WriteLine(" Now we will select your weapon and hero by way of chance...\n");
            Console.WriteLine(" First, your weapon.\n");
            Thread.Sleep(1500);

            WeaponsLibrary.Axe axe = new WeaponsLibrary.Axe();
            WeaponsLibrary.Shield shield = new WeaponsLibrary.Shield();
            WeaponsLibrary.Daggers daggers = new WeaponsLibrary.Daggers();
            WeaponsLibrary.Bow bow = new WeaponsLibrary.Bow();
            WeaponsLibrary.Sting sting = new WeaponsLibrary.Sting();
            WeaponsLibrary.SlamHammer slammer = new WeaponsLibrary.SlamHammer();
            WeaponsLibrary.Lance lance = new WeaponsLibrary.Lance();

            DungeonLibrary.Weapon[] weapons = { axe, shield, bow, daggers, sting, slammer, lance };
            Random rand = new Random();
            int randomNumber = rand.Next(weapons.Length);
            DungeonLibrary.Weapon equippedWeapon = weapons[randomNumber];
            PrintUtility.Print(" Your weapon is " + equippedWeapon.Name + ". Enjoy!", 60);
            Thread.Sleep(5000);
            Console.Clear();
        
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
        }
    }
}
