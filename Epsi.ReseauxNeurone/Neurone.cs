﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsi.ReseauxNeurone
{
    class Neurone
    {
        private int[] Weights = new int[2];

        public Neurone()
        {
            var rand = new Random();
            
            for (int i = 0; i < 2; i++)
            {
                Weights[i] = rand.Next(2);
                Console.WriteLine(Weights[i]);
            } 
        }

        public void Activation()
        {

        }

        public void Forward()
        {

        }
    }
}
