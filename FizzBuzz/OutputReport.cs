// <copyright file="OutputReport.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FizzBuzz
{
    using System;

    /// <summary>
    /// The <see cref="OutputFizzBuzz"/> Report implementation for Step 3.
    /// </summary>
    public class OutputReport : OutputFizzBuzz
    {
        /// <summary>
        /// Gets or sets the word 'Fizz' od the output.
        /// </summary>
        public int FizzCount { get; set; }

        /// <summary>
        /// Gets or sets the word 'Buzz' of the output.
        /// </summary>
        public int BuzzCount { get; set; }

        /// <summary>
        /// Gets or sets the word 'FizzBuzz' of the output.
        /// </summary>
        public int FizzBuzzCount { get; set; }

        /// <summary>
        /// Gets or sets the word 'Lucky' of the output.
        /// </summary>
        public int LuckyCount { get; set; }

        /// <summary>
        /// Gets or sets the integer values of the output.
        /// </summary>
        public int NumbersCount { get; set; }

        /// <inheritdoc/>
        public override void FizzBuzz(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                if (this.IsDivisible(i, 3) && this.IsDivisible(i, 5))
                {
                    var input = this.GetLuckyOverride(i, Enums.FizzBuzz);
                    this.UpdateReportCounter(input);
                    this.AddOutputValue(input);
                }
                else
                {
                    if (this.IsDivisible(i, 3))
                    {
                        var input = this.GetLuckyOverride(i, Enums.Fizz);
                        this.UpdateReportCounter(input);
                        this.AddOutputValue(input);
                    }
                    else
                    {
                        if (this.IsDivisible(i, 5))
                        {
                            var input = this.GetLuckyOverride(i, Enums.Buzz);
                            this.UpdateReportCounter(input);
                            this.AddOutputValue(input);
                        }
                        else
                        {
                            var input = this.GetLuckyOverride(i, i.ToString());
                            this.UpdateReportCounter(input);
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

            this.PrintOutCounters();
        }

        /// <summary>
        /// Updates the counters for the output report.
        /// </summary>
        /// <param name="value">The string value to be counted.</param>
        public void UpdateReportCounter(string value)
        {
            switch (value)
            {
                case Enums.Buzz:
                    this.BuzzCount++;
                    break;
                case Enums.Fizz:
                    this.FizzCount++;
                    break;
                case Enums.FizzBuzz:
                    this.FizzBuzzCount++;
                    break;
                case Enums.Lucky:
                    this.LuckyCount++;
                    break;
                default:
                    if (int.TryParse(value, out _))
                    {
                        this.NumbersCount++;
                    }

                    break;
            }
        }

        private void PrintOutCounters()
        {
            Console.WriteLine("Fizz: " + this.FizzCount);
            Console.WriteLine("Buzz: " + this.BuzzCount);
            Console.WriteLine("FizzBuzz: " + this.FizzBuzzCount);
            Console.WriteLine("Lucky: " + this.LuckyCount);
            Console.WriteLine("Integer: " + this.NumbersCount);
        }
    }
}
