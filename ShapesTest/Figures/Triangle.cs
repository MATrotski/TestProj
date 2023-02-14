namespace ShapesTest.Figures
{
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c) : this()
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            if (IsTriangleExist())
            {
                var p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            throw new Exception("This triangle is not exist");
        }

        public bool IsRightTriangle()
        {
            if (IsTriangleExist())
            {
                var sqrA = a * a;
                var sqrB = b * b;
                var sqrC = c * c;
                if (sqrA == sqrB + sqrC || sqrB == sqrA + sqrC || sqrC == sqrA + sqrB)
                    return true;
                return false;
            }
            throw new Exception("This triangle is not exist");
        }

        public double A { 
            get { return a; } 
            set 
            {
                if (value >= 0)
                    a = value;
                else throw new ArgumentException("A side of triangle can not be less than zero");
            } 
        }
        public double B { 
            get { return b; } 
            set 
            {
                if (value >= 0)
                    b = value;
                else throw new ArgumentException("B side of triangle can not be less than zero");
            } 
        }
        public double C { 
            get { return c; } 
            set 
            {
                if (value >= 0)
                    c = value;
                else throw new ArgumentException("C side of triangle can not be less than zero");
            } 
        }

        private bool IsTriangleExist()
        {
            if (b + c > a && a + c > b && a + b > c) return true;
            return false;
        }

        protected Triangle() : base("Triangle") { }

        private double a, b, c;
    }
}
