using EstructuraDeDatos.DynamicStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Contracts
{
    internal interface IDataStore<T> where T : class
    {
        Lista<T> LoadAll();
        void SaveAll(Lista<T> list);
    }
}
