using System;


namespace SemiconductorMaterialsCalculator
{
    public class GivenParameterSpectrum
    {
        public String ParamName { get; set; }
        public double GaSb { get; set; }
        public double GaAs { get; set; }
        public double InAs { get; set; }
        public double InSb { get; set; }
        public double AlAs { get; set; }
        public double AlSb { get; set; }
        public GivenParameterSpectrum(string nameOfParameter, double gaSb, double gaAs, double inAs, double inSb, double alAs, double alSb)
        {
            ParamName = nameOfParameter;
            GaSb = gaSb;
            GaAs = gaAs;
            InAs = inAs;
            InSb = inSb;
            AlAs = alAs;
            AlSb = alSb;
        }
    }
}
