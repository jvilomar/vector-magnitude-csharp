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
        public double CalculateMagnitudeFromOrigin()
        {
            return Math.Round(Math.Sqrt((Doubled(X) + Doubled(Y))), 2);
        }

        /// <summary>
        /// Used to doubled the given axis.  
        /// </summary>
        /// <param name="axis"> The coordinate part to double X.coordinate or Y.coordinate</param>
        /// <returns></returns>
        private double Doubled(double axis) {
            return axis * axis;
        }

    }
}
