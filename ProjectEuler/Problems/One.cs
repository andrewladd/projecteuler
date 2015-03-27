using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class One
    {

        public One() { }

        public void Run()
        {
            Console.WriteLine("Multiples of x and y on the interval [p,q].");

            int first, second, boundLow, boundUp, totalSum = 0;

            Console.WriteLine("Input multiple candidates: <x> <y>");
            string input1 = Console.ReadLine();
            int index1 = input1.IndexOf(" ");
            first = Convert.ToInt32(input1.Substring(0, index1));
            second = Convert.ToInt32(input1.Substring(index1));
            
            Console.WriteLine("Input bounds: <p> <q>");
            string input2 = Console.ReadLine();
            int index2 = input2.IndexOf(" ");
            boundLow = Convert.ToInt32(input2.Substring(0, index2));
            boundUp = Convert.ToInt32(input2.Substring(index2));
      

            Console.WriteLine("You wish to find the sum of the multiples of {0} and {1} from " +
                "{2} to {3} inclusive!", first, second, boundLow, boundUp);

            for (int i = boundLow; i < boundUp; i++)
            {
                if (i % first == 0 || i % second == 0)
                {
                    totalSum += i;
                }
            }

            Console.WriteLine("\n" + "Total sum of all these multiples: " + totalSum);

            Console.ReadKey();
        }

    }
}
