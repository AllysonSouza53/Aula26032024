using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num =0;
            //while (num!=100) { 
            //    num++;
            //    Console.WriteLine(num);
            //}
            //Console.ReadKey();

            //int num = 100;
            //while (num != 0)
            //{
            //    num--;
            //    Console.WriteLine(num);
            //}
            //Console.ReadKey();

            //int num = 0;
            //while (num != 102)
            //{
            //    Console.WriteLine(num);
            //    num +=2;
            //}
            //Console.ReadKey();

            //int mult = 0;
            //Console.WriteLine("Numero para multiplicar: ");
            //mult = int.Parse(Console.ReadLine());

            //int cont = mult;

            //while (cont <= 100)
            //{
            //    Console.WriteLine(cont);
            //    cont += mult;
            //}
            //Console.ReadKey();

            Console.WriteLine("PARES OU IMPARES?:");
            string n = Console.ReadLine();
            int nn = 0;

            while (n == "P") 
            {
                while (nn != 22) {
                    Console.WriteLine(nn);
                    nn+=2;
                    n = "A";
                }
            }
            while (n == "I")
            {
                nn = 1;
                while (nn <= 20)
                {
                    Console.WriteLine(nn);
                    nn += 2;
                    n = "A";
                }
            }
            Console.ReadKey(); 
        }
    }
}
