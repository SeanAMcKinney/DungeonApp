using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Axe : Weapon
    {
        public Axe()
        {          
            MaxDamage = 14;
            MinDamage = 7;         
            Name += "Axe of Groot";
            BonusHitChance += 6;
            BonusBlock += 4;
        }
    }
}