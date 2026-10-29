using EstructuraDeDatos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Domain
{
    internal abstract class Persona: IEntity<long>
    {
       
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return $"Cedula: {Id}\nNombre: {Nombre}\nDireccion: {Direccion}";
        }
    }
}
