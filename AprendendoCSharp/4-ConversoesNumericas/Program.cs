using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesNumericas
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            salario = 1200.50;

            int salarioInteiro;
            salarioInteiro = (int)salario;

            Console.WriteLine("salario inteiro é" + salarioInteiro);

            long idade;
            idade = 2000000000000000000;
            Console.WriteLine(idade);

            Console.ReadLine();

        }
    }
}
