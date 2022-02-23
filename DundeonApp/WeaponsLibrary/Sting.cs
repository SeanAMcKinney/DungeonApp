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
            MaxDamage += 7;
            //Since MinDamage has business rules that depend on the value of MaxDamage, we MUST set MaxDamage before MinDamage
            MinDamage += 2;
            Name = "Sting";
            BonusHitChance += 0;
            BonusBlock += 8 ;

        }//end  Constructor
    }//end class
}//end namespace
