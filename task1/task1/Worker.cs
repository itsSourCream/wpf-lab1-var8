using System;

namespace task1
{
    public class Worker
    {
        public string Familia { get; set; }
        public double Oklad { get; set; }
        public DateTime DataRogdenia { get; set; }

        public Worker(string fam, double okl, DateTime dr)
        {
            Familia = fam;
            Oklad = okl;
            DataRogdenia = dr;
        }

        public int Vozrast()
        {
            DateTime segodnya = DateTime.Today;
            int vozr = segodnya.Year - DataRogdenia.Year;
            if (DataRogdenia.Date > segodnya.AddYears(-vozr))
            {
                vozr = vozr - 1;
            }
            return vozr;
        }

        public int DneyDo50()
        {
            DateTime den50 = DataRogdenia.AddYears(50);
            DateTime segodnya = DateTime.Today;
            int dney = (int)(den50 - segodnya).TotalDays;
            return dney;
        }
    }
}
