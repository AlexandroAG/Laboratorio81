﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio84
{
    class Program
    {
        private static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "John Doe";
            Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");
            CuentaBancaria cta = new CuentaBancaria();
            cta.Saldo = 100;
            Console.WriteLine($"El saldo del empleado: {cta.Saldo}");
            //probar despues con un saldo negativo, para ver la excepción
            Cobertura c = new Cobertura(5);
            Console.WriteLine($"Con una cobertura de: {c.Radio}");
        }
    }

}
