using GeomLibrary;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class LibraryTest
    {
        [TestCase(new float[4] { 1f, 1f, 1f, 1f }, new float[4] { 2f, 2f, 2f, 2f }, Result = "This is a dot")]
        [TestCase(new float[4] { 1f, 1f, 1f, 2f }, new float[4] { 1f, 1f, 1f, 0f }, Result = "This is a line")]
        [TestCase(new float[4] { -1f, 0f, 1f, 2f }, new float[4] { -1f, 0f, 1f, 2f }, Result = "This is a line")]
        [TestCase(new float[4] { 1f, 1f, 2f, 0f }, new float[4] { 2f, 2f, 0f, 0f }, Result = "This is a triangle")]
        [TestCase(new float[4] { -1f, 0f, 1f, 1f }, new float[4] { 2f, 0f, -2f, 1f }, Result = "This is a triangle")]
        [TestCase(new float[4] { 1f, 2f, 2f, 1f }, new float[4] { 2f, 2f, 1f, 1f }, Result = "This is a convex quadrangle")]
        [TestCase(new float[4] { -2f, 0f, 2f, 0f }, new float[4] { 0f, 2f, 0f, -2f }, Result = "This is a convex quadrangle")]
        [TestCase(new float[4] { -3f, -1f, 1f, 3f }, new float[4] { -1f, 2f, 2f, -1f }, Result = "This is a convex quadrangle")]
        [TestCase(new float[4] { -3f, 1f, 0f, 1f }, new float[4] { 1f, 1f, 0f, -1f }, Result = "This is not a convex quadrangle")]
        [TestCase(new float[4] { 1f, -1f, 2f, 1f }, new float[4] { -1f, 1f, 2f, 1f }, Result = "This is not a convex quadrangle")]
        public string test(float[] x, float[] y)
        {
            Library lib = new Library();
            return lib.result(x, y);
        }
    }
}
