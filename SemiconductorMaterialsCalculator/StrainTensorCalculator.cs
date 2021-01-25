
namespace SemiconductorMaterialsCalculator
{
    public class StrainTensorCalculator
    {
        private double _aE;
        private double _a0;
        private double _C11;
        private double _C12;
        public double EpsilonParallel { get; set; }
        public double EpsilonPerpendicular { get; set; }
        public StrainTensorCalculator(double a_E, InterpolatedParametersSet givenParametersSet)
        {
            _aE = a_E;
            _a0 = givenParametersSet.A;
            _C11 = givenParametersSet.C_11;
            _C12 = givenParametersSet.C_12;
            EpsilonParallel = CalculateEpsilonParallel();
            EpsilonPerpendicular = CalculateEpsilonPerpendicular();
        }

        private double CalculateEpsilonParallel()
        {
            return (_aE - _a0) / _a0;
        }

        private double CalculateEpsilonPerpendicular()
        {
            return -2 * _C12 / _C11 * EpsilonParallel;
        }
    }
}
