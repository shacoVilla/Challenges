// <copyright file="InvalidPositionException.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WordExtractor.Exceptions
{
    using System;

    /// <summary>
    /// The Invalidad position exception. See <see cref="Exception"/>.
    /// </summary>
    public class InvalidPositionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPositionException"/> class.
        /// </summary>
        public InvalidPositionException()
          : base("The position can't be less than 1")
        {
        }
    }
}
