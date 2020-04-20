using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsi.ReseauxNeurone
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1, 5, 6, 8 };
            Neurone neurone1 = new Neurone(4);
            neurone1.forward(tab);
            Console.ReadLine();
        }

    }
}
