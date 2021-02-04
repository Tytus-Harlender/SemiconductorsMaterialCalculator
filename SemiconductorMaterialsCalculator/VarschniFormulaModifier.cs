using System;

namespace SemiconductorMaterialsCalculator
{
    public class VarschniFormulaModifier
    {
        public GivenParameterSpectrum ModifyByVarschniFormula(GivenParameterSpectrum egSpectrum, double temperature)
        {

            var alphaSpectrum = ListOfParametersSpectrums.GetSpectrumByName("alpha");
            var bethaSpectrum = ListOfParametersSpectrums.GetSpectrumByName("betha");
            var eg1 = CalculateVarschniModification(egSpectrum.GaSb,alphaSpectrum.GaSb, temperature,bethaSpectrum.GaSb);
            var eg2 = CalculateVarschniModification(egSpectrum.GaAs, alphaSpectrum.GaAs, temperature,bethaSpectrum.GaAs);
            var eg3 = CalculateVarschniModification(egSpectrum.InAs, alphaSpectrum.InAs, temperature,bethaSpectrum.InAs);
            var eg4 = CalculateVarschniModification(egSpectrum.InSb, alphaSpectrum.InSb, temperature,bethaSpectrum.InSb);
            var eg5 = CalculateVarschniModification(egSpectrum.AlAs, alphaSpectrum.AlAs, temperature,bethaSpectrum.AlAs);
            var eg6 = CalculateVarschniModification(egSpectrum.AlSb, alphaSpectrum.AlSb, temperature, bethaSpectrum.AlSb);
            GivenParameterSpectrum modifiedEgSpectrum = new GivenParameterSpectrum("Eg", eg1, eg2, eg3, eg4, eg5, eg6);
            return modifiedEgSpectrum;
        }
        public double CalculateVarschniModification(double egZeroTemperatureValue, double alphaValue, double temperature, double bethaValue)
        {
            return egZeroTemperatureValue - (alphaValue*Math.Pow(10,-3) * Math.Pow(temperature,2) / (temperature + bethaValue));
        }
    }       
}           
            