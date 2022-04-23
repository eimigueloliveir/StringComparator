using System;

namespace StringComparator
{
    public class Comparator
    {
        public static decimal compare(string Original, string Target)
        {
            char[] OriginalArray = new char[Original.Length];
            char[] TargetArray = new char[Target.Length];
            int letter = 0;
            decimal correct = 0;
            foreach (char letters in OriginalArray)
            {
                OriginalArray[letter] = letters;
                letter++;
            }
            letter = 0;
            foreach (char letters in TargetArray)
            {
                TargetArray[letter] = letters;
                letter++;
            }

            for (int i = 0; i < Original.Length; i++)
            {
                try
                {
                    if (OriginalArray[i] == TargetArray[i])
                    {
                        correct++;
                    }
                }
                catch
                {
                    break;
                }
            }
            decimal porcentagem = (correct * 100 / Original.Length);
            porcentagem = Math.Round(porcentagem, 2);
            return porcentagem;
        }
    }
}
