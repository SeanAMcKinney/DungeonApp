using DungeonLibrary;
using System;
using System.Threading;

namespace Dungeon
{
    public interface IUserInterface
    {
        void BeginGame();
        void IsDead(Monster monster);
        void RunAway(Monster monster, Player player);
        void PlayerInfo(Player player);
        void MonsterInfo(Monster monster);
        void WeaponInfo(Weapon equippedWeapon);
        void ExitGame();
        void GivePlayerScore();
        void AreYouDead();
    }
    public class UserInterface : IUserInterface
    {
        private readonly IConsoleUtilities _consoleUtilities;

        public UserInterface(IConsoleUtilities consoleUtilities)
        {
            _consoleUtilities = consoleUtilities;
        }

        public void BeginGame()
        {
            Console.Title = "FIGHT OR FLIGHT DUNGEON";
            Console.WriteLine(" How long can you last...?\n\n");
            Console.WriteLine(" Welcome to the game!\n" +
              " This game is scored by how many rooms you can" +
              " escape.\n Fight your way out or take flight...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            _consoleUtilities.PrintChar(" GOOD LUCK PLAYER!", 100);
            _consoleUtilities.PrintChar(" YOU'LL NEED IT!", 200);
            _consoleUtilities.PrintChar(" The choice is yours.", 70);
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
        }

        public void IsDead(Monster monster)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            _consoleUtilities.PrintChar( monster.Name + " is dead! You are VICTORIOUS!", 40);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();           
        }

        public void RunAway(Monster monster, Player player)
        {
            Console.WriteLine(" You run away!");
            _consoleUtilities.PrintChar($"{monster.Name} attacks you as you flee!", 40);
            Combat.DoOppertunityAttack(monster, player);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void PlayerInfo(Player player)
        {
            Console.WriteLine(" Player Info");
            Console.WriteLine(player);
            Console.WriteLine(" Rooms Escaped : " + Player.Score);
        }

        public void MonsterInfo(Monster monster)
        {
            Console.WriteLine(" Monster Info");
            Console.WriteLine(monster);
        }

        public void WeaponInfo(Weapon equippedWeapon)
        {
            Console.WriteLine(" Weapon Info");
            Console.WriteLine(equippedWeapon);
        }

        public void ExitGame()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            _consoleUtilities.PrintChar(" You are a yellow bellied coward....", 10);
            Console.ResetColor();
        }

        public void GivePlayerScore()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" You survived " + Player.Score + " room" + ((Player.Score == 1) ? "." : "s"));
            Console.ResetColor();
        }

        public void AreYouDead()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            _consoleUtilities.PrintChar(" YOUR FIGHT IS OVER!", 100);
            _consoleUtilities.PrintChar(" YOU... ARE.. DEAD!", 300);
            Console.ResetColor();
            Thread.Sleep(3000);
        }
    }
}
