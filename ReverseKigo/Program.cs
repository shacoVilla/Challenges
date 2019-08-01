// <copyright file="Program.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReverseKigo
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">Any arguments passed on the execution call.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce a string value to be reversed: ");

            var input = Console.ReadLine();

            var stringReverseByBits = ReverseHelper.ReverseTextByBit(input);

            var stringReverseByChar = ReverseHelper.ReverseTextByChar(input);

            Console.WriteLine("Revert ready, press any key");

            Console.ReadLine();

            Console.WriteLine("String reverted per bits: " + stringReverseByBits);

            Console.WriteLine("String reverted by chars :" + stringReverseByChar);

            Console.WriteLine("Press any key to exit");

            Console.ReadLine();
        }
    }
}
