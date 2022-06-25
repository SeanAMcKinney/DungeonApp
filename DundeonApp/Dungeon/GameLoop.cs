using DungeonLibrary;
using System;

namespace Dungeon
{
    public interface IGameLoop
    {
        void RunGame();
    }

    public class GameLoop : IGameLoop
    {
        private readonly IUserInterface _ui;
        private readonly IConsoleUtilities _consoleUtilities;
        private readonly IPlayerAutoSelection _playerAutoSelection;
        private readonly IWeaponAutoSelect _weaponAutoSelect;
        private readonly IMonsterManager _monsterManager;

        public GameLoop(IUserInterface ui, IConsoleUtilities consoleUtilities, IPlayerAutoSelection playerAutoSelection, IWeaponAutoSelect weaponAutoSelect, IMonsterManager monsterManager)
        {
            _ui = ui;
            _consoleUtilities = consoleUtilities;
            _playerAutoSelection = playerAutoSelection;
            _weaponAutoSelect = weaponAutoSelect;
            _monsterManager = monsterManager;
        }

        public void RunGame()
        {
            _ui.BeginGame();
            Weapon equippedWeapon = _weaponAutoSelect.WeaponSelection();
            Player player = _playerAutoSelection.PlayerSelection(equippedWeapon);

            bool exit = false;          
            do
            {
                _consoleUtilities.PrintChar(RoomCreation.GetRoom(), 10);

                Monster monster = _monsterManager.GetMonster();

                _consoleUtilities.PrintChar("\n Inside of this room you find a " + monster.Name, 40);

                bool reload = false;
                do
                {               
                    ConsoleKey userChoice = InGameMenu.RunInGameMenu();
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {                             
                                _ui.IsDead(monster);
                                reload = true;
                                Player.Score++;
                            }
                            break;
                       
                        case ConsoleKey.R:                        
                            _ui.RunAway(monster, player);
                            reload = true;
                            Player.Score++;
                            break;
                       
                        case ConsoleKey.P:
                            _ui.PlayerInfo(player);
                            break;
                      
                        case ConsoleKey.M:
                            _ui.MonsterInfo(monster);
                            break;

                        case ConsoleKey.W:
                            _ui.WeaponInfo(equippedWeapon);
                            break;
                      
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            _ui.ExitGame();
                            exit = true; //updates exit to leave game
                            break;

                        default:
                            Console.WriteLine(" Are you daft!? Thouset choice is not an option! Please triest again.");
                            break;
                    }              
                    if (player.Life <= 0)
                    {
                        _ui.AreYouDead();
                        exit = true;
                    }
                } while (!reload && !exit);  //Conditions for relooping to continue
            } while (!exit);//If exit is true, keep looping
            _ui.GivePlayerScore();
        }
    }
}