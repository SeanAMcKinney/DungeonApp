using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class RandomMonsterSelection
    {
       public static Monster SelectedMonster(Monster[] monsters)
        {
            Random rand3 = new Random();
            int randomNumber3 = rand3.Next(monsters.Length);
            Monster monster = monsters[randomNumber3];
            return monster;
        }
    }
}
