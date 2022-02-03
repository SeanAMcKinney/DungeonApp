using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Slime : Monster
    {
        //Slime is a child/sub-class/sub-type of Monster

        //Fields

        //Properties
        public bool IsGooey { get; set; }

        //Constructors
        public Slime(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isGooey)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsGooey = isGooey;
        }

        //Unqulified Constructor
        public Slime()
        {
            //SET MAX VALUES FIRST
            MaxLife = 5;
            MaxDamage = 2;
            Name = "Slime";
            Life = 5;
            HitChance = 15;
            Block = 10;
            MinDamgae = 1;
            Description = "It's a ball of slime.";
            IsGooey = false;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + (IsGooey ? "Gross!!" : "More solid than I expected...");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();

            int calculatedBlock = Block;

            if (IsGooey)
            {
                //If rabbit is fluffy it gains 50% damage reduction
                calculatedBlock -= calculatedBlock / 2;
            }//end if

            return calculatedBlock;
        }


    }//end class
}//end namespace
