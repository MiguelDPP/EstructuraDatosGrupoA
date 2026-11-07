using EstructuraDeDatos.Contracts;
using System;
using System.Collections;
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

    public class Paginator<T> where T : class
    {
        public T Data { get; set; }
        public int Page { get; set; }
        public int TotalPage { get; set; }

        public Paginator(T data, int page, int totalPage)
        {
            Data = data;
            Page = page;
            TotalPage = totalPage;
        }
    }

    public class Lista<T>:IEnumerable<T>, IListOperation<T> where T: class
    {
        private Node<T> Head { get; set; }
        private Node<T> Last { get; set; }
        private int _count;

        private Node<T> Current { get; set; }
        private int _index;
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

        public Paginator<T> moveToHead()
        {
            if (!IsEmpty)
            {
                Current = Head;
                _index = 0;
                return new Paginator<T>(Current.Data, _index + 1, Count);
            }

            return null;
        }

        public Paginator<T> moveToLast()
        {
            if (!IsEmpty)
            {
                Current = Last;
                _index = Count - 1;
                return new Paginator<T>(Current.Data, _index + 1, Count);
            }

            return null;
        }
        public Paginator<T> moveToRigth()
        {
            if (!IsEmpty)
            {
                if (Current != Last)
                {
                    _index++;
                    Current = Current.Next;
                    return new Paginator<T>(Current.Data, _index + 1, Count);
                }

            }

            return null;
        }

        public Paginator<T> moveToLeft()
        {
            if (!IsEmpty)
            {
                if (Current != Head)
                {
                    _index--;
                    Current = Current.Back;
                    return new Paginator<T>(Current.Data, _index + 1, Count);
                }

            }

            return null;
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
                Current = n;
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

        public void Delete(T data)
        {
            if (IsEmpty)
            {
                return;
            }

            if (Head.Data == data)
            {
                Head = Head.Next;
                if (IsEmpty)
                {
                    Last = null;
                }
                else
                {
                    Head.Back = null;
                }
            }
            else
            {
                Node<T> tempo = Head;
                while (tempo.Next != null && tempo.Next.Data != data)
                {
                    tempo = tempo.Next;
                }

                if (tempo.Next == null) return;

                Node<T> temp2 = tempo.Next.Next;
                if (tempo.Next == Last)
                {
                    Last = tempo;
                }
                else
                {
                    temp2.Back = tempo;
                }
                tempo.Next = temp2;
            }
            _count--;
        }
        public void Set(int index, T data)
        {
            if (index >= 0 && index < Count)
            {
                Node<T> temp = Head;

                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }

                temp.Data = data;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = Head;
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

        public T FirstOrDefault(Predicate<T> check)
        {
            Node<T> temp = Head;
            while(temp != null)
            {
                if (check(temp.Data))
                {
                    return temp.Data;
                }

                temp = temp.Next;
            }

            return null;
        }

        public int FindIndex(Predicate<T> check)
        {
            Node<T> temp = Head;
            int index = 0;
            while (temp != null)
            {
                if (check(temp.Data))
                {
                    return index;
                }

                temp = temp.Next;
                index++;
            }

            return -1;
        }

        public bool Exists(Predicate<T> check)
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                if (check(temp.Data))
                {
                    return true;
                }

                temp = temp.Next;
            }

            return false;
        }
    }
}
