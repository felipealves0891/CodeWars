using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Drifts
{
    public class ArrayDiff
    {

        [Theory]
        [InlineData(new int[] { 2 }, new int[] { 1, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 2 }, new int[] { 1, 2, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 1 }, new int[] { 1, 2, 2 }, new int[] { 2 })]
        [InlineData(new int[] { 1, 2, 2 }, new int[] { 1, 2, 2 }, new int[] { })]
        [InlineData(new int[] { }, new int[] { }, new int[] { 1, 2 })]
        [InlineData(new int[] { 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        public void Kata_ArrayDiff(int[] expected, int[] a, int[] b)
            => Assert.Equal(expected, Kata.ArrayDiff(a, b));


        private class Kata
        {
            public static int[] ArrayDiff(int[] array1, int[] array2)
            {
                return array1.Where(x => !array2.Any(y => y.Equals(x))).ToArray();

            }
        }
    }
}
