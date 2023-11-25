using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Drifts
{
    public class SimplePigLatin
    {
        [Theory]
        [InlineData("igPay atinlay siay oolcay", "Pig latin is cool")]
        [InlineData("hisTay siay ymay tringsay", "This is my string")]
        [InlineData("elloHay orldway !", "Hello world !")]
        public void Kata_PigIt(string expected, string value)
            => Assert.Equal(expected, Kata.PigIt(value));

        private class Kata
        {
            public static string PigIt(string str)
            {
                var suffix = "ay";
                var accentuation = new char[] { '!', '?', '.', ',' };

                var words = str.Split(' ');
                var result = string.Empty;

                foreach (var word in words)
                {
                    if(!string.IsNullOrEmpty(result))
                        result += " ";

                    var chars = word.ToCharArray();

                    for (int i = 1; i < chars.Length; i++)
                        result += chars[i];

                    result += chars[0];

                    var lastChar = result[result.Length - 1];
                    if (!accentuation.Contains(lastChar))
                        result += suffix;
                    
                }

                return result;
            }

        }
    }
}
