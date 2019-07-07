using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_List
{
    class Program
    {
        private static void PrintList(Node val) // val == first
        {
            while (val != null) //  val = first = new Node() != null 
            {
                Console.WriteLine(val.Value); // cw(first.Value == 1)
                val = val.Next; // val = first.Next == sec 
            }
        }

        static void Main(string[] args)
        {
            Node first = new Node();
            first.Value = 1;

            Node sec = new Node();
            sec.Value = 2;

            first.Next = sec;

            Node thr = new Node();
            thr.Value = 3;

            sec.Next = thr;

            PrintList(first);
        }
    }
}
