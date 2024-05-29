namespace ClassLibrary1
{
    public abstract class Shape
    {
        public abstract double GetSquare();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(in double radius) {
            if (radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new Exception("Такого круга не существует");
            }
        }
        public override double GetSquare() {
            return Math.Pow(Radius, 2) * double.Pi;
        }
    }

    public class Triangle : Shape
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }

        public Triangle(in double edgeA, in double edgeB, in double edgeC) {
            if ((edgeA < 0 || edgeB < 0 || edgeC < 0) || (edgeA > edgeB + edgeC || edgeB > edgeA + edgeC || edgeC > edgeB + edgeA))
            {
                throw new Exception("Такого треугольника не существует");
            }
            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }

        public override double GetSquare() {
            double p = (EdgeA + EdgeB + EdgeC) / 2;
            return Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
        }

        public bool IsRectangular()
        {
            bool isRectangular = (EdgeA == Math.Sqrt(Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2))
                               || EdgeB == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2))
                               || EdgeC == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2)));

            return isRectangular;
        }
    }
}
