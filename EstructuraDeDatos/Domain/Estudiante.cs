using EstructuraDeDatos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Domain
{
    internal class Estudiante: Persona, IFactory<Estudiante>, ISerialize<Estudiante>
    {
        public int Semestre { get; set; }
        public string Programa { get; set; }

        private Estudiante()
        { 
            Id = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            Semestre = 0;
            Programa = string.Empty;          
        }

        public static Estudiante Create()
        {
            return new Estudiante();
        }

        public static Estudiante Create(string textCsv)
        {
            return Deserialize(textCsv);
        }

        
        public static Estudiante CrearEstudianteFactory(long cedula, string nombre, string direccion, int semestre, string programa)
        {
            return new Estudiante
            {
                Id = cedula, Nombre = nombre, Direccion = direccion, Programa = programa, Semestre = semestre
            };
        }

        public static Estudiante Deserialize(string textSCV)
        {
            string[] menber = textSCV.Split(',');
            return new Estudiante
            {
                Id = long.Parse(menber[0]),
                Nombre = menber[1],
                Direccion = menber[2],
                Semestre = int.Parse(menber[3]),
                Programa = menber[4],
            };
        }

        public static string Serialize(Estudiante obj)
        {
            return $"{obj.Id},{obj.Nombre},{obj.Direccion},{obj.Semestre},{obj.Programa}";
        }

        public override string ToString()
        {
            return base.ToString() + $",Semestre: {Semestre},Programa: {Programa}".Replace(',','\n');
        }

    }
}
