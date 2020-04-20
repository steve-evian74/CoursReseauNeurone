using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epsi.ReseauxNeurone
{
    class Trainer
    {
        int[] tabTrainer;
        int x = 0, y = 0;
        int excepted;
        public Trainer(int []tab , int value)
        {
            excepted = value;
            tabTrainer = tab;
            choicesNumber();
        
        }

        public void choicesNumber()
        {
            var rand = new Random();
            x = rand.Next(0, 3);
            do
            {
                y = rand.Next(0, 3);
            }
            while (y == x);

            
        }

        public void somme(int x,int y)
        {
            int result = x + y;
            verification(result , excepted); 
        }

        public void verification(int result , int excepted)
        {
            double test = Math.Sqrt(result - excepted);
            if(test == 0)
            {
                Console.WriteLine("Le neurone a trouvé !" );
            }
            else
            {
                Console.WriteLine("Le neurone n'a pas encore trouvé !, il doit encore réalisé les opérations ! ");
                choicesNumber();
            }
        }





    }
}
