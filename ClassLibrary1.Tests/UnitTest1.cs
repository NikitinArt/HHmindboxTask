using ClassLibrary1;

namespace ClassLibrary1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TriangleIsRectangular_True()
        {
            double edgeA = 5;
            double edgeB = 4;
            double edgeC = 3;

            Triangle t = new Triangle(in edgeA, in edgeB, in edgeC);

            Assert.True(t.IsRectangular());
        }

        [Fact]
        public void TriangleIsExists_False()
        {
            double edgeA = 5;
            double edgeB = 4;
            double edgeC = 555;

            Triangle t;

            Assert.Throws<Exception>(() => t = new Triangle(in edgeA, in edgeB, in edgeC));
        }

        [Fact]
        public void TriangleGetSquare_1469()
        {
            double edgeA = 5;
            double edgeB = 6;
            double edgeC = 7;

            Triangle t = new Triangle(in edgeA, in edgeB, in edgeC);

            Assert.Equal(14.696938456699069, t.GetSquare());
        }

        [Fact]
        public void CircleGetSquare_7853()
        {
            double radius = 5;

            Circle c = new Circle(in radius);

            Assert.Equal(78.53981633974483, c.GetSquare());
        }
        [Fact]
        public void CircleIsExists_False()
        {
            double radius = -5;

            Circle c;

            Assert.Throws<Exception>(() => c = new Circle(in radius));
        }
    }
}