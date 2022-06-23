using System;

namespace DungeonLibrary
{
    public class Weapon
    { 
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public int BonusBlock { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {                 
                    _minDamage = 1;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("\n******* WEAPON *******\n" +
                "Name: {0}\n" +
                "Minimum Damage: {1}\n" +
                "Maximum Damage: {2}\n" +
                "Bonus HitChance: {3}\n" +
                "Bonus Block: {4}\n", Name, MinDamage, MaxDamage, BonusHitChance, BonusBlock);
        }

        public static implicit operator Weapon(Player v)
        {
            throw new NotImplementedException();
        }
    }
}
