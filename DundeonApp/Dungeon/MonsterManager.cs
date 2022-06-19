using DungeonLibrary;
using MonsterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public interface IMonsterManager
    {
        Monster GetMonster();
    }

    public class MonsterManager : IMonsterManager
    {
        public Monster GetMonster()
        {
            Slime s1 = new Slime();
            Slime s2 = new Slime("Solid Slime", 15, 15, 50, 30, 3, 5, "Not very Jiggly!", true);
            Goblin g1 = new Goblin();
            WizardOrc wO1 = new WizardOrc();
            WizardOrc wO2 = new WizardOrc("Fley'ot the Un-mutable", 20, 20, 50, 25, 8, 20, "Un-natural mystic power... a fiend!", true);
            Kraken k1 = new Kraken();
            Kraken k2 = new Kraken("Leviathan", 35, 35, 65, 40, 5, 30, "Oceanic Catastrophe!", true);
            Imp i1 = new Imp("Waskle the Weenis", 6, 6, 45, 20, 1, 3, "My friends call me Weenis");
            Imp i2 = new Imp();
            Imp i3 = new Imp("Billy Bads", 8, 8, 48, 22, 4, 8, "Who's bad? I'm baaaaaad!");
            BlackDragon bD1 = new BlackDragon();

            Monster[] monsters = { s1, s1, s1, s2, s2, g1, g1, g1, wO1, wO1, wO1, wO2, k1, k2, i1, i2, i2, i2, i3, bD1 };
            Monster monster = RandomMonsterSelection.SelectedMonster(monsters);
            return monster;
        }
    }
}
