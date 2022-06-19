using DungeonLibrary;
using System;

namespace Dungeon
{
    public interface IGameLoop
    {
        void RunRoomAndGameoptions();
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

        public void RunRoomAndGameoptions()
        {
            _ui.BeginGame();
            Weapon equippedWeapon = _weaponAutoSelect.WeaponSelection();
            Player player = _playerAutoSelection.PlayerSelection(equippedWeapon);

            bool exit = false; //counter for Do/While loop
            Player.Score = 0;//score counter           
            do
            {
                _consoleUtilities.PrintChar(RoomCreation.GetRoom(), 10);

                Monster monster = _monsterManager.GetMonster();

                _consoleUtilities.PrintChar("\n Inside of this room you find a " + monster.Name, 40);

                bool reload = false; //counter for second do/while loop
                do
                {
                    #region MENU
                    ConsoleKey userChoice = InGameMenu.RunInGameMenu();
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:  //do combat
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {                             
                                _ui.IsDead(monster);
                                reload = true;
                                Player.Score++;
                            }
                            break;
                       
                        case ConsoleKey.R: //Run Away                         
                            _ui.RunAway(monster, player);
                            reload = true;
                            Player.Score++;
                            break;
                       
                        case ConsoleKey.P: //Player Info
                            _ui.PlayerInfo(player);
                            break;
                      
                        case ConsoleKey.M: //Monster Info
                            _ui.MonsterInfo(monster);
                            break;

                        case ConsoleKey.W: //Weapon Info
                            _ui.WeaponInfo(equippedWeapon);
                            break;
                      
                        case ConsoleKey.X: //Exit
                        case ConsoleKey.E:
                            _ui.ExitGame();
                            exit = true; //updates exit to leave game
                            break;

                        default:
                            Console.WriteLine(" Are you daft!? Thouset choice is not an option! Please triest again.");
                            break;
                    }
                    #endregion                
                    if (player.Life <= 0) //Check if the player is dead or weakened
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
