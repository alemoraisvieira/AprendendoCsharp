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

            if (IdadeJoao >= 18 || QuantidadePessoas >= 2)
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {

                Console.WriteLine("Joao não pode entrar");
            }


        }
    }
}
