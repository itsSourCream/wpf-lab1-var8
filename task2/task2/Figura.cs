namespace task2
{
    public class Figura : IFigure
    {
        public string Nazvanie { get; set; }

        public Figura(string nazv)
        {
            Nazvanie = nazv;
        }
        
        public virtual double Ploshad()
        {
            return 0;
        }

        public virtual double Perimetr()
        {
            return 0;
        }
        
        public virtual string Info()
        {
            return "Это фигура: " + Nazvanie;
        }
    }
}
