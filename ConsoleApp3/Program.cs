using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valorAcao = { 7, 6, 4, 3, 1 };
            var lucro = 0;

            for (int d0 = 0; d0 < valorAcao.Length; d0++)
            {
                for (int d1 = 0; d1 < valorAcao.Length; ++d1)
                {
                    if (d0 >= d1)
                        continue;

                    if (valorAcao[d0] < valorAcao[d1])
                    {
                        if (lucro < (valorAcao[d1] - valorAcao[d0]))
                        {
                            lucro = valorAcao[d1] - valorAcao[d0];
                        }
                    }
                }
            }

            Console.WriteLine($"Seu lucro máximo foi de R$ {lucro},00");

            Console.ReadKey();
        }
    }
}
