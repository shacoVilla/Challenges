// <copyright file="OutputFizzBuzz.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FizzBuzz
{
    using System.Collections.Generic;

    /// <summary>
    ///  The abstract class that represents the output.
    /// </summary>
    public abstract class OutputFizzBuzz
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFizzBuzz"/> class.
        /// </summary>
        protected OutputFizzBuzz()
        {
            this.OutputValues = new List<string>();
        }

        /// <summary>
        /// Gets or sets the list of output values to FizzBuzz.
        /// </summary>
        protected List<string> OutputValues { get; set; }

        /// <summary>
        /// The FizzBuzz operation on a max range of numbers as a loop.
        /// If the loop value is multiple of 3, the output word is Fizz.
        /// If the loop value is multiple of 5, the output word is Buzz.
        /// /// If the loop value is multiple of 3 and 5, the output word is FizzBuzz.
        /// </summary>
        /// <param name="max">The maximum numbers to FizzBuzz.</param>
        public abstract void FizzBuzz(int max);

        /// <summary>
        /// Adds a value to the output list.
        /// </summary>
        /// <param name="value">The value to be added.</param>
        public void AddOutputValue(string value) => this.OutputValues.Add(value);

        /// <summary>
        /// Gets the 'lucky' value if the input contains any character '3'. If not then, the original value will be returned.
        /// </summary>
        /// <param name="input">The input value to check for '3' characters.</param>
        /// <param name="originalValue">The original value as a result of the input check.</param>
        /// <returns>A <see cref="string"/> value.</returns>
        public string GetLuckyOverride(int input, string originalValue)
        {
            var isLuckyOverride = input.ToString().IndexOf("3") >= 0;
            return isLuckyOverride ? Enums.Lucky : originalValue;
        }

        /// <summary>
        /// Print out the added output values.
        /// </summary>
        public abstract void PrintOutput();

        /// <summary>
        /// Gets true or false if 'i' is multiple of 'x'.
        /// </summary>
        /// <param name="i">The number to be divided.</param>
        /// <param name="x">The divisor.</param>
        /// <returns>A <see cref="bool"/> value.</returns>
        public bool IsDivisible(int i, int x)
        {
            if (i >= x)
            {
                return i % x == 0;
            }
            else
            {
                return false;
            }
        }
    }
}