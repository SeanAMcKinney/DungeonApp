using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Bow : Weapon
    {
        public Bow()
        {
            MaxDamage += 15;           
            MinDamage += 2;
            Name = "Bow of Ages";
            BonusHitChance += 5;
            BonusBlock += 2;
        }  
    }
}