using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9
{
    static public class LevenshteinDistance
    {
        static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;

        public static int Find(string text1, int len1, string text2, int len2)
        {
               if (len1 == 0) return len2;
               if (len2 == 0) return len1;

               var substitutionCost = 0;
               if (text1[len1 - 1] != text2[len2 - 1]) substitutionCost = 1;

               var deletion = Find(text1, len1 - 1, text2, len2) + 1;
               var insertion = Find(text1, len1, text2, len2 - 1) + 1;
               var substitution = Find(text1, len1 - 1, text2, len2 - 1) + substitutionCost;

               return Minimum(deletion, insertion, substitution);
        }

        public static int Find(string word1, string word2) => Find(word1, word1.Length, word2, word2.Length);
    }
}
