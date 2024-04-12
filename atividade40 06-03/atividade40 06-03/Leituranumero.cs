using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace exercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue; 
            int menor = int.MaxValue;
            
                    Console.Write("Digite um número inteiro: ");
                    int valor = int.Parse(Console.ReadLine());
                {
                while (valor > 0)
                {
                    if (valor < 0)


                        if (valor > maior)
                            maior = valor;

                    if (valor < menor)
                        menor = valor;
                }
                }

                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
                }
            

            Console.WriteLine($"O maior número lido foi: {maior}");
            Console.WriteLine($"O menor número lido foi: {menor}");
        }
    }
}

