using EstructuraDeDatos.Contracts;
using EstructuraDeDatos.DynamicStructure;
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

        public Lista<T> LoadAll()
        {
            Lista<T> list = new Lista<T>();

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

        public void SaveAll(Lista<T> list)
        {
            StringBuilder sb = new StringBuilder();

            for (int  i=0; i < list.Count; i++)
            {
                T data = list.ElementAt(i)!;

                //Aquí hay un error

                //data.Ser
                //sb.AppendLine(((T)list.ElementAt(i)).ser);
            }
            //Aquí hay un error

            //foreach (T item in list)
            //    sb.AppendLine(T.Serialize(item));
            
            using (StreamWriter sw = new StreamWriter(_path))
            {
                sw.Write(sb.ToString());
            }
        }
    }
}
