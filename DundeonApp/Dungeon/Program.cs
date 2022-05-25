using System;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomsEscaped = 0; //score counter
            GameText.GameTitleAndOpeningMessage();
            WeaponAndPlayerAutoSelect.WeaponAndPlayerSelection();
            RoomGetAndGameOptionsLoops.RunRoomAndGameoptions();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" You survived " + roomsEscaped + " room" + ((roomsEscaped == 1) ? "." : "s"));
            Console.ResetColor();
        }//end Main
    }//end class
}//end namespace
