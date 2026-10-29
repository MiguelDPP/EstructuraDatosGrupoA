using EstructuraDeDatos.Contracts;
using EstructuraDeDatos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.Infraestructure
{
    internal class RepositorioEstudiantes : IRepository<Estudiante, long>, IUnidOfWork
    {
        #region Singleton
        private static RepositorioEstudiantes _instance;

        public static RepositorioEstudiantes GetInstance(string path)
        {
            if (_instance == null)
            {
                _instance = new RepositorioEstudiantes(path);
            }
            return _instance;
        }
        #endregion
        private List<Estudiante> cache;
        private Repository<Estudiante, long> _repository;
        public RepositorioEstudiantes(string path)

        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            _repository = new Repository<Estudiante, long>(path);
            cache = _repository.GetAll().ToList();
        }

        public void Add(Estudiante entity)
        {
            cache.Add(entity);
            _repository.Add(entity);
        }

        public int Find(long id)
        {
            
            return cache.FindIndex(p  => p.Id == id);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
            cache.Remove(GetById(id));
        }

        public bool Exist(long id)
        {
            _repository.Exist(id);
            return cache.Exists(p => p.Id == id);
        }

        public IEnumerable<Estudiante> GetAll()
        {
            _repository.GetAll();
            return cache;
        }

        public Estudiante GetById(long id)
        {
            _repository.GetById(id);
            return cache.Find(p => p.Id == id);
        }

        public void Update(Estudiante entity)
        {
            int index = Find(entity.Id);
            if (index != -1)
            {
                cache[index] =entity;
            }
            _repository.Update(entity);
        }

        public void Commit()
        {
            _repository.Commit();
        }
    }
}
