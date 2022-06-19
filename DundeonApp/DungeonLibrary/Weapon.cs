using System;

namespace DungeonLibrary
{
    public class Weapon
    { 
        //Fields
        //Attributes: MinDamage, MaxDamage, Name, BonusHitChance, 2-Handed?
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private int _bonusBlock;


        //Propererties
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public int BonusBlock
        {
            get { return _bonusBlock; }
            set { _bonusBlock = value; }
        }

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
                }//end if/else
            }//end business
        }//end MinDamage

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
    }//end class
}//end namespace
