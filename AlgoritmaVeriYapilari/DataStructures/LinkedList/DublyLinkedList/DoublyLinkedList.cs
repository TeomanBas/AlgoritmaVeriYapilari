using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.DublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable
    {

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }
        public DoublyLinkedListNode<T> Head {  get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        private bool isHeadNull => Head == null;
        private bool isTailNull => Tail == null;

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;

            if (Tail == null)
            {
                Tail = Head;
            }
            return;
        }
        public void AddLast(T value)
        {
            if(Tail== null)
            {
                AddFirst(value);
                return;
            }

            var newNode= new DoublyLinkedListNode<T>(value);
            Tail.Next = newNode;
            newNode.Next = null;
            newNode.Prev = Tail;
            Tail = newNode;
            return;
        }
        public void AddAfter(DoublyLinkedListNode<T> refNode,DoublyLinkedListNode<T> newNode)
        {
            if(refNode == null)
            {
                throw new ArgumentNullException();
            }
            if (refNode == Head && refNode == Tail)
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Prev = refNode;
                newNode.Next= null;
                
                Head = refNode;
                Tail= newNode;

                return;
            }

            if(refNode != Tail)
            {
                newNode.Prev= refNode;
                newNode.Next= refNode.Next;

                refNode.Next.Prev = newNode;
                refNode.Next = newNode;
            }
            else
            {
                newNode.Prev = refNode;
                newNode.Next = null;

                refNode.Next = newNode;
                Tail = newNode;

            }
        }

        public void AddBefore(DoublyLinkedListNode<T> refNode,DoublyLinkedListNode<T> newNode)
        {
            throw new NotImplementedException();
        }

        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;
            while(current != null)
            {
                list.Add(current); current = current.Next;
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }

        public T RemoveFirst()
        {
            if(isHeadNull)
            {
                throw new Exception();
            }

            var temp = Head.Value;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;

            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }


            return temp;
        }

        public T RemoveLast()
        {
            if(isTailNull)
            {
                throw new Exception();
            }
            var temp = Tail.Value;
            if(Tail == Head)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }

            return temp;
        }

        public void Delete(T Value)
        {
            if (isHeadNull)
            {
                throw new Exception();
            }
            if(Head== Tail)
            {
                if(Head.Value.Equals(Value))
                {
                    RemoveFirst();
                }
                return;

            }

            var current = Head;

            while(current != null)
            {
                if(current.Prev == null)
                {
                    current = current.Next;
                    Head = current.Next;

                }else if(current.Next == null)
                {
                    current.Prev.Next = null;
                    Head = current.Next;
                }else if(current.Next == null)
                {
                    current.Prev.Next = null;
                    Tail = current.Prev;

                }
                else
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;

                }
                break;
            }
        }
    }
}
