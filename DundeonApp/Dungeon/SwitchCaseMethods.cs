using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dungeon
{
    public class SwitchCaseMethods
    {
        public static void CaseSelectA(Monster monster)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintUtility.Print( monster.Name + " is dead! You are VICTORIOUS!", 40);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void CaseSelectR(Monster monster, Player player)
        {
            Console.WriteLine(" You run away!");
            PrintUtility.Print($"{monster.Name} attacks you as you flee!", 40);
            Combat.DoOppertunityAttack(monster, player);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void CaseSelectP(Player player)
        {
            Console.WriteLine(" Player Info");
            Console.WriteLine(player);
            Console.WriteLine(" Rooms Escaped : " + Player.Score);
        }

        public static void CaseSelectM(Monster monster)
        {
            Console.WriteLine(" Monster Info");
            Console.WriteLine(monster);
        }

        public static void CaseSelectW(Weapon equippedWeapon)
        {
            Console.WriteLine(" Weapon Info");
            Console.WriteLine(equippedWeapon);
        }

        public static void CaseSelectXorE()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            PrintUtility.Print(" You are a yellow bellied coward....", 10);
            Console.ResetColor();
        }
    }
}
