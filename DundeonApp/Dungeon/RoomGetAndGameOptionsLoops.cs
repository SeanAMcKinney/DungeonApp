using DungeonLibrary;
using MonsterLibrary;
using System;
using System.Threading;

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
                //Get Room
                PrintUtility.Print(RoomCreation.GetRoom(), 10);

                //Monster List
                Slime s1 = new Slime();
                Slime s2 = new Slime("Solid Slime", 15, 15, 50, 30, 3, 5, "Not very Jiggly!", true);
                Goblin g1 = new Goblin();
                WizardOrc wO1 = new WizardOrc();
                WizardOrc wO2 = new WizardOrc("Fley'ot the Un-mutable", 20, 20, 50, 25, 8, 20, "Un-natural mystic power... a fiend!", true);
                Kraken k1 = new Kraken();
                Kraken k2 = new Kraken("Leviathan", 35, 35, 65, 40, 5, 30, "Oceanic Catastrophe!", true);
                Imp i1 = new Imp("Waskle the Weenis", 6, 6, 45, 20, 1, 3, "My friends call me Weenis");
                Imp i2 = new Imp();
                BlackDragon bD1 = new BlackDragon();

                Monster[] monsters = { s1, s1, s1, s2, s2, g1, g1, g1, wO1, wO1, wO1, wO2, k1, k2, i1, i2, i2, i2, bD1 };

                //Second do/while loop
                bool reload = false; //counter for second do/while loop

                //Select random monster for combat in room selected above
                Monster monster =  RandomMonsterSelection.SelectedMonster(monsters);

                PrintUtility.Print("\n Inside of this room you find a " + monster.Name, 40);

                do
                {
                    #region MENU

                    //Console.Write("\n Please choose your course ahead:\n" +
                    //    "A) Attack\n" +
                    //    "R) Run Away\n" +
                    //    "P) Player Info\n" +
                    //    "W) Weapon Info\n" +
                    //    "M) Monster Info\n" +
                    //    "X) Exit\n");

                    //ConsoleKey userChoice = Console.ReadKey(true).Key;
                    ////Executes user input without hitting enter
                    ConsoleKey userChoice = InGameMenu.RunInGameMenu();
                    Console.Clear();

                    // Switch for Choices
                    switch (userChoice)
                    {
                        //Attack
                        case ConsoleKey.A:
                            //do combat
                            Combat.DoBattle(player, monster);

                            if (monster.Life <= 0)
                            {
                                //Monster dies - possible to add further functionality/logic for victory bonuses such as life++ etc...
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                PrintUtility.Print(monster.Name + " is dead! You are VICTORIOUS!", 40);
                                Console.ResetColor();
                                Thread.Sleep(2000);
                                Console.Clear();
                                reload = true; // gets us a new room
                                Player.Score++;
                            }//end if

                            break; //end case A

                        //Run Away
                        case ConsoleKey.R:

                            Console.WriteLine(" You run away!");

                            //Monster gets an attack either way (success in running or not)
                            PrintUtility.Print($"{monster.Name} attacks you as you flee!", 40);
                            Combat.DoOppertunityAttack(monster, player);
                            Console.WriteLine();
                            Thread.Sleep(2000);
                            Console.Clear();
                            reload = true;
                            Player.Score++;

                            break;

                        //Player Info
                        case ConsoleKey.P:

                            //Need to display player's info/stats
                            Console.WriteLine(" Player Info");
                            Console.WriteLine(player);
                            Console.WriteLine(" Rooms Escaped : " + Player.Score);

                            break;

                        //Monster Info

                        case ConsoleKey.M:

                            //Display Monster's Info/stats
                            Console.WriteLine(" Monster Info");
                            Console.WriteLine(monster);

                            break;

                        //Weapon Info

                        case ConsoleKey.W:

                            //Display Weapon Stats/ Info
                            Console.WriteLine(" Weapon Info");
                            Console.WriteLine(equippedWeapon);

                            break;

                        //Exit

                        case ConsoleKey.X:
                        case ConsoleKey.E:

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            PrintUtility.Print(" You are a yellow bellied coward....", 10);
                            Console.ResetColor();

                            exit = true; //updates exit to leave game

                            break;

                        default:

                            Console.WriteLine(" Are you daft!? Thouset choice is not an option! Please triest again.");

                            break;
                    }

                    #endregion

                    //Check if the player is dead or weakened
                    if (player.Life <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Red;
                        PrintUtility.Print(" YOUR FIGHT IS OVER!", 100);
                        PrintUtility.Print(" YOU... ARE.. DEAD!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        exit = true;
                    }

                } while (!reload && !exit);  //Condietions for relooping to continue

            } while (!exit);//If exit is true, keep looping
        }
    }
}
