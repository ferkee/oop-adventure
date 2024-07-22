using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public class English : Language
    {
        public English()
        {
            ChooseYourName = "Hello, what is your name";
            DefaultName = "Unknown";
            Welcome = "Welcome {0} to your OOP Adventure!";
            DefaultRoomName = "Room {0} ({1},{2})";
            DefaultRoomDescription = "You are in a room with doors to the {0}.";
            ActionError = "Woopsie";
            Go = "Go";
            GoError = "You can't go that way.";
            WhatToDo = "What do you want to do ?";
            Quit = "quit";
            RoomNew = "You entered {0}. ";
            RoomOld = "You've returned to {0}. ";
            And = "and";
            Comma = ",";
            Space = " ";
        }
    }
}
