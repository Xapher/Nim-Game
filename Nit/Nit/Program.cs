
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nit
{
    class Program
    {
        static bool play = true;
        static int Player = 1;
        static string[] HeapA = { "|", "|", "|" };
        static string[] HeapB = { "|", "|", "|", "|", "|" };
        static string[] HeapC = { "|", "|", "|", "|", "|", "|", "|" };
        static int HeapTotal = 15;
        static ComputerPlayer Computer1 = new ComputerPlayer();
        static ComputerPlayer Computer2 = new ComputerPlayer();
        static RandomComputer RandComp = new RandomComputer();
        static void Main(string[] args)
        {
            Console.WriteLine("1. 1P V 2P");
            Console.WriteLine("2. 1P V CPU");
            Console.WriteLine("3. CPU V CPU");
            string Input = Console.ReadLine();
            switch (Input)
            {
                case ("1"):
                    Console.WriteLine("Player 1 goes first, Please pick any number of sticks to take from a heap.");
                    Program prog = new Program();
                    prog.Play(false,false);
                    break;
                case ("2"):
                    Console.WriteLine("Player 1 goes first, Please pick any number of sticks to take from a heap.");
                    Program prog2 = new Program();
                    prog2.Play(true, false);
                    break;
                case ("3"):
                    Program prog3 = new Program();
                    prog3.Play(false, true);
                    break;
            }



        }

        public void Play(bool Computer, bool cvc)
        {
            if (!Computer && !cvc)
            {
                printBoard();
                while (play == true)
                {
                    while (HeapTotal > 0)
                    {
                        Console.WriteLine("Player " + Player + "'s Turn");
                        Console.WriteLine("How Many sticks do you want to take?");
                        String Response = Console.ReadLine();
                        if (String.IsNullOrEmpty(Response) != true)
                        {
                            int TakeAway = Convert.ToInt32(Response);
                            Console.WriteLine("From What Line");
                            Response = Console.ReadLine();
                            switch (Response)
                            {
                                case ("1"):
                                    if (HeapA.Length < TakeAway)
                                    {
                                        Console.WriteLine("There are not that many sticks in that heap.");
                                    }
                                    else
                                    {
                                        HeapTotal -= TakeAway;
                                        var list = HeapA.ToList();
                                        for (int i = 0; i < TakeAway; i++)
                                        {
                                            list.RemoveAt((HeapA.Length - i) - 1);
                                        }
                                        HeapA = list.ToArray();
                                    }
                                    switch (Player)
                                    {
                                        case (1):
                                            Player = 2;
                                            break;
                                        case (2):
                                            Player = 1;
                                            break;
                                    }
                                    break;
                                case ("2"):
                                    if (HeapB.Length < TakeAway)
                                    {
                                        Console.WriteLine("There are not that many sticks in that heap.");
                                    }
                                    else
                                    {
                                        HeapTotal -= TakeAway;
                                        var list = HeapB.ToList();
                                        for (int i = 0; i < TakeAway; i++)
                                        {
                                            list.RemoveAt((HeapB.Length - i) - 1);
                                        }
                                        HeapB = list.ToArray();
                                    }
                                    switch (Player)
                                    {
                                        case (1):
                                            Player = 2;
                                            break;
                                        case (2):
                                            Player = 1;
                                            break;
                                    }
                                    break;
                                case ("3"):
                                    if (HeapC.Length < TakeAway)
                                    {
                                        Console.WriteLine("There are not that many sticks in that heap.");
                                    }
                                    else
                                    {
                                        HeapTotal -= TakeAway;
                                        var list = HeapC.ToList();
                                        for (int i = 0; i < TakeAway; i++)
                                        {
                                            list.RemoveAt((HeapC.Length - i) - 1);
                                        }
                                        HeapC = list.ToArray();
                                    }
                                    switch (Player)
                                    {
                                        case (1):
                                            Player = 2;
                                            break;
                                        case (2):
                                            Player = 1;
                                            break;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("That Heap Does Not Exist");
                                    break;
                            }
                            printBoard();
                        }
                        else
                        {
                            Console.WriteLine("Your Response Munst Not Be Empty.");
                        }
                    }
                    switch (Player)
                    {
                        case (1):
                            Player = 2;
                            Console.WriteLine("Player " + Player + " Loses");
                            break;
                        case (2):
                            Player = 1;
                            Console.WriteLine("Player " + Player + " Loses");
                            break;
                    }
                    Console.WriteLine("Would You like to Play Again? Y/N");
                    if (Console.ReadLine().Equals("N"))
                    {
                        play = false;
                    }

                }
            }
            else if (Computer)
            {
               
                while (play == true)
                {
                    printBoard();
                    bool PlayerChose = false;
                    while (HeapTotal > 0)
                    {
                        PlayerChose = false;
                        while (!PlayerChose)
                        {
                            Console.WriteLine("Your Turn");
                            Console.WriteLine("How Many sticks do you want to take?");
                            String Response = Console.ReadLine();
                            if (String.IsNullOrEmpty(Response) != true)
                            {
                                int TakeAway = Convert.ToInt32(Response);
                                Console.WriteLine("From What Line");
                                Response = Console.ReadLine();
                                switch (Response)
                                {
                                    case ("1"):
                                        if (HeapA.Length < TakeAway)
                                        {
                                            Console.WriteLine("There are not that many sticks in that heap.");
                                        }
                                        else
                                        {
                                            HeapTotal -= TakeAway;
                                            var list = HeapA.ToList();
                                            for (int i = 0; i < TakeAway; i++)
                                            {
                                                list.RemoveAt((HeapA.Length - i) - 1);
                                            }
                                            HeapA = list.ToArray();
                                            PlayerChose = true;
                                        }
                                        break;
                                    case ("2"):
                                        if (HeapB.Length < TakeAway)
                                        {
                                            Console.WriteLine("There are not that many sticks in that heap.");
                                        }
                                        else
                                        {
                                            HeapTotal -= TakeAway;
                                            var list = HeapB.ToList();
                                            for (int i = 0; i < TakeAway; i++)
                                            {
                                                list.RemoveAt((HeapB.Length - i) - 1);
                                            }
                                            HeapB = list.ToArray();
                                            PlayerChose = true;
                                        }
                                        break;
                                    case ("3"):
                                        if (HeapC.Length < TakeAway)
                                        {
                                            Console.WriteLine("There are not that many sticks in that heap.");
                                        }
                                        else
                                        {
                                            HeapTotal -= TakeAway;
                                            var list = HeapC.ToList();
                                            for (int i = 0; i < TakeAway; i++)
                                            {
                                                list.RemoveAt((HeapC.Length - i) - 1);
                                            }
                                            HeapC = list.ToArray();
                                            PlayerChose = true;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("That Heap Does Not Exist");
                                        break;
                                }
                                Computer1.otherPlayerMoved();

                            }
                            else
                            {
                                Console.WriteLine("Your Response Munst Not Be Empty.");
                            }
                        }

                        if (HeapTotal > 0)
                        {
                            Console.WriteLine("A");
                            Computer1.setHeaps(HeapA.Length, HeapB.Length, HeapC.Length);
                            switch (Computer1.chooseHeap())
                            {
                                case (1):
                                    Console.WriteLine(1);
                                    Moves move = Computer1.getMove(HeapA.Length, 1);
                                    var li = HeapA.ToList();
                                    for (int o = 0; o <= move.sticks; o++)
                                    {
                                        li.RemoveAt(0);
                                    }
                                    HeapA = li.ToArray();
                                    HeapTotal -= move.sticks + 1;
                                    break;
                                case (2):
                                    Console.WriteLine(2);
                                    var li2 = HeapB.ToList();
                                    Moves move2 = Computer1.getMove(HeapB.Length, 2);
                                    for (int o = 0; o <= move2.sticks; o++)
                                    {
                                        li2.RemoveAt(0);
                                    }
                                    HeapB = li2.ToArray();
                                    HeapTotal -= move2.sticks + 1;
                                    break;
                                case (3):
                                    Console.WriteLine(3);
                                    var li3 = HeapC.ToList();
                                    Moves move3 = Computer1.getMove(HeapC.Length, 3);
                                    for (int o = 0; o <= move3.sticks; o++)
                                    {
                                        li3.RemoveAt(0);
                                    }
                                    HeapTotal -= move3.sticks + 1;
                                    HeapC = li3.ToArray();
                                    break;
                            }
                            Computer1.otherPlayerMoved();
                        }
                        printBoard();
                        
                    }

                    Console.WriteLine("Would You like to Play Again? Y/N");
                    String res = Console.ReadLine();
                    if (res.Equals("n") ||res.Equals("N"))
                    {
                        play = false;
                    }
                    else
                    {
                        HeapA = new String[]{ "|", "|", "|" };
                        HeapB = new String[]{ "|", "|", "|", "|", "|" };
                        HeapC = new String[]{ "|", "|", "|", "|", "|", "|", "|" };
                        HeapTotal = 15;
                    }
                }
            }
            else if (cvc)
            {
                Console.WriteLine("How many games do you want the computers to play.");
                String response = Console.ReadLine();
                    int games = 0;
                    if(Int32.TryParse(response, out games))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Your Response must be a number");
                    }
                int i = 0;
                while(i < games){
                    
                    if (HeapTotal <= 0)
                    {
                        Console.WriteLine(HeapTotal);
                        
                        if (Computer1.getMovedLast())
                        {
                            Computer1.newGame(false);
                            RandComp.newGame(true);
                        }
                        else
                        {
                            RandComp.newGame(false);
                            Computer1.newGame(true);
                        }
                        HeapA = new String[] { "|", "|", "|" };
                        HeapB = new String[] { "|", "|", "|", "|", "|" };
                        HeapC = new String[] { "|", "|", "|", "|", "|", "|", "|" };
                        HeapTotal = 15;
                        i++;
                        Console.WriteLine("Game " + i);
                        if(i == games)
                        {
                            break;
                        }
                    }
                    if (HeapTotal > 0)
                    {
                        Computer1.setHeaps(HeapA.Length, HeapB.Length, HeapC.Length);
                        switch (Computer1.chooseHeap())
                        {
                            case (1):
                                Moves move = Computer1.getMove(HeapA.Length, 1);
                                var li = HeapA.ToList();
                                for (int o = 1; o < move.sticks - 1; o++)
                                {
                                    li.RemoveAt(0);
                                }
                                HeapA = li.ToArray();
                                HeapTotal -= move.sticks + 1;
                                break;
                            case (2):
                                var li2 = HeapB.ToList();
                                Moves move2 = Computer1.getMove(HeapB.Length, 2);
                                for (int o = 1; o < move2.sticks - 1; o++)
                                {
                                    li2.RemoveAt(0);
                                }
                                HeapB = li2.ToArray();
                                HeapTotal -= move2.sticks + 1;
                                break;
                            case (3):
                                var li3 = HeapC.ToList();
                                Moves move3 = Computer1.getMove(HeapC.Length, 3);
                                for (int o = 1; o < move3.sticks - 1; o++)
                                {
                                    li3.RemoveAt(0);
                                }
                                HeapTotal -= move3.sticks + 1;
                                HeapC = li3.ToArray();
                                break;
                        }
                        RandComp.otherPlayerMoved();
                    }


                    if (HeapTotal > 0)
                    {
                        RandComp.setHeaps(HeapA.Length, HeapB.Length, HeapC.Length);
                        switch (RandComp.chooseHeap())
                        {

                            case (1):
                                var li = HeapA.ToList();
                                Moves move = RandComp.getMove(HeapA.Length, 1);
                                for (int o = 0; o <= move.sticks - 1; o++)
                                {
                                    li.RemoveAt(0);
                                }
                                HeapA = li.ToArray();
                                HeapTotal -= move.sticks + 1;
                                break;
                            case (2):
                                var li2 = HeapB.ToList();
                                Moves move2 = RandComp.getMove(HeapB.Length, 2);
                                for (int o = 0; o <= move2.sticks - 1; o++)
                                {
                                    li2.RemoveAt(0);
                                }
                                HeapB = li2.ToArray();
                                HeapTotal -= move2.sticks + 1;
                                break;
                            case (3):
                                var li3 = HeapC.ToList();
                                Moves move3 = RandComp.getMove(HeapC.Length, 3);
                                for (int o = 0; o <= move3.sticks - 1; o++)
                                {
                                    li3.RemoveAt(0);
                                }
                                HeapTotal -= move3.sticks + 1;
                                HeapC = li3.ToArray();
                                break;
                        }
                        Computer1.otherPlayerMoved();
                    }
                    
                }
                Console.WriteLine(Computer1.getWins() + " " + RandComp.getWins());
                Console.Read();
            }
        }
        
        public void printBoard()
        {
            Console.Write("1. ");
            foreach (string c in HeapA)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            Console.Write("2. ");
            foreach (string c in HeapB)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            Console.Write("3. ");
            foreach (string c in HeapC)
            {
                Console.Write(c);
            }
            Console.WriteLine();
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