using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Kraken : Monster
    {
        //Fields

        //Propeties

        public bool InDeepWater { get; set; }

        //FQCTOR

        public Kraken(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool inDeepWater)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            InDeepWater = inDeepWater;
        }
        //Unqualified Constructor
        public Kraken()
        {
            MaxLife = 35;
            MaxDamage = 20;
            Name = "Zarg the Black";
            Life = 35;
            HitChance = 60;
            Block = 35;
            MinDamage = 10;
            Description = "Tentacled Beast of Legand!!";
            InDeepWater = false;
        }

        //Methods

        public override string ToString()
        {
            return base.ToString() + (InDeepWater ? "Watery Death that strikes thrice!" : "Lesser Kraken");
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            if (InDeepWater)
            {
                return rand.Next(MinDamage, MaxDamage + 1)
                    + rand.Next(MinDamage, MaxDamage + 1)                                           
                    + rand.Next(MinDamage, MaxDamage + 1);                                           
            }
            else
            {
                return rand.Next(MinDamage, MaxDamage + 1);
            }//end if/else
        }//end CalcDamage()


    }//end class
}//end Namespace
