using DungeonLibrary;
using MonsterLibrary;
using System;

namespace Dungeon
{
    public class RoomGetAndGameOptionsLoops
    {
        public static void RunRoomAndGameoptions(Weapon equippedWeapon, Player player)
        {
            bool exit = false; //counter for Do/While loop
            Player.Score = 0;//score counter           
            do
            {
                PrintUtility.Print(RoomCreation.GetRoom(), 10);

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

                PrintUtility.Print("\n Inside of this room you find a " + monster.Name, 40);

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
                                SwitchCaseMethods.CaseSelectA(monster);
                                reload = true; 
                                Player.Score++;
                            }
                            break;
                       
                        case ConsoleKey.R: //Run Away                         
                            SwitchCaseMethods.CaseSelectR(monster, player);
                            reload = true;
                            Player.Score++;
                            break;
                       
                        case ConsoleKey.P: //Player Info
                            SwitchCaseMethods.CaseSelectP(player);
                            break;
                      
                        case ConsoleKey.M: //Monster Info
                            SwitchCaseMethods.CaseSelectM(monster);
                            break;

                        case ConsoleKey.W: //Weapon Info
                            SwitchCaseMethods.CaseSelectW(equippedWeapon);
                            break;
                      
                        case ConsoleKey.X: //Exit
                        case ConsoleKey.E:
                            SwitchCaseMethods.CaseSelectXorE();
                            exit = true; //updates exit to leave game
                            break;

                        default:
                            Console.WriteLine(" Are you daft!? Thouset choice is not an option! Please triest again.");
                            break;
                    }
                    #endregion                
                    if (player.Life <= 0) //Check if the player is dead or weakened
                    {
                        GameText.AreYouDead();
                        exit = true;
                    }
                } while (!reload && !exit);  //Conditions for relooping to continue
            } while (!exit);//If exit is true, keep looping
        }
    }
}
