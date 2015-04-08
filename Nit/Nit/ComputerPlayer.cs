using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nit
{
    class ComputerPlayer
    {
        int HeapA = 3;
        int HeapB = 5;
        int HeapC = 7;
        public int drawSticks(int max)
        {
            return new Random().Next(max) + 1;
        }

        public int chooseHeap()
        {
            int heap = new Random().Next(3) + 1;
            bool Chose = false;
            while(!Chose)
            {
                switch(heap)
                {
                    case(1):
                        if(HeapA != 0)
                        {
                            return heap;
                            Chose = true;
                        }
                        else
                        {
                            heap = new Random().Next(2,4);
                        }
                        break;
                    case(2):
                        if (HeapB != 0)
                        {
                            return heap;
                            Chose = true;
                        }
                        else
                        {
                            heap = new Random().Next(50) + 1;
                            if(heap > 50)
                            {
                                heap = 3;
                            }
                            else
                            {
                                heap = 2;
                            }
                            return heap;
                            Chose = true;
                        }
                        break;
                    case(3):
                        if (HeapC != 0)
                        {
                            return heap;
                            Chose = true;
                        }
                        else
                        {
                            heap = new Random().Next(3);
                        }
                        break;
                }
            }
            return heap;
        }

        public void setHeaps(int HeapASize, int HeapBSize, int HeapCSize)
        {
            HeapA = HeapASize;
            HeapB = HeapBSize;
            HeapC = HeapCSize;
        }
    }
}
