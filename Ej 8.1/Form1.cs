using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ej_8._1.Models;

namespace Ej_8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Banco banco;

        private void bVerCuentas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= banco.CantidadCuentas; i++)
            {
                Cuenta cuenta = banco.VerCuenta(i);
                tBMostrar.Text = $"Nro de cuenta: {cuenta.Numero} | Nombre: {cuenta.Titular.Nombre} | Saldo: {cuenta.Saldo:f2} {Environment.NewLine}";
            }
        }
        
        private void bImportarCuentas_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importar Cuenta";
            openFileDialog1.Filter = "fichero .csv|*.csv";
            string path = openFileDialog1.FileName;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);  
            StreamReader sr = new StreamReader(fs);
            string linea = sr.ReadLine();
            while (sr.EndOfStream ==false)
            {
                linea = sr.ReadLine();
                string[] campos = linea.Split(';');
                int dni = Convert.ToInt32(campos[0]);
                string nombre = campos[1];
                int numero = Convert.ToInt32(campos[2]);
                double saldo = Convert.ToDouble(campos[3]);
                Cuenta cuenta = banco.AgregarCuenta(numero, dni, nombre);
                cuenta.Saldo = saldo;
                sr.Close();
                fs.Close();
            }
        }
    }
}
