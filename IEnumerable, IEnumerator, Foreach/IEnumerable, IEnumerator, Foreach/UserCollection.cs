using System.Collections;

namespace IEnumerable__IEnumerator__Foreach
{
    class UserCollection : IEnumerable, IEnumerator
    {
        Element[] element = null;

        public UserCollection()
        {
            element = new Element[4];
            element[0] = new Element("A", 1, 10);
            element[1] = new Element("B", 2, 20);
            element[2] = new Element("C", 3, 30);
            element[3] = new Element("D", 4, 40);
        }

        int position = -1;

        public object Current => element[position];

        public bool MoveNext()
        {
            if (position < element.Length-1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
