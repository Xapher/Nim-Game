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
<<<<<<< HEAD
            return b.Score;
=======
            return b.Score1;
>>>>>>> origin/master
        }

        public void setScore(float score)
        {
<<<<<<< HEAD
            b.Score = score;
=======
            b.Score1 = score;
>>>>>>> origin/master
        }
    }
}
