using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Daggers : Weapon
    {
        public Daggers()
        {
            MaxDamage = 9 * 2;
            MinDamage = 4 * 2;
            Name = "Daggers";
            BonusHitChance = 2;
            BonusBlock = 0;
        }
    }
}