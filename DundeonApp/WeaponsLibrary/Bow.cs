﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Bow : Weapon
    {
        public Bow()
        {
            MaxDamage += 15;           
            MinDamage += 2;
            Name = "Bow of Ages";
            BonusHitChance += 5;
            BonusBlock += 2;

        }//end FQ Constructor   
    }
}
