using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;


namespace WeaponsLibrary
{
    public class Shield : Weapon
    {
        public Shield()
        {          
            MaxDamage += 14;
            //Since MinDamage has business rules that depend on the value of MaxDamage, we MUST set MaxDamage before MinDamage
            MinDamage += 8;
            Name = "Shield";
            BonusHitChance += 2;
            BonusBlock += 10;

        }//end Constructor
    }//end class
}//end namespace
