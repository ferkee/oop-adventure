using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public class Go : Action
    {
        // override base class virtual proprety Name 
        public override string Name => Text.Language.Go;

        // Go Action needs a reference to the House
        //  allowing us to
        //  1. figure out what room the player is in
        //  2. check the direction of neighboring rooms
        //  3. decide if we can move to the next room
        private readonly House _house;

        public Go(House house)
        {
            _house = house;
        }

        public override void Execute(string[] args)
        {
            var currentRoom = _house.CurrentRoom;
            
            var dir = args[1].Substring(0,1).ToUpper() + args[1].Substring(1).ToLower();
            
            // if fails, 
            Enum.TryParse(dir, out Directions newDirection);

            var nextRoomIndex = currentRoom.Neighbors[newDirection];

            if (nextRoomIndex == -1 || newDirection == Directions.None)
            {
                Console.WriteLine(Text.Language.GoError);
            }
            else
            {
                _house.GoToRoom(nextRoomIndex);
            }
        }
    }
}
