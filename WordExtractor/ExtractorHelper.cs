// <copyright file="ExtractorHelper.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WordExtractor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using WordExtractor.Exceptions;

    /// <summary>
    /// The words extractor helper.
    /// </summary>
    public static class ExtractorHelper
    {
        /// <summary>
        /// Gets the words from a text.
        /// </summary>
        /// <param name="input">The text to suffer the extraction.</param>
        /// <returns>A <see cref="List{string}"/> with the extracted words.</returns>
        public static List<string> GetWords(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\b[\w']*\b");

            var result = matches.Cast<Match>().Where(o => !string.IsNullOrEmpty(o.Value)).Select(x => TrimSuffix(x.Value));

            return result.ToList();
        }

        /// <summary>
        /// Getsa word from a text by a determined position.
        /// </summary>
        /// <param name="text">The text to be processed.</param>
        /// <param name="positionStr">The position where the word should be extracted.</param>
        /// <returns>A <see cref="string"/> that represents the extracted word.</returns>
        public static string GetWordFromText(string text, string positionStr)
        {
            int position = int.TryParse(positionStr, out position)
                ? position
                : throw new Exception("position must be an INT type)");

            var wordExtracted = string.Empty;

            if (position < 1)
            {
                throw new InvalidPositionException();
            }
            else
            {
                var wordsExtractedList = GetWords(text);

                if (wordsExtractedList.Count < position)
                {
                    throw new WordAmountException(wordsExtractedList.Count, position);
                }

                wordExtracted = wordsExtractedList[position - 1];
            }

            return wordExtracted;
        }

        /// <summary>
        /// Trims the suffix that are in a text.
        /// </summary>
        /// <param name="word">The word to the trimmed.</param>
        /// <returns>A <see cref="string"/> with no suffixes.</returns>
        public static string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');

            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }
    }
}