using System;

namespace BinaryTree
{
    class BinaryTreeBase<T> : IComparable<T> where T : IComparable<T>
    {
        public T Value { get; }

        public BinaryTreeBase<T> Left { get; set; }
        public BinaryTreeBase<T> Right { get; set; }

        public BinaryTreeBase(T value)
        {
            Value = value;
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }
}
