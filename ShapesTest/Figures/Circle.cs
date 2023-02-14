namespace ShapesTest.Figures
{
    public class Circle : Shape
    {
        public Circle(double r) : this()
        {
            Radius = r;
        }
        public override double GetArea() => Math.PI * Math.Pow(radius, 2);

        public double Radius { 
            get { return radius; } 
            set 
            {
                if (value >= 0)
                    radius = value;
                else throw new ArgumentException("Radius can not be less than zero");
            } 
        }

        protected Circle() : base("Circle") {}

        private double radius;
    }
}
