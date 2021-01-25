namespace SemiconductorMaterialsCalculator
{
    public class LayerEnergiesSet
    {
        public double E_c { get; set; }
        public double E_hh { get; set; }
        public double E_lh { get; set; }
        public double E_sh { get; set; }
        public void CalculateLayerEnergies(InterpolatedParametersSet givenParametersSet, double E_ch, double E_vh, double E_vb, double E_vbPlus, double E_vbMinus)
        {
            E_c = givenParametersSet.VBO + givenParametersSet.Eg + E_ch;
            E_hh = givenParametersSet.VBO + E_vh + E_vb;
            E_lh = givenParametersSet.VBO + E_vh + E_vbPlus;
            E_sh = givenParametersSet.VBO + E_vh + E_vbMinus;
        }
    }
}
