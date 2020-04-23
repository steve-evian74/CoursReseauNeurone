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
            Console.Write("Veuillez entrer un nombre : ");
            int valueDefined = Convert.ToInt32(Console.ReadLine());

            double[] tab = new double[] { 1, 5, 6, 8 };


            Neurone neurone1 = new Neurone(4);
            neurone1.forward(tab);

            Trainer trainer1 = new Trainer(tab , valueDefined);

            Console.ReadLine();
        }

    }
}
