using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nit
{
    class Moves
    {
        public int Heap {get; set;}
        public int sticks { get; set; }

        public BoardState b { get; set; }

        public int Move { get; set; }

        public float getBoardScore()
        {
            return b.Score1;
        }

        public void setScore(float score)
        {
            b.Score1 = score;
        }
    }
}
