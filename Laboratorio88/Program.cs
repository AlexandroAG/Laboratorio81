using System;

namespace Laboratorio88
{
    abstract class ClaseAbstracta
    {
        // Se fuerza la herencia de la clase para definir estos métodos
        abstract protected string tomarValor();
        abstract public string prefixValor(string prefix);

        // Método común
        public void printout()
        {
            Console.WriteLine(tomarValor());
        }
    }

    class ClaseConcretal : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcretal";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcretal";
        }
    }

    class ClaseConcreta2 : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcreta2";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcreta2";
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ClaseConcretal concretal = new ClaseConcretal();
            concretal.printout();
            Console.WriteLine(concretal.prefixValor("ES_"));

            ClaseConcreta2 concreta2 = new ClaseConcreta2();
            concreta2.printout();
            Console.WriteLine(concreta2.prefixValor("ES_"));
        }
    }
}
