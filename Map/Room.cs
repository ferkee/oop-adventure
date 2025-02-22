﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public class Room
    {
        public string Name { get; set; } = Text.Language.DefaultRoomName;
        public string Description { get; set; } = Text.Language.DefaultRoomDescription;

        // dictionary to represent all the neighbors this room can have
        public Dictionary<Directions, int> Neighbors { get; set; } = new()
        {
                {Directions.None, -1 },
                {Directions.North, -1 },
                {Directions.East, -1 },
                {Directions.South, -1 },
                {Directions.West, -1 },
        };

        public bool Visited { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if(Visited)
            {
                sb.Append(string.Format(Text.Language.RoomOld, Name));
            }
            else
            {
                sb.Append(string.Format(Text.Language.RoomNew, Name));
            }

            var names = Enum.GetNames(typeof(Directions));

            var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();

            var description = string.Format(Description, Text.Language.JoinedWordList(directions, Text.Language.And));

            sb.Append(description);

            return sb.ToString();
        }
    }
}
