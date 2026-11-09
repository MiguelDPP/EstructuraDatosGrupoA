using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.Contracts
{
    internal interface IPila<T>
    {
        T Pop();
        void Push(T data);
        void Clear();
        T Peek();
    }
}
