using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClass
{
    class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        public int Count { get; private set; }

        public void Print(LinkedList<T> instance, string str)
        {
            LinkedListNode<T> value = head;

            if (value != null)
            {
                Console.WriteLine(str);

                do
                {
                    Console.Write(value.Value + " ");
                    value = value.Next;

                } while (value != null);
            }
            else
            {
                Console.WriteLine("List is empty");
            }
            Console.WriteLine();
        }

        public void Add(T item)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(item);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            Count++;
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = current.Next;

                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;

        }

        public T[] CopyTo(T[] arr, int index)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                arr[index++] = current.Value;
                current = current.Next;
            }

            return arr;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
    }
}
