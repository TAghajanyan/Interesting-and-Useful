using System;

namespace BinaryTree
{
    class BinaryTree<T> where T : IComparable<T>
    {
        private BinaryTreeBase<T> _head;
        public uint Count { get; private set; }

        public void Add(T value)
        {
            if (_head == null)
            {
                _head = new BinaryTreeBase<T>(value);
            }
            else
            {
                AddTo(_head, value);
            }
            Count++;
        }

        private void AddTo(BinaryTreeBase<T> node, T value)
        {
            if (value.CompareTo(node.Value) <= 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeBase<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeBase<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public bool IsNodeExist(T value)
        {
            BinaryTreeBase<T> parent;
            return FindNode(value, out parent) != null;
        }

        private BinaryTreeBase<T> FindNode(T node, out BinaryTreeBase<T> parent)
        {
            BinaryTreeBase<T> current = _head;
            parent = null;

            while (current != null)
            {
                if (node.CompareTo(current.Value) == 0)
                {
                    return current;
                }

                if (node.CompareTo(current.Value) <= 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else
                {
                    parent = current;
                    current = current.Right;
                }
            }
            return null;
        }

        public bool Remove(T value)
        {
            BinaryTreeBase<T> parent;
            BinaryTreeBase<T> current = FindNode(value, out parent);

            if (current == null)
                return false;

            Count--;

            if (current.Right == null)
            {
                if (parent == null)
                    _head = current.Left;

                else
                {
                    int res = current.Value.CompareTo(parent.Value);

                    if (res < 0)
                    {
                        parent.Left = current.Left;
                    }
                    else if (res > 0)
                    {
                        parent.Right = current.Left;
                    }
                }
            }
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                    _head = current.Right;

                else
                {
                    int res = current.Value.CompareTo(parent.Value);

                    if (res < 0)
                    {
                        parent.Left = current.Right;
                    }
                    else if (res > 0)
                    {
                        parent.Right = current.Right;
                    }
                }
            }
            else
            {
                BinaryTreeBase<T> endLeft = current.Right.Left;
                BinaryTreeBase<T> endLeftParent = current.Right;

                while (endLeft.Left != null)
                {
                    endLeftParent = endLeft;
                    endLeft = endLeft.Left;
                }

                endLeftParent.Left = endLeft.Right;

                endLeft.Left = current.Left;
                endLeft.Right = current.Right;


                if (parent == null)
                    _head = endLeft;

                else
                {
                    int res = current.Value.CompareTo(parent.Value);

                    if (res < 0)
                    {
                        parent.Left = endLeft;
                    }
                    else if (res > 0)
                    {
                        parent.Right = endLeft;
                    }
                }
            }
            return true;
        }

    }
}
