using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapesTest
{
    public class TestDataSource
    {
        public static IEnumerable<object[]> Circle_With_Wrong_Parameters
        {
            get
            {
                yield return new object[]
                {
                    -3
                };

            }
        }

        public static IEnumerable<object[]> Triangle_With_Wrong_Parameters
        {
            get
            {
                yield return new object[]
                {
                    4,
                    5.2,
                    -3
                };

            }
        }

        public static IEnumerable<object?[]> GetAreaTest_Circle_ExpectedResult
        {
            get
            {
                yield return new object[]
                {
                    2,
                    12.57
                };
                yield return new object[]
                {
                    0.3,
                    0.28
                };
            }
        }

        public static IEnumerable<object?[]> GetAreaTest_Triangle_ExpectedResult
        {
            get
            {
                yield return new object[]
                {
                    (double)3,
                    (double)4,
                    (double)5,
                    (double)6
                };
                yield return new object[]
                {
                    3,
                    5,
                    7,
                    6.5
                };
                yield return new object?[]
                {
                    5,
                    6,
                    13,
                    null
                };
            }
        }

        public static IEnumerable<object[]> IsRightTriangleTest_Triangle_ExpectedResult
        {
            get
            {
                yield return new object[]
                {
                    3,
                    4,
                    5,
                    true
                };
                yield return new object[]
                {
                    3,
                    3,
                    3,
                    false
                };
            }
        }
    }
}
