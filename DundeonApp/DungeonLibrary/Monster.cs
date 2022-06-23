using System;

namespace DungeonLibrary
{
    public abstract class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
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

        public Monster() { }
 
        public Monster(int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            Life = life;
            MaxLife = maxLife;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format("\n******* MONSTER *******\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} to {4}\n" +
                "Block: {5}\nHitChance: {6}%\nDescription:\n{7}\n", Name, Life, MaxLife, MinDamage, MaxDamage, Block, HitChance, Description);
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}
