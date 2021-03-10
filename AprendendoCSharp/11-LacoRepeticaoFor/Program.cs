using System;

namespace _11_LacoRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            

            Console.WriteLine("NOME: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("ALTURA: ");
            string Alturafloat = Console.ReadLine();
            float altura;

            if (Single.TryParse(Alturafloat, out altura))
                p.Altura = altura;
            
            DateTime data;

            Console.WriteLine("data nascimento: ");
            string calcIdade = Console.ReadLine();
            Boolean resp = DateTime.TryParse(calcIdade, out data);
            if (resp == false)
            {
                Console.WriteLine("ERRO NA CONVERSAO");
            }
            else
            {
                p.DataNascimento = data;
            }

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}
