// Takes problem characteristics and produces a simple console
// I/O framework with it.

using System;
using System.IO;

public class IOSkeleton
  {
    //Fields
    public string progName;
    public string[] options;
    public string inputPrompt;

    //Construct
    public IOSkeleton(string progName, string[] options, string inputPrompt)
    {
        this.progName = progName;
        this.options = options;
        this.inputPrompt = inputPrompt;
    }

    //Methods/Advancement

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Welcome to: \"" + this.progName + "\"!\n");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public void CreateMainMenu(out int input)
    {
        string inputString = "";
        bool incorrectForm = false;

        do
        {
            Console.Clear();

            if (incorrectForm == true)
            {
                Console.WriteLine("Unknown option: " + inputString);
                Console.WriteLine();
            }

            incorrectForm = false;

            Console.WriteLine(this.inputPrompt + "\n");

            for (int x = 0; x < this.options.Length; x++)
            {
                Console.WriteLine((x + 1) + ") " + this.options[x]);
            }

            Console.WriteLine("\n" + (this.options.Length+1) + ") Exit");
            Console.Write("\n\nSelection: ");

            inputString = Console.ReadLine();

            if (Int32.TryParse(inputString, out input) == false)
            {
                incorrectForm = true;
            }
            else
            {
                input = Int32.Parse(inputString);

                if (input > options.Length+1 || input < 0)
                    incorrectForm = true;

                else
                    incorrectForm = false;
            }
        } while (incorrectForm);
    }

    public void ExitSequence(out bool dontExit)
    {
        bool optRight = true;

        do
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to exit?\n\n");
            Console.Write("(Y|N): ");
            
            optRight = true;
            string opt = Console.ReadLine();
            dontExit = true;

            switch (opt)
            {
                case "Y":
                case "y":
                    dontExit = false;
                    Console.Clear();
                    break;


                case "N":
                case "n":
                    dontExit = true;
                    break;

                default:
                {
                    optRight = false;
                    break;
                }
            }
        } while (!optRight);
    }



    static void Main( )
    {
        string[] options = {"Problem 1", "Problem 2", "Problem 3"};
        string prompt = ("Ask me about which problem: ");
        int choice;

        IOSkeleton gen = new IOSkeleton("ProjectEuler", options, prompt);
        gen.Start();

        bool programLoop = true;

        do
        {
            gen.CreateMainMenu(out choice);

            switch (choice)
            {
            case 1:
                Console.WriteLine("This is where this method will go");
                break;
            case 2:
                Console.WriteLine("This is where this method will go");
                break;
            case 3:
                Console.WriteLine("This is where this method will go");
                break;
            case 4:
                gen.ExitSequence(out programLoop);
                break;
            default:
                break;
            }
        } while(programLoop);



    }
}   

