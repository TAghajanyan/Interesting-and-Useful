using System;

namespace VarLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Add(5);
            tree.Add(8);
            tree.Add(11);
            tree.Add(7);
            tree.Add(4);
            tree.Add(2);

            Console.WriteLine("Count: " + tree.Count); // 6

            Console.WriteLine("IsNodeExist Param. is 25: " + tree.IsNodeExist(25)); // false
            Console.WriteLine("IsNodeExist Param. is 8: " + tree.IsNodeExist(8)); // true
            Console.WriteLine("IsNodeExist Param. is 3: " + tree.IsNodeExist(3)); // false

            Console.WriteLine("Remove param 7: " + tree.Remove(7)); // true
            Console.WriteLine("Remove param 3: " + tree.Remove(3)); // false
            Console.WriteLine("Count: " + tree.Count); // 5

            Console.WriteLine("IsNodeExist Param. is 7: " + tree.IsNodeExist(7)); // false
        }
    }
}
