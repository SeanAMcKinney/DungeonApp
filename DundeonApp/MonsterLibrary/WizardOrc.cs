using System;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class WizardOrc : Monster
    {
        public bool IsMaster { get; set; }

        public WizardOrc(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isMaster)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            IsMaster = isMaster;
        }
        
        public WizardOrc()
        {
            MaxLife = 16;
            MaxDamage = 12;
            Name = "Mystical Orc Wizard";
            Life = 16;
            HitChance = 55;
            Block = 20;
            MinDamage = 6;
            Description = "A dark magic wielding Orc.";
            IsMaster = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsMaster ? "Very Dagerous" : "Not as skilled...");
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            if (IsMaster)
            {
            return rand.Next(MinDamage * 2, (MaxDamage * 2) + 1);
            }
            else
            {
            return rand.Next(MinDamage, MaxDamage + 1);
            }
        }
    }
}