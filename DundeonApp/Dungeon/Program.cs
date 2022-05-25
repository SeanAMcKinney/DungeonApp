using System;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {         
            GameText.GameTitleAndOpeningMessage();
            DungeonLibrary.Weapon equippedWeapon = WeaponAutoSelect.WeaponSelection();
            DungeonLibrary.Player player = PlayerAutoSelection.PlayerSelection(equippedWeapon);
            RoomGetAndGameOptionsLoops.RunRoomAndGameoptions(equippedWeapon, player);
            GameText.GivePlayerScore();
        }//end Main
    }//end class
}//end namespace
