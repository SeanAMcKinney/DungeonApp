using System;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public static int Score { get; set; } 
        
        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.ElvenThief:
                    description = "Stealthy Elf Thief";
                    break;
                case Race.MountainDwarf:
                    description = "Strong Bodied Dwarf";
                    break;
                case Race.Halfling:
                    description = "Difficult to Spot Hobbit";
                    break;
                case Race.HumanPalidin:
                    description = "Human Holy Knight";
                    break;
                case Race.Centaur:
                    description = "Fast Fighter - Horse-man";
                    break;
            }

            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +              
                "Block: {4}\n" +
                "Evade: {6}\n" +
                "Description: {5}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),              
                Block,
                description,
                Evade);
        }

        public override int CalcDamage()
        {         
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
