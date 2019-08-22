using System;
using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    public class Person : ISerializable
    {
        [NonSerialized]
        private int id = 254463;

        public string FirstName { get; private set; } = "John";
        public string LastName { get; private set; } = "Smith";

        public Person()
        {
        }

        private Person(SerializationInfo info, StreamingContext context)
        {
            FirstName = info.GetString("FirstName");
            LastName = info.GetString("LastName");
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FirstName", FirstName);
            info.AddValue("LastName", LastName);
        }
    }
}
