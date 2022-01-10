using FirstTest_Haiku.Models;
using System;

namespace FirstTest_Haiku
{
    public class HaikuParser
    {
        public HaikuParserResponse ParseHaiku(string haiku)
        {
            if(String.IsNullOrWhiteSpace(haiku))
                 return new HaikuParserResponse()
                 {
                     IsSuccess = false,
                     Message = "Data empty",
                     Count = 0
                 };

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            char[] currentWord = haiku.ToCharArray();
            int numVowels = 0;
            bool lastWasVowel = false;
            foreach (char wc in currentWord)
            {
                bool foundVowel = false;
                foreach (char v in vowels)
                {
                    if ((v == wc) && lastWasVowel)
                    {
                        foundVowel = true;
                        lastWasVowel = true;
                        break;
                    }
                    else if (v == wc && !lastWasVowel)
                    {
                        numVowels++;
                        foundVowel = true;
                        lastWasVowel = true;
                        break;
                    }
                }
                if (!foundVowel)
                    lastWasVowel = false;
            }

            
            return new HaikuParserResponse()
            {
                IsSuccess = true,
                Message = "Success",
                Count = numVowels
            };

        }
    }
}
