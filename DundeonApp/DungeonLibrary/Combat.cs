using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DungeonLibrary
{
    public class Combat
    {      
        //METHODS - Methods only for this class

        public static void DoAttack(Character attacker, Character defender)
        {
            //Get a random number from 1 to 100
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(30);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //If attacker hit, calculate the damage
                int damageDealt = attacker.CalcDamage();

                //Assign damage
                defender.Life -= damageDealt;

                //Write results to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }
            else
            {
                //The attacker missed
                Console.WriteLine("{0} missed!", attacker.Name);
            }//end if/else
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            //Player attacks first
            DoAttack(player, monster);

            //Monster attacks second -- if still alive
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }//end DoBattle()

        public static void DoOppertunityAttack(Character attacker, Character defender)
        {
            //Get a random number from 1 to 100
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(30);
            int damageDealt = 0;
            if (diceRoll <= attacker.CalcHitChance() - (defender.CalcBlock() + defender.CalcEvadeAttack()))
            {
                damageDealt = attacker.CalcDamage() * 2;

                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }                     
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} missed its attack", attacker.Name);
                Console.ResetColor();
            }//end if
        }//end DoOppertunityAttack()
    }//end class
}//end namespace
