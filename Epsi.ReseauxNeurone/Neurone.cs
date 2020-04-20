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
                Weights[i] = rand.Next(2);
                Console.WriteLine(Weights[i]);
                Activation();
            }
            forward(Weights);
            
        }

        public void Activation()
        {

        }

        public float forward(int []weight)
        {
            float result = 0;

            for (int i = 0; i < Weights.Length; i++)
            {
                result = Weights[i] * weight[i];
            }

            return result;
            
        }
    }
}
