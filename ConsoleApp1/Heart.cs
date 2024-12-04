using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeGame
{
    public class Heart
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Heart(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
