using System;
using System.Collections.Generic;
using System.Text;
using VectorMagnitudeCalculusCore.interfaces;

namespace VectorMagnitudeCalculusCore
{
    /// <summary>
    ///     The Point class, will serve as the base definition for our vectors calculus.
    ///     It represents the cartesian plane on the form (X,Y).
    /// </summary>
    public class Point : IPoint
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        /// <summary>
        ///   CalculateMagnitude return the Magnitude of a Vector from it's Origin point.
        /// </summary>
        /// <returns> double </returns>
        public double CalculateMagnitude()
        {
            return Math.Round(Math.Sqrt((Math.Pow(X, 2) + Math.Pow(Y, 2))),2);
        }

    }
}
