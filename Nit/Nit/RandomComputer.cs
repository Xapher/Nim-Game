using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nit
{
    class RandomComputer
    {
        int HeapA = 3;
        int HeapB = 5;
        int HeapC = 7;
        int move = 0;
        Dictionary<Moves, float> Moves = new Dictionary<Moves, float>();
        List<Moves> tempMoves = new List<Moves>();
        int Sticks = 0;
        int Heap = 0;
        int games = 0;
        int wins = 0;
        bool movedLast = false;
        public int drawSticks(int max)
        {
            Sticks = new Random().Next(max);
            return Sticks;
        }

        public int chooseHeap()
        {
            int heap = new Random().Next(3) + 1;
            Heap = heap;
            bool Chose = false;
            while (!Chose)
            {
                switch (heap)
                {
                    case (1):
                        if (HeapA != 0)
                        {
                            Chose = true;
                            return heap;
                        }
                        else
                        {
                            heap = new Random().Next(2, 4);
                            Heap = heap;
                        }
                        break;
                    case (2):
                        if (HeapB != 0)
                        {
                            Chose = true;
                            return heap;
                        }
                        else
                        {
                            if (HeapA == 0 && HeapB == 0)
                            {
                                heap = 3;
                            }
                            else if (HeapB == 0 && HeapC == 0)
                            {
                                heap = 1;
                            }
                            else
                            {
                                heap = new Random().Next(100);
                                if (heap > 50)
                                {
                                    heap = 1;
                                }
                                else
                                {
                                    heap = 3;
                                }
                            }
                            Heap = heap;
                        }
                        break;
                    case (3):
                        if (HeapC != 0)
                        {
                            Chose = true;
                            return heap;
                        }
                        else
                        {
                            heap = new Random().Next(2) + 1;
                            Heap = heap;
                        }
                        break;
                }
            }

            return Heap;
        }

        public Moves getMove(int max, int heap)
        {
            return new Moves() { Heap = chooseHeap(), sticks = drawSticks(max), b = new BoardState() { HA = this.HeapA, HB = this.HeapB, HC = this.HeapC }, Move = this.move };
        }

        public void setHeaps(int HeapASize, int HeapBSize, int HeapCSize)
        {
            HeapA = HeapASize;
            HeapB = HeapBSize;
            HeapC = HeapCSize;
            move++;
            Moves g = new Moves() { Heap = this.Heap, sticks = this.Sticks, b = new BoardState() { HA = this.HeapA, HB = this.HeapB, HC = this.HeapC }, Move = this.move };
            tempMoves.Add(g);
        }

        public void newGame(bool win)
        {
            HeapA = 3;
            HeapB = 5;
            HeapC = 7;
            games++;
            if (win)
            {
                wins++;
                foreach (Moves LM in tempMoves)
                {
                    LM.setScore(((float)(LM.Move)) / tempMoves.Count());
                    Moves.Add(LM, LM.getBoardScore());
                }
                tempMoves.Clear();
            }
            else
            {
                foreach (Moves legalMove in tempMoves)
                {
                    legalMove.setScore(((float)-(legalMove.Move)) / tempMoves.Count);
                    Moves.Add(legalMove, legalMove.getBoardScore());
                }
                tempMoves.Clear();
            }
            this.move = 0;
        }

        public void otherPlayerMoved()
        {
            if (movedLast)
            {
                movedLast = false;
            }
            else
            {
                movedLast = true;
            }
        }

        public bool getMovedLast()
        {
            return movedLast;
        }

        public int getWins()
        {
            return wins;
        }
    }
}
//total moves
//move reference
//board state
//board rating
//