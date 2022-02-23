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
        public Halfling(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon, int evade)
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
        //No added methods
    }//end class 
}//end namespace
