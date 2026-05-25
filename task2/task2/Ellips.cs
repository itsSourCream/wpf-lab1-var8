using System;

namespace task2
{
    public class Ellips : Figura
    {
        public double A { get; set; }
        public double B { get; set; }

        public Ellips(double a, double b) : base("Эллипс")
        {
            A = a;
            B = b;
        }

        public override double Ploshad()
        {
            return Math.PI * A * B;
        }

        public override double Perimetr()
        {
            return Math.PI * (3 * (A + B) - Math.Sqrt((3 * A + B) * (A + 3 * B)));
        }
        
        public override string Info()
        {
            return "Эллипс с полуосями a=" + A + " и b=" + B;
        }
    }
}
