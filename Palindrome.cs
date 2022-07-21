using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Palindrome
    {
        private string Phrase;

        public Palindrome(string phrase)
        {
            Phrase = phrase.ToLower();
        }

        public bool isPalindrome()
        {
            for(int i = 0; i < Phrase.Length; i++)
            {
                if (Phrase[i] == Phrase[Phrase.Length - 1 - i])
                {
                    continue;
                }
                return false;
            }
            return true;
        }
    }
}