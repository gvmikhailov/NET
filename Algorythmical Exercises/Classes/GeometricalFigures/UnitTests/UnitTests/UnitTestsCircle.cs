using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsCircle
    {
        [TestMethod]
        public void CircleArea_3_returned()
        {
            double radius = 3;
            double expectedArea = 28.27;

            IFigure circle = new Circle (radius);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CircleArea_Double_returned()
        {
            double radius = 7.9;
            double expectedArea = 196.07;

            IFigure circle = new Circle (radius);
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
