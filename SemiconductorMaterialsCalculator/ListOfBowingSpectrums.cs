using System.Collections.Generic;
using System.Linq;

namespace SemiconductorMaterialsCalculator
{
    public class ListOfBowingSpectrums
    {
        private static List<BowingSpectrum> _listOfBowingSpectrums = new List<BowingSpectrum>()
        {
            new BowingSpectrum("a", 0,0,0,0,0,0,0),
            new BowingSpectrum("Eg",0.477,0.415,0.67,1.43,-0.127,-0.044,0.8),
            new BowingSpectrum("alpha",0,0,0,0,0,0,0),
            new BowingSpectrum("betha",0,0,0,0,0,0,0),
            new BowingSpectrum("delta_so",0.15,0.1,1.2,0.6,0.075,0.3,0.15),
            new BowingSpectrum("mass_e",0.0091,0.0092,0.035,0,0,0,0),
            new BowingSpectrum("mass_hh",-0.145,0,0,0,0,0,0),
            new BowingSpectrum("mass_lh",0.0202,0.011,0,0,0,0,0),
            new BowingSpectrum("a_c",2.61,0,0,0,0,0,0),
            new BowingSpectrum("a_v",0,0,0,0,0,0,0),
            new BowingSpectrum("b",0,0,0,0,0,0,0),
            new BowingSpectrum("vbo",-0.38,0,0,-1.06,0,0, -1.71),
            new BowingSpectrum("c_11",0,0,0,0,0,0,0),
            new BowingSpectrum("c_12",0,0,0,0,0,0,0)
        };
        public static BowingSpectrum GetBowingSpectrumByName(string nameOfParameter)
        {
            return _listOfBowingSpectrums.First(data => data.BowingParam == nameOfParameter);
        }
    }
}
