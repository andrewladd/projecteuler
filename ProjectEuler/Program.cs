using ProjectEuler.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {

        //""
        static void Problem2()
        {
            Console.Clear();
            Console.ReadKey();
        }

        //""
        static void Problem3()
        {
            Console.Clear();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //TODO: Build using SS
            string name = "Project Euler Problems";
            string[] options = { "Problem 1", "Problem 2", "Problem 3" };
            string prompt = ("What project do you wish to view? ");

            IOSkeleton gen = new IOSkeleton(name, options, prompt);
            gen.Start();

            bool programLoop = true;
            int input;

            do
            {
                gen.CreateMainMenu(out input);
                Console.Clear();
                switch (input)
                {
                    case 1:
                        var one = new One();
                        one.Run();
                        break;
                    case 2:
                        var two = new Two();
                        two.Run();
                        break;
                    case 3:
                        var three = new Three();
                        three.Run();
                        break;
                    case 4:
                        gen.ExitSequence(out programLoop);
                        break;
                    default:
                        break;
                }

            } while (programLoop);

            Environment.Exit(0);

        }
    }
}
