using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesTest.Figures;

namespace TestShapesTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [DynamicData(nameof(TestDataSource.Triangle_With_Wrong_Parameters), typeof(TestDataSource))]
        public void GetTriangleWithWrongParameters(double a, double b, double c)
        {
            try
            {
                new Triangle(a, b, c);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        [DynamicData(nameof(TestDataSource.GetAreaTest_Triangle_ExpectedResult), typeof(TestDataSource))]
        public void GetAreaTest(double a, double b, double c, double? expectedResult)
        {
            double actualResult = 0;
            try
            {
                var tr = new Triangle(a, b, c);
                actualResult = tr.GetArea();
                actualResult = Math.Round(actualResult, 2);
                Assert.IsTrue(expectedResult <= actualResult && actualResult > (expectedResult - 0.1));
            }
            catch
            {
                Assert.IsNull(expectedResult);
            }
        }

        [TestMethod]
        [DynamicData(nameof(TestDataSource.IsRightTriangleTest_Triangle_ExpectedResult), typeof(TestDataSource))]
        public void IsRightTriangleTest(double a, double b, double c, bool expectedResult)
        {
            var tr = new Triangle(a, b, c);
            var actualResult = tr.IsRightTriangle();
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
