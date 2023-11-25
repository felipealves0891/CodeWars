using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Drifts
{
    public class Brace
    {
        [Theory]
        [InlineData("(){}[]", true)]
        [InlineData("([{}])", true)]
        [InlineData("(}", false)]
        [InlineData("[(])", false)]
        [InlineData("[({})](]", false)]
        public void Kata_validBraces(string name, bool isValid)
            => Assert.Equal(isValid, Kata.ValidBraces(name));

        private class Kata
        {
            public static bool ValidBraces(string text)
            {
                var context = new List<char>();
                var chars = text.ToCharArray();
                var isValid = true;

                foreach (char c in chars) 
                {
                    if (c == '{' || c == '(' || c == '[')
                    {
                        context.Add(c);
                        continue;
                    }
                    
                    if(context.Any() && context.Last() == '{' && c == '}')
                    {
                        context.RemoveAt(context.Count - 1);
                        continue;
                    }

                    if (context.Any() && context.Last() == '[' && c == ']')
                    {
                        context.RemoveAt(context.Count - 1);
                        continue;
                    }

                    if (context.Any() && context.Last() == '(' && c == ')')
                    {
                        context.RemoveAt(context.Count - 1);
                        continue;
                    }

                }


                return false;
            }

        }

    }
}
