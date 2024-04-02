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

            //Console.WriteLine("PARES OU IMPARES?:");
            //string n = Console.ReadLine();
            //int nn = 0;

            //while (n == "P") 
            //{
            //    while (nn != 22) {
            //        Console.WriteLine(nn);
            //        nn+=2;
            //        n = "A";
            //    }
            //}
            //while (n == "I")
            //{
            //    nn = 1;
            //    while (nn <= 20)
            //    {
            //        Console.WriteLine(nn);
            //        nn += 2;
            //        n = "A";
            //    }
            //}
            //Console.ReadKey();

            double ap = 0;
            int qf = 0;
            double sl = 0;
            string Con = "S";
            while (Con == "S")
            {
                Console.Write("Forma de Contratação: ");
                string Fc = (Console.ReadLine());
                Console.WriteLine("____________________________________________________________________________");
                switch (Fc)
                {
                    case "A":
                        Console.WriteLine("Selecionado: Assalariado");
                        Console.WriteLine("");
                        Console.Write("Salário (bruto): ");
                        double sb = double.Parse((Console.ReadLine()));
                        double d = 200.00;
                        sl = sb - d;
                        ap += sb - d;
                        qf++;
                        Console.WriteLine("____________________________________________________________________________");
                        Console.WriteLine("Salario liquido: " + sl);
                        Console.WriteLine("Desconto: " + d);
                        break;
                    case "C":
                        Console.WriteLine("Selecionado: Comissionado");
                        Console.WriteLine("");
                        Console.Write("Quantidade de Vendas: ");
                        int Qv = int.Parse((Console.ReadLine()));
                        double vv = 10.5;
                        sl = Qv * vv;
                        ap += Qv * vv;
                        qf++;

                        Console.WriteLine("____________________________________________________________________________");
                        Console.WriteLine("Salario liquido: " + sl);
                        Console.WriteLine("Comissão por venda: " + vv);
                        break;
                    case "H":
                        Console.WriteLine("Selecionado: Horista");
                        Console.WriteLine("");
                        Console.Write("Quantidade de horas trabalhadas: ");
                        int Qh = int.Parse((Console.ReadLine()));
                        double Vh = 10.50;
                        sl = Qh * Vh;
                        ap += Vh * Qh;
                        qf++;
                        Console.WriteLine("____________________________________________________________________________");
                        Console.WriteLine("Salario liquido: " + sl);
                        Console.WriteLine("Valor por hora: " + Vh);
                        break;
                    default:
                        Console.WriteLine("ERROR.Forma invalida");
                        break;
                }
                Console.WriteLine("____________________________________________________________________________");
                Console.WriteLine("Deseja cadastrar outro funcionario?");
                Con = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Total liquido à pagar: "+ ap);
            Console.WriteLine("Quantidade de funcionarios cadastrados: " + qf);
            Console.ReadKey();
        }
    }
}
