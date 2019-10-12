using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] v = { "{", "[", "(", ")", "]", "}" };
            var lastIndex = v.Length - 1;



            for (int i = 0; i < (v.Length / 2); i++)
            {
                if (v[i] == "(")
                {
                    if (v[lastIndex - i] == ")")
                    {
                        continue;
                    }
                }

                if (v[i] == "[")
                {
                    if (v[lastIndex - i] == "]")
                    {
                        continue;
                    }
                }

                if (v[i] == "{")
                {
                    if (v[lastIndex - i] == "}")
                    {
                        continue;
                    }
                }

                //NAO BALANCEADO
                Console.WriteLine("NAO!");
                Console.ReadKey();

                return;
            }

            //BALANCEADO
            Console.WriteLine("SIM!");
            Console.ReadKey();
        }
    }
}
