using System;
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
            MaxDamage += 10;           
            MinDamage += 7;
            Name = "Bow";
            BonusHitChance += 2;
            BonusBlock += 2;

        }//end FQ Constructor   
    }
}
