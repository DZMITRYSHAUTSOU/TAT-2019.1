using System;
using System.Linq;
using System.Text;

namespace Transcryption
{
    class EnteryPoint
    {
        static int Main(string[] args)
        {
            WordProcessing obj = new WordProcessing();
            try
            {
                if (args[0].Length == 0)//Blank input check
                {
                    throw new System.DivideByZeroException();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Blank input");
                return 1;
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong...");
                return 1;
            }
            obj.Set(args[0]);
            bool flagPlus=false,  flagYo=false;
            int flagSyllable = 0;
            string SyllableCheck = "ауоыиэяюёе",plus = "+",Yo="ё";
            for (int i = 0; i < obj.Str.Length; i++)
            {
                if (obj.Str[i] == plus[0])
                {
                    flagPlus=true;
                    break;
                }
                if(SyllableCheck.Contains(obj.Str[i]))
                {
                    flagSyllable++;
                }
                if(obj.Str[i]==Yo[i])
                {
                    flagYo = true;
                    break;
                }
            }
            try
            {
                if (!flagPlus && !flagYo && flagSyllable != 1)
                {
                    throw new System.DivideByZeroException();
                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Input is wrong! Try putting '+' ");
                Console.ReadKey();
                return 1;
            }
            obj.Process(args[0]);
            Console.ReadKey();
            return 1;
        }
    }
}