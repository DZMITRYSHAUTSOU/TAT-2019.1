using System;
namespace DEV_1
{
    class Sequence
    {
        public Sequence() { }
        public void SequenceSearch(string word)
        {
            bool flag = false;//Repeating symbol indicator
            string seq;//Keeps non-repeating symbols 
            seq = string.Empty;
            seq += word[0];
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] != word[i - 1])
                {
                    seq += word[i];
                }
                else
                {
                    flag = true;
                }
                if (flag || (i == word.Length - 1))
                {
                    SequenceOutput(seq);//output of all combinations found in 'seq' 
                    seq = string.Empty;
                    seq += word[i];
                    flag = false;
                }
            }
        }
        public void SequenceOutput(string seq)//Combination outputter
        {
            string OutputBuffer = string.Empty;//Buffer for subsequences
            while (seq.Length >= 2)
            {

                for (int k = 0; k < seq.Length; k++)
                {
                    OutputBuffer += seq[k];
                    if (OutputBuffer.Length >= 2)
                    {
                        Console.WriteLine(OutputBuffer);
                    }

                }
                OutputBuffer = string.Empty;
                seq = seq.TrimStart(seq[0]);
            }
        }
    }
}