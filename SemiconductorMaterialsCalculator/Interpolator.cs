namespace SemiconductorMaterialsCalculator
{
    public class Interpolator
    {
        private readonly GivenParameterSpectrum _parameterSpectrum;
        private readonly BowingSpectrum _bowingSpectrum;
        public Interpolator(string parameter, double temperature)
        {
            _bowingSpectrum = ListOfBowingSpectrums.GetBowingSpectrumByName(parameter);
            if (parameter == "Eg")
            {
                var EgSpectrum = ListOfParametersSpectrums.GetSpectrumByName(parameter);
                VarschniFormulaModifier newModifier = new VarschniFormulaModifier();
                _parameterSpectrum = newModifier.ModifyByVarschniFormula(EgSpectrum, temperature);
            }
            else
            {
                _parameterSpectrum = ListOfParametersSpectrums.GetSpectrumByName(parameter);
            }
        }
        public double InterpolateFourElements(double x, double y, double materialSwitch, int layerNumber)
        {
            double z1;
            double z2;
            double z3;
            double z4;
            double outputValue;
            switch (materialSwitch)
            {
                case 1:
                    if (layerNumber == 2)
                    {
                        z1 = InterpolateThreeElements(x, _parameterSpectrum.GaAs, _parameterSpectrum.InAs, _bowingSpectrum.GaInAs);
                        z2 = InterpolateThreeElements(x, _parameterSpectrum.GaSb, _parameterSpectrum.InSb, _bowingSpectrum.GaInSb);
                        z3 = InterpolateThreeElements(y, _parameterSpectrum.InAs, _parameterSpectrum.InSb, _bowingSpectrum.InAsSb);
                        z4 = InterpolateThreeElements(y, _parameterSpectrum.GaAs, _parameterSpectrum.GaSb, _bowingSpectrum.GaAsSb);
                        outputValue = (x * (1 - x) * (y * z1 + (1 - y) * z2) + y * (1 - y) * (x * z3 + (1 - x) * z4)) / (x * (1 - x) + y * (1 - y));
                        return outputValue;
                    }
                    else
                    {
                        z1 = InterpolateThreeElements(x, _parameterSpectrum.GaAs, _parameterSpectrum.GaAs, _bowingSpectrum.AlGaAs);
                        z2 = InterpolateThreeElements(x, _parameterSpectrum.GaSb, _parameterSpectrum.GaSb, _bowingSpectrum.AlGaSb);
                        z3 = InterpolateThreeElements(y, _parameterSpectrum.InAs, _parameterSpectrum.GaSb, _bowingSpectrum.GaAsSb);
                        z4 = InterpolateThreeElements(y, _parameterSpectrum.GaAs, _parameterSpectrum.AlSb, _bowingSpectrum.AlAsSb);
                        outputValue = (x * (1 - x) * (y * z1 + (1 - y) * z2) + y * (1 - y) * (x * z3 + (1 - x) * z4)) / (x * (1 - x) + y * (1 - y));
                        return outputValue;
                    }
                case 2:
                    if (layerNumber == 2)
                    {
                        z1 = InterpolateThreeElements(x, _parameterSpectrum.GaAs, _parameterSpectrum.GaAs, _bowingSpectrum.AlGaAs);
                        z2 = InterpolateThreeElements(x, _parameterSpectrum.GaSb, _parameterSpectrum.GaSb, _bowingSpectrum.AlGaSb);
                        z3 = InterpolateThreeElements(y, _parameterSpectrum.InAs, _parameterSpectrum.GaSb, _bowingSpectrum.GaAsSb);
                        z4 = InterpolateThreeElements(y, _parameterSpectrum.GaAs, _parameterSpectrum.AlSb, _bowingSpectrum.AlAsSb);
                        outputValue = (x * (1 - x) * (y * z1 + (1 - y) * z2) + y * (1 - y) * (x * z3 + (1 - x) * z4)) / (x * (1 - x) + y * (1 - y));
                        return outputValue;
                    }
                    else
                    {
                        z1 = InterpolateThreeElements(x, _parameterSpectrum.GaAs, _parameterSpectrum.InAs, _bowingSpectrum.GaInAs);
                        z2 = InterpolateThreeElements(x, _parameterSpectrum.GaSb, _parameterSpectrum.InSb, _bowingSpectrum.GaInSb);
                        z3 = InterpolateThreeElements(y, _parameterSpectrum.InAs, _parameterSpectrum.InSb, _bowingSpectrum.InAsSb);
                        z4 = InterpolateThreeElements(y, _parameterSpectrum.GaAs, _parameterSpectrum.GaSb, _bowingSpectrum.GaAsSb);
                        outputValue = (x * (1 - x) * (y * z1 + (1 - y) * z2) + y * (1 - y) * (x * z3 + (1 - x) * z4)) / (x * (1 - x) + y * (1 - y));
                        return outputValue;
                    }
                default:
                    return 0;
            }
        }
        public double InterpolateThreeElements(double c, double p1, double p2, double bowing)
        {
            double z = c * p1 + (1 - c) * p2 - c * (1 - c) * bowing;
            return z;
        }
    }
}