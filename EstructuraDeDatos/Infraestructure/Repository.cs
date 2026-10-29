using EstructuraDeDatos.Contracts;
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
        private List<T> _cache;
        private DataStore<T> _store;

        public Repository(string path)
        {
            _store = new DataStore<T>(path);         
            _cache = _store.LoadAll().ToList() ?? new List<T>();
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
            _cache.Remove(GetById(id));
        }

        public T GetById(E id)
        {
            return _cache.FirstOrDefault(d => d.Id.Equals(id));
        }

        public IEnumerable<T> GetAll()
        {
            return _cache;
        }

        public void Update(T entity)
        {
            int index = _cache.FindIndex(d => d.Id.Equals( entity.Id));
            if(index != -1)
                _cache[index] = entity;
        }

        public bool Exist(E Id)
        {
            return _cache.Exists(d => d.Id.Equals(Id));
        }

        //Implementacion de IUnitOfWork
        public void Commit() 
        {
            _store.SaveAll(_cache);
        }
    }
}
