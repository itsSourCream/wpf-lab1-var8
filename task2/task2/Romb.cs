using System;

namespace task2
{
    public class Romb : Figura
    {
        public double Storona { get; set; }
        public double Visota { get; set; }
        
        public Romb(double storona, double visota) : base("Ромб")
        {
            Storona = storona;
            Visota = visota;
        }

        public override double Ploshad()
        {
            return Storona * Visota;
        }

        public override double Perimetr()
        {
            return 4 * Storona;
        }
        
        public override string Info()
        {
            return "Ромб со стороной " + Storona + " и высотой " + Visota;
        }
    }
}
