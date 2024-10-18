using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_8._1.Models
{
    internal class Banco
    {
        List<Cuenta> cuentas = new List<Cuenta>();
        List<Persona> clientes = new List<Persona>();   
        public int CantidadClientes { get { return clientes.Count; } }
        public int CantidadCuentas { get { return cuentas.Count; } }
        public Cuenta VerCuenta(int idx)
        {
            if(idx>0 && idx <cuentas.Count)
                return cuentas[idx];
            return null;
        }
        public Persona VerCliente(int idx)
        {
            if (idx > 0 && idx < clientes.Count)
                return clientes[idx];
            return null;
        }
        public Cuenta AgregarCuenta (int numeroCuenta, int dni, string nombre)
        {
            Persona persona = VerClientePorDNI(dni);
            if (persona==null)
            {
                persona = new Persona(dni, nombre);
                clientes.Add(persona);
            }
            Cuenta cuenta = VerCuentaPorNumero(numeroCuenta);
            if(cuenta == null)
            {
                cuenta = new Cuenta(numeroCuenta, persona);
                cuentas.Add(cuenta);
            }
            return cuenta;
        }
        public Cuenta VerCuentaPorNumero(int numeroCuenta)
        {
            cuentas.Sort();
            Persona a = new Persona (1,"a"); 
            Cuenta cuenta = new Cuenta(numeroCuenta,a);
            int idx = cuentas.BinarySearch (cuenta);
            return cuentas[idx];
        }
        public Persona VerClientePorDNI(int dni)
        {
            clientes.Sort();
            Persona a = new Persona (1,"a");
            int idx = clientes.BinarySearch(a);
            return clientes[idx];
        }
        public bool RestaurarCuenta(int numero, double saldo, DateTime fecha, Persona persona)
        {
            return true;
        }
    }
}
