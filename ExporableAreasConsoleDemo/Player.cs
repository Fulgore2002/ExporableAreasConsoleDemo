using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExporableAreasConsoleDemo
{
    internal class Player: Person
    {
        public int Lives = 3;
        public int Score = 0;
        public int Level = 0;

        public Player(string name)
        {
            Name = "Anonymous Player";
            if (name != "")
            {
                Name = name;
            }

        }
    }
}
