using EstructuraDeDatos.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.DynamicStructure
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Back { get; set; }

        public Node (T data)
        {
            Data = data;
        }
    }

    internal class Lista<T>: IListOperation<T> where T: class
    {
        private Node<T> Head { get; set; }
        private Node<T> Last { get; set; }
        private int _count;
        public int Count {
            get
            {
                return _count;
            }   
        }
        public bool IsEmpty
        {
            get
            {
                return Head == null;
            }
        }

        public Lista()
        {
            _count = 0;
        }

        public void Add(T data)
        {
            Node<T> n = new Node<T>(data);
            if (IsEmpty)
            {
                Head = n;
                Last = n;
            }
            else
            {
                n.Back = Last;
                Last.Next = n;
                Last = n;
            }
            _count++;
        }

        public void Delete(int position)
        {
            if (position >= 0 && position < Count)
            {
                if (position == 0)
                {
                    Head = Head.Next;
                    if (IsEmpty)
                    {
                        Last = null;
                    } else
                    {
                        Head.Back = null;
                    }
                }
                else
                {
                    Node<T> temp = Head;
                    for (int i = 0; i < position - 1; i++)
                    {
                        temp = temp.Next;
                    }
                    Node<T> temp2 = temp.Next.Next;
                    if (temp.Next == Last)
                    {
                        Last = temp;
                    }
                    else
                    {
                        temp2.Back = temp;
                    }
                    temp.Next = temp2;
                }
                _count--;
            }
        }

        public T? ElementAt(int position)
        {
            if (position < 0 || position >= Count)
            {
                return null;
            }

            Node<T> temp = Head;
            for (int i = 0; i < position; i++)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }
    }
}
