using System;
using System.Collections.Generic;

namespace DEV_4
{
    /// <summary>
    /// Class that contain extension method for string
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// <param name="Guids">list of unique identifiers</param>
        /// </summary>
        private static List<string> Guids = new List<string>();

        /// <summary>
        /// static method that generate and return unique identifiers
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GenerateGUID(this string str)
        {
            Random rnd = new Random();
            while(!Guids.Contains(str))
            {
                str = rnd.Next(100).ToString();
                Guids.Add(str);
            }                               
            return str;
        }
    }
}
