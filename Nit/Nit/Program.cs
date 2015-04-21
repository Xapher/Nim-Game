
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. 1P V 2P");
            Console.WriteLine("2. 1P V CPU");
            Console.WriteLine("3. CPU V CPU");
            string Input = Console.ReadLine();
            Game nim = new Game();
            switch (Input)
            {
                case ("1"):
                    Console.WriteLine("Player 1 goes first, Please pick any number of sticks to take from a heap.");
                    Program prog = new Program();
                    nim.Play(false, false);
                    break;
                case ("2"):
                    Console.WriteLine("Player 1 goes first, Please pick any number of sticks to take from a heap.");
                    Program prog2 = new Program();
                    nim.Play(true, false);
                    break;
                case ("3"):
                    Program prog3 = new Program();
                    nim.Play(false, true);
                    break;
            }



        }
    }
}







//if (HeapTotal > 0)
//                    {
//                        Computer2.setHeaps(HeapA.Length, HeapB.Length, HeapC.Length);
//                        switch (Computer2.chooseHeap())
//                        {

//                            case (1):
//                                var li = HeapA.ToList();
//                                Moves move = Computer2.getMove(HeapA.Length, 1);
//                                for (int o = 0; o <= move.sticks - 1; o++)
//                                {
//                                    li.RemoveAt(0);
//                                }
//                                HeapA = li.ToArray();
//                                HeapTotal -= move.sticks + 1;
//                                break;
//                            case (2):
//                                var li2 = HeapB.ToList();
//                                Moves move2 = Computer2.getMove(HeapB.Length, 2);
//                                for (int o = 0; o <= move2.sticks - 1; o++)
//                                {
//                                    li2.RemoveAt(0);
//                                }
//                                HeapB = li2.ToArray();
//                                HeapTotal -= move2.sticks + 1;
//                                break;
//                            case (3):
//                                var li3 = HeapC.ToList();
//                                Moves move3 = Computer2.getMove(HeapC.Length, 3);
//                                for (int o = 0; o <= move3.sticks - 1; o++)
//                                {
//                                    li3.RemoveAt(0);
//                                }
//                                HeapTotal -= move3.sticks + 1;
//                                HeapC = li3.ToArray();
//                                break;
//                        }
//                        Computer1.otherPlayerMoved();
//                    }