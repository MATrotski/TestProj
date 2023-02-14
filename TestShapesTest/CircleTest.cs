using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesTest.Figures;

namespace TestShapesTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [DynamicData(nameof(TestDataSource.Circle_With_Wrong_Parameters), typeof(TestDataSource))]
        public void GetCircleWithWrongParameters(double r)
        {
            try
            {
                new Circle(r);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        [DynamicData(nameof(TestDataSource.GetAreaTest_Circle_ExpectedResult), typeof(TestDataSource))]
        public void GetAreaTest(double r, double expectedResult)
        {
            var cl = new Circle(r);
            var actualResult = cl.GetArea();
            actualResult = Math.Round(actualResult, 2);
            Assert.IsTrue(expectedResult <= actualResult && actualResult > (expectedResult - 0.1));
        }
    }
}
