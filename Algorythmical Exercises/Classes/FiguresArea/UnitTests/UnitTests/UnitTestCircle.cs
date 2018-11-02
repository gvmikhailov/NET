using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void CircleArea_3_returned()
        {
            double radius = 3;
            double expectedArea = 28.27;

            IFigure circle = new Circle(radius);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CircleArea_7_returned()
        {
            double radius = 7;
            double expectedArea = 153.94;

            IFigure circle = new Circle(radius);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CircleArea_Minus_returned()
        {
            double radius = -6;
            double expectedArea = -1;

            IFigure circle = new Circle(radius);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
