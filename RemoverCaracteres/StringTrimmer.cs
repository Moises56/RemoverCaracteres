using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoverCaracteres
{
    public class StringTrimmer
    {
        public static string RemoveSpaces(string input)
        {
            return input.Replace(" ", string.Empty);
        }
        /*public static string TrimSequence(string inputString, string sequence = " ")
        {
            return inputString.Replace(sequence, "");
        }*/
    }
}
