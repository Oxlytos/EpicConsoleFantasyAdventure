using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
            //string completeInput = "";
            ////BIL
            //char[] segments = input.ToCharArray();
            //completeInput += segments.FirstOrDefault().ToString().ToUpper();

            //for(int c = 1; c < segments.Length; c++)
            //{
            //    completeInput += c;
            //}
            //return completeInput;

        }
    }
}
