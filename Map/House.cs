using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public partial class House
    {
        // Need a Reference to the player
        // We only want to be able to GET the player, not SET it externally
        public Player Player { get; }

        // 1. private field to store randomization we'll need for the game
        //    Only needs to be created ONCE (readonly)
        // 2. Using a constant seed for Random, will always get the same random results
        //     This helps to reproduce results for testing
        //    For truly Random - send in a completely unique value, like system time
        private readonly Random _rnd = new(1234);

        // Width & Height define the grid dimensions for rooms to exist
        public int Width {  get; set; }
        public int Height { get; set; }
        public Room[] Rooms { get; private set; }

        public House(Player player)
        {
            Player = player;
        }
    }
}
