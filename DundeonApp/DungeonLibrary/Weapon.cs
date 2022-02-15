using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //Fields
        //Attributes: MinDamage, MaxDamage, Name, BonusHitChance, 2-Handed?
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;


        //Propererties
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

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
            }//end business
        }//end MinDamage

        //Constructors
        //(FQCTOR)Fully Qualified
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            //If you have ANY properties that have business rules that are based
            //off of any OTHER properties... Set the other properties FIRST. (MaxDamage before MinDamage in this case)
            MaxDamage = maxDamage;
            //Since MinDamage has business rules that depend on the value of MaxDamage, we MUST set MaxDamage before MinDamage
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        //UnQualified Constructor
        //No Default Constructor! We do not want anyone to make a blank weapon with any missing info realated to the weapon.

        //Methods
        //Since DungeonLibrary.Weapon is NOT what we want printed to the string we must override the ToString() method.
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }

    }//end class
}//end namespace
