using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsi.ReseauxNeurone
{
    class Trainer
    {
        double[] tabTrainer;
        int x = 0, y = 0;
        int excepted;
        int numbertimes = 0;
        public Trainer(double[] tab, int value)
        {
            excepted = value;
            tabTrainer = tab;
            choicesNumber();

        }

        public void choicesNumber()
        {
            var rand = new Random();
            x = rand.Next(1,4);
            y = rand.Next(1,4);


            somme(x, y);

        }

        public void somme(int x, int y)
        {
            double result = tabTrainer[x] + tabTrainer[y];
            verification(result, excepted);
        }

        public void verification(double result, int excepted)
        {
            /*
            double resultDouble = result, exceptedDouble = excepted;
            resultDouble  = Math.Pow(resultDouble,2);
            exceptedDouble = Math.Pow(exceptedDouble, 2);*/

            double test = 2*(result - Convert.ToDouble(excepted));

            Neurone neuro = new Neurone();
            Console.WriteLine(neuro.Activation(test));

            if (test == 0)
            {
                
                Console.WriteLine("Le neurone a trouvé !");
                Console.WriteLine("Le neurone a réalisé le nombre d'essai : " + nombreoperation()) ;
            }
            else
            {
                Console.WriteLine("{0} - {1} " , numbertimes , test);
                numbertimes++;
                choicesNumber();
            }
        }

        public int nombreoperation()
        {
            return numbertimes;
        }





    }
}
