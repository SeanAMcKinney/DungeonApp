using DungeonLibrary;

namespace MonsterLibrary
{
    public class Slime : Monster
    {
        public bool IsGooey { get; set; }

        public Slime(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isGooey)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            IsGooey = isGooey;
        }

        public Slime()
        {
            MaxLife = 5;
            MaxDamage = 2;
            Name = "Slime";
            Life = 5;
            HitChance = 40;
            Block = 10;
            MinDamage = 1;
            Description = "It's a ball of slime.";
            IsGooey = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsGooey ? "More solid than I expected..." : "Gross!!");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsGooey)
            {
                calculatedBlock -= calculatedBlock * 2;
            }
            return calculatedBlock;
        }
    }
}
