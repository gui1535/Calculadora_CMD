using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma=1, Subtracao=2, Divisao=3, Multiplicacao=4, Potencia=5, Raiz=6, Sair=7 }
        static void Main(string[] args)
        {
            bool escolheSair = false;

            while (!escolheSair) // Enquanto o escolheSair for FALSO faça
            {
                Console.WriteLine("Seja bem vindo ao Calculator, selecione uma das opções: ");
                Console.WriteLine(" 1 - Soma \n 2 - Subtração \n 3 - Divisão \n 4 - Multiplicação \n 5 - Potência \n 6 - Raiz \n 7 - Sair");

                // Uma variavel do tipo Menu, chamada de opcao, é convertida para um numero do tipo Menu
                
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Sair:
                        escolheSair = true;
                        break;
                }

                Console.Clear();

            }
        }
        // SOMA
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        // Subtração
        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        // Divisão
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o dividendo: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o divisor: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a / b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        // Multiplicação
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o multiplicando: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o multiplicador: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        // Potência
        static void Potencia()
        {
            Console.WriteLine("Potência de um numero: ");
            Console.WriteLine("Digite a base: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = Pow(a, b);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
