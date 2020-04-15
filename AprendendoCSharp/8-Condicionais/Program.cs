using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 8 - condicionais");

            int IdadeJoao = 16;
            int QuantidadePessoas = 2;

            if (IdadeJoao >= 18)
            {
                Console.WriteLine("João possui mais que 18 anos");
            }
            else
            {
                if (QuantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao possui menos que 18 anos e a quantidade de pessoas é >=2");
                }
                else 
                {
                    Console.WriteLine("Joao possui menos que 18 anos e a quantidade de pessoas é <2");
                }
                Console.ReadKey();
            }

        }
    }
}
