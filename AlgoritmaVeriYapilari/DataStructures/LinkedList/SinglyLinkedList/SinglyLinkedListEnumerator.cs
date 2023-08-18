using System.Collections;
using System.Runtime.Serialization;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    [Serializable]
    internal class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> Head;
        private SinglyLinkedListNode<T> _Current;

        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head) 
        {
            Head = head;
        }
        public T Current => _Current.Value;

        object IEnumerator.Current => _Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if(_Current == null)
            {
                _Current = Head;
                return true;
            }
            else
            {
                _Current = _Current.Next;
                return _Current != null ? true : false;

            }
        }

        public void Reset()
        {
            _Current = null;
        }
    }
}