namespace FizzBuzzTest
{
    using FizzBuzz;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Xunit;

    public class FizzBuzzTest
    {
        List<string> varTest = new List<string> { "hola", "test", "Fizz", "Buzz", "test2", "13", "133", "9" };

        string[] fizzbuzzValues = new string[] { "Fizz", "Buzz", "FizzBuzz" };

        [Fact]
        public void FizzBuzz_OutputPrintOut()
        {
            // Arrange
            var output = new OutputBasic();
            varTest.ForEach(o => output.AddOutputValue(o));
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                output.PrintOutput();

                string expected = "hola test Fizz Buzz test2 13 133 9 \r\n";

                // Assert
                Assert.Equal(expected, sw.ToString());
            }
        }

        [Theory]
        [InlineData(-1, 3)]
        [InlineData(5, 6)]
        [InlineData(4, 5)]
        public void FIzzBuzz_IsDivisible_FalseIfXLessThanY(int x, int y)
        {
            // Arrange
            var output = new OutputBasic();

            // Act
            var result = output.IsDivisible(x, y);

            // Assert
            Assert.True(!result);
        }

        [Theory]
        [InlineData(8, 4)]
        [InlineData(6, 3)]
        [InlineData(12, 4)]
        public void FizzBuzz_IsDivisible_TrueIfModGreaterThanZero(int x, int y)
        {
            // Arrange
            var output = new OutputBasic();

            // Act
            var result = output.IsDivisible(x, y);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(4, 3)]
        [InlineData(6, 5)]
        [InlineData(7, 5)]
        public void FizzBuzz_IsDivisible_FalseIfModEqualsZero(int x, int y)
        {
            // Arrange
            var output = new OutputBasic();

            // Act
            var result = output.IsDivisible(x, y);

            // Assert
            Assert.True(!result);
        }

        [Theory]
        [InlineData(20)]
        [InlineData(30)]
        [InlineData(50)]
        public void CheckCountersUpdatedValueGreaterThanZero(int max)
        {
            // Arrange
            var output = new OutputReport();

            // Act
            output.FizzBuzz(max);

            Assert.True(output.LuckyCount > 0);
            Assert.True(output.NumbersCount > 0);
            Assert.True(output.FizzCount > 0);
            Assert.True(output.FizzBuzzCount > 0);
            Assert.True(output.BuzzCount > 0);
        }

        [Theory]
        [InlineData(20, 2)]
        [InlineData(30, 3)]
        public void FizzBuzz_GetLuckyOverride(int max, int luckyCounts)
        {
            // Arrange
            var output = new OutputBasic();
            List<string> convertedValues = new List<string>();

            // Act
            for (int i = 1; i < max; i++)
            {
                var randomFizzBuzzValue = fizzbuzzValues[new Random().Next(0, fizzbuzzValues.Length)];

                convertedValues.Add(output.GetLuckyOverride(i, randomFizzBuzzValue));
            }

            var resultCount = convertedValues.FindAll(o => o == "lucky").Count();

            // Assert
            Assert.Equal(resultCount, luckyCounts);
        }
    }
}