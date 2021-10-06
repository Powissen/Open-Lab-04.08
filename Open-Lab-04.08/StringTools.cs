using System;
using System.Collections;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            ArrayList arrayList = new ArrayList(strings);

            foreach (string word in strings)
            {
                if (word.Length != 4)
                {
                    arrayList.Remove(word);
                }
            }
            strings = arrayList.ToArray(typeof(string)) as string[];
            return strings;
        }
    }
}
