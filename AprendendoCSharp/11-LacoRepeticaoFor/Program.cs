using System;

namespace _11_LacoRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)

            {
                valorInvestido = valorInvestido * 1.0036;
                Console.WriteLine(
                    "Após" + contadorMes +
                    "meses, você terá R$" + valorInvestido
                    );
            }
            Console.ReadLine();
        }
    }
}
