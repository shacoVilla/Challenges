// <copyright file="Program.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WordExtractor
{
    using System;

    /// <summary>
    /// The main program.
    /// </summary>
    public static class Program
    {
        private static int positionValue;

        /// <summary>
        /// The main executable method.
        /// </summary>
        /// <param name="args">Any arguments to be considered.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce the text to extract: ");
            var text = Console.ReadLine();

            Console.WriteLine("Introduce the position of the word you want to extract: ");
            var position = Console.ReadLine();

            try
            {
                var result = ExtractorHelper.GetWordFromText(text, position);
                Console.WriteLine("Extracted word:" + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}