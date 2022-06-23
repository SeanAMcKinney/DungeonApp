using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Sting : Weapon 
    {
        public Sting()
        {
            MaxDamage = 12;
            MinDamage = 7;
            Name = "Sting";
            BonusHitChance = 4;
            BonusBlock = 8 ;
        }
    }
}