using DungeonLibrary;

namespace MonsterLibrary
{
    public class BlackDragon : Monster
    {
        public BlackDragon(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        
        public BlackDragon()
        {
            MaxLife = 38;
            MaxDamage = 25;
            Name = "Arthorg The Stained";
            Life = 38;
            HitChance = 60;
            Block = 45;
            MinDamage = 8;
            Description = "Strong... Fast... Deadly";        
        }
    }
}
