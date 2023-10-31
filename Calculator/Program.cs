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
        
        static void Subtracao()
            {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double subtracao = primeiroValor - segundoValor;
            Console.WriteLine("A subtração dos dois valores resultou em: {0}", subtracao);

            Console.ReadKey();
            //Menu();
            }

        static void Divisao()
            {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (primeiroValor == 0)
                {
                Console.WriteLine("O resultado de qualquer operação em que o dividendo é Zero, resulta Zero!");
                }
            else if (segundoValor == 0)
                {
                Console.WriteLine("Não há resultado para qualquer operação em que o divisor é Zero!");
                }
            else
                {
                double divisao = primeiroValor / segundoValor;
                Console.WriteLine("A divisão dos dois valores resultou em: {0}", divisao);
                }

            Console.ReadKey();
            //Menu();
            }

        static void Multiplicacao()
            {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double multiplicacao = primeiroValor * segundoValor;
            Console.WriteLine("A multiplicação dos dois valores resultou em: {0}", multiplicacao);

            Console.ReadKey();
            //Menu();
            }
        }
    }
