using System;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GameLoop gameLoop = new GameLoop(new UserInterface(new ConsoleUtilities()), new ConsoleUtilities(), new PlayerAutoSelection(new ConsoleUtilities()), new WeaponAutoSelect(new ConsoleUtilities()), new MonsterManager());
                gameLoop.RunRoomAndGameoptions();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}