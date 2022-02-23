using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Axe : Weapon
    {
        public Axe()
        {          
            MaxDamage = +12;
            MinDamage = +7;         
            Name += "Axe";
            BonusHitChance += 4;
            BonusBlock += 4;
        }//end  Constructor
    }
}
