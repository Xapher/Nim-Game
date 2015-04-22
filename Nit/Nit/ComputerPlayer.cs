using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nit
{
    class ComputerPlayer
    {
<<<<<<< HEAD
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
                foreach(KeyValuePair<Moves,float> move in Moves)
                {
                    if(move.Value > 0)
                    {
                        if(move.Key.b.HA == this.HeapA && move.Key.b.HB == this.HeapB && move.Key.b.HC == this.HeapC)
                        {
                            Sticks = move.Key.sticks;
                            Console.WriteLine("Matched");
                            break;
                        }
                    }
                }
                Console.WriteLine(Sticks);
=======
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
>>>>>>> origin/master
            return Sticks;
        }

        public int chooseHeap()
        {
<<<<<<< HEAD
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

=======
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
>>>>>>> origin/master
            foreach (KeyValuePair<Moves, float> move in Moves)
            {
                if (move.Value > 0)
                {
<<<<<<< HEAD
                    if (move.Key.b.HA == this.HeapA && move.Key.b.HB == this.HeapB && move.Key.b.HC == this.HeapC)
                    {
                        this.Heap = move.Key.Heap;
                        Console.WriteLine("Match");
                        break;
=======
                    if (move.Key.b.HA1 == this.HeapA && move.Key.b.HB1 == this.HeapB && move.Key.b.HC1 == this.HeapC)
                    {
                        score = move.Key.getBoardScore() > score ? move.Key.getBoardScore() : score;
                        score = move.Key.getBoardScore() == 1 ? move.Key.getBoardScore() : score;
>>>>>>> origin/master
                    }
                }
            }
            return Heap;
        }

        public Moves getMove(int max, int heap)
        {
<<<<<<< HEAD
            return new Moves() { Heap = heap, sticks = drawSticks(max) , b = new BoardState(){HA = this.HeapA, HB = this.HeapB, HC = this.HeapC }, Move = this.move };
=======
            return new Moves() { Heap = heap, sticks = drawSticks(max) , b = new BoardState(){HA1 = this.HeapA, HB1 = this.HeapB, HC1 = this.HeapC }, Move = this.move };
>>>>>>> origin/master
        }

        public void setHeaps(int HeapASize, int HeapBSize, int HeapCSize)
        {
            HeapA = HeapASize;
            HeapB = HeapBSize;
            HeapC = HeapCSize;
            move++;
<<<<<<< HEAD
            Moves g = new Moves() { Heap = this.Heap, sticks = this.Sticks, b = new BoardState() {HA = this.HeapA, HB = this.HeapB, HC = this.HeapC }, Move = this.move };
            tempMoves.Add(g);
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
                foreach(Moves LM in tempMoves)
                {
                    LM.setScore(((float)(LM.Move)) / tempMoves.Count());
                    Moves.Add(LM, LM.getBoardScore());
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
            if(movedLast)
            {
                movedLast = false;
            }
            else
            {
                movedLast = true;
            }
        }

=======
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

>>>>>>> origin/master
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
