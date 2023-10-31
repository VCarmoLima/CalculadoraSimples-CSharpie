using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
    {
    class Program
        {
        static void Main(string[] args)
            {

            }
        static void Soma()
            {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double segundaValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double soma = primeiroValor + segundaValor;
            Console.WriteLine("A soma dos dois valores resultou em: {0}", soma);

            Console.ReadKey();
            //Menu();
            }
        }
    }
