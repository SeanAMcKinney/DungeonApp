using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Rabbit : Monster
    {
        //Rabbit is a child/sub-class/sub-type of Monster

        //Fields

        //Properties
        public bool IsFluffy { get; set; }

        //Constructors
        public Rabbit(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isFluffy)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsFluffy = isFluffy;
        }

        //Unqulified Constructor
        public Rabbit()
        {
            //SET MAX VALUES FIRST
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Rabbit";
            Life = 6;
            HitChance = 20;
            Block = 20;
            MinDamgae = 1;
            Description = "It's just a cute little bunny... why would you hurt it?!";
            IsFluffy = false;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "Fluffy" : "Not so fluffy...");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();

            int calculatedBlock = Block;

            if (IsFluffy)
            {
                //If rabbit is fluffy it gains 50% damage reduction
                calculatedBlock += calculatedBlock / 2;
            }//end if

            return calculatedBlock;
        }


    }//end class
}//end namespace
