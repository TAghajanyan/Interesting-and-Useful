using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClass
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<int> instance = new LinkedList<int>();

            instance.Add(15);
            instance.Add(16);
            instance.Add(17);

            instance.Print(instance, "List");
            Console.WriteLine("\nCount: " + instance.Count);

            instance.Remove(15);
            instance.Print(instance, "\nList (Removed '15')");
            Console.WriteLine("\nCount: " + instance.Count);

            instance.Add(150);

            int[] arr = new int[100];
            arr = instance.CopyTo(arr, 0);

            Console.WriteLine("\nList items in array");
            for (int i = 0; i < instance.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            instance.Clear();
            Console.WriteLine("\nList is cleared");

            Console.ReadKey();
        }
    }
}
