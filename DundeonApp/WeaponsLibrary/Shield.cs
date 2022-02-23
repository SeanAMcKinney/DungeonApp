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
            MaxDamage = 10;
            //Since MinDamage has business rules that depend on the value of MaxDamage, we MUST set MaxDamage before MinDamage
            MinDamage = 5;
            Name = "Shield";
            BonusHitChance = 5;
            BonusBlock = 12;

        }//end Constructor
    }//end class
}//end namespace
