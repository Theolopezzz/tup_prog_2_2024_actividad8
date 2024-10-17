using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_8._1.Models
{
    internal class Cuenta:IComparable
    {
        Persona Titular;
        public int Numero;
        public double Saldo;
        public DateTime fecha; 
        public Cuenta(int numero, Persona titular) 
        {
            Numero = numero;
            Titular = titular;
        }
        public Cuenta (int numero, Persona titular, DateTime fecha, double saldo) 
        {
            Numero = numero;
            Titular = titular;
            this.fecha = fecha; 
            Saldo = saldo;  
        }
        public int CompareTo(object obj) 
        {
            if (obj == null && obj is Cuenta)
                return Numero.CompareTo(Numero);
            return 0;
        }
    }
}
