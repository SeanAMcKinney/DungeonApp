using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public abstract class Character
    {

        //The ABSTRACT keyword indicates that the thing being modified (class here)
        //has an incomplete implementation. The abstract modifier can be used with
        //classes, methods, and properties. We can use the abstrat modifier in a 
        //class declaration (as shown above) to indicate that the class is intended
        //to only be a base(parent) class of other classes.

        //Fields
        //Brought over most of the fields/prperties from Player.cs and then made Player : Character
        //Attributes
        private int _life;

        //Properties
        public string Name { get; set; }

        public int HitChance { get; set; }

        public int Block { get; set; }

        public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                //Business rule: Life should not exceed MaxLife
                if (value <= MaxLife)
                {
                    //Good to go
                    _life = value;
                }
                else
                {
                    //Tried to set a value for life greater than MaxLife
                    _life = MaxLife;
                }//end if/else
            }//end set
        }//end business
         //Constructors
         //We have already done all the work for the FQCTOR of Player, so we'll opt not to create
         //any constructors here. We do still get access to th edefault constructor but we can't use
         //it because the class is ABSTRACT.  Never meant to be constructed.

        //Methods
        //No need to override the ToString() because we will NEVER creat a Character object.  It will 
        //always be a Player or a Monster.

        //Below are methods we want to be inherited by Player and Monster.
        //Create default versions of each method here. The child classes will use these
        //methods if they do not override them for thier own, unique versions.

        public virtual int CalcBlock()
        {
            //To be able to override this in a child class we MUSt make it VIRTUAL
            //This basic version just returns block, but will give us the option to 
            //do something different in our child classes.

            return Block;
        }

        //MINI-LAB - Make CalcHitChance and make it return HitChance.  Make it available in other namspaces and be sure its overridable.
        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
            //Starting with return 0. We will override this method for Monster and Player
            //They will have own ways to Calcutlate damage
        }

    }//end class
}//end namespace
