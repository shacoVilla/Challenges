// <copyright file="Program.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FizzBuzz
{
    using System;

    /// <summary>
    /// FizzBuzz main program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The output to be processed.
        /// </summary>
        private static OutputFizzBuzz output;

        /// <summary>
        /// Main execution method.
        /// </summary>
        /// <param name="args">Arguments for executing the program.</param>
        public static void Main(string[] args)
        {
            // Step1
            Console.WriteLine("Step 1 -------");
            output = new OutputBasic();
            output.FizzBuzz(20);
            output.PrintOutput();
            Console.WriteLine("--------------");

            // Step2
            Console.WriteLine("Step 2 -------");
            output = new OutputEnhanced();
            output.FizzBuzz(20);
            output.PrintOutput();
            Console.WriteLine("--------------");

            // Step3
            Console.WriteLine("Step 3 -------");
            output = new OutputReport();
            output.FizzBuzz(20);
            output.PrintOutput();
            Console.WriteLine("--------------");
        }
    }
}