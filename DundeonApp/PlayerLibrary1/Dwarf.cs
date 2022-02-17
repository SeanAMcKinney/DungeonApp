﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace PlayerLibrary
{
    public sealed class Dwarf : Player
    {
        //No New Fields

        //No new properties

        //FQCTOR
        public Dwarf(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon, double evade)
        {
            Name = "Argrath the Mighty";
            HitChance = 50;
            Block = 75;
            MaxLife = 100;
            Life = 100;
            CharacterRace = Race.MountainDwarf;
            EquippedWeapon = Weapon.blank; //ToDo  Add weapons to select from 
            Evade = .75;
        }

        //No added methods
    }//end class
}//end namespace
