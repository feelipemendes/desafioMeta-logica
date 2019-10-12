using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio META - 01 - QUESTÃO");


            int[] nums = { 1,2,3,4,5,6 };

            Console.WriteLine("Insira o alvo:");
            int alvo = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;
                    if ((nums[i] + nums[j]) == alvo)
                    {
                        Console.WriteLine($"Posicao do Alvo {i}, {j}");
                        Console.ReadKey();
                        return;
                    }
                }
                Console.WriteLine("Nenhum alvo encontrado!");
                Console.ReadKey();
                return;
            }
        }
    }
}
