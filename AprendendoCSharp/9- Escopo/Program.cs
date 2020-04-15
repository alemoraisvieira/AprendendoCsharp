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
            bool acompanhado = false;

            int QuantidadePessoas = 2;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else
            {
                mensagemAdicional = "João não está acompnhado"; 
                
            }
            //* OU
            //*if (IdadeJoao >= 18 || QuantidadePessoas >= 2)

            //* E
            //if (IdadeJoao >= 18 && QuantidadePessoas >= 2)


            if (IdadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {

                Console.WriteLine("Joao não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }


        }
    }
}
