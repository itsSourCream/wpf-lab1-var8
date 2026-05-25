namespace task2
{
    public class Pryamougolnik : Figura
    {
        public double Shirina { get; set; }
        public double Visota { get; set; }
        
        public Pryamougolnik(double shir, double vis) : base("Прямоугольник")
        {
            Shirina = shir;
            Visota = vis;
        }

        public override double Ploshad()
        {
            return Shirina * Visota;
        }

        public override double Perimetr()
        {
            return 2 * (Shirina + Visota);
        }
        
        public double Ploshad(double koeff)
        {
            return Shirina * Visota * koeff;
        }
    }
}
