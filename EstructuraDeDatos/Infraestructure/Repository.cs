using EstructuraDeDatos.Contracts;
using EstructuraDeDatos.DynamicStructure;
using EstructuraDeDatos.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Infraestructure
{
    internal class Repository<T,E> : IUnidOfWork, IRepository<T, E> where T : class, IFactory<T>, IEntity<E>, ISerialize<T>
    {
        private Lista<T> _cache;
        private DataStore<T> _store;

        public Repository(string path)
        {
            _store = new DataStore<T>(path);
            _cache = _store.LoadAll() ?? new Lista<T>();
        }


        //public Repository(string path, IDataStore<T> store)
        //{
        //    if (!File.Exists(path))
        //        throw new FileNotFoundException("El archivo no existe");

        //    _store = store;
        //    _cache = new List<T>();

        //    _cache = _store.LoadAll().ToList();
        //}

        //Implementacion de IRepository<T>
        public void Add(T entity)
        {
            _cache.Add(entity);
        }

        public void Delete(E id)
        {
            _cache.Delete(GetById(id));
        }

        public T GetById(E id)
        {
            //foreach(T data in _cache)
            //{
            //    if (data.Id.Equals(id))
            //    {
            //        return data;
            //    }
            //}
            _cache.FirstOrDefault(
                (T data) => data.Id.Equals(id)
            );
            return null;
            //return _cache.FirstOrDefault(d => d.Id.Equals(id));
        }

        public Lista<T> GetAll()
        {
            return _cache;
        }

        //Lambda functions, funciones anonimas, funciones flecha
        //Callback

        public void Update(T entity)
        {
            int index = _cache.FindIndex(
                (T data) => data.Id.Equals(entity.Id)
            );
            //int index = -1;
            //for (int i = 0; i < _cache.Count; i++)
            //{
            //    T data = _cache.ElementAt(i);
            //    if (data.Id.Equals(entity.Id))
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            if (index != -1)
                _cache.Set(index, entity);
        }

        public bool Exist(E Id)
        {
            //for (int i = 0; i < _cache.Count; i++)
            //{
            //    T data = _cache.ElementAt(i)!;
            //    if (data.Id.Equals(Id))
            //    {
            //        return true;
            //    }
            //}
            //return false;
            return _cache.Exists(
                (T data) => data.Id.Equals(Id)
            );
        }

        //Implementacion de IUnitOfWork
        public void Commit() 
        {
            _store.SaveAll(_cache);
        }
    }
}
