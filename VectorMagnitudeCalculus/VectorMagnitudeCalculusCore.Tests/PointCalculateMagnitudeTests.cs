using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMagnitudeCalculusCore.interfaces;
using Xunit;

namespace VectorMagnitudeCalculusCore.Tests
{
    public class PointCalculateMagnitudeTests
    {
        [Fact]
        public void CalculateMagnitudeShouldCalculate()
        {
            //Arrange
            IPoint vector = new Point() { X = 3, Y = 5 };
            double expected = 5.83;

            //Act
            double actual = vector.CalculateMagnitude();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
