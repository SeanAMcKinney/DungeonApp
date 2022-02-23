using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Monster : Character
    {
        //Fields
        private int _minDamage;
        //Properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //Shouldn't be more than the Max Damage
                //shouldn't be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    //This follows the guidelines above, go ahead and assign the field the value that was provided
                    _minDamage = value;
                }
                else
                {
                    //tried to set the value outside the appropriate ranges
                    //Default to 1
                    _minDamage = 1;
                }//end if/else
            }//end set
        }// end MinDamage

        //Constructors    
        //Unqulified Constructor
        public Monster() { }
        //FQCTOR
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

        //Methods
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
    }//end class
}//end namespace
