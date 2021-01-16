using System.Collections.Generic;

namespace SemiconductorMaterialsCalculator
{
    public class BandStructureParametersNames
    {
        public List<string> ListOfBandStructureParameters { get; set; }
        public BandStructureParametersNames()
        {
            List<string> listOfBandStructuresParameters = new List<string>()
            {
                "a",
                "Eg",
                "alpha",
                "betha",
                "delta_so",
                "mass_e",
                "mass_hh",
                "mass_lh",
                "a_c",
                "a_v",
                "b",
                "vbo",
                "c_11",
                "c_12"
            };
            ListOfBandStructureParameters = listOfBandStructuresParameters;
        }
    }
}
