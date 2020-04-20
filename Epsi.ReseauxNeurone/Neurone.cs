using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsi.ReseauxNeurone
{
    class Neurone
    {
        private int[] Weights;

        public Neurone( int numberRandom)
        {
            var rand = new Random();
            Weights = new int[numberRandom];

            for (int i = 0; i < numberRandom; i++)
            {
                Weights[i] = rand.Next(1,5);
                Console.WriteLine(Weights[i]);
                Activation(Weights);
            }

            
        }

        public int Activation(int[] Poids)
        {
            return Poids.Count();
        }

        public float forward(int []weight)
        {
            float result = 0;

            for (int i = 0; i < Weights.Length; i++)
            {
                result = (Weights[i] * weight[i]) + result;
            }

            return result;
            
        }
    }
}
