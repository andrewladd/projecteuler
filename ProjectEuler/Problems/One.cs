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
            Console.Clear();

            Console.WriteLine("Multiples of x and y on the interval [p,q].");

            int num1 = 1;
            int num2 = 1;
            int num3 = 1;
            int num4 = 1;

            Console.WriteLine("Input numbers: <x> <y>");
            string input1 = Console.ReadLine();
            int index1 = input1.IndexOf(" ");
            try
            {
                num1 = Convert.ToInt32(input1.Substring(0, index1));
                num2 = Convert.ToInt32(input1.Substring(index1));
            }
            catch
            {
                Console.WriteLine("Not entered correctly. Default to: 1 1");
            }

            Console.WriteLine("Input numbers: <p> <q>");
            string input2 = Console.ReadLine();
            int index2 = input2.IndexOf(" ");
            try
            {
                num3 = Convert.ToInt32(input2.Substring(0, index2));
                num4 = Convert.ToInt32(input2.Substring(index2));
            }
            catch
            {
                Console.WriteLine("Not entered correctly. Default to: 1 1");
            }

            Console.WriteLine("You wish to find the multiples of {0} and {1} from " +
                "{2} to {3} inclusive!", num1, num2, num3, num4);

            string stringNum1 = "The multiples of " + num1 + " are: ";
            string stringNum2 = "The multiples of " + num2 + " are: ";

            for (int i = num3; i <= num4; i++)
            {
                if (i % num1 == 0)
                {
                    stringNum1 = stringNum1 + i + ", ";
                }

                if (i % num2 == 0)
                {
                    stringNum2 = stringNum2 + i + ", ";
                }
            }

            Console.WriteLine(stringNum1.TrimEnd(new Char[] { ' ', ',' }));
            Console.WriteLine(stringNum2.TrimEnd(new Char[] { ' ', ',' }));

            Console.ReadKey();
        }

    }
}
