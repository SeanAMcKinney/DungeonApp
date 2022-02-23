using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Goblin : Monster
    {
        //Fields

        public Goblin(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
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
        //Unqualified Constructor
        public Goblin()
        {
            MaxLife = 10;
            MaxDamage = 5;
            Name = "Goblin";
            Life = 10;
            HitChance = 60;
            Block = 15;
            MinDamage = 3;
            Description = "He's a ugly one...";        
        }

        //Methods
       

    }//end class
}//end Namespace
