using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    //find sum of all even Fibonacci numbers up to four million. 
    class Two
    {
        public Two() { }

        public void Run()
        {

            int numOne = 1;
            int numTwo = 2;
            int max = 4000000;
            int sum = 2; //starts at 2 because of numtwos value
            bool isOne = true;

            while (numOne < max || numTwo < max)
            {
                if (isOne)
                {
                    numOne += numTwo;
                    isOne = false;

                    if (numOne % 2 == 0)
                    { sum += numOne; }
                }
                if (!isOne)
                {
                    numTwo += numOne;
                    isOne = true;

                    if (numTwo % 2 == 0)
                    { sum += numTwo; }
                }
            }
            Console.WriteLine("The sum of all even Fibonacci numbers under 4 million is: " + sum);
            Console.ReadKey();
        }
    }
}
