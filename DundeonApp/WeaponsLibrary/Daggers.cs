using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Daggers : Weapon
    {
        public Daggers()
        {

            MaxDamage = 9 * 2;
            //Since MinDamage has business rules that depend on the value of MaxDamage, we MUST set MaxDamage before MinDamage
            MinDamage = 4 * 2;
            Name = "Daggers";
            BonusHitChance = 2;
            BonusBlock = 0;

        }//end FQ Constructor
    }//end class
}//end namespace
