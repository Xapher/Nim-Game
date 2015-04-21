using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nit
{
    class BoardState
    {
        private int HA = 0;

        public int HA1
        {
            get { return HA; }
            set { HA = value; }
        }
        private int HB = 0;

        public int HB1
        {
            get { return HB; }
            set { HB = value; }
        }
        private int HC = 0;

        public int HC1
        {
            get { return HC; }
            set { HC = value; }
        }
        private float Score = 0;

        public float Score1
        {
            get { return Score; }
            set { Score = value; }
        }

    }
}
