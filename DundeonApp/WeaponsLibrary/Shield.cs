using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Shield : Weapon
    {
        public Shield()
        {          
            MaxDamage = 10;
            MinDamage = 5;
            Name = "Shield";
            BonusHitChance = 5;
            BonusBlock = 12;
        }
    }
}