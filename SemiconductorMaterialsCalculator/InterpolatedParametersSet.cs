using System.Collections.Generic;

namespace SemiconductorMaterialsCalculator
{
    public class InterpolatedParametersSet
    {
        public double A { get; set; }
        public double Eg { get; set; }
        public double Alpha { get; set; }
        public double Betha { get; set; }
        public double Delta_so { get; set; }
        public double Mass_e { get; set; }
        public double Mass_hh { get; set; }
        public double Mass_lh { get; set; }
        public double A_c { get; set; }
        public double A_v { get; set; }
        public double B { get; set; }
        public double VBO { get; set; }
        public double C_11 { get; set; }
        public double C_12 { get; set; }
        public InterpolatedParametersSet(List<double> outcomesList)
        {
            A = outcomesList[0];
            Eg = outcomesList[1];
            Alpha = outcomesList[2];
            Betha = outcomesList[3];
            Delta_so = outcomesList[4];
            Mass_e = outcomesList[5];
            Mass_hh = outcomesList[6];
            Mass_lh = outcomesList[7];
            A_c = outcomesList[8];
            A_v = outcomesList[9];
            B = outcomesList[10];
            VBO = outcomesList[11];
            C_11 = outcomesList[12];
            C_12 = outcomesList[13];
        }
    }
}
