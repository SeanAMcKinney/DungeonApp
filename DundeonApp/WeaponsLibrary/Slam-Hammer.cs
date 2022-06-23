using DungeonLibrary;

namespace WeaponsLibrary
{
    public class SlamHammer : Weapon
    {
        public SlamHammer()
        {
            MaxDamage = 18;           
            MinDamage = 2;
            Name = "Slam-Hammer";
            BonusHitChance = 6;
            BonusBlock = 1;
        } 
    }
}