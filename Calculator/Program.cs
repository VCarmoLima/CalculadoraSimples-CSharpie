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
            Console.WriteLine("Bem vindo a calculadora básica de dois operadores!");
            Console.ReadKey();
            Menu();
            }

        static void Menu()
            {
            Console.Clear();

            Console.WriteLine("Qual operação você deseja executar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("");

            Console.Write("Selecione a sua opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
                {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
                }
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
            Menu();
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
            Menu();
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
            Menu();
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
            Menu();
            }
        }
    }
