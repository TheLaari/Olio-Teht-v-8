using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Teht_v_8
{
    /// <summary>
    /// Ohjelma kysyy kolme lukua ja näyttää niistä suurimman.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numerot = 3;
            int suurin = 0;

            for (int i = 1; i <= numerot; i++)
            {
                Console.Write("Anna luku: ");
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out numero);
                if (result)
                {
                    if (i == 1) suurin = numero;
                    else if (numero > suurin) suurin = numero;
                }
                else
                {
                    Console.WriteLine("Et antanut lukua!");
                }
            }
            Console.WriteLine("Suurin luku on " + suurin);
            Console.ReadLine();
        }
    }
}
