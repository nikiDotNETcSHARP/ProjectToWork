namespace ProjectToWork
{
    public class Circle : IShape
    {
        public double _radius {  get; set; }

        public Circle(double radius) 
        { 
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
