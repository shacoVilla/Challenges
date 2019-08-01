using ReverseKigo;
using Xunit;

namespace ReverseTest
{
    public class ReverseKigoTest
    {
        [Theory]
        [InlineData("one", "eno")]
        [InlineData("abcd dcba", "abcd dcba")]
        [InlineData("", "")]
        public void ReverseTextStringBasic(string input, string output)
        {
            // Act
            var result = ReverseHelper.ReverseTextByBit(input);
            var result2 = ReverseHelper.ReverseTextByChar(input);

            // Assert
            Assert.Equal(result, output);
            Assert.Equal(result2, output);
        }

        [Theory]
        [InlineData("Les Mise\u0301rables", "selbaŕesiM seL")]
        [InlineData("L'es Miserables", "selbaresiM se'L")]
        public void ReverseTextStringWithApostrophes(string input, string output)
        {
            // Act
            var result = ReverseHelper.ReverseTextByBit(input);
            var result2 = ReverseHelper.ReverseTextByChar(input);

            // Assert
            Assert.Equal(result, output);
            Assert.Equal(result2, output);
        }

        [Theory]
        [InlineData("++#!hOLA SPECIAL ", " LAICEPS ALOh!#++")]
        public void ReverseTextStringWithSpecialCharacters(string input, string output)
        {
            // Act
            var result = ReverseHelper.ReverseTextByBit(input);
            var result2 = ReverseHelper.ReverseTextByChar(input);

            // Assert
            Assert.Equal(result, output);
            Assert.Equal(result2, output);
        }
    }
}
