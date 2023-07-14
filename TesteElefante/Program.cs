using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteElefante
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numElefantes, i, cont;

            Console.WriteLine("Digite a quantidade de elefnates: ");
            numElefantes = int.Parse(Console.ReadLine());

            for (i = 1; i <= numElefantes; i++)
            {

                if (i == 1)
                {

                    Console.WriteLine( i + " elefante incomoda muita gente");
                }

                else if (i % 2 == 0)
                {
                    Console.Write( i + " elefantes ");
                    cont = 0;

                    while (cont < i)
                    {
                        Console.Write("incomodam,");
                        cont++;

                    }
                    Console.WriteLine(" muito mais (:");

                }

                else
                {
                    Console.WriteLine(i + " elefantes incomodam muita gente");
                }

            }

            Console.ReadKey();

        }
    }
}
