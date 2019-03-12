using System;

namespace DEV_1
{
    class EntryPoint
    {

        static void Main(string[] args)
        {
            int ErrorIndex = 0;
            try
            {
                if (args.Length == 0)//Blank input check
                {
                    throw new System.DivideByZeroException();
                }
                for (int i = 0; i < args.Length; i++)//Cycle for working with more than 1 word from cmd
                {
                    string word = args[i];//Contains current word from cmd
                    if (word.Length < 2 || args.Length == 0)//Length check
                    {
                        ErrorIndex = i;
                        throw new FormatException();
                    }
                    Console.WriteLine($"\n{word}\n");//current word output
                    var obj = new Sequence();
                    obj.SequenceSearch(word);//Algorithm start
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"'{args[ErrorIndex]}', {ErrorIndex + 1}'s argument caused Format Exception\n Word must contain 2 or more symbols");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Blank input");
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong...");
            }
        }
    }
}