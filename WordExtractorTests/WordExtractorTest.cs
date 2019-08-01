// <copyright file="WordExtractorTest.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WordExtractorTests
{
    using System;
    using System.Linq;
    using WordExtractor;
    using WordExtractor.Exceptions;
    using Xunit;

    /// <summary>
    /// Defines the test cases for getting words from a text.
    /// </summary>
    public class WordExtractorTest
    {
        /// <summary>
        /// Gets Invalid position exception.
        /// </summary>
        [Theory]
        [InlineData("The ocean is blue and the sky is purple", "10")]
        public void WordExtractor_GetInvalidPositionByWordAmountException(string text, string position)
        {

            //act
            Action act = () => ExtractorHelper.GetWordFromText(text, position);
            //assert
            Assert.Throws<WordAmountException>(act);
        }

        [Theory]
        [InlineData("The ocean is blue and the sky is purple", "as")]
        [InlineData("The ocean is blue and the sky is purple", "ddffg")]
        public void WordExtractor_PositionIsNotIntType(string text, string position)
        {
            //act
            Action act = () => ExtractorHelper.GetWordFromText(text, position);
            //assert
            Assert.Throws<Exception>(act);
        }

        [Theory]
        [InlineData("The ocean is blue and the sky is purple", "0")]
        [InlineData("The ocean is blue and the sky is purple", "-1")]
        public void WordExtractor_PositionIsLessThanOne(string text, string position)
        {
            //act
            Action act = () => ExtractorHelper.GetWordFromText(text, position);
            //assert
            Assert.Throws<InvalidPositionException>(act);
        }

        /// <summary>
        /// Asserst
        /// </summary>
        /// <param name="input">The input to suffer the extraction.</param>
        [Theory]
        [InlineData("The ocean is blue and the sky is purple", 9)]
        [InlineData("The man have ears way too big for this scene", 10)]
        public void GetWordsListNotEmpty(string input, int wordCount)
        {
            // Act
            var wordsList = ExtractorHelper.GetWords(input);  

            // Assert
            Assert.True(wordsList.Count() == wordCount);
        }

        /// <summary>
        /// 
        /// </summary>
        [Theory]
        [InlineData("The ocean is blue, and the sky is purple", 9)]
        [InlineData("The man's ears are way too big for this scene", 10)]
        public void GetWordsWithSuffixAndTrimSuffixAfter(string input, int wordCount)
        {
            // Act
            var wordsList = ExtractorHelper.GetWords(input);

            // Assert
            Assert.True(wordsList.Count() == wordCount);
        }

        [Theory]
        [InlineData(" The sky ", "The sky")]
        [InlineData("   Hey   Brian   ", "Hey   Brian")]
        public void GetWordWithoutBeginningAndEndSpaces(string input, string expectedOutput)
        {
            var result = input.Trim();

            Assert.Equal(result, expectedOutput);
        }
    }
}
