using System;
using System.Collections.Generic;
using System.Text;

namespace No1.Solution.Interface
{
    /// <summary>
    /// Client's class for analysis string.
    /// </summary>
    public interface IChecker
    {
        /// <summary>
        /// Method for analysis string.
        /// </summary>
        /// <param name="password">Source password.</param>
        /// <returns>True if number is correct, else false.</returns>
        (bool, string) Verify(string password);
    }
}
