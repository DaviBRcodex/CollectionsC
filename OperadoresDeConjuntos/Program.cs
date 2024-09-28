using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresDeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "Janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("Concatenando duas sequências");


            var consulta = seq1.Concat(seq2);
            foreach (var item in consulta) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("União de duas sequências ");

            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("União de duas sequências com comparador");

            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Interseçção entre duas sequencias");

            var consulta4 = seq1.Intersect(seq2);
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Exceto: elementos de seq1 que não estão na seq2");

            var consulta5 = seq1.Except(seq2);
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}