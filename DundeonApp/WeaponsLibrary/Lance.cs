using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Lance : Weapon
    {
        public Lance()
        {
            MaxDamage += 13;           
            MinDamage += 7;
            Name = "Lance-o-lot";
            BonusHitChance += 9;
            BonusBlock += 1;
        }
    }
}