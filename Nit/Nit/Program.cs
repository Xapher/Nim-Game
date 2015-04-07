using System;
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
            string[] HeapA = { "|", "|", "|" };
            string[] HeapB = { "|", "|", "|", "|", "|" };
            string[] HeapC = { "|", "|", "|", "|", "|", "|", "|" };
            int HeapTotal = 15;
            Console.WriteLine("1. 1P V 2P");
            Console.WriteLine("2. 1P V CPU");
            Console.WriteLine("3. CPU V CPU");
            string Input = Console.ReadLine();
            switch (Input)
            {
                case ("1"):
                    Console.WriteLine("Player 1 goes first, Please pick any number of sticks to take from a heap.");
                    break;
                case ("2"):
                    Console.WriteLine("Player 1 goes first, Please pick any number of sticks to take from a heap.");
                    break;
                case ("3"):

                    break;
            }
            foreach (string c in HeapA)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (string c in HeapB)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (string c in HeapC)
            {
                Console.Write(c);
            }
            Console.Read();
        }
    }
}
