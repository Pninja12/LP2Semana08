using System;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {
        private static readonly Random rng;

        static StringExtensions()
        {
            rng = new Random();
        }

        public static string ToRandomCase(this string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in str)
            {
                sb.Append(rng.NextDouble() < 0.5 ? char.ToLower(c) : char.ToUpper(c));

            }
            return sb.ToString();
        }
    }
}