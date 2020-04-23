using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsi.ReseauxNeurone
{
    class Neurone
    {
        private double[] Weights;

        public Neurone()
        { }

        public Neurone( int numberRandom)
        {
            var rand = new Random();
            Weights = new double[numberRandom];

            for (int i = 0; i < numberRandom; i++)
            {
                Weights[i] = rand.NextDouble();
            }

        }

        public double Activation(double x)
        {
            return x;


        }

        public void backprogate()
        {

        }

        public double forward(double []weight)
        {
            double result = 0;

            for (int i = 0; i < Weights.Length; i++)
            {
                result = (Weights[i] * weight[i]) + result;
            }
            Activation(result);
            return result;
            
        }
    }
}
