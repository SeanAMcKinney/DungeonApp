using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace PlayerLibrary
{
    public sealed class Thief : Player
    {
        //No New Fields

        //No new properties

        //FQCTOR
        public Thief(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon, int evade)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            Evade = evade;
        }
            //Name = "Snelaglas the Faint";
            //HitChance = 50;
            //Block = 25;
            //MaxLife = 100;
            //Life = 100;
            //CharacterRace = Race.Centar;
            //EquippedWeapon = Weapon.Dagger; //ToDo  Add weapons to select from 
            //Evade = .75;

        //No added methods

    }//end class 
}//end namespace
