namespace HeatMapDemo
{
    public class TemperatureModel 
    {
        public string Year { get; set; }
        public double Jan { get; set; }
        public double Feb { get; set; }
        public double Mar { get; set; }
        public double April { get; set; }
        public double May { get; set; }
        public double June { get; set; }
        public double July { get; set; }
        public double Aug { get; set; }
        public double Sep { get; set; }
        public double Oct { get; set; }
        public double Nov { get; set; }
        public double Dec { get; set; }

        public TemperatureModel (string year,double jan, double feb,double mar,double apr, double may, double june,double july,double aug,double sep, double oct, double nov, double dec)
        {
            Year = year;
            Jan = jan;
            Feb = feb;
            Mar = mar;
            April = apr;
            May = may;
            June = june;
            July = july;
            Aug = aug;
            Sep = sep;
            Oct = oct;
            Nov = nov;
            Dec = dec;
        }
    }
}
