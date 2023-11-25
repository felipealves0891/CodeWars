using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Drifts
{
    public class ConvertStringToCamelCase
    {
        [Theory]
        [InlineData("theStealthWarrior", "the_stealth_warrior")]
        [InlineData("TheStealthWarrior", "The-Stealth-Warrior")]
        [InlineData("theStealthWarrior", "the_stealthWarrior")]
        public void Kata_ToCameCase(string expected, string value)
            => Assert.Equal(expected, Kata.ToCamelCase(value));

        private class Kata
        {
            private static char[] SeparatorWordChars = new char[] { '-', '_', ' ' };

            public static string ToCamelCase(string str)
            {
                var chars = str.ToCharArray();
                var camelCase = string.Empty;
                var separatorFound = false;

                foreach (var @char in chars)
                {
                    if (separatorFound)
                    {
                        camelCase += @char.ToString().ToUpper();
                        separatorFound = false;
                        continue;
                    }

                    if (SeparatorWordChars.Contains(@char))
                    {
                        separatorFound = true;
                        continue;
                    }

                    camelCase += @char.ToString();
                }

                return camelCase;
            }
        }
    }

    
}
