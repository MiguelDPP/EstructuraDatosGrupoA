using EstructuraDeDatos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Persistence
{
    internal class DataStore<T> : IDataStore<T> where T : class, IFactory<T>, ISerialize<T>
    {
        private string _path;
        public DataStore(string path)
        {
            _path = path;
        }

        public IEnumerable<T> LoadAll()
        {
            List<T> list = new List<T>();

            using (StreamReader sr = new StreamReader(_path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? string.Empty;

                    if (string.IsNullOrEmpty(line)) 
                        continue;

                    list.Add(T.Create(line));
                }
            }
            return list;          
        }

        public void SaveAll(IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in list)
                sb.AppendLine(T.Serialize(item));
            
            using (StreamWriter sw = new StreamWriter(_path))
            {
                sw.Write(sb.ToString());
            }
        }
    }
}
