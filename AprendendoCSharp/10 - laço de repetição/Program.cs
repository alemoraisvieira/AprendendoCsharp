using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___laço_de_repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;
            int mes = 1;

            while (mes <=12)
            {


                //0.36% = 0.0036, pois dividimos por 100
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após 1 mes vc terá " + valorInvestido);

                mes = mes +1;
            }

            Console.ReadLine();           
        }
    }
}
