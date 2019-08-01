// <copyright file="OutputBasic.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FizzBuzz
{
    using System;

    /// <summary>
    /// The <see cref="OutputFizzBuzz"/> Basic implementation for Step 1.
    /// </summary>
    public class OutputBasic : OutputFizzBuzz
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputBasic"/> class.
        /// </summary>
        public OutputBasic()
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
                    this.AddOutputValue(Enums.FizzBuzz);
                }
                else
                {
                    if (this.IsDivisible(i, 3))
                    {
                        this.AddOutputValue(Enums.Fizz);
                    }
                    else
                    {
                        if (this.IsDivisible(i, 5))
                        {
                            this.AddOutputValue(Enums.Buzz);
                        }
                        else
                        {
                            this.AddOutputValue(i.ToString());
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