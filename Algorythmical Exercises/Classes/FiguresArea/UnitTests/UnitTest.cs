using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {

        // First of all - UT for triangles area:

        [TestMethod]
        public void TriangleArea_3_4_5_returned()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;

            Figure triangle = new Triangle(side1, side2, side3);
            double actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TriangleArea_6_8_10_returned()
        {
            double side1 = 6;
            double side2 = 8;
            double side3 = 10;
            double expectedArea = 24;

            Figure triangle = new Triangle(side1, side2, side3);
            double actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TriangleArea_Minus_returned()
        {
            double side1 = -6;
            double side2 = 8;
            double side3 = 10;
            double expectedArea = -1;

            Figure triangle = new Triangle(side1, side2, side3);
            double actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TriangleArea_Double_returned()
        {
            double side1 = 3;
            double side2 = 5;
            double side3 = 5.83;
            double expectedArea = 7.5;

            Figure triangle = new Triangle(side1, side2, side3);
            double actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        // Then UT for circles area:

        [TestMethod]
        public void CircleArea_3_returned()
        {
            double radius = 3;
            double expectedArea = 28.27;

            Figure circle = new Circle(radius);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CircleArea_7_returned()
        {
            double radius = 7;
            double expectedArea = 153.94;

            Figure circle = new Circle(radius);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CircleArea_Minus_returned()
        {
            double radius = -6;
            double expectedArea = -1;

            Figure circle = new Circle(radius);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}