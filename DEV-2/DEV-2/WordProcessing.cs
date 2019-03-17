using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcryption
{
    class WordProcessing
    {
        public string Str = string.Empty;
        public WordProcessing() { }
        public void Set(string arg)
        {
            string Str = arg;
            Console.WriteLine(Str);
        }
        public void Process(string Str)
        {
            string[] processed = new string[Str.Length + 1];
            string vowels = "ауоыиэяюёе";//
            string vowelsspcl = "яюёе";//
            string voweldflt = "ауоэ";//            Arrays for each latters according t
            string deaf = "пфктсхц";//
            string media = "бвгдзлмнр";//
            string soundless = "ьъ";//
            string OtoA = "+ао";//array for O to A change (if not stressed)
            int[] PrevIndex = new int[Str.Length + 1];//contains information about letters, where vowel==1 soundless==2 deaf==3 media==4
            for (int i = 0; i < Str.Length; i++)
            {
                if (vowels.Contains(Str[i]))
                {
                    processed[i] += Str[i];
                    PrevIndex[i + 1] = 1;
                }
                if (soundless.Contains(Str[i]))
                {
                    PrevIndex[i + 1] = 2;
                }
                if (media.Contains(Str[i]))
                {
                    processed[i] += Str[i];
                    PrevIndex[i + 1] = 4;
                }
                if (deaf.Contains(Str[i]))
                {
                    processed[i] += Str[i];
                    PrevIndex[i + 1] = 3;
                }
            }
            for (int i = 0; i < Str.Length; i++)//transcryption cycle
            {
                if (vowelsspcl.Contains(Str[i]) && (i == 0 || PrevIndex[i] == 1 || PrevIndex[i] == 2))//ё->й+о
                {
                    processed[i] = string.Empty;
                    processed[i] += "й" + voweldflt[vowelsspcl.IndexOf(Str[i])];
                }
                if (vowelsspcl.Contains(Str[i]) && (PrevIndex[i] == 4 || PrevIndex[i] == 3))//ё->'+о
                {
                    processed[i] = string.Empty;
                    processed[i] += "'" + voweldflt[vowelsspcl.IndexOf(Str[i])];
                }
                if (Str[i] == soundless[0] && (PrevIndex[i] == 3 || PrevIndex[i] == 4))//бь->б+'
                {
                    processed[i] = string.Empty;
                    processed[i] += "'";
                }
                if (media.Contains(Str[i]) && (i == Str.Length - 1 || (i + 2 != Str.Length && PrevIndex[i + 2] == 3)) && media.IndexOf(Str[i]) <= 4)//media to deaf
                {
                    processed[i] = string.Empty;
                    processed[i] += deaf[media.IndexOf(Str[i])];
                }
                if (deaf.Contains(Str[i]) && (i+1<Str.Length && i + 2 != Str.Length && PrevIndex[i + 2] == 4) && deaf.IndexOf(Str[i]) <= 4 && media.IndexOf(Str[i+1]) <= 4 )//deaf to media
                {
                    processed[i] = string.Empty;
                    processed[i] += media[deaf.IndexOf(Str[i])];
                }
                if (Str[i] == OtoA[2] && (i == Str.Length - 1 || Str[i + 1] != OtoA[0]))// о->a
                {
                    processed[i] = string.Empty;
                    processed[i] += OtoA[1];
                }
                if (Str[i] == OtoA[0])//deletes "+" from transcryption
                {
                    processed[i] = string.Empty;
                }
            }
            string result = string.Empty;//resulting transcryption
            for (int i = 0; i < Str.Length; i++)//assembles resulting varieble
            {
                result = string.Concat(result, processed[i]);
            }
            Console.WriteLine(result);
        }
    }
}