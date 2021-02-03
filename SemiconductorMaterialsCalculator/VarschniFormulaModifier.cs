using System;

namespace SemiconductorMaterialsCalculator
{
    public class VarschniFormulaModifier
    {
        public GivenParameterSpectrum ModifyByVarschniFormula(GivenParameterSpectrum egSpectrum, double temperature)
        {
            var alphaSpectrum = ListOfParametersSpectrums.GetSpectrumByName("alpha");
            var bethaSpectrum = ListOfParametersSpectrums.GetSpectrumByName("betha");
            egSpectrum.GaSb = CalculateVarschniModification(egSpectrum.GaSb,alphaSpectrum.GaSb, temperature,bethaSpectrum.GaSb);
            egSpectrum.GaAs = CalculateVarschniModification(egSpectrum.GaAs, alphaSpectrum.GaAs, temperature,bethaSpectrum.GaAs);
            egSpectrum.InAs = CalculateVarschniModification(egSpectrum.InAs, alphaSpectrum.InAs, temperature,bethaSpectrum.InAs);
            egSpectrum.InSb = CalculateVarschniModification(egSpectrum.InSb, alphaSpectrum.InSb, temperature,bethaSpectrum.InSb);
            egSpectrum.AlAs = CalculateVarschniModification(egSpectrum.AlAs, alphaSpectrum.AlAs, temperature,bethaSpectrum.AlAs);
            egSpectrum.AlSb = CalculateVarschniModification(egSpectrum.AlSb, alphaSpectrum.AlSb, temperature, bethaSpectrum.AlSb);
            return egSpectrum;
        }
        public double CalculateVarschniModification(double egZeroTemperatureValue, double alphaValue, double temperature, double bethaValue)
        {
            return egZeroTemperatureValue - (alphaValue*Math.Pow(10,-3) * Math.Pow(temperature,2) / (temperature + bethaValue));
        }
    }       
}           
            