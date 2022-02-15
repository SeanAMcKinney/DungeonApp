﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonsterLibrary;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {

            //Opening 
            Console.Title = "FIGHT OR FLIGHT DUNGEON";
            Console.WriteLine("How long can you last...?");

            //How is this game scored: A player gets 1 point for each room they exit.  Fight it out or run away it makes no difference, but you will pay... in BLOOD! 
            int roomsEscaped = 0;

            //Player needs to select a Race:  Race to have relavent sat bonuses and penalties
            //ToDo must create races / set up menu for selection


            //Player must select a weapon:  Weapon will have bonuses
            //ToDo must creat weapons / set up menue for selection

            //Loop for room

            bool exit = false; //counter for Do/While loop

            do
            {
                //Get Room
                Console.WriteLine(GetRoom());
                //TODO write get room function / create library of rooms w/ descriptions.  Room generator online will help

                //Need Monster list
                //ToDo create monster library 
                //use Monster[] array to collect all monsters in monsters variable
                Monster[] monsters = { };

                //Second do/while loop
                bool reload = false; //counter for second do/while loop

                //Select random monster for combat in room selected above
                Random rand = new Random();
                int randomNumber = rand.Next(monsters.Length);
                Monster monster = monsters[randomNumber];

                Console.WriteLine("\nInside of this room you find a " + monster.Name);
                //ToDo write a better line for above 
                do
                {
                    #region MENU
                    //ToDo possibly add more functionality to menu

                    Console.Write("\nPlease choose your course ahead:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        //"U) Use Ability" + //This is just an IDEA
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //Executes user input without hitting enter

                    Console.Clear();

                    //Build Switch for Choices
                    switch (userChoice)
                    {
                        //Attack
                        case ConsoleKey.A:
                            //do combat
                            Combat.DoBattle(player, monster); //ToDo create combat class and player class

                            if (monster.Life <= 0)
                            {
                                //Monster dies - possible to add further functionality/logic for victory bonuses such as life++ etc...
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("{0} is dead! You are VICTORIOUS!", monster.Name);
                                Console.ResetColor();
                                reload = true; // gets us a new room
                                roomsEscaped++;
                            }//end if

                            break; //end case A

                        //Run Away
                        case ConsoleKey.R:

                            //ToDo add logic that decides if you succeed at your attempt to flee - set up RunAway class and flee-logic

                            Console.WriteLine("You run away!");

                            //Monster gets an attack either way (success in running or not)
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true;

                            break;

                        //Possible use ability option
                        //case ConsoleKey.U:
                        //ToDo logic for and class for ability use

                        //Player Info
                        case ConsoleKey.P:

                            //Need to display player's info/stats
                            Console.WriteLine("Player Info");
                            Console.WriteLine(player);
                            Console.WriteLine("Rooms Escaped : " + roomsEscaped);

                            break;

                        //Monster Info

                        case ConsoleKey.M:

                            //Display Monster's Info/stats
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);

                            break;

                        //Exit

                        case ConsoleKey.X:
                        case ConsoleKey.E:

                            Console.WriteLine("You are a coward....");

                            exit = true; //updates exit to leave game

                            break;

                        default:

                            Console.WriteLine("Are you daft!? Thouset choice is not an option! Plese triest again.");

                            break;
                    }


                    #endregion

                    //Check if the player is dead or weakened
                    if (player.life <= 0)//ToDo Add in player class and race selection
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("YOUR FIGHT IS OVER! You are dead...");
                        Console.ResetColor();

                        exit = true;
                    }

                } while (!reload && !exit);  //Condietions for relooping to continue


            } while (!exit);//If exit is true, keep looping

            //Give the players score
            Console.WriteLine("You survived " + roomsEscaped + " room" + ((roomsEscaped == 1) ? "." : "s"));

        }//end Main

        private static string GetRoom()
        {
            string[] rooms =
            {
                "Thick cobwebs fill the corners of the room, and wisps of webbing hang from the ceiling and waver in a wind you can barely feel. One corner of the ceiling has a particularly large clot of webbing within which a goblin's bones are tangled",
                "Stinking smoke wafts up from braziers made of skulls set around the edges of this room. The walls bear scratch marks and lines of soot that form crude pictures and what looks like words in some language [Goblin]. To the left lies a pile of rubbish and rubble heaped into a crude dais. The dais has upon it an ironbound chest that has been painted with a goblinlike face. Furs and skins of unknown origin are strewn haphazardly about the floor before the dais.",
                "A dim bluish light suffuses this chamber, its source obvious at a glance. Blue-glowing lichen and violet-glowing moss cling to the ceiling and spread across the floor. It even creeps down and up each wall, as if the colonies on the floor and ceiling are growing to meet each other. Their source seems to be a glowing, narrow crack in the ceiling, the extent of which you cannot gauge from your position. The air in the room smells fresh and damp.",
                "A 30-foot-tall demonic idol dominates this room of black stone. The potbellied statue is made of red stone, and its grinning face holds what looks to be two large rubies in place of eyes. A fire burns merrily in a wide brazier the idol holds in its lap.",
                "There's a hiss as you open this door, and you smell a sour odor, like something rotten or fermented. Inside you see a small room lined with dusty shelves, crates, and barrels. It looks like someone once used this place as a larder, but it has been a long time since anyone came to retrieve food from it.",
                "The strong, sour-sweet scent of vinegar assaults your nose as you enter this room. Sundered casks and broken bottle glass line the walls of this room. Clearly this was someone's wine cellar for a time. The shards of glass are somewhat dusty, and the spilled wine is nothing more than a sticky residue in some places.",
                "You open the door and before you is a dragon's hoard of treasure. Coins cover every inch of the room, and jeweled objects of precious metal jut up from the money like glittering islands in a sea of gold. But you soon realize, it is an illusion.",
                "The manacles set into the walls of this room give you the distinct impression that it was used as a prison and torture chamber, although you can see no evidence of torture devices. One particularly large set of manacles -- big enough for an ogre -- have been broken open.",
                "You've opened the door to a torture chamber. Several devices of degradation, pain, and death stand about the room, all of them showing signs of regular use. The wood of the rack is worn smooth by struggling bodies, and the iron maiden appears to be occupied by a corpse.",
                "You enter a small room and your steps echo. Looking about, you're uncertain why, but then a wall vanishes and reveals an enormous chamber. The wall was an illusion and whoever cast it must be nearby!",
                "The door to this room swings open easily on well-oiled hinges. Beyond it you see that the chamber walls have been disguised by wood paneling, and the stone ceiling and floor are hidden by bright marble tiles. Several large and well-stuffed chairs are arranged about the room along with some small reading tables.",
                "A glow escapes this room through its open doorways. The masonry between every stone emanates an unnatural orange radiance. Glancing quickly about the room, you note that each stone bears the carving of someone's name.",
                "This chamber holds one occupant: the statue of a male figure with elven features but the broad, muscular body of a hale human. It kneels on the floor as though fallen to that posture. Both its arms reach upward in supplication, and its face is a mask of grief. Two great feathered wings droop from its back, both sculpted to look broken. The statue is skillfully crafted.",
                "You poke your head through the break in the wall and look upon a room of titanic size. It is clearly an enormous mausoleum built to the proportions of giants. Huge niches are set into the walls within which you can discern giant bones. Stern-looking statues of stone giants stand 20 feet tall against the walls, and in the center of the room lies a 15-foot-long sarcophagus.",
                "This hall stinks with the wet, pungent scent of mildew. Black mold grows in tangled veins across the walls and parts of the floor. Despite the smell, it looks like it might be safe to travel through. A path of stone clean of mold wends its way through the hallway.",
                "Rounded green stones set in the floor form a snake's head that points in the direction of the doorway you stand in. The body of the snake flows back and toward the wall to go round about the room in ever smaller circles, creating a spiral pattern on the floor. Similar green-stone snakes wend along the walls, seemingly at random heights, and their long bodies make wave shapes.",
                "This room looks like it was designed by drow. Rusted metal tiles create a huge mosaic of a spider in the floor, and someone set up rusted gratings like draperies of webs. At the far end of the chamber, the carving of a spider squats on the floor. It's about 3 feet tall and seems molded into the floor. Beyond it stands tall double doors of stone, their surface covered in a glittering web of gold.",
                "Several white marble busts that rest on white pillars dominate this room. Most appear to be male or female humans of middle age, but one clearly bears small horns projecting from its forehead and another is spread across the floor in a thousand pieces, leaving one pillar empty.",
                "Tapestries decorate the walls of this room. Although they may once have been brilliant in hue, they now hang in graying tatters. Despite the damage of time and neglect, you can perceive once-grand images of wizards' towers, magical beasts, and symbols of spellcasting. The tapestry that is in the best condition bulges out weirdly, as though someone stands behind it.",
                "A huge iron cage lies on its side in this room, and its gate rests open on the floor. A broken chain lies under the door, and the cage is on a rotting corpse that looks to be a hobgoblin. Another corpse lies a short distance away from the cage. It lacks a head."
            };

            //Random room selection
            Random rand = new Random();

            int indexNumber = rand.Next(rooms.Length);

            string room = rooms[indexNumber];

            return room;
        }//end GetRoom() method

    }//end class
}//end namespace
