using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Imp : Monster
    {
        //Fields

        public Imp(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
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
        public Imp()
        {
            MaxLife = 5;
            MaxDamage = 2;
            Name = "Imp";
            Life = 5;
            HitChance = 30;
            Block = 15;
            MinDamage = 1;
            Description = "Small and fiesty";        
        }

        //Methods
       

    }//end class
}//end Namespace
