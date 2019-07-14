using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable__IEnumerator__Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection userCollection = new UserCollection();

            foreach (Element item in userCollection)
            {
                Console.WriteLine($"Name: {item.Name}, Field1: {item.Field1}, Field2: {item.Field2}");
            }

            userCollection.Reset();

            Console.WriteLine(new string('-', 30));

            IEnumerable enumerable = userCollection as IEnumerable;

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Element item = enumerator.Current as Element;

                Console.WriteLine($"Name: {item.Name}, Field1: {item.Field1}, Field2: {item.Field2}");
            }

            userCollection.Reset();
        }
    }
}
