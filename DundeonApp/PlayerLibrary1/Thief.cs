﻿using System;
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
        public Centar(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon, double evade)
        {
            Name = "Snelaglas the Faint";
            HitChance = 50;
            Block = 25;
            MaxLife = 100;
            Life = 100;
            CharacterRace = Race.Centar;
            EquippedWeapon = Weapon.blank; //ToDo  Add weapons to select from 
            Evade = 1.50;
        }

        //No added methods

    }//end class 
}//end namespace
