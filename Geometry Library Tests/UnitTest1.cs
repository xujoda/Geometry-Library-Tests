using Geometry_Library;

namespace Geometry_Library_Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Triangle_GetArea_True()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);
            double area = triangle.GetArea();
            Assert.AreEqual(6, area);
        }

        [Test]
        public void Triangle_GetArea_False()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);
            double area = triangle.GetArea();
            Assert.AreEqual(10, area);
        }

        [Test]
        public void Triangle_IsRightAngled_True1()
        {
            var triangle = new Triangle(3, 4, 5);
            bool isRightAngled = triangle.IsRightAngled();
            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void Triangle_IsRightAngled_True2()
        {
            var triangle = new Triangle(2, 2, 12);
            bool isRightAngled = triangle.IsRightAngled();
            Assert.IsFalse(isRightAngled);
        }
    }
}