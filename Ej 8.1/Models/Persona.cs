using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_8._1.Models
{
    internal class Persona:IComparable
    {
        public int DNI;
        public string Nombre;
        public Persona (int DNI, string nombre)
        {
            this.DNI = DNI;
            Nombre = nombre;
        }
        public int CompareTo(object obj)
        {
            if (obj == null && obj is Persona)
            {
                return this.DNI.CompareTo(DNI);

            }
            return 0;
        }
    }
}
