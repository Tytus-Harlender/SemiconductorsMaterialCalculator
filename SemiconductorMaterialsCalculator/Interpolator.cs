
namespace SemiconductorMaterialsCalculator
{
    public class Interpolator
    {
        private readonly GivenParameterSpectrum _parameterSpectrum;
        private readonly BowingSpectrum _bowingSpectrum;
        public Interpolator(string parameter)
        {
            _parameterSpectrum = ListOfParametersSpectrums.GetSpectrumByName(parameter);
            _bowingSpectrum = ListOfBowingSpectrums.GetBowingSpectrumByName(parameter);
        }
        public double InterpolateFourElements(double x, double y)
        {//TODO include a choice between one of two four-elementary layers and change z1,z2,z3,z4 if the second is chosen
            double z1 = InterpolateThreeElements(x,_parameterSpectrum.GaAs,_parameterSpectrum.InAs,_bowingSpectrum.GaInAs);
            double z2 = InterpolateThreeElements(x, _parameterSpectrum.GaSb, _parameterSpectrum.InSb, _bowingSpectrum.GaInSb);
            double z3 = InterpolateThreeElements(y, _parameterSpectrum.InAs, _parameterSpectrum.InSb, _bowingSpectrum.InAsSb);
            double z4 = InterpolateThreeElements(y, _parameterSpectrum.GaAs, _parameterSpectrum.GaSb, _bowingSpectrum.GaAsSb);
            double outputValue = (x*(1-x)*(y*z1+(1-y)*z2)+y*(1-y)*(x*z3+(1-x)*z4))/(x*(1-x)+y*(1-y));
            return outputValue;
        }
        public double InterpolateThreeElements(double c, double p1, double p2, double bowing)
        {
            double z = c * p1 + (1 - c) * p2 - c * (1 - c) * bowing;
            return z;
        }
    }
}