using EstructuraDeDatos.Contracts;
using EstructuraDeDatos.Domain;
using EstructuraDeDatos.DynamicStructure;
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
        private Lista<Estudiante> cache;
        private Repository<Estudiante, long> _repository;
        private RepositorioEstudiantes(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            _repository = new Repository<Estudiante, long>(path);
            cache = _repository.GetAll();
        }

        public void Add(Estudiante entity)
        {
            _repository.Add(entity);
        }

        public int Find(long id)
        {
            for (int i = 0; i < cache.Count; i++)
            {
                Estudiante data = cache.ElementAt(i);
                if (data.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exist(long id)
        {
            return _repository.Exist(id);
        }


        public Estudiante GetById(long id)
        {
            return _repository.GetById(id);
        }

        public void Update(Estudiante entity)
        {
            //int index = Find(entity.Id);
            //if (index != -1)
            //{
            //    //Ahora volvemos
            //    ///cache[index] =entity;
            //}
            _repository.Update(entity);
        }

        public void Commit()
        {
            _repository.Commit();
        }

        public Lista<Estudiante> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
