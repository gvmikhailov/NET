using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricalFigureSquare;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {

        // Test Methods For Triangles

        [TestMethod]
        public void TriangleSquare_3_4_5_returned()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedSquare = 6;
            
            double actualSquare = FigureSquare.GetSquare(side1,side2,side3);

            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void TriangleSquare_6_8_10_returned()
        {
            double side1 = 6;
            double side2 = 8;
            double side3 = 10;
            double expectedSquare = 24;

            double actualSquare = FigureSquare.GetSquare(side1, side2, side3);

            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void TriangleSquare_Minus_returned()
        {
            double side1 = -6.0;
            double side2 = 8.0;
            double side3 = 10.0;
            double expectedSquare = -1;

            double actualSquare = FigureSquare.GetSquare(side1, side2, side3);

            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void TriangleSquare_Double_returned()
        {
            double side1 = 3.0;
            double side2 = 5.0;
            double side3 = 5.83;
            double expectedSquare = 7.5;

            double actualSquare = FigureSquare.GetSquare(side1, side2, side3);

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        // Test Methods For Circle

        [TestMethod]
        public void CircleSquare_3_returned()
        {
            double radius = 3;
            double expectedSquare = 28.27;

            double actualSquare = FigureSquare.GetSquare(radius);

            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void CircleSquare_7_returned()
        {
            double radius = 7;
            double expectedSquare = 153.94;

            double actualSquare = FigureSquare.GetSquare(radius);

            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [TestMethod]
        public void CircleSquare_Minus_returned()
        {
            double radius = -6;
            double expectedSquare = -1;

            double actualSquare = FigureSquare.GetSquare(radius);

            Assert.AreEqual(expectedSquare, actualSquare);
        }
    }
}
