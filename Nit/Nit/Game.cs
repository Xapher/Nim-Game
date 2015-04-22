using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Nit
{
    class Game
    {
        private bool play = true;
        private int Player = 1;
        private string[] HeapA = { "|", "|", "|" };
        private string[] HeapB = { "|", "|", "|", "|", "|" };
        private string[] HeapC = { "|", "|", "|", "|", "|", "|", "|" };
        private int HeapTotal = 15;
        public void Play(bool Computer, bool cvc)
        {
            //REMOVE COMPLEMENT
            //if(Computer)
            //if(cvc)
            //else
            if (Computer)
            {
                ComputerPlayer Computer1 = new ComputerPlayer();
                while (play)
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
                            //REMOVE COMPLEMENT
                            if (String.IsNullOrEmpty(Response))
                            {
                                Console.WriteLine("Your Response Munst Not Be Empty.");
                            }
                            else
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
                                            List<String> list = HeapA.ToList();
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
                                            List<String> list = HeapB.ToList();
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
                                            List<String> list = HeapC.ToList();
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
                        }

                        if (HeapTotal > 0)
                        {
                            Computer1.setHeaps(HeapA.Length, HeapB.Length, HeapC.Length);
                            switch (Computer1.chooseHeap())
                            {
                                case (1):
                                    Moves move = Computer1.getMove(HeapA.Length, 1);
                                    List<String> li = HeapA.ToList();
                                    for (int o = 0; o <= move.sticks; o++)
                                    {
                                        li.RemoveAt(0);
                                    }
                                    HeapA = li.ToArray();
                                    HeapTotal -= move.sticks + 1;
                                    break;
                                case (2):
                                    List<String> li2 = HeapB.ToList();
                                    Moves move2 = Computer1.getMove(HeapB.Length, 2);
                                    for (int o = 0; o <= move2.sticks; o++)
                                    {
                                        li2.RemoveAt(0);
                                    }
                                    HeapB = li2.ToArray();
                                    HeapTotal -= move2.sticks + 1;
                                    break;
                                case (3):
                                    List<String> li3 = HeapC.ToList();
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
                    if (res.Equals("n") || res.Equals("N"))
                    {
                        play = false;
                    }
                    else
                    {
                        HeapA = new String[] { "|", "|", "|" };
                        HeapB = new String[] { "|", "|", "|", "|", "|" };
                        HeapC = new String[] { "|", "|", "|", "|", "|", "|", "|" };
                        HeapTotal = 15;
                    }
                }
            }
            else if (cvc)
            {
                ComputerPlayer Computer1 = new ComputerPlayer();
                ComputerPlayer Computer2 = new ComputerPlayer();
                RandomComputer RandComp = new RandomComputer();
                Console.WriteLine("How many games do you want the computers to play.");
                String response = Console.ReadLine();
                int games = 0;
                if (Int32.TryParse(response, out games))
                {

                }
                else
                {
                    Console.WriteLine("Your Response must be a number");
                }
                int i = 0;
                while (i < games)
                {
                    if (HeapTotal <= 0)
                    {

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
                        if (i == games)
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
                                List<String> li = HeapA.ToList();
                                for (int o = 1; o < move.sticks - 1; o++)
                                {
                                    li.RemoveAt(0);
                                }
                                HeapA = li.ToArray();
                                HeapTotal -= move.sticks + 1;
                                break;
                            case (2):
                                List<String> li2 = HeapB.ToList();
                                Moves move2 = Computer1.getMove(HeapB.Length, 2);
                                for (int o = 1; o < move2.sticks - 1; o++)
                                {
                                    li2.RemoveAt(0);
                                }
                                HeapB = li2.ToArray();
                                HeapTotal -= move2.sticks + 1;
                                break;
                            case (3):
                                List<String> li3 = HeapC.ToList();
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
                                List<String> li = HeapA.ToList();
                                Moves move = RandComp.getMove(HeapA.Length, 1);
                                for (int o = 0; o <= move.sticks - 1; o++)
                                {
                                    li.RemoveAt(0);
                                }
                                HeapA = li.ToArray();
                                HeapTotal -= move.sticks + 1;
                                break;
                            case (2):
                                List<String> li2 = HeapB.ToList();
                                Moves move2 = RandComp.getMove(HeapB.Length, 2);
                                for (int o = 0; o <= move2.sticks - 1; o++)
                                {
                                    li2.RemoveAt(0);
                                }
                                HeapB = li2.ToArray();
                                HeapTotal -= move2.sticks + 1;
                                break;
                            case (3):
                                List<String> li3 = HeapC.ToList();
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
            else
            {
                printBoard();
                while (play)
                {
                    while (HeapTotal > 0)
                    {
                        Console.WriteLine("Player " + Player + "'s Turn");
                        Console.WriteLine("How Many sticks do you want to take?");
                        String Response = Console.ReadLine();
                        //REMOVE COMPLEMENT
                        if (String.IsNullOrEmpty(Response))
                        {
                            Console.WriteLine("Your Response Munst Not Be Empty.");
                        }
                        else
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
                                        List<String> list = HeapA.ToList();
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
                                        List<String> list = HeapB.ToList();
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
                                        List<String> list = HeapC.ToList();
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

