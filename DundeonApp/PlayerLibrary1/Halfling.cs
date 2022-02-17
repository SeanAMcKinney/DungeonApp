using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace PlayerLibrary
{
    public sealed class Halfling : Player
    {
        //No New Fields

        //No new properties

        //FQCTOR
        public Halfling(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon, double evade)
        {
            Name = "Tep of the Glade";
            HitChance = 25;
            Block = 25;
            MaxLife = 100;
            Life = 100;
            CharacterRace = Race.Halfling;
            EquippedWeapon = Weapon.blank; //ToDo  Add weapons to select from 
            Evade = 1.75;
        }

        //No added methods
    }//end class 
}//end namespace
