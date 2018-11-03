using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace UnitTests
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TriangleArea_3_4_5_Right_Triangle_returned()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;

            IFigure triangle = new Triangle (side1, side2, side3);
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

            IFigure triangle = new Triangle (side1, side2, side3);
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

            IFigure triangle = new Triangle (side1, side2, side3);
            double actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
