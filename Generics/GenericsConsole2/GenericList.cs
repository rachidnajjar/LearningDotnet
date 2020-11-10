using System.Collections.Generic;

namespace GenericsConsole2
{
    public class GenericList<T>
    {
        // The nested class is also generic on T.
        private class Node
        {
            // T used in non-generic constructor.
            public Node(T entity)
            {
                next = null;
                this.entity = entity;
            }

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            // T as private member data type.
            private T entity;

            // T as return type of property.
            public T Entity
            {
                get { return this.entity; }
                set { this.entity = value; }
            }
        }

        private Node head;

        // constructor
        public GenericList()
        {
            head = null;
        }
        
        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Entity;
                current = current.Next;
            }
        }
    }


}