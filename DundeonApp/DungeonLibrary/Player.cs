using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {     
        //Properties
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }


        //(FQCTOR)
       // ONLY MAKE A FQ-CONSTRUCTOR
        //We don't want to allow anyone to make a blank Player, so they MUST give us all of the info necessary
        //public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon, double evade)
        //{
        //    //Since Life depends on MaxLife, SET MAXLIFE FIRST
        //    MaxLife = maxLife;
        //    Name = name;
        //    HitChance = hitChance;
        //    Block = block;
        //    Life = life;
        //    CharacterRace = characterRace;
        //    EquippedWeapon = equippedWeapon;
        //    Evade = evade;
        //}

        //Methods
        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.ElvenThief:
                    description = "Stealthy Elf Thief";
                    break;
                case Race.MountainDwarf:
                    description = "Strong Bodied Dwarf";
                    break;
                case Race.Halfling:
                    description = "Difficult to Spot Hobbit";
                    break;
                case Race.HumanPalidin:
                    description = "Human Holy Knight";
                    break;
                case Race.Centaur:
                    description = "Fast Fighter Horse-man";
                    break;
            }//end switch

            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +              
                "Block: {4}\n" +
                "Evade: {6}\n" +
                "Description: {5}",
                Name,
                Life,
                MaxLife,
                //HitChance, // updated HitChance with method CalcHitChance
                CalcHitChance(),              
                Block,
                description,
                Evade);

        }//end ToString()

        public override int CalcDamage()
        {
            //return base.CalcDamage(); //Will do what base class does - return 0
            //Weapon is the basis for how our player deals damage
            //Weapon has MinDamgage and MaxDamage properties
            //Use a Rndom object to randomly select how much damage our weapon can do with any given attact
            Random rand = new Random();

            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            //return the damage

            return damage;
        }

        public override int CalcHitChance()
        {
            //return base.CalcHitChance();

            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }//end class
}//end Namespace
