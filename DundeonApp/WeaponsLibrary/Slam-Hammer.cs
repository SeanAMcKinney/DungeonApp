using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace WeaponsLibrary
{
    public class SlamHammer : Weapon
    {
        public SlamHammer()
        {
            MaxDamage = 18;           
            MinDamage = 2;
            Name = "Slam-Hammer";
            BonusHitChance = 6;
            BonusBlock = 1;

        }//end FQ Constructor   
    }
}
