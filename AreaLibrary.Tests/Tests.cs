using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void �alculation_1_Return19_63()
        {
            // Arrange
            Circle circle = new Circle(2.5);
            double expected = 19.63;

            // Act
            var result = circle.�alculation();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }


    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Caclulation_2And3And4_Return_2_83()
        {
            // Arrange
            Triangle triangle = new Triangle(2, 3, 3);
            double expected = 2.83;

            // Act
            var result = triangle.�alculation();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsRectangularTriangle_6And8And10_Return_True()
        {
            // Arrange
            Triangle triangle = new Triangle(6, 8, 10);
            bool expected = true;

            // Act
            var result = triangle.IsRectangularTriangle();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}