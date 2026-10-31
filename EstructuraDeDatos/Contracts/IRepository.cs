using EstructuraDeDatos.DynamicStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Contracts
{
    public interface IRepository<T,E> where T : class, IEntity<E>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(E id);
        bool Exist(E id);
        T GetById(E id);
        Lista<T> GetAll(); //la implementan las listas
    }

}
