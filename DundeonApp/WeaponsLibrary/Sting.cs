using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Sting : Weapon 
    {
        public Sting()
        {
            MaxDamage = 12;
            //Since MinDamage has business rules that depend on the value of MaxDamage, we MUST set MaxDamage before MinDamage
            MinDamage = 7;
            Name = "Sting";
            BonusHitChance = 4;
            BonusBlock = 8 ;

        }//end  Constructor
    }//end class
}//end namespace
