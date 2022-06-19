using System;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var app = new App(new GameLoop(new UserInterface(new ConsoleUtilities()), new ConsoleUtilities(), new PlayerAutoSelection(new ConsoleUtilities()), new WeaponAutoSelect(new ConsoleUtilities()), new MonsterManager()));
                app.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}