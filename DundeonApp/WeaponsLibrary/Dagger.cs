using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Dagger : Weapon
    {
        public Dagger()
        {

            MaxDamage += 9;
            //Since MinDamage has business rules that depend on the value of MaxDamage, we MUST set MaxDamage before MinDamage
            MinDamage += 4;
            Name = "Dagger";
            BonusHitChance += 2;
            BonusBlock += 0;

        }//end FQ Constructor
    }//end class
}//end namespace
