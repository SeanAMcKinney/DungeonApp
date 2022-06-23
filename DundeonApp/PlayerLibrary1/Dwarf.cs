using DungeonLibrary;

namespace PlayerLibrary
{
    public sealed class Dwarf : Player
    {
        public Dwarf(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon, int evade)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            Evade = evade;
        }
    }
}
