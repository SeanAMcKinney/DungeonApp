﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //Fields
        private int _life;
        //Properties
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int Evade { get; set; }

        public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }//end if/else
            }//end set
        }//end business

        //No Constructors

        //Methods

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;           
        }

        public virtual int CalcEvadeAttack()
        {
            return Evade;
        }
    }//end class
}//end namespace
