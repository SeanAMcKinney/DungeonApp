using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Monster : Character
    {
        //Fields
        private int _minDamage;


        //Properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamgae
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
        }

        //Constructors
        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxdamage, string description)
        //: base(name, maxLife, life, hitChance, block) //Can't use : base since there is not CONSTRUCTOR in ABSTRACT CHARACTER class 
        //from which it would be inherited.  (Technically, we never inherit constructors, but we are able to use :base(parameters) shortcut
        //for automatic assigment of any inherited properties). Since Character has no constructor it does nothing for assignment of it's 
        //properties.  When inheriting from an abstract class, we enjoy all the benefits related to fields, properties, and methods, but 
        //must manually perform assingmnet for all properties in th constructor.
        {
            MaxLife = maxLife;
            MaxDamage = MaxDamage;
            Description = description;
            Name = name;
            Life = life;
            HitChance = hitChance;
            MinDamgae = minDamage;
            Block = block;
        }

        //Unqulified Constructor
        public Monster() { }

        //Methods
        public override string ToString()
        {
            //return base.ToString();

            return string.Format("\n******* MONSTER *******\n" +
                "{0}\nLie: {1} of {2}\nDamage: {3} to {4}\n" +
                "Block: {5}Description:\n{6}\n", Name, Life, MaxLife, MinDamgae, MaxDamage, Block, Description);
        }

        public override int CalcDamage()
        {
            //return base.CalcDamage();
            Random rand = new Random();

            return rand.Next(MinDamgae, MaxDamage + 1);
        }

    }//end class
}//end namespace
