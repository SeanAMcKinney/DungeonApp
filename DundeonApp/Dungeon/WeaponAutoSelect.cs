using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Dungeon
{
    public interface IWeaponAutoSelect
    {
        Weapon WeaponSelection();
    }

    public class WeaponAutoSelect : IWeaponAutoSelect
    {
        private readonly IConsoleUtilities _consoleUtilities;
        public WeaponAutoSelect(IConsoleUtilities consoleUtilities)
        {
            _consoleUtilities = consoleUtilities;
        }
        public Weapon WeaponSelection()
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
            _consoleUtilities.PrintChar(" Your weapon is " + equippedWeapon.Name + ". Enjoy!", 60);
            Thread.Sleep(5000);
            Console.Clear();

            return equippedWeapon;

        }
    }
}
