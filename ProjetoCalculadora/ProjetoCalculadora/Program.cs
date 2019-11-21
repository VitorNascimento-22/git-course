using System;

namespace ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora simples:");
            char sair = 'S';
            double adi, sub, div, mult, mod;
            while (sair != 'N')
            {
                Console.WriteLine("Digite o primeiro valor");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                double n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escolha uma operação:\n+=Soma\n-=Subtração\n*=Multiplicação\n/=Divisão\n%=modulo");
                char op = char.Parse(Console.ReadLine());
                if (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')
                {
                    if (op == '+')
                    {
                        adi = soma(n1,n2);
                        Console.WriteLine(adi);
                    }
                    else if (op == '-')
                    {
                        sub = subtração(n1, n2);
                        Console.WriteLine(sub);
                    }
                    else if (op == '*')
                    {
                        mult = multiplicacao(n1, n2);
                        Console.WriteLine(mult);
                    }
                    else if (op == '/')
                    {
                        div = divisao(n1, n2);
                        Console.WriteLine(div);
                    }
                    else
                    {
                        mod = modulo(n1, n2);
                        Console.WriteLine(mod);
                    }
                }
                else
                {
                    Console.WriteLine("Operação inválida");
                }
                Console.WriteLine("Deseja continuar?\nS-Sim\nN=Não");
                sair = char.Parse(Console.ReadLine());
            }

        }

        static double soma(double n1, double n2)
        {
            return n1 + n2;
        }

        static double subtração(double n1, double n2)
        {
            return n1 - n2;
        }

        static double divisao(double n1, double n2)
        {
            return n1 / n2;
        }

        static double multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        static double modulo(double n1, double n2)
        {
            return n1 % n2;
        }
    }
}
