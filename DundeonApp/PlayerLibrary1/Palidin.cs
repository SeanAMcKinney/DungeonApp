﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace PlayerLibrary
{
    public sealed class Palidin : Player
    {
        //No New Fields

        //No new properties

        //FQCTOR
        public Palidin(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon, int evade)
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
            //Name = "Marith of Algar";
            //HitChance = 75;
            //Block = 75;
            //MaxLife = 100;
            //Life = 100;
            //CharacterRace = Race.HumanPalidin;
            //equippedWeapon = Weapon.Shield; //ToDo  Add weapons to select from 
            //Evade = 1.75;

        //No added methods

    }//end class
}//end namespace
