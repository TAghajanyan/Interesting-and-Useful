using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Stream stream = File.Create("Person.xml");

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, person);
            stream.Close();

            stream = File.OpenRead("Person.xml");
            person = formatter.Deserialize(stream) as Person;

            Console.WriteLine("First name: " + person.FirstName + "\nLast name: " + person.LastName);

            Console.ReadKey();

        }
    }
}
