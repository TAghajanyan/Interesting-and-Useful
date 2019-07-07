using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            if (instance1 == instance2)
            {
                Console.WriteLine("instance1.GetHashCode() == instance2.GetHashCode()");
            }
            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance2.GetHashCode());
        }
    }
}
