using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            numero =  int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Numero");
            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

        }
    }
}