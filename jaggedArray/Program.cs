using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Familia 1: Familia Flinstones
            //Familia 2: Familia Simpsons
            //Familia 3: Familia Dona Florinda

            //jagged array = array denteado || array serrilhado

            string[][] familias = new string[3][];
            // {
            //     { "Fred", "Wilma", "Pedrita" },
            //     { "Homer", "Marge", "Lisa","Bart","Maggie" },
            //     { "Florinda","Kiko" }
            // };

            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join("," , familia));
            }
        }
    }
}