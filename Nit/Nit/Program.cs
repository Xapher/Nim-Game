using System;
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
                    Play(false);
                    break;
                case ("2"):
                    Console.WriteLine("Player 1 goes first, Please pick any number of sticks to take from a heap.");
                    Play(true);
                    break;
                case ("3"):

                    break;
            }

            
            
        }

        public static void Play(bool Computer)
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
    }
}
