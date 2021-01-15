using System.Collections.Generic;
using System.Linq;

namespace SemiconductorMaterialsCalculator
{
    public class ListOfParametersSpectrums
    {
        private static List<GivenParameterSpectrum> _listOfParamSpectrums = new List<GivenParameterSpectrum>()
        {
            new GivenParameterSpectrum("a", 6.0959, 5.65325, 6.0583,6.4794,5.6611,6.1355),
            new GivenParameterSpectrum("Eg",0.812,1.519,0.417,0.235,3.099,2.386),
            new GivenParameterSpectrum("alpha",0.417,0.5405,0.276,0.32,0.885,0.42),
            new GivenParameterSpectrum("betha",140,204,93,170,530,140),
            new GivenParameterSpectrum("delta_so",0.76,0.341,0.39,0.81,0.28,0.676),
            new GivenParameterSpectrum("mass_e",0.039,0.067,0.024,0.013,0.124,0.14),
            new GivenParameterSpectrum("mass_hh",0.22,0.33,0.26,0.24,0.51,0.47),
            new GivenParameterSpectrum("mass_lh",0.045,0.090,0.027,0.015,0.18,0.16),
            new GivenParameterSpectrum("a_c",-7.5,-7.17,-5.08,-6.94,-5.64,-4.5),
            new GivenParameterSpectrum("a_v",-0.8,-1.16,-1.00,-0.36,-2.47,-1.4),
            new GivenParameterSpectrum("b",-2.0,-2.0,-1.8,-2.0,-2.3,-1.35),
            new GivenParameterSpectrum("vbo",-0.03,-0.8,-0.59,0,-1.33,-0.41),
            new GivenParameterSpectrum("c_11",884.2,1221,832.9,684.7,1250,876.9),
            new GivenParameterSpectrum("c_12",402.6,566,452.6,373.5,534,434.1)
        };
        public static GivenParameterSpectrum GetSpectrumByName(string nameOfParameter)
        {
            return _listOfParamSpectrums.First(data => data.ParamName ==nameOfParameter);
        }
    }
}
