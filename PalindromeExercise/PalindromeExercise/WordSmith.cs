using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool PalFinder(string pally)
        {
            string maybeThis = pally.ToLower();
            return maybeThis.SequenceEqual(maybeThis.Reverse());
        }
    }
}
