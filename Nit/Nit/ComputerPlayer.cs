using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nit
{
    class ComputerPlayer
    {
        private int HeapA = 3;
        private int HeapB = 5;
        private int HeapC = 7;
        private int move = 0;
        private Dictionary<Moves, float> Moves = new Dictionary<Moves, float>();
        private List<Moves> tempMoves = new List<Moves>();
        private int Sticks = 0;
        private int Heap = 0;
        private int games = 0;
        private int wins = 0;
        private bool movedLast = false;
        public int drawSticks(int max)
        {
            Moves key = null;
            Sticks = new Random().Next(max);
            float score = 0;
            foreach (KeyValuePair<Moves, float> move in Moves)
            {
                if (move.Key.getBoardScore() > 0)
                {
                    if (move.Key.b.HA1 == this.HeapA && move.Key.b.HB1 == this.HeapB && move.Key.b.HC1 == this.HeapC)
                    {
                        score = move.Key.getBoardScore() > score ? move.Key.getBoardScore() : score;
                        score = move.Key.getBoardScore() == 1 ? move.Key.getBoardScore() : score;
                    }
                }
            }
            foreach(KeyValuePair<Moves,float> move in Moves)
            {
                if (move.Key.b.HA1 == this.HeapA && move.Key.b.HB1 == this.HeapB && move.Key.b.HC1 == this.HeapC && move.Key.getBoardScore() == score)
                {
                    key = move.Key;
                }
            }
            if (key != null)
            {
                Sticks = key.sticks;
            }
            return Sticks;
        }

        public int chooseHeap()
        {
            Heap = new Random().Next(3) + 1;
                switch (Heap)
                {
                    case (1):
                        Heap = HeapA == 0 ? new Random().Next(2, 4) : Heap;
                        break;
                    case (2):
                        if (HeapB == 0)
                        {
                            if (HeapA == 0 && HeapB == 0)
                            {
                                Heap = 3;
                            }
                            else if (HeapB == 0 && HeapC == 0)
                            {
                                Heap = 1;
                            }
                            else
                            {
                                Heap = new Random().Next(100);
                                if (Heap > 50)
                                {
                                    Heap = 1;
                                }
                                else
                                {
                                    Heap = 3;
                                }
                            }
                        }
                        else
                        {
                            return Heap;
                            
                        }
                        break;
                    case (3):
                        Heap = HeapC == 0 ? new Random().Next(2) + 1 : Heap;
                        break;
                
            }
            float score = 0;
            foreach (KeyValuePair<Moves, float> move in Moves)
            {
                if (move.Value > 0)
                {
                    if (move.Key.b.HA1 == this.HeapA && move.Key.b.HB1 == this.HeapB && move.Key.b.HC1 == this.HeapC)
                    {
                        score = move.Key.getBoardScore() > score ? move.Key.getBoardScore() : score;
                        score = move.Key.getBoardScore() == 1 ? move.Key.getBoardScore() : score;
                    }
                }
            }
            return Heap;
        }

        public Moves getMove(int max, int heap)
        {
            return new Moves() { Heap = heap, sticks = drawSticks(max) , b = new BoardState(){HA1 = this.HeapA, HB1 = this.HeapB, HC1 = this.HeapC }, Move = this.move };
        }

        public void setHeaps(int HeapASize, int HeapBSize, int HeapCSize)
        {
            HeapA = HeapASize;
            HeapB = HeapBSize;
            HeapC = HeapCSize;
            move++;
            Moves newMove = new Moves() { Heap = this.Heap, sticks = this.Sticks, b = new BoardState() {HA1 = this.HeapA, HB1 = this.HeapB, HC1 = this.HeapC }, Move = this.move };
            tempMoves.Add(newMove);
        }

        public void newGame(bool win)
        {
            HeapA = 3;
            HeapB = 5;
            HeapC = 7;
            games++;
            if(win)
            {
                wins++;
                foreach(Moves legalMove in tempMoves)
                {
                    legalMove.setScore(((float)(legalMove.Move)) / tempMoves.Count());
                    Moves.Add(legalMove , legalMove.getBoardScore());
                }
                tempMoves.Clear();
            }
            else
            {
                foreach(Moves legalMove in tempMoves)
                {
                    legalMove.setScore(((float)-(legalMove.Move))/tempMoves.Count);
                    Moves.Add(legalMove, legalMove.getBoardScore());
                }
                tempMoves.Clear();
            }
            this.move = 0;
        }

        public void otherPlayerMoved()
        {
            movedLast = movedLast ? false : true;
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