using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        private bool isHeadNull => Head == null;
        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            var current = Head;
            while ( current.Next != null )
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (isHeadNull)
            {
                throw new Exception("head boş olamaz");
                return;
            }
            if (isHeadNull)
            {
                throw new Exception("düğüm ve değer boş olamaz");
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while ( current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The refence node is not in this list");
        }

        public void AddAfter(SinglyLinkedListNode<T> refnode,SinglyLinkedListNode<T> newNode)
        {
            var current = Head;
            SinglyLinkedListNode<T> temp;
            while (current != null)
            {
                if (current.Equals(refnode))
                {
                    temp = current.Next;
                    current.Next= newNode;
                    while(current.Next != null)
                    {
                        current = current.Next;

                    }
                    if (current.Next == null)
                    {
                        current.Next = temp;
                    }
                    return;
                }
                current = current.Next;
            }
        }
        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (isHeadNull)
            {
                throw new Exception("head boş olamaz");
                return;
            }
            if (isHeadNull)
            {
                throw new Exception("düğüm ve değer boş olamaz");
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current != null)
            {
                if (current.Next.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The refence node is not in this list");
        }
        public void AddBefore(SinglyLinkedListNode<T> refnode, SinglyLinkedListNode<T> newNode)
        {
            var current = Head;
            SinglyLinkedListNode<T> temp;
            while (current != null)
            {
                if (current.Next.Equals(refnode))
                {
                    temp = current.Next;
                    current.Next = newNode;
                    while (current.Next != null)
                    {
                        current = current.Next;

                    }
                    if (current.Next == null)
                    {
                        current.Next = temp;
                    }
                    return;
                }
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
