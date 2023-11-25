using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Drifts
{
    public class WhoLikesIt
    {
        [Theory]
        [InlineData(new string[] { }, "no one likes this")]
        [InlineData(new string[] { "Peter" }, "Peter likes this")]
        [InlineData(new string[] { "Jacob", "Alex" }, "Jacob and Alex like this")]
        [InlineData(new string[] { "Max", "John", "Mark" }, "Max, John and Mark like this")]
        [InlineData(new string[] { "Alex", "Jacob", "Mark", "Max" }, "Alex, Jacob and 2 others like this")]
        public void Kata_Likes(string[] names, string text)
            => Assert.Equal(text, Kata.Likes(names));

        private class Kata
        {
            public static string Likes(string[] names)
            {
                if (names.Length <= 0)
                    return "no one likes this";
                else if (names.Length == 1)
                    return $"{names[0]} likes this";
                else if (names.Length == 2)
                    return $"{names[0]} and {names[1]} like this";
                else if (names.Length == 3)
                    return $"{names[0]}, {names[1]} and {names[2]} like this";
                else
                    return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
            }
        }
    }
}
