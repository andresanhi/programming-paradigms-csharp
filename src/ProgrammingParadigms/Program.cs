using System;

namespace ProgrammingParadigms
{
    class Program
    {
        static void Main(string[] args)
        {
            PairOdd();
        }

        static void PairOdd()
        {
            int num;
            Console.WriteLine("Par o Impar");
            Console.Write("Introduce un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("El número {0} es Par", num);
            else
                Console.WriteLine("El número {0} es Impar", num);
            Console.ReadLine();
        }
    }
}
