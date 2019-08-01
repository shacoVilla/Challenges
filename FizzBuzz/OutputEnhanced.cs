// <copyright file="OutputEnhanced.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FizzBuzz
{
    using System;

    /// <summary>
    /// The <see cref="OutputFizzBuzz"/> Enhanced implememtation for Step 2.
    /// </summary>
    public class OutputEnhanced : OutputFizzBuzz
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputEnhanced"/> class. This is for the Step 2.
        /// </summary>
        public OutputEnhanced()
            : base()
        {
        }

        /// <inheritdoc/>
        public override void FizzBuzz(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                if (this.IsDivisible(i, 3) && this.IsDivisible(i, 5))
                {
                    var input = this.GetLuckyOverride(i, Enums.FizzBuzz);
                    this.AddOutputValue(input);
                }
                else
                {
                    if (this.IsDivisible(i, 3))
                    {
                        var input = this.GetLuckyOverride(i, Enums.Fizz);
                        this.AddOutputValue(input);
                    }
                    else
                    {
                        if (this.IsDivisible(i, 5))
                        {
                            var input = this.GetLuckyOverride(i, Enums.Buzz);
                            this.AddOutputValue(input);
                        }
                        else
                        {
                            var input = this.GetLuckyOverride(i, i.ToString());
                            this.AddOutputValue(input);
                        }
                    }
                }
            }
        }

        /// <inheritdoc/>
        public override void PrintOutput()
        {
            foreach (var item in this.OutputValues)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}