using EstructuraDeDatos.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.DynamicStructure
{
    public class NodePila<T> where T: class
    {
        public T Data { get; set; }
        public NodePila<T> Next { get; set; }

        public NodePila(T data)
        {
            Data = data;
        }
    }

    public class Pila<T>: IEnumerable<T>, IPila<T> where T: class
    {
        private NodePila<T> Top { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty
        {
            get
            {
                return Top == null;
            }
        }

        public void Clear()
        {
            Top = null;
            Count = 0;
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                NodePila<T> element = Top;
                Top = Top.Next;

                Count--;

                return element.Data;
            }

            return null;
        }

        public void Push(T data)
        {
            NodePila<T> n = new NodePila<T>(data);
            n.Next = Top;
            Top = n;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            NodePila<T> temp = Top;
            while(temp != null)
            {
                yield return temp.Data;
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T Peek()
        {
            return Top.Data;
        }
    }
}
