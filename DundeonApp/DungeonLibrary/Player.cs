using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        //ToDo  Need to figure out how to add in race and weapon benefits and penalties to the players methods.


        //Fields
        //Attributes: Name, HitChance, Block, Life, MaxLife, Race, Weapon
        //Only need to create fields for any attributes that require business rules
        private int _life;

        //Properties
        //Automatic properties: A shortcut syntax that allows you to create a shortened version of a public property.
        //Automatic properties have an open getter and setter.
        //They automatically create default fields for you at runtime.

        //public string Name { get; set; }


        //public int HitChance { get; set; }

        //public int Block { get; set; }

        //public int MaxLife { get; set; }

        public Race CharacterRace { get; set; }

        public Weapon EquippedWeapon { get; set; }

        ////If you need business rules, the field must be declared above and write the property the long way
        //public int Life
        //{
        //    get { return _life; }
        //    set
        //    {
        //        //Business rule: Life should not exceed MaxLife
        //        if (value <= MaxLife)
        //        {
        //            //Good to go
        //            _life = value;
        //        }
        //        else
        //        {
        //            //Tried to set a value for life greater than MaxLife
        //            _life = MaxLife;
        //        }//end if/else
        //    }//end business
        //}//end Life

        //(FQCTOR)
        //ONLY MAKE A FQ-CONSTRUCTOR
        //We don't want to allow anyone to make a blank Player, so they MUST give us all of the info necessary
        public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon)
        {
            //Since Life depends on MaxLife, SET MAXLIFE FIRST
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }

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
                case Race.Centar:
                    description = "Fast Fighter Horse-man";
                    break;
            }//end switch

            return string.Format("-=-= {0} =-=-/n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +
                "Weapon:\n{4}\n" +
                "Block: {5}\n" +
                "Description: {6}",
                Name,
                Life,
                MaxLife,
                //HitChance, // updated HitChance with method CalcHitChance
                CalcHitChance(),
                EquippedWeapon,
                Block,
                description);

        }//end ToString()

        public override int CalcDamage()
        {
            //return base.CalcDamage(); //Will do what base class does - return 0

            //Weapon is the basis for how our player deals damage
            //Weapon has MinDamgage and MaxDamage properties
            //Use a Rndom object to randomly select how much damage our weapon can do with any given attact

            Random rand = new Random();

            //Determin range of potential damage
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
