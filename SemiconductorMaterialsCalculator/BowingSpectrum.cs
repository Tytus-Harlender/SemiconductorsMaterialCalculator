
namespace SemiconductorMaterialsCalculator
{
    public class BowingSpectrum
    {
        public string BowingParam { get; set; }
        public double GaInAs { get; set; }
        public double GaInSb { get; set; }
        public double InAsSb { get; set; }
        public double GaAsSb { get; set; }
        public double AlGaAs { get; set; }
        public double AlGaSb { get; set; }
        public double AlAsSb { get; set; }
        public BowingSpectrum(string bowingParam, double gaInAs, double gaInSb, double inAsSb, double gaAsSb, double alGaAs, double alGaSb, double alAsSb)
        {
            BowingParam = bowingParam;
            GaInAs = gaInAs;
            GaInSb = gaInSb;
            InAsSb = inAsSb;
            GaAsSb = gaAsSb;
            AlGaAs = alGaAs;
            AlGaSb = alGaSb;
            AlAsSb = alAsSb;
          
        }
    }
}
