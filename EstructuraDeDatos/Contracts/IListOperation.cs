using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.Contracts
{
    internal interface IListOperation<T>
    {
        void Add(T data);
        void Delete(int position);

        void Delete(T data);
        T? ElementAt(int position);

        void Set(int index, T data);
    }
}
